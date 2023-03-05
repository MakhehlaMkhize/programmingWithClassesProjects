using System;
class Resume
{
    public string _nameOfPerson = "";
    public List<Job>_jobsList = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_nameOfPerson}\nJobs:");
        foreach(Job myJobs in _jobsList)
        {
            myJobs.DisplayJobDetails();
        } 
    }
}