using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaramentMeetingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningSongTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningSongNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymnTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymn = table.Column<int>(type: "int", nullable: false),
                    IntermediateTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateNum = table.Column<int>(type: "int", nullable: false),
                    ClosingHymnTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymnNum = table.Column<int>(type: "int", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSpeakers = table.Column<int>(type: "int", nullable: false),
                    Speakers = table.Column<string>(type: "string", nullable: true),
                    SpeakerSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}
