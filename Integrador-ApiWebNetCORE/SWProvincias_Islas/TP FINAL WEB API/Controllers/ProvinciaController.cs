using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using TP_FINAL_WEB_API.Data;
using TP_FINAL_WEB_API.Models;

namespace TP_FINAL_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private readonly DBPaisFinalContext context;

        public ProvinciaController(DBPaisFinalContext context)
        {

            this.context = context;

        }

        //GET api/provincia
        [HttpGet]
        public ActionResult<IEnumerable<Provincia>> Get()
        {
            return context.Provincias.ToList();
        }

        //POST api/provincia
        [HttpPost]
        public ActionResult Post(Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Provincias.Add(provincia);
            context.SaveChanges();
            return Ok();
        }

        // PUT api/provincia/2
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provincia provincia)
        {
            if (id != provincia.IdProvincia)
            {
                return BadRequest();
            }

            context.Entry(provincia).State = EntityState.Modified;
            context.SaveChanges();

            return NoContent();

        }

        //DELETE api/provincia/2
        [HttpDelete("{id}")]
        public ActionResult<Provincia> Delete(Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Provincias.Remove(provincia);
            context.SaveChanges();

            return provincia;
        }
    }
}
