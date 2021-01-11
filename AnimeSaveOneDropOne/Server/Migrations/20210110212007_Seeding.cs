using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeSaveOneDropOne.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnimeCharacters",
                columns: new[] { "MalId", "AnimeMalId", "AnimeMeMalId", "ImageUrl", "Name", "Points", "PreviousRank", "Rank" },
                values: new object[,]
                {
                    { 1, 1, null, "https://fiverr-res.cloudinary.com/images/q_auto,f_auto/gigs/149470781/original/cf87ada92b21431ab6418eeae2aac47aa6502d56/draw-cool-anime-or-manga-style-characters-fan-art-or-oc.png", "AMN", 0, 2, 1 },
                    { 2, 1, null, "https://cdn.myanimelist.net/images/characters/2/284121.jpg", "Naruto", 0, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "MalId", "Description", "ImageUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "best anime", "book", "NDL Universe", "ndl-universe" },
                    { 2, "dats my nindo", "leaf", "Naruto", "naruto" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimeCharacters",
                keyColumn: "MalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnimeCharacters",
                keyColumn: "MalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "MalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "MalId",
                keyValue: 2);
        }
    }
}
