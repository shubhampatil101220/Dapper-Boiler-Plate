using Dapper1.Model;

namespace Dapper1.Repo
{
    public interface ICustomerRepo
    {
        public IEnumerable<Customer> GetAllCustomer();
    }
}
