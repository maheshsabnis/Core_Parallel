using System;
namespace Core_Parallels.Models
{
    public class DataViewModel
    {
        public List<Employee>? NonParallelEmployeesResult { get; set; } = new List<Employee>();
        public double NonParallelTotalDuration { get; set; }
        public List<Employee>? ParallelEmployeesResult { get; set; } = new List<Employee>();
        public double ParallelTotalDuration { get; set; }
    }



    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = String.Empty;
        public string ProductName { get; set; } = String.Empty;
        public int Quantity { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public string CategoryName { get; set; } = String.Empty;
        public string Manufacturer { get; set; } = String.Empty;
        public int Price { get; set; }
    }

    public class ParallelViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}

