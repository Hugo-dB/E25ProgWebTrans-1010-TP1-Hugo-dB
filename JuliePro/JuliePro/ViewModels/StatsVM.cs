using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class StatsVM
    {
        public StatsVM(List<Customer> customers)
        {
            Customers = customers;
            TotalDistance = Customers.Sum(c => c.Objectives.Sum(o => o.DistanceKm != null ? o.DistanceKm.Value : 0));
            MaxObjective = Customers.Max(c => c.Objectives.Count);
            OldestCustomers = Customers.OrderBy(c => c.BirthDate).Take(2).ToList();
            AverageWeightLossChrystal = Customers.Where(c => c.TrainerId == 1).Average(c => c.Objectives.Average(o => o.LostWeightKg != null ? o.LostWeightKg.Value : 0));
            MaxObjectiveChrystal = Customers.Where(c => c.TrainerId == 1).Max(c => c.Objectives.Count);
        }

        public double TotalDistance { get; set; }
        public int MaxObjective { get; set; }
        public List<Customer> OldestCustomers { get; set; }
        public double AverageWeightLossChrystal { get; set; }
        public int MaxObjectiveChrystal { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
