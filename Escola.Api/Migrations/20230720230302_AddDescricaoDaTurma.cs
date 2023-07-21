using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddDescricaoDaTurma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Turmas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Turmas");
        }
    }
}
