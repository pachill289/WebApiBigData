using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DataManager
{
    public class DataManager
    {
        //Inyeccion de dependencias
        private dbContext _context;

        public DataManager(dbContext context)
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
                Ip = row.Ip,
                Genero = row.Genero,
                Profesion = row.Profesion
            }));
            return response;
        }
        public List<HechosModel> ObtenerHechos()
        {
            //Se crea una lista de modelos de tipo usuario
            List<HechosModel> response = new List<HechosModel>();
            //Se recupera a partir del dbContext todos los usuarios con la ayuda de EntityFramework 5.0
            var dataList = _context.Hechos.ToList();
            //Luego se llena la lista de usuarios
            dataList.ForEach(row => response.Add(new HechosModel()
            {
                idHecho = row.idHecho,
                Hora = row.Hora,
                colorFondo = row.colorFondo,
                colorTexto = row.colorTexto,
                Mensaje = row.Mensaje,
                Genero = row.Genero,
                Profesion = row.Profesion,
                Resultado = row.Resultado
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
            nuevaPublicacion.Genero = pubModel.Genero;
            nuevaPublicacion.Profesion = pubModel.Profesion;
            
            _context.Publicaciones.Add(nuevaPublicacion);
            _context.SaveChanges();
        }
        public void InsertarHecho(HechosModel hechoModel)
        {
            Hechos nuevoHecho = new Hechos();
            nuevoHecho.Hora = hechoModel.Hora;
            nuevoHecho.colorFondo = hechoModel.colorFondo;
            nuevoHecho.colorTexto = hechoModel.colorTexto;
            nuevoHecho.Mensaje = hechoModel.Mensaje;
            nuevoHecho.Profesion = hechoModel.Profesion;
            nuevoHecho.Genero = hechoModel.Genero;
            nuevoHecho.Resultado = hechoModel.Resultado;
            _context.Hechos.Add(nuevoHecho);
            _context.SaveChanges();
        }
    }
}
