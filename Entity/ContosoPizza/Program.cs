using ContosoPizza.Models;
using ContosoPizza.Data;

using ContosoPizzaContext context = new ContosoPizzaContext();


///// <summary>
///// Represents a special veggie pizza.
///// </summary>
//Product vegieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};
//context.Products.Add(vegieSpecial);

///// <summary>
///// Represents a deluxe meat pizza.
///// </summary>
//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};
//context.Add(deluxeMeat);

//context.SaveChanges();


///// <summary>
///// Change price
///// </summary>
//var veggieSpecial = context.Products
//    .Where(p  => p.Name == "Veggie Special Pizza")
//    .FirstOrDefault();
//if (veggieSpecial is Product)
//{
//    veggieSpecial.Price = 10.99M;
//}
//context.SaveChanges();


/// <summary>
/// Remove from database
/// </summary>
var veggieSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();
if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
}
context.SaveChanges();


/// <summary>
/// Retrieves the products with a price greater than 10.00M and orders them by name.
/// </summary>
var products = context.Products
        .Where(p => p.Price > 10.00M)
        .OrderBy(p => p.Name);

foreach (var product in products)
{
    Console.WriteLine($"Id:     {product.Id}");
    Console.WriteLine($"Name:   {product.Name}");
    Console.WriteLine($"Price:  {product.Price}");
    Console.WriteLine(new string('-', 20));
}


