using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HipHopPizza.Migrations
{
    public partial class CloseOrder1Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Orders",
                newName: "CloseOrderDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CloseOrderDate",
                table: "Orders",
                newName: "Date");
        }
    }
}
