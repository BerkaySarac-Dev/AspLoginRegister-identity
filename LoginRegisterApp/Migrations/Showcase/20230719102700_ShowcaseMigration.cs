using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginRegisterApp.Migrations.Showcase
{
    public partial class ShowcaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "showcases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowcaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowcasePhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowcaseHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowcaseText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsItMını = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_showcases", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "showcases");
        }
    }
}
