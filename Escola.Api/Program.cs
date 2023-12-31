using System.Globalization;
using AutoMapper;
using Escola.Api.Controllers.Filters;
using Escola.Api.Data;
using Escola.Api.Models.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
CultureInfo.CurrentCulture = new CultureInfo("pt-BR");


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        p => p.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(180), errorNumbersToAdd: null)), ServiceLifetime.Scoped);

InjecaoDepedencia(builder.Services);

#region Filtro para validar o ModelState

builder.Services.Configure<ApiBehaviorOptions>(options
    => options.SuppressModelStateInvalidFilter = true);
builder.Services.AddScoped<ModelStateValidationFilter>();
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ModelStateValidationFilter>();
    options.Filters.Add<ExceptionFilter>();
});

#endregion

var config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app
    = builder.Build();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void InjecaoDepedencia(IServiceCollection services)
{
    services.Scan(scan =>
        scan.FromCallingAssembly()
            .AddClasses()
            .AsMatchingInterface());
}