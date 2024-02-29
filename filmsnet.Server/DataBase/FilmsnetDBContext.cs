using Microsoft.EntityFrameworkCore;

namespace filmsnet.Server.DataBase
{
	public partial class FilmsnetDBContext : DbContext
	{
		public FilmsnetDBContext(DbContextOptions<FilmsnetDBContext> options) : base(options) { }


		public virtual DbSet<CatGenre> CatGenres { get; set; }
		public virtual DbSet<CatActor> CatActors { get; set; }
		public virtual DbSet<Film> Films { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			List<CatGenre> genresInit = new List<CatGenre>();
			genresInit.Add(new CatGenre { Id = 1L, Name = "Sci-Fi"});
			genresInit.Add(new CatGenre { Id = 2L, Name = "Comedy" });
			genresInit.Add(new CatGenre { Id = 3L, Name = "Drama" });
			genresInit.Add(new CatGenre { Id = 4L, Name = "Action" });
			genresInit.Add(new CatGenre { Id = 5L, Name = "Horror" });
			genresInit.Add(new CatGenre { Id = 6L, Name = "Romance" });
			genresInit.Add(new CatGenre { Id = 7L, Name = "Animation" });

			modelBuilder.Entity<CatGenre>(entity =>
			{
				entity.HasData(genresInit);
			});

			List<CatActor> actorsInit = new List<CatActor>();
			actorsInit.Add(new CatActor { Id = 1L, Name = "Robert De Niro" });
			actorsInit.Add(new CatActor { Id = 2L, Name = "Jack Nicholson" });
			actorsInit.Add(new CatActor { Id = 3L, Name = "Marlon Brando" });
			actorsInit.Add(new CatActor { Id = 4L, Name = "Denzel Washington" });
			actorsInit.Add(new CatActor { Id = 5L, Name = "Katharine Hepburn" });
			actorsInit.Add(new CatActor { Id = 6L, Name = "Meryl Streep" });
			actorsInit.Add(new CatActor { Id = 7L, Name = "Sidney Poitier" });
			actorsInit.Add(new CatActor { Id = 8L, Name = "Tom Hanks" });
			actorsInit.Add(new CatActor { Id = 9L, Name = "Elizabeth Taylor" });
			actorsInit.Add(new CatActor { Id = 10L, Name = "Leonardo DiCaprio" });
			actorsInit.Add(new CatActor { Id = 11L, Name = "Cate Blanchett" });
			actorsInit.Add(new CatActor { Id = 12L, Name = "Kate Winslet" });
			actorsInit.Add(new CatActor { Id = 13L, Name = "Shah Rukh Khan" });
			actorsInit.Add(new CatActor { Id = 14L, Name = "Viola Davis" });

			modelBuilder.Entity<CatActor>(entity =>
			{
				entity.HasData(actorsInit);
			});

			List<Film> filmsInit = new List<Film>();
			filmsInit.Add(new Film { Id = 1L, Title = "Night Swim" });
			filmsInit.Add(new Film { Id = 2L, Title = "The Underdoggs" });
			filmsInit.Add(new Film { Id = 3L, Title = "Mean Girls" });
			filmsInit.Add(new Film { Id = 4L, Title = "Creed III" });
			filmsInit.Add(new Film { Id = 5L, Title = "John Wick: Chapter 4" });


			modelBuilder.Entity<Film>(entity =>
			{
				entity.HasData(filmsInit);
			});

			modelBuilder.Entity<Film>()
				.HasMany(e => e.Actors)
				.WithMany(e => e.Films)
				.UsingEntity<Dictionary<string, object>>(
					"CatActorFilm",
					r => r.HasOne<CatActor>().WithMany().HasForeignKey("ActorsId"),
					l => l.HasOne<Film>().WithMany().HasForeignKey("FilmsId"),
					je =>
					{
						je.HasKey("FilmsId", "ActorsId");
						je.HasData(
							new { FilmsId = 1L, ActorsId = 1L },
							new { FilmsId = 1L, ActorsId = 7L },
							new { FilmsId = 1L, ActorsId = 4L },
							new { FilmsId = 2L, ActorsId = 1L },
							new { FilmsId = 2L, ActorsId = 4L },
							new { FilmsId = 2L, ActorsId = 13L },
							new { FilmsId = 2L, ActorsId = 11L },
							new { FilmsId = 2L, ActorsId = 3L },
							new { FilmsId = 2L, ActorsId = 9L },
							new { FilmsId = 3L, ActorsId = 7L },
							new { FilmsId = 3L, ActorsId = 5L },
							new { FilmsId = 3L, ActorsId = 6L },
							new { FilmsId = 3L, ActorsId = 3L },
							new { FilmsId = 3L, ActorsId = 2L },
							new { FilmsId = 3L, ActorsId = 10L },
							new { FilmsId = 3L, ActorsId = 9L },
							new { FilmsId = 4L, ActorsId = 11L },
							new { FilmsId = 4L, ActorsId = 3L },
							new { FilmsId = 4L, ActorsId = 6L },
							new { FilmsId = 4L, ActorsId = 8L },
							new { FilmsId = 4L, ActorsId = 9L },
							new { FilmsId = 4L, ActorsId = 14L },
							new { FilmsId = 4L, ActorsId = 13L }
						);
					}
				);

			modelBuilder.Entity<Film>()
				.HasMany(e => e.Genres)
				.WithMany(e => e.Films)
				.UsingEntity<Dictionary<string, object>>(
					"CatGenreFilm",
					r => r.HasOne<CatGenre>().WithMany().HasForeignKey("GenresId"),
					l => l.HasOne<Film>().WithMany().HasForeignKey("FilmsId"),
					je =>
					{
						je.HasKey("FilmsId", "GenresId");
						je.HasData(
							new { FilmsId = 1L, GenresId = 1L },
							new { FilmsId = 1L, GenresId = 5L },
							new { FilmsId = 2L, GenresId = 3L },
							new { FilmsId = 3L, GenresId = 7L },
							new { FilmsId = 4L, GenresId = 2L }
						);
					}
				);

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
