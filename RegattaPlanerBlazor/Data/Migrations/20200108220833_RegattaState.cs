using Microsoft.EntityFrameworkCore.Migrations;

namespace RegattaPlanerBlazor.Data.Migrations
{
    public partial class RegattaState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Regattas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Regattas");
        }
    }
}
