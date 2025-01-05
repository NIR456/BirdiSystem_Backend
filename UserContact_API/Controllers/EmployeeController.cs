
using Employee_API.Services;
using Microsoft.AspNetCore.Mvc;
using Employee_API.Models;
using Microsoft.AspNetCore.Authorization;

namespace Employee_API.Controllers
{
    [ApiController]
    [Route("api_employee/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeJsonFileService _EmployeeService;
        private readonly IJwtTokenService _jwtTokenService;

        public EmployeeController(IEmployeeJsonFileService EmployeeService, IJwtTokenService jwtTokenService)
        {
            _EmployeeService = EmployeeService;
            _jwtTokenService = jwtTokenService;
        }

        [HttpGet]
        [Authorize]
        public  async Task<Response> GetEmployeeListData()
        {
            return await _EmployeeService.GetEmployeeList();
        }

        [HttpPost]
        [Authorize]
        public async Task<Response> AddOrUpdateEmployeeList([FromBody] EmployeeList newEmployee)
        {
            return await _EmployeeService.AddEmployee(newEmployee);
        }

        [HttpGet]
        [Authorize]
        public async Task<Response> RemoveEmployeeList(int Id)
        {
            return await _EmployeeService.RemoveEmployee(Id);
        }

        [HttpPost]
        public async Task<Response> Login([FromBody] LoginRequest request)
        {
            Response response = new Response();
            if (request.Username == "nirmal" && request.Password == "123")
            {
                var token = _jwtTokenService.GenerateToken(request.Username);
                response.ResponseStatus = true;
                response.ResponseObject = token;
                response.ResponseMessage = "Success";
            }
            else
            {
                response.ResponseStatus = false;
                response.ResponseMessage = "Login Failed";

            }
            return response;
            
        }
    }
}
