namespace filmsnet.Server.DataBase
{
	public partial class Film
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public List<CatActor> Actors { get; } = [];
		public List<CatGenre> Genres { get; } = [];
	}
}
