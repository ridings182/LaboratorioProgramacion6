using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using WBL;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciaController : ControllerBase
    {
        private readonly IAgenciaService agencia;

        public AgenciaController(IAgenciaService agenciaService)
        {
            this.agencia = agenciaService;
        }


        [HttpGet("Lista")]
        public async Task<IEnumerable<AgenciaEntity>> GetLista()
        {
            try
            {
                return await agencia.GetLista();
            }
            catch (Exception ex)
            {

                return new List<AgenciaEntity>();
            }
        }




    }
}
