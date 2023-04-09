public int СalculateWeeklyPay(bool overtime) 
{
    int tenthRate = GetTenthRate();
    int tenthsWorked = GetTenthsWorked();
    int straightTime = Math.min(400, tenthsWorked);
    int overTime = Math.max(0, tenthsWorked - straightTime);
    int straightPay = straightTime * tenthRate;
    double overtimeRate = overtime ? 1.5 : 1.0 * tenthRate;
    int overtimePay = (int)Math.Round(overTime*overtimeRate);
    
    return straightPay + overtimePay;
}
// You call this function with a true if overtime is paid as time and a half, and with a false if overtime is paid as straight time. 
// It’s bad enough that you must remember what CalculateWeeklyPay(false) means whenever you happen to stumble across it. 
// But the real shame of a function like this is that the author missed the opportunity to write the following:

public int StraightPay() 
{
    return GetTenthsWorked() * GetTenthRate();
}

public int OverTimePay() 
{
    int overTimeTenths = Math.max(0, GetTenthsWorked() - 400);
    int overTimePay = overTimeBonus(overTimeTenths);
    
    return straightPay() + overTimePay;
}

private int OverTimeBonus(int overTimeTenths) 
{
    double bonus = 0.5 * GetTenthRate() * overTimeTenths;
    
    return (int) Math.Round(bonus);
}
// Of course, selectors need not be boolean. 
// They can be enums, integers, or any other type of argument that is used to select the behavior of the function. 
// In general it is better to have many functions than to pass some code into a function to select the behavior.
