using System;
using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of factories: ");
        int cntFactories = int.Parse(Console.ReadLine());

        
        Factory[] arrFactories = new Factory[cntFactories];

        
        for (int i = 0; i < cntFactories; i++)
        {
            Console.WriteLine($"\nEntering data for factory #{i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Year Founded: ");
            int yearFounded = int.Parse(Console.ReadLine());

            Console.Write("Number of Employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.Write("Production Type: ");
            string productionType = Console.ReadLine();

            Console.Write("Capacity per Day: ");
            double capacityPerDay = double.Parse(Console.ReadLine());

            Console.Write("Is Working (true/false): ");
            bool isWorking = bool.Parse(Console.ReadLine());

            Console.Write("Owner: ");
            string owner = Console.ReadLine();

           
            arrFactories[i] = new Factory(name, location, yearFounded, numEmployees, productionType, capacityPerDay, isWorking, owner);
        }

        
        Console.WriteLine("\nInformation about all factories:");
        for (int i = 0; i < cntFactories; i++)
        {
            Console.WriteLine($"\nFactory #{i + 1}:");
            Console.WriteLine(arrFactories[i].ToString());
            Console.WriteLine($"Annual Capacity: {arrFactories[i].CalculateAnnualCapacity()} units");
            Console.WriteLine($"Working Status: {arrFactories[i].WorkingStatus()}");
            Console.WriteLine($"Years in Operation: {arrFactories[i].YearsInOperation()} years");
        }
    }
}