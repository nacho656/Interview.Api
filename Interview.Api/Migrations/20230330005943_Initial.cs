using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Interview.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "Date", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Science Fiction" },
                    { 2, "Animation" },
                    { 3, "Comedy" },
                    { 4, "Action" },
                    { 5, "Horror" },
                    { 6, "Romance" },
                    { 7, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "GenreId", "IsActive", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 4, true, new DateTime(2010, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 2, 4, true, new DateTime(2009, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2012" },
                    { 3, 1, true, new DateTime(2015, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Martian" },
                    { 4, 1, true, new DateTime(1978, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars - A New Hope" },
                    { 5, 2, true, new DateTime(2017, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name" },
                    { 6, 2, true, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weathering with You" },
                    { 7, 3, true, new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kung Fu Hustle" },
                    { 8, 3, true, new DateTime(2009, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hangover" },
                    { 9, 5, true, new DateTime(1996, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scream" },
                    { 10, 5, true, new DateTime(2004, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saw" },
                    { 11, 6, true, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" },
                    { 12, 6, true, new DateTime(2004, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Notebook" },
                    { 13, 7, true, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { 14, 7, true, new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 15, 4, false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Media_GenreId",
                table: "Media",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
