using JuliePro.Models;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.ViewModels
{
    public class CustomerObjectivesVM
    {
        public CustomerObjectivesVM(Customer customer)
        {
            CustomerName = customer.FirstName + " " + customer.LastName;
            if (customer.Objectives != null)
            {
                NbCompletedObjectives = customer.Objectives.Count(o => o.AchievedDate != null);
                NbIncompletedObjectives = customer.Objectives.Count(o => o.AchievedDate == null);
                NbActiveObjectives = customer.Objectives.Count(o => o.AchievedDate == null);
            }
            else
            {
                NbCompletedObjectives = 0;
                NbIncompletedObjectives = 0;
                NbActiveObjectives = 0;
            }
        }
            

        [Display(Name ="Customer's Name")]
        public string CustomerName { get; set; }

        [Display(Name ="Nb Completed Objectives")]
        public int NbCompletedObjectives { get; set; }

        [Display(Name ="Nb Incompleted Objecetives")]
        public int NbIncompletedObjectives { get; set; }

        public int NbActiveObjectives { get; set; }
        
    }
}
