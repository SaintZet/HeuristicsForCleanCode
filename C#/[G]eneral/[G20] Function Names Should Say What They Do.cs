Date newDate = date.Add(5);

// Would you expect this to add five days to the date? Or is it weeks, or hours?
// Is the date instance changed or does the function just return a new Date without changing the old one?
// You can’t tell from the call what the function does.

// If the function adds five days to the date and changes the date, then it should be called addDaysTo or increaseByDays.
// If, on the other hand, the function returns a new date that is five days later but does not change the date instance,
// it should be called daysLater or daysSince.
