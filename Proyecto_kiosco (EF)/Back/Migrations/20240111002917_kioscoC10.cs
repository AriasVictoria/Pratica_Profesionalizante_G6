using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class kioscoC10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Productos_Id_Producto1",
                table: "DetallePedidos");

            migrationBuilder.RenameColumn(
                name: "Id_Producto",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Producto1",
                table: "DetallePedidos",
                newName: "Id1");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_Id_Producto1",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Productos_Id1",
                table: "DetallePedidos",
                column: "Id1",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Productos_Id1",
                table: "DetallePedidos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productos",
                newName: "Id_Producto");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "DetallePedidos",
                newName: "Id_Producto1");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_Id1",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_Id_Producto1");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Productos_Id_Producto1",
                table: "DetallePedidos",
                column: "Id_Producto1",
                principalTable: "Productos",
                principalColumn: "Id_Producto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
