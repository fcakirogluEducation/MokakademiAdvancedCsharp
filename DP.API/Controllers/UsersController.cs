using DP.API.Design_Patterns.ODP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserObserverSubject _userObserverSubject;

        public UsersController(UserObserverSubject userObserverSubject)
        {
            _userObserverSubject = userObserverSubject;
        }

        [HttpPost]
        public IActionResult UserCreated()
        {

            // kayıt yapıldı

            _userObserverSubject.Notify(new User { Id = 1, Name = "test" });
            return Ok();
        }
    }
}
