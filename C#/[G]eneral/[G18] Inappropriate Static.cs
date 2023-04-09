HourlyPayCalculator.CalculatePay(employee, overtimeRate);

// This seems like a reasonable static function.
// It doesn’t operate on any particular object and gets all it’s data from it’s arguments.
// However, there is a reasonable chance that we’ll want this function to be polymorphic.
// We may wish to implement several different algorithms for calculating hourly pay, for example:
// OvertimeHourlyPayCalculator and StraightTimeHourlyPayCalculator.
// So in this case the function should not be static. It should be a nonstatic member function of Employee.
