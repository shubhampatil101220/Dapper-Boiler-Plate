using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper1.Model;
using Dapper1.Repo;
namespace Dapper1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo repo;
        public CustomerController(ICustomerRepo repo)
        {
            this.repo = repo;

        }
        private List<Customer> userList = new List<Customer>();

        [HttpGet("GetAllCustomer")]
        public IActionResult GetAll()
        {
            var _list = repo.GetAllCustomer();
            userList.AddRange(_list);
            if (_list != null)
            {
                return Ok(_list);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
