public class HourlyPayCalculator
{
    public Money CalculateWeeklyPay(HourlyEmployee e)
    {
        int tenthRate = e.GetTenthRate().GetPennies();
        int tenthsWorked = e.GetTenthsWorked();
        int straightTime = Math.Min(400, tenthsWorked);
        int overTime = Math.Max(0, tenthsWorked - straightTime);
        int straightPay = straightTime * tenthRate;
        int overtimePay = (int)Math.Round(overTime * tenthRate * 1.5);
        return new Money(straightPay + overtimePay);
    }
}

// The CalculateWeeklyPay method reaches into the HourlyEmployee object to get the data on which it operates. 
// The CalculateWeeklyPay method envies the scope of HourlyEmployee. It “wishes” that it could be inside HourlyEmployee.

// All else being equal, we want to eliminate Feature Envy because it exposes the internals of one class to another. 
// Sometimes, however, Feature Envy is a necessary evil. Consider the following:

public class HourlyEmployeeReport
{
    private HourlyEmployee employee;

    public HourlyEmployeeReport(HourlyEmployee e)
    {
        this.employee = e;
    }

    public string ReportHours()
    {
        return string.Format(
            "Name: {0}\tHours: {1}.{2}\n",
            employee.GetName(),
            employee.GetTenthsWorked() / 10,
            employee.GetTenthsWorked() % 10);
    }
}
// Clearly, the ReportHours method envies the HourlyEmployee class. 
// On the other hand, we don’t want HourlyEmployee to have to know about the format of the report. 
// Moving that format string into the HourlyEmployee class would violate several principles of object oriented design. 
// It would couple HourlyEmployee to the format of the report, exposing it to changes in that format.
