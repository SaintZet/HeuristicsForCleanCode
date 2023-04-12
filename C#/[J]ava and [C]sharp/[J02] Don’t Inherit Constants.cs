public class HourlyEmployee : Employee
{
    private int _tenthsWorked;
    private double _hourlyRate;

    public Money CalculatePay()
    {
        int straightTime = Math.min(_tenthsWorked, TENTHS_PER_WEEK);
        int overTime = _tenthsWorked - straightTime;

        return new Money(_hourlyRate * (tenthsWorked + OVERTIME_RATE * overTime));
    }
    ...
}
// Where did the constants TENTHS_PER_WEEK and OVERTIME_RATE come from?
// They might have come from class Employee;
// so let's take a look at that:

public class Employee : PayrollConstants
{
    public bool IsPayday();
    public Money CalculatePay();
    public void DeliverPay(Money pay);
}
// Nope, not there. But then where? Look closely at class Employee. It implements PayrollConstants.

public class PayrollConstants
{
    public static int TENTHS_PER_WEEK = 400;
    public static double OVERTIME_RATE = 1.5;
}
// This is a hideous practice! The constants are hidden at the top of the inheritance hierarchy.
// Ick! Don't use inheritance as a way to cheat the scoping rules of the language. Use a static using instead.

public class HourlyEmployee : Employee
{
    private int _tenthsWorked;
    private double _hourlyRate;

    public Money CalculatePay()
    {
        int straightTime = Math.min(_tenthsWorked, PayrollConstants.TENTHS_PER_WEEK);
        int overTime = _tenthsWorked - straightTime;
        return new Money(_hourlyRate * (_tenthsWorked + OVERTIME_RATE * overTime));
    }
    ...
}