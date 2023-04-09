// A function that translates the name of a day to an enum that represents the day.

Day day = DayDate.StringToDay(String dayName);

// We would expect the string "Monday" to be translated to Day.MONDAY.
// We would also expect the common abbreviations to be translated, and we would expect the function to ignore case.
