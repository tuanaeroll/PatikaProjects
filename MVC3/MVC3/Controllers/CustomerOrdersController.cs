using Microsoft.AspNetCore.Mvc;
using MVC3.Models;

namespace MVC3.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer1 = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@gmail.com"
            };

            var order1 = new Order
            {
                Id = 1,
                ProductName = "Laptop",
                Price = 1500,
                Quantity = 1
            };

            var order2 = new Order
            {
                Id = 2,
                ProductName = "Mouse",
                Price = 50,
                Quantity = 2
            };

            var order3 = new Order
            {
                Id = 3,
                ProductName = "Keyboard",
                Price = 100,
                Quantity = 1
            };

            var CustomerOrderViewModel = new CustomerOrderViewModel
            {
                Customer = customer1,
                Orders = new List<Order> { order1, order2, order3 }
            };

            return View(CustomerOrderViewModel);
        }
    }
}
