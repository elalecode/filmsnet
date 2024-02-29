using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace filmsnet.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CatActorFilm",
                table: "CatActorFilm");

            migrationBuilder.DropIndex(
                name: "IX_CatActorFilm_FilmsId",
                table: "CatActorFilm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatActorFilm",
                table: "CatActorFilm",
                columns: new[] { "FilmsId", "ActorsId" });

            migrationBuilder.InsertData(
                table: "CatActors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Robert De Niro" },
                    { 2L, "Jack Nicholson" },
                    { 3L, "Marlon Brando" },
                    { 4L, "Denzel Washington" },
                    { 5L, "Katharine Hepburn" },
                    { 6L, "Meryl Streep" },
                    { 7L, "Sidney Poitier" },
                    { 8L, "Tom Hanks" },
                    { 9L, "Elizabeth Taylor" },
                    { 10L, "Leonardo DiCaprio" },
                    { 11L, "Cate Blanchett" },
                    { 12L, "Kate Winslet" },
                    { 13L, "Shah Rukh Khan" },
                    { 14L, "Viola Davis" }
                });

            migrationBuilder.InsertData(
                table: "CatGenres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Sci-Fi" },
                    { 2L, "Comedy" },
                    { 3L, "Drama" },
                    { 4L, "Action" },
                    { 5L, "Horror" },
                    { 6L, "Romance" },
                    { 7L, "Animation" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1L, "Night Swim" },
                    { 2L, "The Underdoggs" },
                    { 3L, "Mean Girls" },
                    { 4L, "Creed III" },
                    { 5L, "John Wick: Chapter 4" }
                });

            migrationBuilder.InsertData(
                table: "CatActorFilm",
                columns: new[] { "ActorsId", "FilmsId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 4L, 1L },
                    { 7L, 1L },
                    { 1L, 2L },
                    { 3L, 2L },
                    { 4L, 2L },
                    { 9L, 2L },
                    { 11L, 2L },
                    { 13L, 2L },
                    { 2L, 3L },
                    { 3L, 3L },
                    { 5L, 3L },
                    { 6L, 3L },
                    { 7L, 3L },
                    { 9L, 3L },
                    { 10L, 3L },
                    { 3L, 4L },
                    { 6L, 4L },
                    { 8L, 4L },
                    { 9L, 4L },
                    { 11L, 4L },
                    { 13L, 4L },
                    { 14L, 4L }
                });

            migrationBuilder.InsertData(
                table: "CatGenreFilm",
                columns: new[] { "FilmsId", "GenresId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 1L, 5L },
                    { 2L, 3L },
                    { 3L, 7L },
                    { 4L, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatActorFilm_ActorsId",
                table: "CatActorFilm",
                column: "ActorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CatActorFilm",
                table: "CatActorFilm");

            migrationBuilder.DropIndex(
                name: "IX_CatActorFilm_ActorsId",
                table: "CatActorFilm");

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 4L, 1L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 7L, 1L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 9L, 2L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 11L, 2L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 13L, 2L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 3L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 5L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 6L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 7L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 9L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 10L, 3L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 3L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 6L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 8L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 9L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 11L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 13L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActorFilm",
                keyColumns: new[] { "ActorsId", "FilmsId" },
                keyValues: new object[] { 14L, 4L });

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "CatGenreFilm",
                keyColumns: new[] { "FilmsId", "GenresId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "CatGenreFilm",
                keyColumns: new[] { "FilmsId", "GenresId" },
                keyValues: new object[] { 1L, 5L });

            migrationBuilder.DeleteData(
                table: "CatGenreFilm",
                keyColumns: new[] { "FilmsId", "GenresId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "CatGenreFilm",
                keyColumns: new[] { "FilmsId", "GenresId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "CatGenreFilm",
                keyColumns: new[] { "FilmsId", "GenresId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "CatActors",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CatGenres",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatActorFilm",
                table: "CatActorFilm",
                columns: new[] { "ActorsId", "FilmsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CatActorFilm_FilmsId",
                table: "CatActorFilm",
                column: "FilmsId");
        }
    }
}
