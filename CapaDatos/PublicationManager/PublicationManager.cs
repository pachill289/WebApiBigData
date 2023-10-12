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
    }
}
