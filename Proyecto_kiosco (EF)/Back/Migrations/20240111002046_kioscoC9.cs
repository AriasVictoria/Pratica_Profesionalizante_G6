using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class kioscoC9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Pedidos_Id1",
                table: "DetallePedidos");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "DetallePedidos",
                newName: "NombreDuenioDNI");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_Id1",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_NombreDuenioDNI");

            migrationBuilder.CreateTable(
                name: "Dueños",
                columns: table => new
                {
                    DNI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDuenio = table.Column<int>(type: "int", nullable: false),
                    ApellidoDuenio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dueños", x => x.DNI);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Dueños_NombreDuenioDNI",
                table: "DetallePedidos",
                column: "NombreDuenioDNI",
                principalTable: "Dueños",
                principalColumn: "DNI",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Dueños_NombreDuenioDNI",
                table: "DetallePedidos");

            migrationBuilder.DropTable(
                name: "Dueños");

            migrationBuilder.RenameColumn(
                name: "NombreDuenioDNI",
                table: "DetallePedidos",
                newName: "Id1");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_NombreDuenioDNI",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_Id1");

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApellidoAdministrador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreAdministrador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApellidoVendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreVendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVendedorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Vendedores_NombreVendedorid",
                        column: x => x.NombreVendedorid,
                        principalTable: "Vendedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_NombreVendedorid",
                table: "Pedidos",
                column: "NombreVendedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Pedidos_Id1",
                table: "DetallePedidos",
                column: "Id1",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
