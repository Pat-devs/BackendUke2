Console.Clear();
// Loops intro

string word = "morn"; // 4 characters.... dvs. 0,1,2,3
// indexes are 0 based, not 1 based


Console.WriteLine(word.Length - 1); // Gets the number of characters in the current string object.

//Console.WriteLine(word[100]);

for (int i = word.Length - 1; i >= 0; i--)
{
    Console.Write(word[i]); 
}