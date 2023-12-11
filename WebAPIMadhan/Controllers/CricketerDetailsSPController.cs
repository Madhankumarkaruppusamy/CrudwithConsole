using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIMadhan.Controllers
   
{
    [Route("api/[controller]")]
    [ApiController]
    public class CricketerDetailsSPController : ControllerBase
    {
        private readonly ICricketer _obje = null;


        public CricketerDetailsSPController()
    {
        _obje = new CricketerRepos();
    }
    // GET: api/<ValuesController>
    [HttpGet]
        public List<Cricketer> Get()
        {
            return _obje.ReadSP();
        }

        /*// GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Cricketer value)
        {
            _obje.InsertSP(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cricketer value)
        {
            _obje.UpdateSP(id,value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _obje.DeleteSP(id);
        }
    }
}
