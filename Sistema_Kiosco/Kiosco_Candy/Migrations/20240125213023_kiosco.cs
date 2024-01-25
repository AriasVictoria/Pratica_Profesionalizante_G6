using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KioscoCandy.Migrations
{
    /// <inheritdoc />
    public partial class kiosco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dueños",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    NombreDuenio = table.Column<int>(type: "int", nullable: false),
                    ApellidoDuenio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dueños", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cuit = table.Column<int>(type: "int", nullable: false),
                    NombreProvedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoProvedor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    NombreProvedorId = table.Column<int>(type: "int", nullable: false),
                    tipoproducto = table.Column<string>(name: "tipo_producto", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedor_NombreProvedorId",
                        column: x => x.NombreProvedorId,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedidos",
                columns: table => new
                {
                    numeropedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id1 = table.Column<int>(type: "int", nullable: false),
                    NombreDuenioID = table.Column<int>(type: "int", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoproducto = table.Column<string>(name: "tipo_producto", type: "nvarchar(max)", nullable: false),
                    CantidadProducto = table.Column<int>(name: "Cantidad_Producto", type: "int", nullable: false),
                    PrecioProducto = table.Column<int>(name: "Precio_Producto", type: "int", nullable: false),
                    FechaPedido = table.Column<DateTime>(name: "Fecha_Pedido", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidos", x => x.numeropedido);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Dueños_NombreDuenioID",
                        column: x => x.NombreDuenioID,
                        principalTable: "Dueños",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Productos_Id1",
                        column: x => x.Id1,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_Id1",
                table: "DetallePedidos",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_NombreDuenioID",
                table: "DetallePedidos",
                column: "NombreDuenioID");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_NombreProvedorId",
                table: "Productos",
                column: "NombreProvedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedidos");

            migrationBuilder.DropTable(
                name: "Dueños");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedor");
        }
    }
}
