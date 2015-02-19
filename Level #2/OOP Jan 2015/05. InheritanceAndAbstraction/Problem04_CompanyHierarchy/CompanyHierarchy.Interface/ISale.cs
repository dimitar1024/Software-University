namespace CompanyHierarchy.Interface
{
    using System;
    using CompanyHierarchy.ConsoleApp;
    
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }

    }
}
