using CapaDatos;
using CapaDatos.PublicationManager;
using CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBigData.Controllers {
    public class PublicacionController : Controller {

        private readonly PublicationManager _context;
        public PublicacionController(dbContext context) {
            _context = new PublicationManager(context);
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        [Route("ObtenerPublicaciones")]
        public IActionResult Get() {
            
            try {
                IEnumerable<Publicaciones> usuarios = _context.ObtenerPublicaciones();
                return Ok(usuarios);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        // POST api/<UsuarioController>
        [HttpPost]
        [Route("RegistrarPublicacion")]
        public IActionResult Post([FromBody] Publicaciones pubModel) {
            
            try {
                _context.InsertarPublicacion(pubModel);
                return Ok();
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
