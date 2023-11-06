using System;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using mini.Repositories;
using mini.Shared.Models;

namespace mini.Server.Controllers
{
    [Route("api/shelter")]
    [ApiController]
    public class ShelterController : ControllerBase
    {

        public readonly IShelter _shelterRepository;

        public ShelterController(IShelter shelterRepository)
        {
            _shelterRepository = shelterRepository;
        }

        // GET: api/Shelter
        [HttpGet]
        public List<Shelter> getShelters()
        {
            return _shelterRepository.GetShelters();
        }


        // GET: api/Shelter/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shelter
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Shelter/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Shelter/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}