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
        //Algoritmo
        [HttpGet]
        [Route("ObtenerResultadoAlgoritmo")]
        public IActionResult GetAlgoritmo(double Ls, double Li, double Vc) {
            try {
                //Valor medio
                double Vm = Ls - Li / 2;
                double Pv = 0,Ti = 0,Ts = 0;
                if (Vm > Vc)
                {
                    Pv = Vm - (Vc - Li) / Vm;
                    //Convertir Pv a porcentaje
                    //Primero se halla el tope que representa el valor total de la medición
                    double tope = Ls - Li;
                    //Convertir a porcentaje
                    Pv = Pv / tope * 100;
                    Ti = Li + Pv; 
                    Ts = Ls - Pv;
                }
                else if(Vm < Vc) //No se usa else porque !(Vm > Vc) = Vm <= Vc y no Vm < Vc
                {
                    Pv = (Vc - (Li + Vm)) / Vm;
                    //Convertir Pv a porcentaje
                    //Primero se halla el tope que representa el valor total de la medición
                    double tope = Ls - Li;
                    //Convertir a porcentaje
                    Pv = Pv / tope * 100;
                    Ts = Ls + Pv; 
                    Ti = Li - Pv;
                }
                int sumaI = 0,sumaS = 0;
                bool EsCuantico = false;
                //Integral (opcional)
                if(Li < Ti)
                {
                    //Integral definida desde Li hasta Ti
                    for(int i = (int)Li; i<=Ti; i++)
                    {
                        sumaI++;
                    }
                }
                if(Ls > Ts)
                {
                    //Integral definida desde Ls hasta Ts
                    for (int i = (int)Ls; i <= Ts; i++)
                    {
                        sumaS++;
                    }
                }
                //Generación de epsilon
                List<int> signo = new() { 1, -1 };
                Random rdnNumero = new Random();
                int rdnEpsilon = rdnNumero.Next((int)Li, (int)Ls);
                //Aplicación del algoritmo para ver si sale un resultado cuántico
                EsCuantico = (Li < Ti && Ls > Ts && Vc > (0xFFFFFF / 2) + signo[rdnNumero.Next(0, 2)] * rdnEpsilon) ? true : false;
                return Ok($" Li = {Li}, Ti = {Ti} y es cuántico = {EsCuantico},Ts = {Ts},Ls = {Ls},Hexadecimal = {((0xFFFFFF / 2) + signo[rdnNumero.Next(0, 2)] * rdnEpsilon)} epsilon = {signo[rdnNumero.Next(0, 2)] * rdnEpsilon}");
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
