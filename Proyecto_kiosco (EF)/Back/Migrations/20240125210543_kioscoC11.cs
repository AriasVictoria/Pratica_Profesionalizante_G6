using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class kioscoC11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Dueños_NombreDuenioDNI",
                table: "DetallePedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dueños",
                table: "Dueños");

            migrationBuilder.RenameColumn(
                name: "NombreDuenioDNI",
                table: "DetallePedidos",
                newName: "NombreDuenioID");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_NombreDuenioDNI",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_NombreDuenioID");

            migrationBuilder.AlterColumn<int>(
                name: "DNI",
                table: "Dueños",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Dueños",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dueños",
                table: "Dueños",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Dueños_NombreDuenioID",
                table: "DetallePedidos",
                column: "NombreDuenioID",
                principalTable: "Dueños",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Dueños_NombreDuenioID",
                table: "DetallePedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dueños",
                table: "Dueños");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Dueños");

            migrationBuilder.RenameColumn(
                name: "NombreDuenioID",
                table: "DetallePedidos",
                newName: "NombreDuenioDNI");

            migrationBuilder.RenameIndex(
                name: "IX_DetallePedidos_NombreDuenioID",
                table: "DetallePedidos",
                newName: "IX_DetallePedidos_NombreDuenioDNI");

            migrationBuilder.AlterColumn<int>(
                name: "DNI",
                table: "Dueños",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dueños",
                table: "Dueños",
                column: "DNI");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Dueños_NombreDuenioDNI",
                table: "DetallePedidos",
                column: "NombreDuenioDNI",
                principalTable: "Dueños",
                principalColumn: "DNI",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
