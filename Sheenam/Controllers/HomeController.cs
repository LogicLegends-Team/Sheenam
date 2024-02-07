using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using Sheenam.Models.Foundations.Homes;
using Sheenam.Services.Orchestrations.Homes;

namespace Sheenam.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        private readonly IHomeOrchestrationService homeOrchestrationService;

        public HomeController(
            IHomeOrchestrationService homeOrchestrationService)
        {
            this.homeOrchestrationService = homeOrchestrationService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<Home>> PostHome(Home home) =>
            await this.homeOrchestrationService.AddHomeAsync(home);

        [HttpGet]
        public ActionResult<IQueryable<Home>> GelAllHomes()
        {
            IQueryable<Home> allHomes =
                this.homeOrchestrationService.RetrieveAllHomes();

            return Ok(allHomes);
        }

        [HttpGet("ById")]
        public async ValueTask<ActionResult<Home>> GetHomeByIdAsync(Guid id) =>
            await this.homeOrchestrationService.RetrieveHomeByIdAsync(id);

        [HttpPut]
        public async ValueTask<ActionResult<Home>> PutHome(Home home) =>
            await this.homeOrchestrationService.ModifyHomeAsync(home);

        [HttpDelete]
        public async ValueTask<ActionResult<Home>> DeleteHome(Guid id) =>
            await this.homeOrchestrationService.RemoveHomeAsync(id);
    }
}