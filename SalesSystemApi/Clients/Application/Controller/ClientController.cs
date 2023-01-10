using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesSystemApi.Clients.Domain;
using SalesSystemApi.Clients.Infrastructure.MSSql;

namespace SalesSystemApi.Clients.Application.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private ClientContext context;

        public ClientController() {
            this.context = new ClientContext();
        }
        [HttpGet(Name = "Client")]
        public IActionResult Get()
        {
            MSSqlClientRepository clientRepository = new MSSqlClientRepository(this.context);
            var clientResponse = clientRepository.Find();
            return Ok(clientResponse);
        }
    }
}
