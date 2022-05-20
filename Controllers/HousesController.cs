using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMSProject.Data;
using HRMSProject.Models;
using MicroserviceProjects.Service;

namespace HRMSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        // GET: api/<HouseController>
        [HttpGet]
        public IEnumerable<House> Get()
        {
            Services s = new Services();
            return s.GetHouses();
        }

        // GET api/<HouseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HouseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HouseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
