using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCGrund.Migrations
{
    public partial class ChangedEmployee2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employee");
        }
    }
}
