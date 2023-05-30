using System;

namespace laba_7_forms
{
    public class Station
    {
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
        public int WaysNumber { get; set; }
        public double Area { get; set; }
        public int EmployeesAtStation { get; set; }
        public int PassagersAtStation { get; set; }
        public string Director { get; set; }

        public static Station GenerateStation()
        {
            Random random = new Random();
            Station station = new Station();
            station.Name = $"Station - {DateTime.Now.Hour} - {DateTime.Now.Minute} - {DateTime.Now.Second}";
            station.Area = random.NextDouble() * 100;

            return station;
        }

        public Station(string name, int seatsNumber, int waysNumber, double area, int passagersAtStation, int employeesAtStation, string director)
        {
            Name = name;
            SeatsNumber = seatsNumber;
            WaysNumber = waysNumber;
            Area = area;
            PassagersAtStation = passagersAtStation;
            EmployeesAtStation = employeesAtStation;
            Director = director;
        }

        public Station(string name) : this(name, 10, 3, 100.0, 0, 0, "Не назначен") { }

        public Station(string name, string director) : this(name, 10, 3, 100.0, 0, 0, director) { }

        public Station() : this("Не назначено", 10, 3, 100.0, 0, 0, "Не назначен") { }

        public override string ToString()
        {
            return $"Название вокзала: {Name}. Площадь: {Area}";
        }

        public void printName()
        {
            Console.WriteLine($"Название вокзала: {Name}\n");
        }
    }
}
