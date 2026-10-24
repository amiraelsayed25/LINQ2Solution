using static LINQ.DataSources.Source;
namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//////---------------------------------Q3

			////var SortedProducts = ProductList
			////  .OrderBy(p => p.UnitPrice);
			////foreach (var P in SortedProducts)
			////{
			////	Console.WriteLine($"{P.ProductName}-{P.UnitPrice}");

			//	//----------------------------Q8 8.Sort ProductList by Category ascending, then within eachcategory, sort by UnitPrice descending.
			//	var Categoryascending = ProductList
			//		 .OrderBy(p => p.Category)
			//			  .ThenByDescending(p => p.UnitPrice);
			//	foreach (var p in Categoryascending)
			//	{
			//		Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
			//	}

			//	//------------------------Q9 9.Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

			//	var Products = ProductList
			//		 .Where(p => p.Category == "Beverages")
			//		 .OrderByDescending(p => p.UnitsInStock);

			//	foreach (var p in Products)
			//	{
			//		Console.WriteLine(
			//			$"{p.ProductName} - Stock: {p.UnitsInStock}");
			//	}
			//	// ------------------------Q12
			//	String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			//	var StoreWords = Arr.OrderBy(w => w.Length)
			//		.ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
			//	foreach(var word  in StoreWords)
			//	{
			//		Console.WriteLine(word);
			//	}

			//	//----------------------Q13
			//	string[] digits = { "ziro", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			//	var digitalresult = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
			//	foreach (var item in digitalresult)
			//	{
			//		Console.WriteLine(item);
			//	}



			//// -------------------------Q1
			//var top3expensive = ProductList.OrderByDescending(p => p.UnitPrice)
			//  .Take(3);
			//foreach(var p in top3expensive)
			//{
			//	Console.WriteLine($"{p.ProductName}-{p.UnitPrice}");
			//}

			////----------------------------Q2
			//int pagesize = 5;
			//int pagenumber = 2;
			//var page2products = ProductList.Skip((pagenumber - 1) * pagesize)
			//	.Take(pagesize);
			//foreach(var p in page2products)
			//{
			//	Console.WriteLine($"{p.ProductName}-{p.UnitPrice}");
			//}


			////----------------------------Q3
			//var cheapproducts = ProductList.TakeWhile(p => p.UnitPrice < 25);
			//foreach (var p in cheapproducts)
			//{
			//	Console.WriteLine($"{p.ProductName}-{p.UnitPrice}");
			//}

			////-----------------------Q4
			//bool allfoodinstock = ProductList.Where(p => p.Category == "seafood")
			//	.All(p => p.UnitsInStock > 0);
			//Console.WriteLine($"are all seafood in stock ?{allfoodinstock}");

			////-------------------------Q5
			//int[] ids = { 3, 9, 13, 18 };
			//bool contains9 = ids.Contains(9);
			//Console.WriteLine($"Does ID list contain 9? {contains9}");


			////-------------------------Q6
			//var productsByCategoryCount = ProductList.GroupBy(p => p.Category)
			//			 .Select(g => new { Category = g.Key, Count = g.Count() });

			//foreach (var item in productsByCategoryCount)
			//{
			//	Console.WriteLine($"{item.Category}: {item.Count}");
			//}


			////-------------------------Q7
			//var productNamesByCategory = ProductList.GroupBy(p => p.Category)
			//			 .Select(g => new
			//				 {
			//					 Category = g.Key,
			//					 ProductNames = g.Select(p => p.ProductName)
			//				 });

			//foreach (var group in productNamesByCategory)
			//{
			//	Console.WriteLine($"-- {group.Category} --");
			//	foreach (var name in group.ProductNames)
			//	{
			//		Console.WriteLine($"   {name}");
			//	}
			//}


			////-------------------------Q8
			//var categoriesMoreThan3 = ProductList.GroupBy(p => p.Category)
			//									 .Where(g => g.Count() > 3)
			//									 .Select(g => new { Category = g.Key, Count = g.Count() });

			//foreach (var item in categoriesMoreThan3)
			//{
			//	Console.WriteLine($"{item.Category}: {item.Count}");
			//}


			////-------------------------Q9
			//var customersByCountry = from c in CustomerList
			//						 group c by c.Country into g
			//						 select new
			//						 {
			//							 Country = g.Key,
			//							 Customers = g
			//						 };

			//foreach (var group in customersByCountry)
			//{
			//	Console.WriteLine($"Country: {group.Country}");
			//	foreach (var customer in group.Customers)
			//	{
			//		Console.WriteLine($"   {customer.CompanyName}");
			//	}
			//}
			////-------------------------Q10
			//int totalUnitsInStock = ProductList.Sum(p => p.UnitsInStock);
			//Console.WriteLine($"Total units in stock: {totalUnitsInStock}");


			////-------------------------Q11
			//decimal minPrice = ProductList.Min(p => p.UnitPrice);
			//decimal maxPrice = ProductList.Max(p => p.UnitPrice);

			//Console.WriteLine($"Cheapest price: {minPrice:C}");
			//Console.WriteLine($"Most expensive price: {maxPrice:C}");


			////-------------------------Q12
			//var distinctCategories = ProductList.Select(p => p.Category)
			//								   .Distinct();

			//foreach (var category in distinctCategories)
			//{
			//	Console.WriteLine(category);
			//}


			////-------------------------Q13
			//int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
			//int[] setB = { 3, 6, 9, 12, 15, 13 };

			//var resultIds = setA.Except(setB);

			//foreach (var id in resultIds)
			//{
			//	Console.WriteLine(id);
			//}

			////-------------------------Q14
			//string[] list1 = { "Germany", "France", "UK", "Spain" };
			//string[] list2 = { "france", "SPAIN", "Italy" };

			//var uniqueCountries = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

			//foreach (var country in uniqueCountries)
			//{
			//	Console.WriteLine(country);
			//}


			////-------------------------Q15
			//var productDictionary = ProductList.ToDictionary(p => p.ProductID);

			//if (productDictionary.TryGetValue(18, out var product18))
			//{
			//	Console.WriteLine($"Product ID 18: {product18.ProductName} - {product18.UnitPrice}");
			//}


			////-------------------------Q16
			//var firstOver50 = ProductList.First(p => p.UnitPrice > 50);
			//Console.WriteLine($"First product > $50: {firstOver50.ProductName} - {firstOver50.UnitPrice}");


			////-------------------------Q17
			//var firstOver500 = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

			//if (firstOver500 == null)
			//{
			//	Console.WriteLine("No product found with price > $500 (returns null).");
			//}
			//else
			//{
			//	Console.WriteLine($"Product: {firstOver500.ProductName}");
			//}


			////-------------------------Q18
			//var multiplicationTable7 = Enumerable.Range(1, 12)
			//									 .Select(i => $"7 x {i} = {7 * i}");

			//foreach (var line in multiplicationTable7)
			//{
			//	Console.WriteLine(line);
			//}


			////-------------------------Q19
			//var evenNumbers = Enumerable.Range(1, 30)
			//							.Where(n => n % 2 == 0);

			//foreach (var num in evenNumbers)
			//{
			//	Console.WriteLine(num);
			//}

   //       // -------------------------Q20
   //        var top3Products = ProductList.Take(3).Select(p => p.ProductName);
			//var top3Customers = CustomerList.Take(3).Select(c => c.CompanyName);

			//var concatenatedSequence = top3Products.Concat(top3Customers);

			//foreach (var item in concatenatedSequence)
			//{
			//	Console.WriteLine(item);
			//}


			////-------------------------Q21
			//var pairedSequence = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

			//foreach (var item in pairedSequence)
			//{
			//	Console.WriteLine(item);
			//}



		}
		}
	}

