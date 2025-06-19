using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class TrainerObjectivesVM
    {
        public TrainerObjectivesVM(Trainer trainer)
        {
            TrainerInfos = trainer.FirstName + " " + trainer.LastName + " - " + trainer.Speciality.Name;
            Trainer = trainer;
            CustomerObjectivesVMs = new();
            foreach(Customer customer in trainer.Customers)
            {
                CustomerObjectivesVM customerObjectives = new(customer);
                CustomerObjectivesVMs.Add(customerObjectives);
            }
        }

        public string TrainerInfos { get; set; }

        public Trainer Trainer { get; set; }
        
        public List<CustomerObjectivesVM> CustomerObjectivesVMs { get; set; }
    }
}
