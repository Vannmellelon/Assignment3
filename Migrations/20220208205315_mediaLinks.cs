using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class mediaLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 1,
                column: "Picture",
                value: "https://upload.wikimedia.org/wikipedia/en/4/4d/Shrek_%28character%29.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 2,
                column: "Picture",
                value: "https://upload.wikimedia.org/wikipedia/en/b/b9/Princess_Fiona.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 3,
                column: "Picture",
                value: "https://upload.wikimedia.org/wikipedia/en/6/6c/Donkey_%28Shrek%29.png");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "Trailer",
                value: "https://youtu.be/NPEscG_jLVY");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "Picture",
                value: "https://www.nfkino.no/sites/nfkino.no/files/styles/movie_poster/public/media-images/2021-09/PosterKinoklubbBokma%CC%8Al.jpg?itok=hBhcFy9R");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 1,
                column: "Picture",
                value: null);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 2,
                column: "Picture",
                value: null);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "Id",
                keyValue: 3,
                column: "Picture",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "Picture",
                value: null);
        }
    }
}
