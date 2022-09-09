using System;
namespace OrdersCategologService.Models
{
    // Classes
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    public class Orders : List<Order>
    {
        public Orders()
        {
            Add(new Order() { OrderId = 20001, CustomerName = "Mahesh", ProductName = "Laptop", Quantity = 20 });
            Add(new Order() { OrderId = 20002, CustomerName = "Mukesh", ProductName = "Mobile", Quantity = 10 });
            Add(new Order() { OrderId = 20003, CustomerName = "Milind", ProductName = "RAM", Quantity = 8 });
            Add(new Order() { OrderId = 20004, CustomerName = "Mukul", ProductName = "Hard Disk", Quantity = 40 });
            Add(new Order() { OrderId = 20005, CustomerName = "Mukund", ProductName = "Mixer", Quantity = 2 });
            Add(new Order() { OrderId = 20006, CustomerName = "Mohan", ProductName = "Set Top Box", Quantity = 4 });
            Add(new Order() { OrderId = 20007, CustomerName = "Manohar", ProductName = "Extension Bopx", Quantity = 1 });
            Add(new Order() { OrderId = 20008, CustomerName = "Madhav", ProductName = "Laptop", Quantity = 30 });
            Add(new Order() { OrderId = 20009, CustomerName = "Mihir", ProductName = "Mobile", Quantity = 100 });
            Add(new Order() { OrderId = 20010, CustomerName = "Madhusudhan", ProductName = "TV", Quantity = 200 });
            Add(new Order() { OrderId = 20011, CustomerName = "Mrugank", ProductName = "Power Adapter", Quantity = 70 });
            Add(new Order() { OrderId = 20012, CustomerName = "Mrudul", ProductName = "Sofaset", Quantity = 2 });
            Add(new Order() { OrderId = 20013, CustomerName = "Manish", ProductName = "LED Lights", Quantity = 2000 });
            Add(new Order() { OrderId = 20014, CustomerName = "Manav", ProductName = "Water Bottle", Quantity = 300 });
            Add(new Order() { OrderId = 20015, CustomerName = "Ramesh", ProductName = "Monitor", Quantity = 10 });
            Add(new Order() { OrderId = 20016, CustomerName = "Ram", ProductName = "Radio", Quantity = 8 });
            Add(new Order() { OrderId = 20017, CustomerName = "Raghav", ProductName = "Monitor", Quantity = 9 });
            Add(new Order() { OrderId = 20018, CustomerName = "Ramdas", ProductName = "USB", Quantity = 2000 });
            Add(new Order() { OrderId = 20019, CustomerName = "Rajesh", ProductName = "Memory Catd", Quantity = 2000 });
            Add(new Order() { OrderId = 20020, CustomerName = "Radhey", ProductName = "Iron", Quantity = 2000 });
        }
    }

}

