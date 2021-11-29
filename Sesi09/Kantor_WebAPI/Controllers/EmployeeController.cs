using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        // GET : api/User
        [HttpGet(Name = "Get All Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            // return new string[]
            return _context.GetAllEmployee();
        }

        // Get : api/user/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }

        [HttpPost]
        public ActionResult<IEnumerable<EmployeeItem>> AddEmployeeItem(String nama, String jeniskelamin, String alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.InsertEmployee(nama, jeniskelamin, alamat);
        }

        [HttpPut]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeItem(int id, String nama, String jeniskelamin, String alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateEmployee(id, nama, jeniskelamin, alamat);
        }

        [HttpDelete]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployee(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DeleteEmployee(id);
        }
    }
}
