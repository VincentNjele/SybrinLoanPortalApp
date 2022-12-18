using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SybrinLoanPortal.Server.Services.Interfaces;
using SybrinLoanPortal.Shared.Models;

namespace SybrinLoanPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IService service;

        public ServiceController(IService service)
        {
            this.service = service;
        }

        [Route("GetClients")]

        public async Task<ActionResult<IEnumerable<ClientDoc>>> GetClients()
        {
            var clients = await service.LoadData<ClientDoc>();

            return Ok(clients);
        }
    }
}
