using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return new Order[] { new Order{Id=1,Amount=500},new Order{Id=2,Amount=700} };
        }
    }

    public class Order
{
    public long Id {get;set;}
    public double Amount {get;set;}

}
}
