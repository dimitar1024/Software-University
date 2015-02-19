namespace CompanyHierarchy.Interface
{
    using CompanyHierarchy.ConsoleApp;

    interface IManager
    {

        void AddEmployeeToTeam(Employee employee);

        void RemoveEmployeeToTeam(Employee employee);

        string PrintTeam();
    }
}
