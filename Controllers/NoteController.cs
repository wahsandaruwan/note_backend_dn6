using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // Controller for the note
    public class NoteController : ControllerBase
    {
        private static readonly Note new1 = new();

        [HttpGet]
        public ActionResult<Note> Get(){
            return Ok(new1);
        }
    }
}