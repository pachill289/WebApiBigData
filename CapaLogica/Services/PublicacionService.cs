using CapaDatos.PublicationManager;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Services {
    class PublicacionService {
        //Inyección de dependencias
        private readonly PublicationManager _context;

        public PublicacionService(PublicationManager context) {
            _context = context;
        }

        public IEnumerable<Publicaciones> ObtenerUsuarios() {
            return _context.ObtenerPublicaciones();
        }
        /*
        public void RegistrarPublicacion(Usuario us) {
            _context.InsertUser(us);
        }*/
    }
}
