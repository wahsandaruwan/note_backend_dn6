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
        private static readonly List<Note> notes = new List<Note>{
            new Note(),
            new Note {Title = "Sample Note"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Note>> GetAll(){
            return Ok(notes);
        }

        [HttpGet("GetSingle")]
        public ActionResult<Note> GetSingle(){
            return Ok(notes[0]);
        }
    }
}