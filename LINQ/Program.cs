using static LINQ.DataSources.Source;
namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			////---------------------------------Q3

			//var SortedProducts = ProductList
			//	.OrderBy(p => p.UnitPrice);
			//foreach (var P in SortedProducts)
			//{
			//	Console.WriteLine($"{P.ProductName}-{P.UnitPrice}");

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



			}
		}
}
