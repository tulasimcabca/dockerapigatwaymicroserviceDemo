using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Route("api/catalogs")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr","jpy" };
        }
    }
}
