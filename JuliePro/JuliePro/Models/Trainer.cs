using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 4)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(25, MinimumLength = 4)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(40)]
        public string? Photo { get; set; }

        [ForeignKey("Speciality")]
        public int SpecialityId { get; set; }
        [ValidateNever]
        public Speciality Speciality { get; set; }

        [ValidateNever]
        public List<Customer>? Customers { get; set; }
    }
}
