using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class kiosco1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoFinal",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Productos",
                newName: "NombreProvedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productos",
                newName: "Id_Producto");

            migrationBuilder.RenameColumn(
                name: "Precio_Producto",
                table: "Pedidos",
                newName: "NombreVendedornumerolegajo");

            migrationBuilder.CreateTable(
                name: "DetallePedidos",
                columns: table => new
                {
                    codigo_barra = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id1 = table.Column<int>(type: "int", nullable: false),
                    Id_Producto1 = table.Column<int>(type: "int", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad_Producto = table.Column<int>(type: "int", nullable: false),
                    Precio_Producto = table.Column<int>(type: "int", nullable: false),
                    MontoFinal = table.Column<int>(type: "int", nullable: false),
                    Fecha_Pedido = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidos", x => x.codigo_barra);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Pedidos_Id1",
                        column: x => x.Id1,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Productos_Id_Producto1",
                        column: x => x.Id_Producto1,
                        principalTable: "Productos",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_NombreProvedorId",
                table: "Productos",
                column: "NombreProvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_NombreVendedornumerolegajo",
                table: "Pedidos",
                column: "NombreVendedornumerolegajo");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_Id_Producto1",
                table: "DetallePedidos",
                column: "Id_Producto1");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_Id1",
                table: "DetallePedidos",
                column: "Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vendedores_NombreVendedornumerolegajo",
                table: "Pedidos",
                column: "NombreVendedornumerolegajo",
                principalTable: "Vendedores",
                principalColumn: "numerolegajo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_proveedores_NombreProvedorId",
                table: "Productos",
                column: "NombreProvedorId",
                principalTable: "proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vendedores_NombreVendedornumerolegajo",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_proveedores_NombreProvedorId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "DetallePedidos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_NombreProvedorId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_NombreVendedornumerolegajo",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "NombreProvedorId",
                table: "Productos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Id_Producto",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NombreVendedornumerolegajo",
                table: "Pedidos",
                newName: "Precio_Producto");

            migrationBuilder.AddColumn<double>(
                name: "MontoFinal",
                table: "Pedidos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
