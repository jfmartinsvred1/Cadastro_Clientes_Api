using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro_Cliente_Api.Migrations
{
    public partial class UsuarioUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Clientes",
                newName: "UsuarioUsername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioUsername",
                table: "Clientes",
                newName: "Username");
        }
    }
}
