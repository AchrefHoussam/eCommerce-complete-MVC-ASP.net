using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string PictureProfileURL { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }

    }
}
