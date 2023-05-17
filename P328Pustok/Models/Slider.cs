using System.ComponentModel.DataAnnotations.Schema;

namespace P328Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ButtonDesc { get; set; }
        public string ButtonUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
