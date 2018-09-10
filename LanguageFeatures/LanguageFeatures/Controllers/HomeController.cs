using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
		//public IActionResult Index()
		//{
		//	// var productsString = Product.GetProducts().Select(product => string.Format($"Name = {product?.Name ?? "No Product"} In stock = {product?.InStock.ToString() ?? "No Product"}"));			

		//	// new way to initialise dictionaries
		//	//var products = new Dictionary<string, Product>
		//	//{
		//	//	["Kayak1"] = new Product { Name = "Kayak", Price = 275m},
		//	//	["Lifejacket1"] = new Product { Name = "LifeJacket", Price = 48.95m }
		//	//};

		//	// var totalPrice = new string[] { Product.GetProducts().TotalPrice().ToString() };
		//	var minimumPrice = 50;

		//	// bool filterByPrice(Product product) { return product.Price > minimumPrice; }
		//	// local function
		//	bool filterByPrice(Product product) => product?.Price > minimumPrice;

		//	// use of null conditional operator and coalesce operator together pretty powerful!
		//	bool filterByName(Product product) => product?.Name?.ToLower().StartsWith("ka") ?? false;

		//	var shoppingCart = new ShoppingCart
		//	{
		//		Products = Product.GetProducts()
		//	};

		//	// var totalPrice = new string[] { shoppingCart.TotalPrice().ToString() };
		//	// var filteredProducts = shoppingCart.FilterBy(filterByPrice);
		//	// var filteredProducts = shoppingCart.FilterBy(filterByName);

			
			
		//	// return View("Index", new string[] { filteredProducts.TotalPrice().ToString() });
		//	return View("Index", new string[] { pageLengthTask.ToString() });
  //      }

		public async Task<IActionResult> Index()
		{
			var pageLength = await AsyncMethods.GetPageLength();

			return View("Index", new string[] { $"pageLength={pageLength}" });
		}
    }
}