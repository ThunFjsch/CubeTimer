using System;
using System.Threading;
using cubetimer.Services;
using Microsoft.AspNetCore.Mvc;

namespace cubetimer.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public IActionResult GetUser(Guid id, CancellationToken cancellationToken)
        {
            if (id == Guid.Empty)
            {
                BadRequest($"User {nameof(id)} is not given or null.");
            }

            var user = _userService.GetUser(id, cancellationToken);

            return Json(user);
        }
    }
}