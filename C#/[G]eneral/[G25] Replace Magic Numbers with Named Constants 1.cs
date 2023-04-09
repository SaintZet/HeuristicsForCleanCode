double milesWalked = feetWalked/5280.0;
int dailyPay = hourlyRate * 8;
double circumference = radius * Math.PI * 2;

// Do we really need the constants FEET_PER_MILE, WORK_HOURS_PER_DAY, and TWO in the above examples?
// Clearly, the last case is absurd. There are some formulae in which constants are simply better written as raw numbers.
// You might quibble about the WORK_HOURS_PER_DAY case because the laws or conventions might change.
// On the other hand, that formula reads so nicely with the 8 in it that
// I would be reluctant to add 17 extra characters to the readers’ burden.
// And in the FEET_PER_MILE case, the number 5280 is so very well known and so unique a constant
// that readers would recognize it even if it stood alone on a page with no context surrounding it.

// Constants like 3.141592653589793 are also very well known and easily recognizable.
// However, the chance for error is too great to leave them raw.
// Every time someone sees 3.1415927535890793, they know that it is p, and so they fail to scrutinize it.
// We also don’t want people using 3.14, 3.14159, 3.142, and so forth.
// Therefore, it is a good thing that Math.PI has already been defined for us.
