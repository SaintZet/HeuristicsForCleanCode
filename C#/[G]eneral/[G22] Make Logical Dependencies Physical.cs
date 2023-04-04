// Imagine that you are writing a function that prints a plain text report of hours worked by employees.
// One class named HourlyReporter gathers all the data into a convenient form and then passes it to HourlyReportFormatter to print it.
public class HourlyReporter 
{
    private const int PAGE_SIZE = 55;
    private HourlyReportFormatter _formatter;
    private List<LineItem> _page;
    
    public HourlyReporter(HourlyReportFormatter formatter) 
    {
        _formatter = formatter;
        _page = new List<LineItem>();
    }
    
    public void generateReport(List<HourlyEmployee> employees) 
    {
        foreach (HourlyEmployee e in employees)
        {
            AddLineItemToPage(e);
            
            if (_page.Count() == PAGE_SIZE)
                PrintAndClearItemList();
        }
        
        if (_page.Count() > 0)
            printAndClearItemList();
    }
    
    private void PrintAndClearItemList() 
    {
        _formatter.Format(_page);
        _page.Clear();
    }
    
    private void AddLineItemToPage(HourlyEmployee e) 
    {
        LineItem item = new LineItem();
        item.Name = e.GetName();
        item.Hours = e.GetTenthsWorked() / 10;
        item.Tenths = e.GetTenthsWorked() % 10;
        _page.Add(item);
    }
    public class LineItem 
    {
        public string Name;
        public int Hours;
        public int Tenths;
    }
}

// This code has a logical dependency that has not been physicalized.
// It is the constant PAGE_SIZE. Why should the HourlyReporter know the size of the page?
// Page size should be the responsibility of the HourlyReportFormatter.

// The fact that PAGE_SIZE is declared in HourlyReporter represents a misplaced responsibility [G17]
// that causes HourlyReporter to assume that it knows what the page size ought to be.
// Such an assumption is a logical dependency. HourlyReporter depends on the fact that HourlyReportFormatter can deal with page sizes of 55.
// If some implementation of HourlyReportFormatter could not deal with such sizes, then there would be an error.

// We can physicalize this dependency by creating a new method in HourlyReportFormatter named GetMaxPageSize().
// HourlyReporter will then call that function rather than using the PAGE_SIZE constant.