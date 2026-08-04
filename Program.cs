Console.Clear();

string password = "veryeasy0password";
// password requirements:

bool hasNumber = false;

// go through each character and check if password is "strong"
foreach (char character in password)
{
    if (char.IsDigit(character))
    {
        hasNumber = true;
    }
}

// print password strengh summary
if (hasNumber)
{
    Console.WriteLine("Password contains a number.");
}
else 
{
    Console.WriteLine("Password must contain a number!");
}