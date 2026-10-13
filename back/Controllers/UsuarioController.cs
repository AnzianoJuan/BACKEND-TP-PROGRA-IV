using back.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using back.Services;
using back.DTOs;

namespace back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuariosServices _service;
        public UsuarioController(UsuariosServices service)
        {
            _service = service;
        }

        [HttpPost("/pacientes")]
        [ProducesResponseType(typeof(Respuesta), StatusCodes.Status201Created)]
        public ActionResult<Respuesta> CrearPaciente([FromBody] CrearPacienteDTO crearDto)
        {
            var paciente = _service.CrearUnPaciente(crearDto);
            if (paciente == null)
            {
                return;//error que no pudo crear correctamente
            }
            Respuesta res = new Respuesta("Se creo correctamente!")
            {
                Datos = paciente,
            };

            return Created("api/Usuario/pacientes", res);
        }


        [HttpPost("/doctores")]
        [ProducesResponseType(typeof(Respuesta), StatusCodes.Status201Created)]
        public ActionResult<Respuesta> CrearPaciente([FromBody] CrearDoctorDTO crearDto)
        {
            var doctor = _service.CrearUnDoctor(crearDto);
            if (doctor == null)
            {
                return;//error que no pudo crear correctamente
            }
            Respuesta res = new Respuesta("Se creo correctamente!")
            {
                Datos = doctor,
            };

            return Created("api/Usuario/doctores", res);
        }


    }
}
