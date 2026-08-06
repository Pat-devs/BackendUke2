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
    Console.WriteLine("3. Add an item to cart");
    Console.WriteLine("4. Remove an item from cart");
    Console.WriteLine("5. Remove all items from your cart");
    Console.WriteLine("6. Exit");

    string command = Console.ReadLine(); // prompt user for input

    if (command == "1")
    {
        ShowAllProducts(products);
    }
    if (command == "2")
    {
        ShowAllItemsInCart(cart);
    }
    if (command == "3")
    {
        AddItemToCart(cart, "test item"); // TODO: replace "test item" with actual item (based on user input)
    }
    if (command == "4")
    {
        RemoveItemFromCart(cart, "test item"); // TODO: replace "test item" with actual item (based on user input)
    }
    if (command == "5")
    {
        RemoveAllItemsFromCart(cart);
    }
    if (command == "6") // Exit
    {
        Console.WriteLine("Byebye");
        break;
    }
}

// list all products
static void ShowAllProducts(string[] products)
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

// list all items in cart
static void ShowAllItemsInCart(List<string> cart)
{
    Console.Clear();

    if (cart.Count > 0)
    {
        Console.WriteLine("Items in your cart:");

        foreach (string item in cart)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine("Your cart is empty.");
    }

    Console.WriteLine("Press enter to return to main menu.");
    Console.ReadLine(); // pause the loop :)
}

// add an item to cart
static void AddItemToCart(List<string> cart, string item)
{
    cart.Add(item);
}

// remove an item from cart
static void RemoveItemFromCart(List<string> cart, string item)
{
    bool removeSuccess = cart.Remove(item);
    if (removeSuccess)
    {
        Console.WriteLine(item + " was removed from you cart. Press any key to return to main menu.");
        Console.Read();
    }
    else
    {
        Console.WriteLine(item + " was NOT removed from you cart. Press any key to return to main menu.");
        Console.Read();
    }
}

// remove all items from cart
static void RemoveAllItemsFromCart(List<string> cart)
{
    while (cart.Count > 0)
    {
        Console.WriteLine("Removed " + cart[0]);
        // remove this item
        cart.Remove(cart[0]);   
    }

    Console.WriteLine("Press enter to return to main menu.");
    Console.Read();
}