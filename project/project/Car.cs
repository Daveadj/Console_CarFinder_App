using System;

namespace project
{
    public class Car
    {
        public string PlateNumber { get; set; }
        public string Colour { get; set; }
        public DateTime YearMade { get; set; }
        public string Model { get; set; }

        public int Age => DateTime.Now.Year - this.YearMade.Year;

        public Car(string plateNumber, string color, DateTime yearMade, string model)
        {
            this.PlateNumber = plateNumber;
            this.Colour = color;
            this.YearMade = yearMade;
            this.Model = model;
        }
    }
}