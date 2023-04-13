using System;

class Program
{
    static void Main(string[] args)
    {
#pragma warning disable // Disable all compiler warnings

        // Code that may contain compiler warnings
        int unusedVariable; // Variable is not used

#pragma warning restore // Turn on all compiler warnings

        Console.WriteLine("The program has ended.");
    }
}

// In this example, we have used the #pragma warning disable directive without specifying a specific warning code.
// This will disable all compiler warnings for the block of code following the directive.
// We then enabled all compiler warnings with the #pragma warning restore directive.
// This ensures that all compiler warnings are enabled after the block of code where we disabled them.

// As a reminder, disabling compiler warnings should be used with caution,
// and only in cases where it is absolutely necessary,
// such as when you are working with old code that does not meet modern standards and compiler requirements.
