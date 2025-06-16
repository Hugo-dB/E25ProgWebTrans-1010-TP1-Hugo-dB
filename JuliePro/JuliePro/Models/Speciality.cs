using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }
    }
}
