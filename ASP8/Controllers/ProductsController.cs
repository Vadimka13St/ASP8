using ASP8.Models;

namespace ASP8.Controllers;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>();
        var random = new Random();

        for (int i = 1; i <= 5; i++)
        {
            products.Add(new Product
            {
                ID = i,
                Name = $"Product {i}",
                Price = random.Next(50, 150),
                CreatedDate = DateTime.Now.AddDays(-random.Next(0, 30))
            });
        }

        return View(products);
    }
}
