// Loops intro


// Say hello 10 times.

// using a while loop 

int counter = 0;

while (counter < 100) // loop as long as counter value is above 0
{
    // do somthing


    counter++;

    if (counter == 25)
    {
        continue; // jumps over current iteration
    }

    if (counter == 10)
    {
        break; // terminates the loop completely 
    }

    Console.WriteLine(counter);
}
