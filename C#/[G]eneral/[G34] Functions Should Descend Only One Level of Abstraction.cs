public string Render()
{
    StringBuffer html = new StringBuffer("<hr");
    if(size > 0)
        html.Append(" size=\"").Append(size + 1).Append("\"");
    html.append(">");
    return html.ToString();
}
// A moment’s study and you can see what’s going on.
// This function constructs the HTML tag that draws a horizontal rule across the page.
// The height of that rule is specified in the size variable.

// Now look again. This method is mixing at least two levels of abstraction.
// The first is the notion that a horizontal rule has a size. The second is the syntax of the HR tag itself.
// This code comes from the HruleWidget module in FitNesse.
// This module detects a row of four or more dashes and converts it into the appropriate HR tag.
// The more dashes, the larger the size.

// I refactored this bit of code as follows. Note that I changed the name of the size field to reflect its true purpose.
// It held the number of extra dashes.

public string Render()
{
    HtmlTag hr = new HtmlTag("hr");
    
    if (extraDashes > 0)
        hr.AddAttribute("size", HrSize(extraDashes));
    
    return hr.html();
}

private string HrSize(int height)
{
    int hrSize = height + 1;
    
    return string.Format("%d", hrSize);
}
// This change separates the two levels of abstraction nicely.
// The render function simply constructs an HR tag, without having to know anything about the HTML syntax of that tag.
// The HtmlTag module takes care of all the nasty syntax issues.

// Indeed, by making this change I caught a subtle error.
// The original code did not put the closing slash on the HR tag, as the XHTML standard would have it.
// The HtmlTag module had been changed to conform to XHTML long ago.

// Separating levels of abstraction is one of the most important functions of refactoring, and it’s one of the hardest to do well.
// As an example, look at the code below. This was my first attempt at separating the abstraction levels in the HruleWidget.render method.

public string Render()
{
    HtmlTag hr = new HtmlTag("hr");
    
    if (size > 0)
        hr.AddAttribute("size", ""+(size+1));
    
    return hr.html();
}
// My goal, at this point, was to create the necessary separation and get the tests to pass
// I accomplished that goal easily, but the result was a function that still had mixed levels of abstraction.
// In this case the mixed levels were the construction of the HR tag and the interpretation and formatting of the size variable.
// This points out that when you break a function along lines of abstraction, you often uncover new lines of abstraction
// that were obscured by the previous structure.