Console.Clear();
/* Fizz buzz rules:

1. go through numbers 1-100
2. If a number is divisible by 3, the student says “fizz” rather than the number.
3. If a number is divisible by 5, they say “buzz” rather than the number.
4. If a number is divisible by both, they say “fizz buzz”
5. In all other cases just print out the number

*/

// Fizz buzz example soltion

for (int i = 1; i <= 100; i++)
{
    Console.Write(i + ". ");
    if (i % 3 == 0) // if no rest after division it means number is divisble by 3
    {
        Console.Write("Fizz");
    }
    if (i % 5 == 0)
    {
        Console.Write("Buzz");
    }

    Console.WriteLine();
}