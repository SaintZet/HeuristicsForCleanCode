AppendFooter(s);

// Does this function append s as the footer to something?
//  Or does it append some footer to s? Is s an input or an output?
//  It doesn’t take long to look at the function signature and see:
public void AppendFooter(StringBuffer report)

// This clarifies the issue, but only at the expense of checking the declaration of the function.
// Anything that forces you to check the function signature is equivalent to a double-take.
// It’s a cognitive break and should be avoided

// It would be better for appendFooter to be invoked as:
report.AppendFooter();