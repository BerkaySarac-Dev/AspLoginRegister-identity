using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginRegisterApp.Migrations.Scripts
{
    public partial class ScriptMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Script",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScriptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScriptText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScriptImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ScriptPrice = table.Column<int>(type: "int", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsWaiting = table.Column<bool>(type: "bit", nullable: false),
                    MalwareResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScriptSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScriptUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Script", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Script");
        }
    }
}
