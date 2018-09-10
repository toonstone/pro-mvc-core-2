using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
		public string Name { get; set; }

		public decimal? Price { get; set; }

		public bool? InStock { get; }

		public Product(bool stock = true)
		{
			InStock = stock;
		}

		public static Product[] GetProducts() => new Product[]
		{
			new Product
			{
				Name = "Kayak",
				Price = 275m
			},
			new Product
			{
				Name = "LifeJacket",
				Price = 48.95m
			},
			null
		};
	}
}
