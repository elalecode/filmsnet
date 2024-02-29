using filmsnet.Server.DataBase;

namespace filmsnet.Server.Entities.Response
{
	public class FilmResponse
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public List<GenreResponse> Genres { get; set; }
		public List<ActorResponse> Actors { get; set; }
	}
}
