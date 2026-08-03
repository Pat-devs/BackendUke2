// Loops intro


while (true)
{
    Console.WriteLine("Enter the lucky number!");
    int userNumber = int.Parse(Console.ReadLine());
    if (userNumber == 5)
    {
        break;
    }
}

Console.WriteLine("Congratulations you entered the correct number!");