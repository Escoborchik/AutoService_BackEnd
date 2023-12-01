using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoService_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Fith : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Work",
                table: "OrdersWithoutReg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Work",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Work",
                table: "OrdersWithoutReg");

            migrationBuilder.DropColumn(
                name: "Work",
                table: "Orders");
        }
    }
}
