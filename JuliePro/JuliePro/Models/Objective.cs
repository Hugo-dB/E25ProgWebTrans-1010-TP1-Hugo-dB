using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A {0} is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The {0} must be between {1} and {2} characters long.")]
        public string Name { get; set; }

        [Display(Name = "Lost Weight")]
        [Range(2, 10, ErrorMessage = "The {0} must be between {1}Kg and {2}Kg.")]
        public double? LostWeightKg { get; set; }

        [Display(Name = "Distance")]
        [Range(2, 45, ErrorMessage = "The {0} must be between {1}Km and {2}Km.")]
        public double? DistanceKm { get; set; }

        [Display(Name = "Achieved Date")]
        public DateTime? AchievedDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ValidateNever]
        public Customer Customer { get; set; }
    }
}
