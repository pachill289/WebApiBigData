using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.PublicationManager
{
    public class PublicationManager
    {
        //Inyeccion de dependencias
        private dbContext _context;

        public PublicationManager(dbContext context)
        {
            _context = context;
        }
        
        //GET
        public List<Publicaciones> ObtenerPublicaciones() {
            //Se crea una lista de modelos de tipo usuario
            List<Publicaciones> response = new List<Publicaciones>();
            //Se recupera a partir del dbContext todos los usuarios con la ayuda de EntityFramework 5.0
            var dataList = _context.Publicaciones.ToList();
            //Luego se llena la lista de usuarios
            dataList.ForEach(row => response.Add(new Publicaciones() {
                idPublicacion = row.idPublicacion,
                Hora = row.Hora,
                colorFondo = row.colorFondo,
                colorTexto = row.colorTexto,
                Mensaje = row.Mensaje,
                Like = row.Like,
                Ip = row.Ip
            }));
            return response;
        }
        
        //POST
        public void InsertarPublicacion(Publicaciones pubModel) {
            Publicacion nuevaPublicacion = new Publicacion();
            nuevaPublicacion.Hora = pubModel.Hora;
            nuevaPublicacion.colorFondo = pubModel.colorFondo;
            nuevaPublicacion.colorTexto = pubModel.colorTexto;
            nuevaPublicacion.Mensaje = pubModel.Mensaje;
            nuevaPublicacion.Ip = pubModel.Ip;
            nuevaPublicacion.Like = pubModel.Like;
            
            _context.Publicaciones.Add(nuevaPublicacion);
            _context.SaveChanges();
        }
    }
}
