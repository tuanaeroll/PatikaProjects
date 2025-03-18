using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class MusicianUpdateFunFeatureRequest
    {
        [Required(ErrorMessage = "FunFeature is required")]
        public string FunFeature { get; set; }
    }
}
