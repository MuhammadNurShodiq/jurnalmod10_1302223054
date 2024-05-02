using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jurnalmodul10_1302223054.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // GET: api/<MahasiswaController>
        public static List<string> Matkul = new List<string>
        {
            "Basis Data",
            "Dasar Jaringan Komputer",
            "Konstruksi Perangkat Lunak",
            "Pemrogramman Berbasis Objek",
            "Pengalaman Pengguna",
            "Praktikum Basis Data",
            "Praktikum Konstruksi Perangkat Lunak",
            "Praktikum Pemrogramman Berbasis Objek"
        };
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Nur Shodiq", "1302223054", Matkul, 2022),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127", Matkul, 2022),
            new Mahasiswa("Iksan Oktav Risandy", "1302223042", Matkul, 2022),
            new Mahasiswa("Muhammad Dias Adani", "1302223134", Matkul, 2022),
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007", Matkul, 2022),
        };
        [HttpGet]
        public IEnumerable<Mahasiswa> GetMahasiswa()
        {
            return dataMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {

            return dataMahasiswa[id++];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
