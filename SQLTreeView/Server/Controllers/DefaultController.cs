using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SQLTreeView.Data;
using SQLTreeView.Shared.DataAccess;
using SQLTreeView.Shared.Models;


namespace WebApplication1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        OrganizationDataAccessLayer db = new OrganizationDataAccessLayer();
        [HttpGet]
        public object Get()
        {
            // Get the DataSource from Database
            var data = db.GetAllEmployees().ToList();
            var queryString = Request.Query;
            if (queryString.Keys.Contains("$filter"))
            {
                StringValues Skip;
                StringValues Take;
                int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : data.Count();
                string filter = string.Join("", queryString["$filter"].ToString().Split(' ').Skip(2)); // get filter from querystring
                data = data.Where(d => d.ParentId.ToString() == filter).ToList();
                return data.Skip(skip).Take(top);
            }
            else
            {
                data = data.Where(d => d.ParentId == null).ToList();
                return data;
            }
        }

        [HttpGet("{id}")]
        public object GetIndex(string id)
        {
            // Get the DataSource from Database
            var data = db.GetAllEmployees().ToList();
            int index;
            var count = data.Count;
            if (count > 0)
            {
                index = (data[data.Count - 1].Id);
            }
            else
            {
                index = 0;
            }
            return index;
        }
        [HttpPost]
        public void Post([FromBody]OrganizationDetails employee)
        {
            db.AddEmployee(employee);
        }
        [HttpPut]
        public object Put([FromBody]OrganizationDetails employee)
        {
            db.UpdateEmployee(employee);
            return employee;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.DeleteEmployee(id);
        }
    }
}
