using filmsnet.Server.DataBase;
using filmsnet.Server.Entities.Request;
using filmsnet.Server.Entities.Response;
using Microsoft.EntityFrameworkCore;

namespace filmsnet.Server.Negocio
{
	public class FilmNegocio : IFilmNegocio
	{
		private readonly FilmsnetDBContext _dbContext;
		public FilmNegocio(FilmsnetDBContext context)
		{
			_dbContext = context;
		}

		public async Task<ResponseGeneric<List<FilmResponse>>> getFilms(FilmRequest request)
		{
			var films = _dbContext.Films.AsQueryable();
			if (!string.IsNullOrEmpty(request.Search))
			{
				films = films.Where(x => x.Title.ToLower().Contains(request.Search));
			}
			var result = await films.Select(x => new FilmResponse
			{
				Id = x.Id,
				Title = x.Title,
				Actors = x.Actors.Select(x => new ActorResponse { Id = x.Id, Name = x.Name }).ToList(),
				Genres = x.Genres.Select(x => new GenreResponse { Id = x.Id, Name = x.Name }).ToList(),
			}).ToListAsync();
			return new ResponseGeneric<List<FilmResponse>>(result);
		}
	}

	public interface IFilmNegocio
	{
		Task<ResponseGeneric<List<FilmResponse>>> getFilms(FilmRequest request);
	}
}
