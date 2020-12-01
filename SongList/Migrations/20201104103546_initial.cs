using Microsoft.EntityFrameworkCore.Migrations;

namespace SongList.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongID);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongID", "Name", "Rating", "year" },
                values: new object[] { 1, "Love is Blind", 5, 1980 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongID", "Name", "Rating", "year" },
                values: new object[] { 2, "Love is Bitter", 4, 1981 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongID", "Name", "Rating", "year" },
                values: new object[] { 3, "Love is Sour", 3, 1983 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
