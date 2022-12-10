using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchedulePlanner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymn = table.Column<int>(type: "int", nullable: false),
                    SacramentHymnTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateNumber = table.Column<int>(type: "int", nullable: false),
                    IntermediateNumberTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymn = table.Column<int>(type: "int", nullable: false),
                    ClosingHymnTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSpeakers = table.Column<int>(type: "int", nullable: false),
                    SpeakerSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulePlanner", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchedulePlanner");
        }
    }
}
