namespace ClassLibrary1
{
    public class Factory
    {
        
        private string name;
        private string location;
        private int yearFounded;
        private int numEmployees;
        private string productionType;
        private double capacityPerDay;
        private bool isWorking;
        public string Owner { get; set; } 

        
        public Factory(string name, string location, int yearFounded, int numEmployees, string productionType, double capacityPerDay, bool isWorking, string owner)
        {
            this.name = name;
            this.location = location;
            this.yearFounded = yearFounded;
            this.numEmployees = numEmployees;
            this.productionType = productionType;
            this.capacityPerDay = capacityPerDay;
            this.isWorking = isWorking;
            this.Owner = owner;
        }

        
        public override string ToString()
        {
            return $"Factory Name: {name}\nLocation: {location}\nYear Founded: {yearFounded}\nNumber of Employees: {numEmployees}\nProduction Type: {productionType}\nCapacity per Day: {capacityPerDay}\nIs Working: {isWorking}\nOwner: {Owner}";
        }

       
        public double CalculateAnnualCapacity()
        {
            return capacityPerDay * 365;
        }

       
        public string WorkingStatus()
        {
            if (isWorking)
            {
                return $"{name} is currently operational.";
            }
            else
            {
                return $"{name} is not operational.";
            }
        }

        public int YearsInOperation()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - yearFounded;
        }
    }
}
