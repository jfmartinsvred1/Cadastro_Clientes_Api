using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro_Cliente_Api.Migrations
{
    public partial class usernameCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Clientes");
        }
    }
}
