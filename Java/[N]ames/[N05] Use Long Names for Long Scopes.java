// Consider this snippet from the old standard "Bowling Game":

private void rollMany(int n, int pins)
{
    for (int i=0; i<n; i++)
        g.roll(pins);
}
// This is perfectly clear and would be obfuscated if the variable i were replaced with something annoying like rollCount. 
// On the other hand, variables and functions with short names lose their meaning over long distances. 
// So the longer the scope of the name, the longer and more precise the name should be.