using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository _staffrepository;

        public StaffController(IStaffRepository staffRepository)
        {
            _staffrepository = staffRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var staffs = _staffrepository.GetStaff();
            return new OkObjectResult(staffs);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var staff = _staffrepository.GetStaffByID(id);
            return new OkObjectResult(staff);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Staff staff)
        {
            using (var scope = new TransactionScope())
            {
                _staffrepository.InsertStaff(staff);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = staff.Id }, staff);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Staff staff)
        {
            if (staff != null)
            {
                using (var scope = new TransactionScope())
                {
                    _staffrepository.UpdateStaff(staff);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _staffrepository.DeleteStaff(id);
            return new OkResult();
        }
    }
}
