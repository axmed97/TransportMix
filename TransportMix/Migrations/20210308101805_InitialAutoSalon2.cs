using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportMix.Migrations
{
    public partial class InitialAutoSalon2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AutoSalons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AutoSalons");
        }
    }
}
