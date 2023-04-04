// Here is the overTimePay function as it might have appeared:
public int m_otCalc(int iThsWkd, int iThsRte) 
{
    return iThsWkd * iThsRte +
           (int)Math.Round(0.5 * iThsRte * Math.Max(0, iThsWkd - 400);
}
// Small and dense as this might appear, it’s also virtually impenetrable.
