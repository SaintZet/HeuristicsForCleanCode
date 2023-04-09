// Consider this snippet from the old standard "Bowling Game":

private void RollMany(int n, int pins)
{
    for (int i=0; i<n; i++)
        _g.Roll(pins);
}
// This is perfectly clear and would be obfuscated if the variable i were replaced with something annoying like RollCount.
// On the other hand, variables and functions with short names lose their meaning over long distances.
// So the longer the scope of the name, the longer and more precise the name should be.