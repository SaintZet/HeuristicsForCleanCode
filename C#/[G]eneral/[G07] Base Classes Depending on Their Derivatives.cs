using System;

public class Animal
{
    public void Feed(string foodType)
    {
        if (foodType == "meat")
            Console.WriteLine("Animal is eating meat");
        else if (foodType == "fish")
            Console.WriteLine("Animal is eating fish");
    }
}

public class Cat : Animal
{
    public void Eat() =>
        Feed("fish");
}

public class Dog : Animal
{
    public void Eat() =>
        Feed("meat");
}

// In this example, the "Animal" class contains a "Feed" method that accepts a food type and
// prints out a message that the animal is eating.
// The "Cat" and "Dog" classes then inherit from the "Animal" class and define their own "Eat" methods
// that call the "Feed" method of the base class to feed the animal.

// However, this violates the rule that base classes should not know about their derived classes.
// To fix this, each derived class must define its own "Feed" method to implement the class-specific feeding logic.

using System;

public abstract class Animal
{
    public abstract void Eat();
}

public class Cat : Animal
{
    public override void Eat() =>
        Feed("fish");

    private void Feed(string foodType) =>
        Console.WriteLine("Cat is eating " + foodType);
}

public class Dog : Animal
{
    public override void Eat() =>
        Feed("meat");

    private void Feed(string foodType) =>
        Console.WriteLine("Dog is eating " + foodType);
}