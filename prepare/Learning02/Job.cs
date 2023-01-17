public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _yearStart =  0;
    public int _yearEnd = 0;
    
    public void DisplayCompany()
    {
        Console.WriteLine(_company);
    }
    public void DisplayJobTitle()
    {
        Console.WriteLine(_jobTitle);
    }
    public void DisplayYearStar()
    {
        Console.WriteLine(_yearStart);
    }
    public void DisplayYearEnd()
    {
        Console.WriteLine(_yearEnd);
    }
    public void DisplayAllCompanyDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_yearStart}-{_yearEnd}");
    }
    
}