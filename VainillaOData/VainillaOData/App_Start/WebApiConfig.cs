using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using VainillaOData.Models;

namespace VainillaOData
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			ODataModelBuilder builder = new ODataConventionModelBuilder();

			builder.EntitySet<NotebookModel>("Notebooks");
			config.MapODataServiceRoute(
				routeName: "Jorge",
				routePrefix: "api/v1",
				model: builder.GetEdmModel());
		}
	}
}
