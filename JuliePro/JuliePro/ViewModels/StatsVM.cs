using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class StatsVM
    {
        public StatsVM(List<Trainer> trainers)
        {
            Trainers = trainers;
            TotalDistance = Trainers.Sum(t => t.Customers.Sum(c => c.Objectives.Sum(o => o.DistanceKm != null ? o.DistanceKm.Value : 0)));
            MaxObjective = Trainers.Max(t => t.Customers.Max(c => c.Objectives.Count()));
            List<Customer> test = Trainers.Select(t => t.Customers).ToList();
            OldestCustomer = Trainers;
            AverageWeightLossChrystal = Trainers.Where(t => t.FirstName + t.LastName == "ChrystalLapierre")
                                                .Average(t => t.Customers.Average(c => c.Objectives.Average(o => o.LostWeightKg != null ? o.LostWeightKg.Value : 0)));
            MaxObjectiveChrystal = Trainers.Where(t => t.FirstName + t.LastName == "ChrystalLapierre")
                                            .Max(t => t.Customers.Max(c => c.Objectives.Count()));
        }

        public double TotalDistance { get; set; }
        public int MaxObjective { get; set; }
        public List<Customer> OldestCustomer { get; set; }
        public double AverageWeightLossChrystal { get; set; }
        public int MaxObjectiveChrystal { get; set; }
        public List<Trainer> Trainers { get; set; }
    }
}
