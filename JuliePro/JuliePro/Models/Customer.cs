using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A {0} is required.")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} must be between {1} and {2} characters long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A {0} is required.")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The {0} must be between {1} and {2} characters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "An {0} is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A {0} is required.")]
        public DateTime BirthDate { get; set; }

        [Range(100, 400, ErrorMessage = "The {0} must be between {1} and {2}.")]
        public double? StartWeight { get; set; }

        [ValidateNever]
        public List<Objective>? Objectives { get; set; }

        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ValidateNever]
        public Trainer Trainer { get; set; }
    }
}
