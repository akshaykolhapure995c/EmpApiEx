using EmployeeApiEx.Models;
using EmployeeApiEx.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sql;

namespace EmployeeApiEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpAPIController : ControllerBase
    {
        IEmployeeInfo erepo;
        public EmpAPIController(IEmployeeInfo etemp)
        {
            this.erepo = etemp;
        }

        [HttpGet]
        public IEnumerable<EmployeeInfo> GetAllEmployee()
        {
            var r = this.erepo.GetAllEmployee();
            return r.ToList();
        }

        [HttpPost]
        public IActionResult PostEmployee([FromBody] EmployeeInfo rec)
        {
            //var entities = this.erepo;
            //EmployeeInfo emp = null;
            //foreach (var item in rec)
            //{
            //    emp = this.erepo.GetAllEmployee().Where(p => p.EmployeeFName == item.EmployeeFName).FirstOrDefault();
            //    if (emp == null)
            //    {
            //        entities.AddEmployee(item);

            //    }
            //}
            //if (emp == null)
            //    return BadRequest(string.Empty);
            //if (ModelState.IsValid)
            //{
            //    entities.AddEmployee(emp);
            //    return Ok("Record Saved Suceessfully.");
            //}

            //return BadRequest(ModelState);


            if (rec == null)
                return BadRequest();
            if (ModelState.IsValid)
            {
                this.erepo.AddEmployee(rec);
                return Ok("Saved");
            }
            return BadRequest(ModelState);

        }

        [HttpGet]
        [Route("{EID}")]
        public IActionResult GetEmployeeByID(int EID)
        {
            var rec = this.erepo.GetEmployee(EID);
            if (rec == null)
                return NotFound();
            return Ok(rec);
        }

        [HttpPut]
        public IActionResult PutEmployee([FromBody] EmployeeInfo rec)
        {
            if (rec == null)
                return BadRequest();
            if (ModelState.IsValid)
            {
                this.erepo.EditEmployee(rec);
                return Ok("Updated!");
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEmployee(Int64 id)
        {
            if (id <= 0)
                return BadRequest();
            this.erepo.Delete(id);
            return Ok("Deleted!");
        }

    }

}