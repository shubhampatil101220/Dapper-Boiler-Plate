using Dapper;
using Dapper1.Model;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Dapper1.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly string conn;

        public CustomerRepo(string conn)
        {
            this.conn = conn;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            string query = "SELECT * FROM PrimaryData";
            using (var connection = new SqlConnection(conn))
            {
                var res = connection.Query<Customer>(query);
                return res;
            }
        }
    }
}
