Console.Clear();

string password = "aBc1234jio0i";
// password requirements:

bool hasNumber = false; // needs to contain a number
bool moreThan8Characters = false;  // needs to contain a number
bool containsUpperCaseChar = false;  // needs to contain an uppercase character
bool containsLowerCaseChar = false;  // needs to contain a lowercase character

// go through each character and check if password is "strong"
foreach (char character in password)
{
    if (char.IsDigit(character))
    {
        hasNumber = true;
    }
    if (char.IsUpper(character))
    {
        containsUpperCaseChar = true;
    }
    if (char.IsLower(character))
    {
        containsLowerCaseChar = true;
    }
}

// check length of password
if (password.Length >= 8)
{
    moreThan8Characters = true;
}


// print password strengh summary
if (!hasNumber)
{
    Console.WriteLine("Password must contain a number!");
}

if (!moreThan8Characters)
{
    Console.WriteLine("Password must contain 8 chars or more.");
}
if (!containsUpperCaseChar)
{
    Console.WriteLine("Password must contain an uppercase character.");
}
if (!containsLowerCaseChar)
{
    Console.WriteLine("Password must contain a lowercase character.");
}