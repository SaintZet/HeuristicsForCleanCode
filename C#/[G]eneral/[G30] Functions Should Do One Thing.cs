public void Pay() 
{
    foreach (Employee e in _employees)
    {
        if (e.isPayday()) 
        {
            Money pay = e.CalculatePay();
            e.DeliverPay(pay);
        }
    }
}

// This bit of code does three things. It loops over all the employees, checks to see whether each employee ought to be paid,
// and then pays the employee. This code would be better written as:

public void Pay() 
{
    foreach (Employee e in _employees)
        PayIfNecessary(e);
}

private void PayIfNecessary(Employee e) 
{
    if (e.IsPayday())
        CalculateAndDeliverPay(e);
}

private void CalculateAndDeliverPay(Employee e) 
{
    Money pay = e.CalculatePay();
    e.DeliverPay(pay);
}

// Each of these functions does one thing.
