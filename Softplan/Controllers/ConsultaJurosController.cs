using Microsoft.AspNetCore.Mvc;
using Softplan.Services.JurosService;
using System;

namespace Softplan.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsultaJurosController : ControllerBase
    {
        private readonly IJurosService JurosService;
        public ConsultaJurosController(IJurosService jurosService)
        {
            JurosService = jurosService;
        }

        [HttpGet("taxaJuros")]
        public IActionResult GetJuros()
        {
            try
            { 
                return Ok(JurosService.GetJuros());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
