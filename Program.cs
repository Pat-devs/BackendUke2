Console.Clear();

// Products available:
string[] products = { "Coffee", "Tea", "Bread", "Milk" }; // fixed type (f.eks: string), fixed length

// Users shooping cart:
List<string> cart = new List<string>();

// show initial greeting
Console.WriteLine("Welcome to our shop.");

// menu loop

while(true)
{
    Console.Clear();
    Console.WriteLine("Products menu (enter a number)");
    Console.WriteLine("1. List all products");
    Console.WriteLine("2. List items in your cart");
    Console.WriteLine("3. Exit");

    string command = Console.ReadLine(); // prompt user for input

    if (command == "1")
    {
        Console.Clear();
        Console.WriteLine("Our products:");

        foreach (string product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Press enter to return to main menu.");
        Console.ReadLine(); // pause the loop :)
    }
    if (command == "3")
    {
        Console.WriteLine("Byebye");
        break;
    }
}