using CapaDatos.DataManager;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Services {
    class DataService {
        //Inyección de dependencias
        private readonly DataManager _context;

        public DataService(DataManager context) {
            _context = context;
        }

        public IEnumerable<Publicaciones> ObtenerPublicaciones() {
            return _context.ObtenerPublicaciones();
        }
        
        public void RegistrarPublicacion(Publicaciones pub) {
            _context.InsertarPublicacion(pub);
        }
    }
}
