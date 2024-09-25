using Microsoft.AspNetCore.Mvc;
using web_asp2.Models;

namespace web_asp2.Controllers
{
    public class CartController : Controller
    {
        private static Cart _cart = new Cart();

        // Отображение корзины
        public IActionResult Index()
        {
            return View(_cart);
        }

        // Добавление товара в корзину
        //[HttpPost]
        //public IActionResult AddToCart(int productId)
        //{
        //    // Получаем продукт по ID
        //    var product = new ProductsController().GetProductById(productId);
        //    if (product != null)
        //    {
        //        // Добавляем продукт в корзину
        //        _cart.AddProduct(product);
        //    }
        //    return RedirectToAction("Index", "Products");
        //}

        // Удаление товара из корзины
        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            _cart.RemoveProduct(productId);
            return RedirectToAction("Index");
        }

        // Оформление заказа
        [HttpPost]
        public IActionResult Checkout()
        {
            if (_cart.Items.Any())
            {
                // Логика оформления заказа (например, сохранение данных)
                // Очищаем корзину после оформления
                _cart.Items.Clear();
            }
            return View("OrderConfirmation");
        }

    }
}
