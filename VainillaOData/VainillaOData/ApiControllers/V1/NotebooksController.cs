﻿using System.Web.Http;
using System.Web.OData.Routing;

namespace VainillaOData.ApiControllers.V1
{
	public class NotebooksController : ApiController
	{
		[ODataRoute("Notebooks")]
		public IHttpActionResult Get()
		{
			return Ok(new
			{
				name = "Jorge"
			});
		}
	}
}