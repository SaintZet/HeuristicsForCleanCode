public class HourlyEmployee extends Employee {
    private int tenthsWorked;
    private double hourlyRate;
    public Money calculatePay() {
        int straightTime = Math.min(tenthsWorked, TENTHS_PER_WEEK);
        int overTime = tenthsWorked - straightTime;
        return new Money(
                hourlyRate * (tenthsWorked + OVERTIME_RATE * overTime)
        );
    }
 ...
}
// Where did the constants TENTHS_PER_WEEK and OVERTIME_RATE come from? 
// They might have come from class Employee; 
// so let's take a look at that:

public abstract class Employee implements PayrollConstants {
    public abstract boolean isPayday();
    public abstract Money calculatePay();
    public abstract void deliverPay(Money pay);
}
// Nope, not there. But then where? Look closely at class Employee. It implements PayrollConstants.

public interface PayrollConstants {
    public static final int TENTHS_PER_WEEK = 400;
    public static final double OVERTIME_RATE = 1.5;
}
// This is a hideous practice! The constants are hidden at the top of the inheritance hierarchy. 
// Ick! Don't use inheritance as a way to cheat the scoping rules of the language. Use a static import instead.

import static PayrollConstants.*;
public class HourlyEmployee extends Employee {
    private int tenthsWorked;
    private double hourlyRate;
    public Money calculatePay() {
        int straightTime = Math.min(tenthsWorked, TENTHS_PER_WEEK);
        int overTime = tenthsWorked - straightTime;
        return new Money(
                hourlyRate * (tenthsWorked + OVERTIME_RATE * overTime)
        );
    }
 ...
}