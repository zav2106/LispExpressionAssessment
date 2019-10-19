using LispIsEasy.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LispIsEasy.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckerController: ControllerBase
    {
        private readonly ILispChecker _lispChecker;

        public CheckerController(ILispChecker lispCheckerService)
        {
            _lispChecker = lispCheckerService;

        }
    }
}
