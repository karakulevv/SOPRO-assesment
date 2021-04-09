using Microsoft.EntityFrameworkCore.Migrations;

namespace SOPRO.Migrations
{
    public partial class AddUnionToPackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Union",
                table: "Package",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Union",
                table: "Package");
        }
    }
}
