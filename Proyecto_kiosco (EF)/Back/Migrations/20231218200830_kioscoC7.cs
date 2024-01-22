using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class kioscoC7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vendedores_NombreVendedornumerolegajo",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "MontoFinal",
                table: "DetallePedidos");

            migrationBuilder.RenameColumn(
                name: "numerolegajo",
                table: "Vendedores",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NombreVendedornumerolegajo",
                table: "Pedidos",
                newName: "NombreVendedorid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_NombreVendedornumerolegajo",
                table: "Pedidos",
                newName: "IX_Pedidos_NombreVendedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vendedores_NombreVendedorid",
                table: "Pedidos",
                column: "NombreVendedorid",
                principalTable: "Vendedores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vendedores_NombreVendedorid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vendedores",
                newName: "numerolegajo");

            migrationBuilder.RenameColumn(
                name: "NombreVendedorid",
                table: "Pedidos",
                newName: "NombreVendedornumerolegajo");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_NombreVendedorid",
                table: "Pedidos",
                newName: "IX_Pedidos_NombreVendedornumerolegajo");

            migrationBuilder.AddColumn<int>(
                name: "MontoFinal",
                table: "DetallePedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vendedores_NombreVendedornumerolegajo",
                table: "Pedidos",
                column: "NombreVendedornumerolegajo",
                principalTable: "Vendedores",
                principalColumn: "numerolegajo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
