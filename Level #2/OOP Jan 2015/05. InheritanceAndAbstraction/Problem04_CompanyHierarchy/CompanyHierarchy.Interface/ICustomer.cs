namespace CompanyHierarchy.Interface
{
    using CompanyHierarchy.ConsoleApp;

    interface ICustomer
    {
        void AddSale(Sale sale);
        void RemoveSale(Sale sale);
        void TotalPrice();
    }
}
