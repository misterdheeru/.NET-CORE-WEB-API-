using CRUDEMPLOYEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDEMPLOYEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {

        private readonly IPOSITION _data;

        public PositionsController(IPOSITION data)
        {
            _data = data;
        }

        [HttpGet]   
        public IActionResult Get() 
        {
            var Data = _data.DisplayPosition();
            return Ok(Data);

        }

        [HttpPost]
        public IActionResult Post(selectposition DATA)
        {
           _data.InsertPosition(DATA);

           return Ok("SUCESSED");
        }
    }
}
