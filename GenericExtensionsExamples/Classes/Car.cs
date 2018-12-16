using System.Collections.Generic;

namespace GenericExtensionsExamples.Classes
{
    public class Car
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Company} - {Model}";
        }
    }

    public static class Cars
    {
        public static List<Car> List() => new List<Car>()
        {
            new Car() {Company = "Mazda", Model = "Miata", Year = 2015},
            new Car() { Company = "Mazda", Model = "CX-5", Year = 2016 },
            new Car() { Company = "Mazda", Model = "Miata", Year = 2015 }
        };
    }
}
