using static LINQ.DataSources.Source;
namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//---------------------------------Q3

			var SortedProducts = ProductList
			  .OrderBy(p => p.UnitPrice);
			foreach (var P in SortedProducts)
			{
				Console.WriteLine($"{P.ProductName}-{P.UnitPrice}");

				//----------------------------Q8 8.Sort ProductList by Category ascending, then within eachcategory, sort by UnitPrice descending.
				var Categoryascending = ProductList
					 .OrderBy(p => p.Category)
						  .ThenByDescending(p => p.UnitPrice);
				foreach (var p in Categoryascending)
				{
					Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
				}

				//------------------------Q9 9.Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

				var Products = ProductList
					 .Where(p => p.Category == "Beverages")
					 .OrderByDescending(p => p.UnitsInStock);

				foreach (var p in Products)
				{
					Console.WriteLine(
						$"{p.ProductName} - Stock: {p.UnitsInStock}");
				}
				// ------------------------Q12
				String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
				var StoreWords = Arr.OrderBy(w => w.Length)
					.ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
				foreach(var word  in StoreWords)
				{
					Console.WriteLine(word);
				}

				//----------------------Q13
				string[] digits = { "ziro", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
				var digitalresult = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
				foreach (var item in digitalresult)
				{
					Console.WriteLine(item);
				}

			}
		}
	}
}
