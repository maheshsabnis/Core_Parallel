using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatelogService.Models;

namespace ProductCatelogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        Products Products;

        public ProductController()
        {
            Products = new Products();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }
    }
}
