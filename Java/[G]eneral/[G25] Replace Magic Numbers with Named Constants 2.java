assertEquals(7777, Employee.find(“John Doe”).employeeNumber());

// There are two magic numbers in this assertion. The first is obviously 7777, though what it might mean is not obvious.
// The second magic number is "John Doe" and again the intent is not clear.

// It turns out that "John Doe" is the name of employee #7777 in a well-known test database created by our team.
// Everyone in the team knows that when you connect to this database,
// it will have several employees already cooked into it with well-known values and attributes.
// It also turns out that "John Doe" represents the sole hourly employee in that test database. So this test should really read:

assertEquals(
    HOURLY_EMPLOYEE_ID,
    Employee.find(HOURLY_EMPLOYEE_NAME).employeeNumber());
