if (x > 0) {
    System.out.println("The number is positive");
} else {
    System.out.println("The number is negative");
}

...

if (y > 0) {
    System.out.println("The number is positive");
} else {
    System.out.println("The number is negative");
}

// In this example, the code for checking the sign of a number is duplicated twice.
// This code can be improved by combining it into a single method and calling it at the right places in the program.
// Here is an example of improved code:

checkNumberSign(x);
...
checkNumberSign(y);

private static void checkNumberSign(int number) {
    if (number > 0) {
        System.out.println("The number is positive");
    } else {
        System.out.println("The number is negative");
    }
}