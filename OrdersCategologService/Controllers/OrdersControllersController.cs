using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersCategologService.Models;

namespace OrdersCategologService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        Orders Orders;
        public OrdersController()
        {
            Orders = new Orders();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Orders);
        }
    }
}
