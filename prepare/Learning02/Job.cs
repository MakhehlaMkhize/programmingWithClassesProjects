public class Job
{
    public string _companyName= "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    public Job()
    {
    }
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_companyName} ({_jobTitle}) {_startYear}-{_endYear}");
    }

    

}