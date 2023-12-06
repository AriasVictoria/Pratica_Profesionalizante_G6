using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class kioscoC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "contraseñaV",
                table: "Vendedores",
                newName: "contrasenia");

            migrationBuilder.RenameColumn(
                name: "contraseña",
                table: "Administradores",
                newName: "contrasenia");

            migrationBuilder.RenameColumn(
                name: "Id_Administrador",
                table: "Administradores",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "contrasenia",
                table: "Vendedores",
                newName: "contraseñaV");

            migrationBuilder.RenameColumn(
                name: "contrasenia",
                table: "Administradores",
                newName: "contraseña");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Administradores",
                newName: "Id_Administrador");
        }
    }
}
