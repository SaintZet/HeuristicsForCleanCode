if (x > 0)
    Console.WriteLine("The number is positive");
else
    Console.WriteLine("The number is negative");
...
if (y > 0)
    Console.WriteLine("The number is positive");
else
    Console.WriteLine("The number is negative");

// In this example, the code for checking the sign of a number is duplicated twice.
// This code can be improved by combining it into a single method and calling it at the right places in the program.
// Here is an example of improved code:

CheckNumberSign(x);
...
CheckNumberSign(y);

private static void CheckNumberSign(int number)
{
    if (number > 0)
        Console.WriteLine("The number is positive");
    else
        Console.WriteLine("The number is negative");
}