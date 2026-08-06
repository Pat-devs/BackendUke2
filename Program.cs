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
    ShowMenu();

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
        Console.WriteLine("Enter item name: ");
        string itemName = Console.ReadLine();
        bool isProductNameValid = ProductExists(products, itemName);

        if (isProductNameValid) 
        {
            AddItemToCart(cart, itemName);
            Console.WriteLine("You added " + itemName + " to your cart.");
        }
        else
        {
            Console.WriteLine("We don't have any " + itemName);
        }

        Console.WriteLine("Press any key to coninue");
        Console.ReadLine();
    }
    if (command == "4")
    {
        Console.WriteLine("Enter item name: ");
        string itemName = Console.ReadLine();
        // bool isProductNameValid = ProductExists(products, itemName);
        bool isProductNameInCart = ProductIsInCart(cart, itemName);
        
        if (isProductNameInCart) 
        {
            RemoveItemFromCart(cart, itemName);
            Console.WriteLine("You removed " + itemName + " from your cart.");
        }
        else
        {
            Console.WriteLine("You dont have any " + itemName + " in your cart.");
        }

        Console.WriteLine("Press any key to coninue");
        Console.ReadLine();
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

// show the main menu
static void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("Products menu (enter a number)");
    Console.WriteLine("1. List all products");
    Console.WriteLine("2. List items in your cart");
    Console.WriteLine("3. Add an item to cart");
    Console.WriteLine("4. Remove an item from cart");
    Console.WriteLine("5. Remove all items from your cart");
    Console.WriteLine("6. Exit");
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

// check if product exists and return true or false based on that
static bool ProductExists(string[] products, string itemName)
{
    foreach (string item in products)
    {
        if (item == itemName)
        {
            return true; // return statement also works as a "break"
        }
    }

    // if we get this far, we can return false 
    return false;
}

// check if product is in the cart and return true or false based on that
static bool ProductIsInCart(List<string> cart, string itemName)
{
    foreach (string item in cart)
    {
        if (item == itemName)
        {
            return true; // return statement also works as a "break"
        }
    }

    // if we get this far, we can return false 
    return false;
}