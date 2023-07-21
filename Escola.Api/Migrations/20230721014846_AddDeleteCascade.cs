using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddDeleteCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Escolas_EscolaId",
                table: "Turmas");

            migrationBuilder.AlterColumn<int>(
                name: "EscolaId",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Escolas_EscolaId",
                table: "Turmas",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Escolas_EscolaId",
                table: "Turmas");

            migrationBuilder.AlterColumn<int>(
                name: "EscolaId",
                table: "Turmas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Escolas_EscolaId",
                table: "Turmas",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id");
        }
    }
}
