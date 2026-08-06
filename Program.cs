Console.Clear();



// statisk funksjon som ikke returnerer noenting
// statisk funksjon som returnerer void

// basic greeting function:
static void Greet()
{
    Console.WriteLine("Hello world!");
}

// invoke a function:
// Greet();

// custom greeting 

static void CustomGreet(string message1, string message2)
{
    Console.Write(message1 + " ");
    Console.Write(message2 + "\n");
}

// CustomGreet("Hei verden!", "hadet verden");
// CustomGreet("Hvordan går det?", "Jo, det går fint.");

// a method that takes a text and a number as paramters so that it can print that message a number of times.

// example use: GreetNumberOfTimes("hei", 5) // output: hei, hei, hei, hei, hei

static void GreetNumberOfTimes(string text, int repeatTimes)
{
    // for loop solution
    for (int i = 0; i < repeatTimes; i++)
    {
        // Console.Write(text + ", ");  
    } 
    // while loop solution
    while(repeatTimes > 0)
    {
        Console.Write(text + ", ");  
        repeatTimes--;
    }
}

GreetNumberOfTimes("hei", 5);




Console.ReadLine(); // for å stopppe resten av koden :)

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
    if (command == "2")
    {
        Console.Clear();
        Console.WriteLine("Items in your cart:");

        foreach (string item in cart)
        {
            Console.WriteLine(item);
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