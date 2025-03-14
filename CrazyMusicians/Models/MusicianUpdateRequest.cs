using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class MusicianUpdateRequest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Profession is required")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "FunFeature is required")]
        public string FunFeature { get; set; }
    }
}
