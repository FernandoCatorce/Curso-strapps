using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models = Empleado.WebApi.Models;
using Microsoft.AspNetCore.Cors;

namespace Empleado.WebApi.Controllers
{
    [EnableCors("Policy1")]
    [ApiController]
    [Route("[controller]")]
    public class EmpleadosController : ControllerBase
    {

        public static List<Models.Empleado> listaEmpleados = new List<Models.Empleado>()
        {
            new Models.Empleado()
            {
                IdEmpleado = 1,
                Nombre = "JUANITO",
                ApellidoPaterno = "PEREZ",
                ApellidoMaterno = "PEREZ",
                Sexo ='M',
            },

            new Models.Empleado()
            {
                   IdEmpleado = 2,
                Nombre = "MARIA",
                ApellidoPaterno = "HERNANDEZ",
                ApellidoMaterno = "HERNANDEZ",
                Sexo ='M',
            }
        };



        private readonly ILogger<EmpleadosController> _logger;

        public EmpleadosController(ILogger<EmpleadosController> logger)
        {
            _logger = logger;


        }
        [HttpGet]

        public List<Models.Empleado> Obtener()

        {
            List<Models.Empleado> listaEmpleadoActivos = new List<Models.Empleado>();
            List<Models.Empleado> list = listaEmpleados; 
            foreach(var empleado in list )
            {
                if(empleado.Activo == true )
                {
                    listaEmpleadoActivos.Add(empleado);
                }
            }

            return listaEmpleadoActivos;
        }
        [HttpPost]
        public Models.Empleado Crear(Models.Empleado empleado)
        {
            Models.Empleado ultimoEmpleado = listaEmpleados.Last();
            empleado.IdEmpleado = ultimoEmpleado.IdEmpleado + 1;
            listaEmpleados.Add(empleado);
            return empleado;
        }
        [HttpPut]
        public async Task<ActionResult<Models.Empleado>> actualizar(Models.Empleado empleado)
        {
            Models.Empleado empleadoModificar = null;

            List<Models.Empleado> listaEmp = listaEmpleados;

            foreach (Models.Empleado iEpleado in listaEmp)
            {
                if (iEpleado.IdEmpleado == empleado.IdEmpleado)
                {
                    empleadoModificar = iEpleado;
                    break;
                }
            }
            if (empleadoModificar == null)
            {
                return NotFound();
            }
            else
            {
                empleadoModificar.Nombre = empleado.Nombre;
                empleadoModificar.ApellidoPaterno = empleado.ApellidoPaterno;
                empleadoModificar.ApellidoMaterno = empleado.ApellidoMaterno;
            }
            return empleadoModificar;
        }

        [HttpGet("{IdEmpleado}")]
        public async Task<ActionResult<Models.Empleado>> ObtenerPorIdEmpleado(int IdEmpleado)
        {
            Models.Empleado empleadoEncontrado = null;

            List<Models.Empleado> lista = listaEmpleados;

            foreach (Models.Empleado iEmpleado in lista)
            {
                if (iEmpleado.IdEmpleado == IdEmpleado)
                {
                    empleadoEncontrado = iEmpleado;
                }
            }
            if (empleadoEncontrado == null)
            {
                return NotFound();
            }
            else
            {
                return empleadoEncontrado;
            }
        }

        [HttpDelete("{IdEmpleado}")]
        public async Task<ActionResult<Models.Empleado>> Eliminar(int IdEmpleado)
        {
            Models.Empleado empleadoEliminar = null;
            var list = listaEmpleados;

            foreach (var empleado in list)
            {
                if (empleado.IdEmpleado == IdEmpleado)
                {
                    empleadoEliminar = empleado;
                    break;
                }
            }

            if (empleadoEliminar == null)
            {
                return NotFound();
            }

            if (empleadoEliminar != null)
            {
                empleadoEliminar.Activo = false;
            }
            return empleadoEliminar;
        }
    }
}