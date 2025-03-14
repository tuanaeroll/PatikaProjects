# ASP.NET MVC - Customer and Order Information Display Application

This project is a web application built using ASP.NET MVC that displays customer and order details.

## Project Objectives

This project involves the following steps:

1. **Model Creation:** Define `Customer` and `Order` models.
2. **ViewModel Creation:** Create `CustomerOrderViewModel`.
3. **Controller Creation:** Use `CustomerOrdersController` to pass data to the View.
4. **View Creation:** Display customer and order information in `Index.cshtml`.

## Installation

To run the project locally:

1. Ensure **ASP.NET Core SDK** is installed.
2. Open **Terminal** or **Command Prompt** in the project directory.
3. Execute the following command:
   ```bash
   dotnet run
   ```
4. Open `https://localhost:5001` in your browser to view the application.

## Technologies Used

- ASP.NET Core MVC
- C#
- Razor Views
- Bootstrap (optional)

## Project Structure

```
/MvcCustomerOrders
│-- /Controllers
│   ├── CustomerOrdersController.cs
│-- /Models
│   ├── Customer.cs
│   ├── Order.cs
│   ├── CustomerOrderViewModel.cs
│-- /Views
│   ├── /CustomerOrders
│   │   ├── Index.cshtml
│-- /Views/Shared
│   ├── _Layout.cshtml
│-- appsettings.json
│-- Startup.cs
│-- Program.cs
```

## Implementation Steps

### 1. **Define Models**

Customer.cs

```csharp
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
```

Order.cs

```csharp
public class Order
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

### 2. **Define ViewModel**

CustomerOrderViewModel.cs

```csharp
public class CustomerOrderViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
}
```

### 3. **Create Controller**

CustomerOrdersController.cs

```csharp
public class CustomerOrdersController : Controller
{
    public IActionResult Index()
    {
        var customer = new Customer
        {
            Id = 1,
            FirstName = "Ali",
            LastName = "Yılmaz",
            Email = "ali@example.com"
        };

        var orders = new List<Order>
        {
            new Order { Id = 101, ProductName = "Laptop", Price = 15000, Quantity = 1 },
            new Order { Id = 102, ProductName = "Mouse", Price = 500, Quantity = 2 }
        };

        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        return View(viewModel);
    }
}
```

### 4. **Create View**

Index.cshtml

```html
@model CustomerOrderViewModel
<h1>Customer and Order Information</h1>
<h2>@Model.Customer.FirstName @Model.Customer.LastName</h2>
<p>Email: @Model.Customer.Email</p>

<table>
    <tr>
        <th>ID</th>
        <th>Product</th>
        <th>Price</th>
        <th>Quantity</th>
    </tr>
    @foreach (var order in Model.Orders)
    {
        <tr>
            <td>@order.Id</td>
            <td>@order.ProductName</td>
            <td>@order.Price</td>
            <td>@order.Quantity</td>
        </tr>
    }
</table>
```

## Contributing

To contribute to this project, please create a **Pull Request**.
