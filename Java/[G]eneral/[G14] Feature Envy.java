public class HourlyPayCalculator {
    public Money calculateWeeklyPay(HourlyEmployee e) {
        int tenthRate = e.getTenthRate().getPennies();
        int tenthsWorked = e.getTenthsWorked();
        int straightTime = Math.min(400, tenthsWorked);
        int overTime = Math.max(0, tenthsWorked - straightTime);
        int straightPay = straightTime * tenthRate;
        int overtimePay = (int)Math.round(overTime*tenthRate*1.5);
        return new Money(straightPay + overtimePay);
    }
}
// The calculateWeeklyPay method reaches into the HourlyEmployee object to get the data on which it operates. 
// The calculateWeeklyPay method envies the scope of HourlyEmployee. It “wishes” that it could be inside HourlyEmployee.

// All else being equal, we want to eliminate Feature Envy because it exposes the internals of one class to another. 
// Sometimes, however, Feature Envy is a necessary evil.Consider the following:

public class HourlyEmployeeReport {
    private HourlyEmployee employee ;
    public HourlyEmployeeReport(HourlyEmployee e) {
        this.employee = e;
    }
    String reportHours() {
        return String.format(
                "Name: %s\tHours:%d.%1d\n",
                employee.getName(),
                employee.getTenthsWorked()/10,
                employee.getTenthsWorked()%10);
    }
}
// Clearly, the reportHours method envies the HourlyEmployee class. 
// On the other hand, we don’t want HourlyEmployee to have to know about the format of the report. 
// Moving that format string into the HourlyEmployee class would violate several principles of object oriented design. 
// It would couple HourlyEmployee to the format of the report, exposing it to changes in that format.