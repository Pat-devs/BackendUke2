Console.Clear();

// string products = "Coffee, Tea, Bread, Milk";

string[] products = { "Coffee", "Tea", "Bread", "Milk" }; // fixed type (f.eks: string), fixed length

// print all products
foreach (string product in products)
{
    Console.WriteLine(product);
}

// List 

List<string> items = new List<string>();

items.Add("thing");
items.Add("coffee");
items.Add("laptop");

foreach (var item in items)
{
    Console.WriteLine(item);
}