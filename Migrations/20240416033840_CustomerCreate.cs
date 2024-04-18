using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HipHopPizza.Migrations
{
    public partial class CustomerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Orders",
                newName: "CustomerPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Orders",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Orders",
                newName: "CustomerEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerPhone",
                table: "Orders",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CustomerEmail",
                table: "Orders",
                newName: "Email");
        }
    }
}
