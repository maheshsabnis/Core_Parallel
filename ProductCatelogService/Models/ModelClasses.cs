using System;
namespace ProductCatelogService.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public string CategoryName { get; set; } = String.Empty;
        public string Manufacturer { get; set; } = String.Empty;
        public int Price { get; set; }
    }

    public class Products : List<Product>
    {
        public Products()
        {
            Add(new Product() {ProductId=1,ProductName="Laptop",CategoryName="Electronics IT",Manufacturer="IBM",Price=345000 });
            Add(new Product() { ProductId = 2, ProductName = "Iron", CategoryName = "Electrical Home", Manufacturer = "Bajaj", Price = 5000 });
            Add(new Product() { ProductId = 3, ProductName = "Mobile", CategoryName = "Electronics Communication", Manufacturer = "Samsung", Price = 34000 });
            Add(new Product() { ProductId = 4, ProductName = "RAM", CategoryName = "Electronics IT", Manufacturer = "Samsung", Price = 345000 });
            Add(new Product() { ProductId = 5, ProductName = "Hard Disk", CategoryName = "Electronics IT", Manufacturer = "Western Digital", Price = 345000 });
            Add(new Product() { ProductId = 6, ProductName = "Power Adapter", CategoryName = "Electrical Power", Manufacturer = "HP", Price = 345000 });
            Add(new Product() { ProductId = 7, ProductName = "Mixer", CategoryName = "Electrical Home", Manufacturer = "Phillipse", Price = 345000 });
            Add(new Product() { ProductId = 8, ProductName = "TV", CategoryName = "Electronics Home", Manufacturer = "Samsung", Price = 345000 });
            Add(new Product() { ProductId = 9, ProductName = "Sofaset", CategoryName = "Furniture", Manufacturer = "Bajaj", Price = 345000 });
            Add(new Product() { ProductId = 10, ProductName = "LED Lights", CategoryName = "Electrical Home", Manufacturer = "Syska", Price = 345000 });
            Add(new Product() { ProductId = 11, ProductName = "Cycle", CategoryName = "Fitness", Manufacturer = "Bajaj", Price = 345000 });
            Add(new Product() { ProductId = 12, ProductName = "Keyboard", CategoryName = "Electronics IT", Manufacturer = "Microsoft", Price = 345000 });
            Add(new Product() { ProductId = 13, ProductName = "Mouse", CategoryName = "Electronics IT", Manufacturer = "Microsoft", Price = 345000 });
            Add(new Product() { ProductId = 14, ProductName = "Set Top Box", CategoryName = "Electrical Entertainment", Manufacturer = "D-link", Price = 345000 });
            Add(new Product() { ProductId = 15, ProductName = "Water Bottel", CategoryName = "Home Appliances", Manufacturer = "TATA", Price = 345000 });
            Add(new Product() { ProductId = 15, ProductName = "Monitor", CategoryName = "Electronics IT", Manufacturer = "Phillipse", Price = 345000 });
            Add(new Product() { ProductId = 16, ProductName = "Extension Box", CategoryName = "Electrical Entertainment", Manufacturer = "Bajaj", Price = 345000 });
            Add(new Product() { ProductId = 17, ProductName = "Headphone", CategoryName = "Electronics IT", Manufacturer = "Apple", Price = 345000 });
            Add(new Product() { ProductId = 18, ProductName = "Radio", CategoryName = "Electrical Entertainment", Manufacturer = "Apple", Price = 345000 });
            Add(new Product() { ProductId = 19, ProductName = "USB", CategoryName = "Electronics IT", Manufacturer = "Western Degital", Price = 345000 });
            Add(new Product() { ProductId = 20, ProductName = "Memory Card", CategoryName = "Electronics IT", Manufacturer = "Western Digital", Price = 345000 });
        }
    }
}

