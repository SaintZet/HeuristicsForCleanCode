public void pay() {
    for (Employee e : employees) {
        if (e.isPayday()) {
            Money pay = e.calculatePay();
            e.deliverPay(pay);
        }
    }
}

// This bit of code does three things. It loops over all the employees, checks to see whether each employee ought to be paid,
// and then pays the employee. This code would be better written as:

public void pay() {
    for (Employee e : employees)
    payIfNecessary(e);
}
private void payIfNecessary(Employee e) {
    if (e.isPayday())
        calculateAndDeliverPay(e);
}
private void calculateAndDeliverPay(Employee e) {
    Money pay = e.calculatePay();
    e.deliverPay(pay);
}

// Each of these functions does one thing.
