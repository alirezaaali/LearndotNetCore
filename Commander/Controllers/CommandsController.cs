using Microsoft.AspNetCore.Mvc;
namespace Commander.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    //[Route(template: "api/Commandes")]
    [Route(template: "api/[controller]")] //This is better to use!
    public class CommandesController : ControllerBase
    {
        /* This is the old MVC way
        private readonly Data.ThisIsNotAGoodRepository _repository;
        public CommandesController() : base()
         {
             _repository = new Data.ThisIsNotAGoodRepository();
         }
        */

        //this is new Automatic Dependency Injection
        private readonly Data.ICommandRepository _repository;
        public CommandesController(Data.ICommandRepository repository) : base()
        {
            _repository = repository;

        }

        [HttpGet]
        //Sample with IActionResult and //This is better to use!
        public ActionResult GetString()
        {
            return Content("This is a simple IActionResult from Commanders Contorller which ic default action");
        }
        // public string GetString()
        // {
        //     return "Hello, my name is string Commander";
        // }

        [HttpGet(template: "/DirectAccess")]
        //direct access to an Action with content 
        public ActionResult directAccessToAction()
        {
            return Content("This is a direct access to an Action without controler name");
        }

        [HttpGet(template: "/Model/myModel")]
        //direct access to an Object 
        public Models.Command GetAnObject()
        {

            Models.Command myCommand = new Models.Command
            {
                Id = 1,
                Line = $"Some Line",
                HowTo = $"Some How To?",
                Platform = $"Some Platform",
            };

            return myCommand;
        }

        [HttpGet(template: "/Model/myModelAsync")]
        //direct access to an Action 
        public async System.Threading.Tasks.Task<Models.Command> GetAnObjectAsync()
        {
            Models.Command myCommand = null;
            //This is how we develope an async code
            await System.Threading.Tasks.Task.Run(() =>
            {
                myCommand = new Models.Command
                {
                    Id = 1,
                    Line = $"Some Line",
                    HowTo = $"Some How to",
                    Platform = $"Some Platform",
                };
            });
            return myCommand;
        }

        // [HttpGet(template: "/api/Commandes/GetAll")]
        // public ActionResult<System.Collections.Generic.IEnumerable<Models.Command>> GetAll()
        // {
        //     var result = _repository.GetAll();
        //     return Ok(result);
        // }

        // [HttpGet(template: "/api/Commandes/GetId/{id}")]
        // public ActionResult<Models.Command> GetId(int Id)
        // {
        //     Models.Command result = _repository.GetId(Id);
        //     return Ok(result);
        // }


        [HttpGet(template: "/api/Commandes/GetAll")]
        public async System.Threading.Tasks.Task<ActionResult<System.Collections.Generic.IEnumerable<Models.Command>>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet(template: "/api/Commandes/GetId/{id}")]
        public async System.Threading.Tasks.Task<ActionResult<Models.Command>> GetIdAsync(int Id)
        {
            Models.Command result = await _repository.GetIdAsync(Id);
            return Ok(result);
        }
    }
}