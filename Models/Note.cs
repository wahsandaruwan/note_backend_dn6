using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    // Model for the note
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; } = "New One";
        public string Body { get; set; } = "Dummy Text";
        public NoteType Type { get; set; } = NoteType.Detail;
        public DateTime CurrentDateTime { get; set; } = DateTime.Now;
    }
}