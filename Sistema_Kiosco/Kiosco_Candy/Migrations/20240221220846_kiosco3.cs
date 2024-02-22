using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KioscoCandy.Migrations
{
    /// <inheritdoc />
    public partial class kiosco3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MontoFinal",
                table: "DetallePedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoFinal",
                table: "DetallePedidos");
        }
    }
}
