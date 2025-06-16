using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "The {0} must be between {2} and {1} characters in length.")]
        public string Name { get; set; }

        [ValidateNever]
        public List<Trainer>? Trainers { get; set; }
    }
}
