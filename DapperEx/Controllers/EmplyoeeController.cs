namespace DapperEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplyoeeController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SqlConnection _connection;
        public EmplyoeeController(IConfiguration config)
        {
            _config = config;
            _connection = new SqlConnection(_config.GetConnectionString("Connections"));
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmployees()
        {
           var Employees = await SelectAllEmployees();
            return Ok(Employees);
        }

        private async Task<IEnumerable<EmployeeModel>> SelectAllEmployees()
        {
           return await _connection.QueryAsync<EmployeeModel>("Select * from Employee");
        }

        [HttpGet("{EmpId}")]
        public async Task<ActionResult> GetEmployee(int EmpId)
        {
            var Employee = await _connection.QueryFirstAsync("Select * from Employee where Id = @Id", new { Id = EmpId });
            return Ok(Employee);
        }

        [HttpPost]
        public async Task<ActionResult> InsertEmployee(EmployeeModel employeeModel)
        {
          //  string Query = ("Insert into Employee values(@Id, @Name, @Role)", employeeModel).ToString();
            await _connection.ExecuteAsync("Insert into Employee values(@Id, @Name, @Role)", employeeModel);
            return Ok(await SelectAllEmployees());
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEmployee(EmployeeModel employeeModel)
        {
            await _connection.ExecuteAsync("Update Employee set Id = @Id, Name = @Name, Role = @Role where Id = @Id ", employeeModel);
            // new { Id = employeeModel.Id, Name = employeeModel.Name, Role = employeeModel.Role }
            return Ok(await SelectAllEmployees());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee(int EmpID)
        {
            await _connection.ExecuteAsync("Delete from Employee where Id = @Id",new { Id = EmpID });
            return Ok(await SelectAllEmployees());
        }

    }

}
