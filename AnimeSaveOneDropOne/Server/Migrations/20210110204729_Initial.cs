using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeSaveOneDropOne.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    MalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.MalId);
                });

            migrationBuilder.CreateTable(
                name: "AnimeCharacters",
                columns: table => new
                {
                    MalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    PreviousRank = table.Column<int>(type: "int", nullable: false),
                    AnimeMalId = table.Column<int>(type: "int", nullable: false),
                    AnimeMeMalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeCharacters", x => x.MalId);
                    table.ForeignKey(
                        name: "FK_AnimeCharacters_Animes_AnimeMeMalId",
                        column: x => x.AnimeMeMalId,
                        principalTable: "Animes",
                        principalColumn: "MalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeCharacters_AnimeMeMalId",
                table: "AnimeCharacters",
                column: "AnimeMeMalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeCharacters");

            migrationBuilder.DropTable(
                name: "Animes");
        }
    }
}
