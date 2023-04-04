// Here is the overTimePay function as it might have appeared:
public int m_otCalc() {
    return iThsWkd * iThsRte +
            (int) Math.round(0.5 * iThsRte *
                    Math.max(0, iThsWkd - 400)
            );
}
// Small and dense as this might appear, it’s also virtually impenetrable.