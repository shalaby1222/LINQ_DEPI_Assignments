
using static day10_G01.ListGenerators;

#region LINQ - Restriction Operators

//#region Problem 1
//var outOfStockProducts = ProductList.Where((p) => p.UnitsInStock == 0);
//#endregion

//#region Problem 2
//var inStockAndExpensive = ProductList.Where((p) => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
//#endregion

//#region Problem 3
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var digitsShortName = Arr.Select((n, i) => new { Name = n, Value = i })
//                         .Where((a) => a.Name.Length < a.Value);
//#endregion

#endregion

#region LINQ - Element Operators 

//#region Problem 1
//var firstOutOfStock = ProductList.FirstOrDefault((p) => p.UnitsInStock == 0);
//#endregion

//#region Problem 2
//var expensiveProduct = ProductList.FirstOrDefault((P) => P.UnitsInStock > 0 && P.UnitPrice > 1000);
//#endregion

//#region Problem 3
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var secondGreaterThanFive = Arr.Where((n) => n > 5)
//                               .Skip(1)
//                               .FirstOrDefault();

//#endregion

#endregion

#region LINQ - Aggregate Operators

//#region Problem 1
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var oddNumbersCount = Arr.Count((n) => n % 2 != 0);
//#endregion

//#region Problem 2
//var customerOrdersCount = CustomerList.Select((c) => new { CustomerName = c.Name, OrderCount = c.Orders?.Length ?? 0 });
//#endregion

//#region Problem 3
//var categoryProductCount = ProductList.GroupBy((p) => p.Category)
//                                      .Select((p) => new { Category = p.Key, ProductCount = p.Count() });
//#endregion

//#region Problem 4
//var totalSum = Arr.Sum();
//#endregion

//#region Problem 6
//var categoryTotalUnits = ProductList.GroupBy((c) => c.Category)
//                                    .Select((p) => new { Category = p.Key, TotalUnits = p.Sum((u) => u.UnitsInStock) });
//#endregion

//#region Problem 8
//var cheapestPricePerCategory = ProductList.GroupBy((c) => c.Category)
//                                          .Select((p) => new { Category = p.Key, CheapestPrice = p.Min((u) => u.UnitPrice) });
//#endregion

//#region Problem 9
//var cheapestProductsPerCategory = from p in ProductList
//                                  group p by p.Category into g
//                                  let minPrice = g.Min((p) => p.UnitPrice)
//                                  select new
//                                  {
//                                      Category = g.Key,
//                                      CheapestProducts = g.Where((p) => p.UnitPrice == minPrice)
//                                  };

//#endregion

//#region Problem 11
//var mostExpensivePricePerCategory = ProductList.GroupBy((c) => c.Category)
//                                               .Select((p) => new { Category = p.Key, MaxPrice = p.Max((u) => u.UnitPrice) });
//#endregion

//#region Problem 12
//var mostExpensiveProductsPerCategory = from p in ProductList
//                                       group p by p.Category into g
//                                       let maxPrice = g.Max((p) => p.UnitPrice)
//                                       select new
//                                       {
//                                           Category = g.Key,
//                                           MostExpensiveProducts = g.Where((u) => u.UnitPrice == maxPrice)
//                                       };
//#endregion

//#region Problem 14
//var averagePricePerCategory = ProductList.GroupBy((c) => c.Category)
//                                         .Select((p) => new { Category = p.Key, AveragePrice = p.Average((p) => p.UnitPrice) });
//#endregion

#endregion

#region LINQ - Ordering Operators 

//#region Problem 1
//var sortedProductsByName = ProductList.OrderBy((p) => p.ProductName);
//#endregion

//#region Problem 2
//string[] wordsArr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//var caseInsensitiveSort = wordsArr.OrderBy((w) => w, StringComparer.OrdinalIgnoreCase);
//#endregion

