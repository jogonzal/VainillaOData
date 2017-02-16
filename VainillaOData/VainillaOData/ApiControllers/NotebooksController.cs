using System.Web.Http;

namespace VainillaOData.ApiControllers
{
	public class NotebooksController : ApiController
	{
		public IHttpActionResult Get()
		{
			return Ok(new
			{
				name = "Jorge"
			});
		}
	}
}