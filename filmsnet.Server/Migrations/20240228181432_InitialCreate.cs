using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace filmsnet.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatActors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatActors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatGenres",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatActorFilm",
                columns: table => new
                {
                    ActorsId = table.Column<long>(type: "bigint", nullable: false),
                    FilmsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatActorFilm", x => new { x.ActorsId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_CatActorFilm_CatActors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "CatActors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatActorFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatGenreFilm",
                columns: table => new
                {
                    FilmsId = table.Column<long>(type: "bigint", nullable: false),
                    GenresId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGenreFilm", x => new { x.FilmsId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_CatGenreFilm_CatGenres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "CatGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatGenreFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatActorFilm_FilmsId",
                table: "CatActorFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CatGenreFilm_GenresId",
                table: "CatGenreFilm",
                column: "GenresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatActorFilm");

            migrationBuilder.DropTable(
                name: "CatGenreFilm");

            migrationBuilder.DropTable(
                name: "CatActors");

            migrationBuilder.DropTable(
                name: "CatGenres");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
