namespace CompanyHierarchy.Interface
{
    using CompanyHierarchy.ConsoleApp;

    interface IEmployee
    {
        decimal Salary { get; set; }
        Employee.Department Departament { get; set; }
    }
}
