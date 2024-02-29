using filmsnet.Server.Entities.Request;
using filmsnet.Server.Entities.Response;
using filmsnet.Server.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace filmsnet.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FilmsController : ControllerBase
	{
		private readonly ILogger<FilmsController> _logger;
		private readonly IFilmNegocio _filmNegocio;

		public FilmsController(IFilmNegocio filmNegocio, ILogger<FilmsController> logger)
		{
			_filmNegocio = filmNegocio;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] FilmRequest request)
		{
			try
			{
				var films = await _filmNegocio.getFilms(request);
				if (films.Status == ResponseStatus.Success)
				{
					return Ok(films);
				}
				else
				{
					return NoContent();
				}
			}
			catch (Exception ex)
			{
				return BadRequest(new ResponseGeneric<string>(ex.Message));
			}
		}
	}
}
