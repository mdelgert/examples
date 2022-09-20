using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Data
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
