using SQLTreeView.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQLTreeView.Data;
using SQLTreeView.Shared.DataAccess;
using SQLTreeView.Shared.Models;

namespace SQLTreeView.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        OrganizationDataAccessLayer db = new OrganizationDataAccessLayer();

        [HttpGet]
        public object Get()
        {
            var data = db.GetAllEmployees().ToList();
            return data;
        }
    }
}
