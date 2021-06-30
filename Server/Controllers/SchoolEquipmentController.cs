using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WAPizza.Server.Models;
using WAPizza.Shared.Models;


namespace WAPizza.Server.Controllers
    
{
    //Controlador de utiles
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolEquipmentController : ControllerBase
    {
        private SchoolEquipmentDBContext _context;

        public SchoolEquipmentController(SchoolEquipmentDBContext context)
        {
            _context = context;
        }

        // GET api/< SchoolEquipmentController>

        [HttpGet]
        public object Get()
        {
            return new { Items = _context.SchoolEquipment, Count = _context.SchoolEquipment.Count() };
        }

        // POST api/< SchoolEquipmentController>

        [HttpPost]
        public void Post([FromBody] SchoolEquipment schoolEquipment)
        {
            _context.SchoolEquipment.Add(schoolEquipment);
            _context.SaveChanges();
        }

        // PUT api/< SchoolEquipmentController>

        [HttpPut]
        public void Put(long id, [FromBody] SchoolEquipment schoolEquipment)
        {
            SchoolEquipment _schoolEquipment = _context.SchoolEquipment.Where(x => x.Id.Equals(schoolEquipment.Id)).FirstOrDefault();
            _schoolEquipment.Nombre = schoolEquipment.Nombre;
            _schoolEquipment.Cantidad = schoolEquipment.Cantidad;
            _schoolEquipment.Precio = schoolEquipment.Precio;
            _schoolEquipment.Estado = schoolEquipment.Estado;
            _schoolEquipment.Trabajador = schoolEquipment.Trabajador;
            _context.SaveChanges();
        }

        // DELETE api/< SchoolEquipmentController>

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            SchoolEquipment _schoolEquipment = _context.SchoolEquipment.Where(x => x.Id.Equals(id)).FirstOrDefault();
            _context.SchoolEquipment.Remove(_schoolEquipment);
            _context.SaveChanges();
        }


    }
}
