namespace CompanyHierarchy.Interface
{
    using System;
    using CompanyHierarchy.ConsoleApp;

    interface IProject
    {

        string ProjectName { get; set; }
     
        DateTime StartDate { get; set; }

        Project.State Type { get; set; }
    }
}
