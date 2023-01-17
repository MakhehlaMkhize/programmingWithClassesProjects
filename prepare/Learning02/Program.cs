using System;

class Program
{
    static void Main(string[] args)
    {
       Job company1 = new Job();
       company1._company = "Microsoft";
       company1._jobTitle = "Software Engineer";
       company1._yearStart = 2019;
       company1._yearEnd = 2022;
    //    company1.DisplayAllCompanyDetails();

       Job company2 = new Job();
       company2._company = "Apple";
       company2._jobTitle = "Manager";
       company2._yearStart = 2022;
       company2._yearEnd = 2023;
    //    company2.DisplayAllCompanyDetails();
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";

        resume1._jobs.Add(company1);
        resume1._jobs.Add(company2);

        resume1.Display();
    }
}