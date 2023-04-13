public class Animal {
    public void feed(String foodType) {
        if (foodType.equals("meat")) {
            System.out.println("Animal is eating meat");
        } else if (foodType.equals("fish")) {
            System.out.println("Animal is eating fish");
        }
    }
}

public class Cat extends Animal {
    public void eat() {
        feed("fish");
    }
}

public class Dog extends Animal {
    public void eat() {
        feed("meat");
    }
}

// In this example, the "Animal" class contains a "Feed" method that accepts a food type and
// prints out a message that the animal is eating.
// The "Cat" and "Dog" classes then inherit from the "Animal" class and define their own "Eat" methods
// that call the "Feed" method of the base class to feed the animal.

// However, this violates the rule that base classes should not know about their derived classes.
// To fix this, each derived class must define its own "Feed" method to implement the class-specific feeding logic.

public abstract class Animal {
    public abstract void eat();
}

public class Cat extends Animal {
    @Override
    public void eat() {
        feed("fish");
    }

    private void feed(String foodType) {
        System.out.println("Cat is eating " + foodType);
    }
}

public class Dog extends Animal {
    @Override
    public void eat() {
        feed("meat");
    }

    private void feed(String foodType) {
        System.out.println("Dog is eating " + foodType);
    }
}