//#region Problem 3
//var sortedProductsByUnitsDesc = ProductList.OrderByDescending((u) => u.UnitsInStock);
//#endregion

//#region Problem 4
//string[] numbersArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var sortedDigits = numbersArr.OrderBy((l) => l.Length)
//                              .ThenBy((l) => l);
//#endregion

//#region Problem 5
//var sortedByLengthThenCaseInsensitive = wordsArr.OrderBy((l) => l.Length)
//                                           .ThenBy((l) => l, StringComparer.OrdinalIgnoreCase);

//#endregion

//#region Problem 6
//var sortedProductsCategoryPriceDesc = ProductList.OrderBy((c) => c.Category)
//                                                 .ThenByDescending((u) => u.UnitPrice);
//#endregion

//#region Problem 7
//var sortedByLengthThenCaseInsensitiveDesc = wordsArr.OrderBy((l) => l.Length)
//                                                    .ThenByDescending((l) => l, StringComparer.OrdinalIgnoreCase);
//#endregion

//#region Problem 8


//#endregion

#endregion

#region LINQ - Transformation Operators 

//#region Problem 1
//var productNames = ProductList.Select((p) => p.ProductName);
//#endregion

//#region Problem 2
//string[] wordsToTransform = { "aPPLE", "BlUeBeRrY", "cHeRry" };
//var upperLowerWords = wordsToTransform.Select((w) => new { Upper = w.ToUpper(), Lower = w.ToLower() });
//#endregion

//#region Problem 3
//var productProperties = ProductList.Select((p) => new
//{
//    p.ProductID,
//    p.ProductName,
//    Price = p.UnitPrice,
//});
//#endregion

//#region Problem 4
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var positionMatches = Arr.Select((number, index) => new { Number = number, InPlace = number == index });
//#endregion

//#region Problem 5
//int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
//int[] numbersB = { 1, 3, 5, 7, 8 };
//var numberPairs = from a in numbersA
//                  from b in numbersB
//                  where a < b
//                  select new { a, b };
//#endregion

//#region Problem 6
//var ordersLessThan500 = CustomerList.Where((c) => c.Orders != null)
//                                    .SelectMany((o) => o.Orders)
//                                    .Where((o) => o.Total < 500.00);

//#endregion

//#region Problem 7
//var ordersFrom1998OrLater = CustomerList.Where((c) => c.Orders != null)
//                                        .SelectMany((o) => o.Orders)
//                                        .Where((o) => o.OrderDate.Year >= 1998);
//#endregion

#endregion

#region LINQ - Partitioning Operators

//#region Problem 1
//var washingtonOrdersFirst3 = CustomerList.Where((c) => c.City == "washington")
//                                         .Where((c) => c.Orders != null)
//                                         .SelectMany((c) => c.Orders)
//                                         .Take(3);

//#endregion

//#region Problem 2
//var washingtonOrdersSkip2 = CustomerList.Where((c) => c.City == "washington")
//                                        .Where((c) => c.Orders != null)
//                                        .SelectMany((c) => c.Orders)
//                                        .Skip(2);

//#endregion

//#region Problem 3
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var takeWhileNotLessThanPosition = numbers.TakeWhile((number, index) => number >= index);
//#endregion

//#region Problem 4
//var skipUntilDivisibleBy3 = numbers.SkipWhile((number) => number % 3 != 0);
//#endregion

//#region Problem 5
//var skipUntilLessThanPosition = numbers.SkipWhile((number, index) => number >= index);

//#endregion

#endregion

#region LINQ - Quantifiers  


//#region Problem 2

//var categoriesWithAnyOutOfStock = ProductList.GroupBy((p) => p.Category)
//                                             .Where((p) => p.Any((u) => u.UnitsInStock == 0));
//#endregion

//#region Problem 3
//var categoriesWithAllInStock = ProductList.GroupBy((p) => p.Category)
//                                             .Where((p) => p.All((u) => u.UnitsInStock > 0));
//#endregion

#endregion