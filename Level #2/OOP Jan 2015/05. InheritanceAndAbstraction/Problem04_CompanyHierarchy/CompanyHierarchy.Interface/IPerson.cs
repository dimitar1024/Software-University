namespace CompanyHierarchy.Interface
{
    using CompanyHierarchy.ConsoleApp;

    interface IPerson
    {

        string FirstName { get; set; }

        string LastName { get; set; }

        int ID { get; set; }
    }
}
