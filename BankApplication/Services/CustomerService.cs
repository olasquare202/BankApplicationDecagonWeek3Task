using BankApplication.DataBase;
using BankApplication.Models;

namespace BankApplication.Services
{
    public class CustomerService : ICustomerService
    {

        private IRepository? _repository;

        public IRepository repository
        {
            get => _repository ??= new Repository();
        }
        //Create new account
        public bool Registeration(Customer? customer)
        {
            Customer? exisitingCustomer = repository.GetCustomerByEmail(customer.Email);
            if (exisitingCustomer == null)
            {
                return repository.CreateCustomer(customer);
            }
            return false;
        }
        //Login to existing account
        public Customer? Login(string email, string password)
        {
            Customer? customer = repository.GetCustomerByEmail(email);
            if(customer != null)
            {
                if(customer.Password == password)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer? GetCustomerById(int id)
        {
            return repository.GetCustomerById(id);
        }
        //public static AccountBalance
    }
}
