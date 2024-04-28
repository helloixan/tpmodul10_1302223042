using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_1302223042.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : Controller
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Iksan Oktav Risandy", "1302223042"),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127"),
            new Mahasiswa("Muhammad Dias Adani", "1302223134"),
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007"),
            new Mahasiswa("Muhammad Nur Shodiq", "1302223054")
        };

        // GET: /<controller>/
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}