using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace VainillaOData
{
	public class ApiVersionControllerSelector : DefaultHttpControllerSelector
	{
		public ApiVersionControllerSelector(HttpConfiguration configuration) : base(configuration)
		{
		}
	}
}