using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using Sheenam.Models.Foundations.Users;
using Sheenam.Services.Orchestrations.Users;

namespace Sheenam.Controllers
{
    public class UserController : RESTFulController
    {
        private readonly IUserOrchestrationService userOrchestrationService;

        public UserController(
            IUserOrchestrationService userOrchestrationService)
        {
            this.userOrchestrationService = userOrchestrationService;
        }

        [HttpGet]
        public ActionResult<IQueryable<User>> GelAllUsers()
        {
            IQueryable<User> allUserss =
                this.userOrchestrationService.RetrieveAllUsers();

            return Ok(allUserss);
        }

        [HttpGet("ById")]
        public async ValueTask<ActionResult<User>> GetUserByIdAsync(Guid id) =>
            await this.userOrchestrationService.RetrieveUserByIdAsync(id);

        [HttpPut]
        public async ValueTask<ActionResult<User>> PutHome(User user) =>
            await this.userOrchestrationService.ModifyUserAsync(user);

        [HttpDelete]
        public async ValueTask<ActionResult<User>> DeleteUser(Guid id) =>
            await this.userOrchestrationService.RemoveUserAsync(id);
    }
}