public class HourlyEmployee : Employee
{
    private int _tenthsWorked;
    HourlyPayGrade _grade;

    public Money CalculatePay()
    {
        int straightTime = Math.Min(_tenthsWorked, PayrollConstants.TENTHS_PER_WEEK);
        int overTime = _tenthsWorked - straightTime;
        return new Money(_grade.Rate() * (_tenthsWorked + PayrollConstants.OVERTIME_RATE * overTime));
    }
}

public enum HourlyPayGrade
{
    APPRENTICE,
    LEUTENANT_JOURNEYMAN,
    JOURNEYMAN,
    MASTER
}

public static class HourlyPayGradeExtensions
{
    public static double Rate(this HourlyPayGrade grade)
    {
        switch (grade)
        {
            case HourlyPayGrade.APPRENTICE:
                return 1.0;
            case HourlyPayGrade.LEUTENANT_JOURNEYMAN:
                return 1.2;
            case HourlyPayGrade.JOURNEYMAN:
                return 1.5;
            case HourlyPayGrade.MASTER:
                return 2.0;
            default:
                throw new ArgumentException("Invalid hourly pay grade");
        }
    }
}
