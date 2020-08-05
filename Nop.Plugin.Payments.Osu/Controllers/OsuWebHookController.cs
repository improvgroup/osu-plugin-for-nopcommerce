using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Plugin.Payments.Osu.Controllers
{
    public class OsuWebHookController : Controller
    {
        public IActionResult HandleSuccess()
        {
            return Ok();
        }

        public IActionResult HandleFailure()
        {
            return Ok();
        }
    }
}
