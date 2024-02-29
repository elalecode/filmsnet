namespace filmsnet.Server.DataBase
{
	public partial class CatGenre
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public List<Film> Films { get; } = [];
	}
}
