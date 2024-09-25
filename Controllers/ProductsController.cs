using Microsoft.AspNetCore.Mvc;
using web_asp2.Models;

namespace web_asp2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> products;

        public ProductsController(List<Product> products)
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Price = 100M },
                new Product { Id = 2, Name = "Product B", Price = 150M },
                new Product { Id = 3, Name = "Product C", Price = 200M }
            };
            products = products;
        }

        public IActionResult Index()
        {
            return View(products);
        }
        // Получение продукта по ID
        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
