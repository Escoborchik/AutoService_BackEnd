using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoService_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufactureYear",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "MileAge",
                table: "OrdersWithoutReg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StateNumber",
                table: "OrdersWithoutReg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vin",
                table: "OrdersWithoutReg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MileAge",
                table: "OrdersWithoutReg");

            migrationBuilder.DropColumn(
                name: "StateNumber",
                table: "OrdersWithoutReg");

            migrationBuilder.DropColumn(
                name: "Vin",
                table: "OrdersWithoutReg");

            migrationBuilder.AlterColumn<int>(
                name: "Vin",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManufactureYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
