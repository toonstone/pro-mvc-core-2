using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public static class ExtensionMethods
	{
		public static decimal TotalPrice(this IEnumerable<Product> products)
		{
			return products.Sum(product => product?.Price ?? 0);
		}

		public static IEnumerable<Product> FilterPrice(this IEnumerable<Product> products, decimal minimumPrice)
		{
			return products.Where(product => product?.Price > minimumPrice);
		}

		public static IEnumerable<Product> FilterBy(this IEnumerable<Product> products, Func<Product, bool> selector)
		{
			return products.Where(selector);
		}
    }
}
