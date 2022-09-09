using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Parallels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Parallels.Controllers
{
    public class ParallelController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ParallelViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public    IActionResult Index(ParallelViewModel data)
        {
            var viewModel = new ParallelViewModel();

            Parallel.Invoke(() =>
            {
                viewModel.Products =  GetProducts().Result;
                viewModel.Orders = GetOrders().Result;

            });
            return View("Index",viewModel);
        }


        private async Task<List<Product>> GetProducts()
        {
            List<Product> products = new List<Product>();
            HttpClient http = new HttpClient();

            products = await http.GetFromJsonAsync<List<Product>>("https://localhost:7210/api/Product");

            return products;
        }

        private async Task<List<Order>> GetOrders()
        {
            List<Order> orders = new List<Order>();
            HttpClient http = new HttpClient();

            orders = await http.GetFromJsonAsync<List<Order>>("https://localhost:7028/api/Orders");
            return orders;
        }

    }
}