using BankApplication.Models;

namespace BankApplication.Services
{
    public interface ICustomerService
    {
        bool Registeration(Customer? customer);
        Customer? Login(string email, string password);
        Customer? GetCustomerById(int id);

    }
}