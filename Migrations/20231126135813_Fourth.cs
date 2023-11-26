using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoService_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MileAge",
                table: "OrdersWithoutReg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MileAge",
                table: "OrdersWithoutReg",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
