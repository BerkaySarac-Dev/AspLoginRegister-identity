using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginRegisterApp.Migrations.Tools
{
    public partial class ToolsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ToolPrice = table.Column<int>(type: "int", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsWaiting = table.Column<bool>(type: "bit", nullable: false),
                    MalwareResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tools", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tools");
        }
    }
}
