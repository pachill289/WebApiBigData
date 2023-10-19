using CapaDatos;
using CapaDatos.DataManager;
using CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBigData.Controllers {
    public class PublicacionController : Controller {

        private readonly DataManager _context;
        public PublicacionController(dbContext context) {
            _context = new DataManager(context);
        }

        // GET
        [HttpGet]
        [Route("ObtenerPublicaciones")]
        public IActionResult GetPublicaciones() {
            
            try {
                IEnumerable<Publicaciones> publicaciones = _context.ObtenerPublicaciones();
                return Ok(publicaciones);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("ObtenerHechos")]
        public IActionResult GetHechos()
        {

            try
            {
                IEnumerable<HechosModel> hechos = _context.ObtenerHechos();
                return Ok(hechos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // POST
        [HttpPost]
        [Route("RegistrarPublicacion")]
        public IActionResult Post([FromBody] Publicaciones pubModel)
        {

            try
            {
                _context.InsertarPublicacion(pubModel);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("RegistrarHecho")]
        public IActionResult Post([FromBody] HechosModel hechoModel) {
            
            try {
                _context.InsertarHecho(hechoModel);
                return Ok();
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
