using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserAnswer
    {
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        public int Points { get; set; }

        public bool IsLiked { get; set; }
    }
}
