using System;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carStore = new CarStore();
            carStore.AddCar(new Car("12fgrl", "black", new DateTime(2002, 2, 10), "nissan"));
            carStore.AddCar(new Car("567red", "yellow", new DateTime(1997, 6, 12), "benz"));
            carStore.AddCar(new Car("098pol", "red", new DateTime(1996, 7, 1), "corolla"));
            carStore.AddCar(new Car("876yht", "green", new DateTime(1998, 2, 6), "spider"));
            carStore.AddCar(new Car("453ref", "white", new DateTime(2003, 2, 11), "tesla"));

            //var lists = carStore.GetAllCars();

            //var listOfboks = new List<Car>();
            //foreach (var item in lists)
            //{
            //    listOfboks.Add(item);
            //}

            //foreach (var item in listOfboks)
            //    Console.WriteLine(item.PlateNumber + " " + item.Colour + " " + "age" + " " + item.Age);

            while (true)
            {
                Console.Write("confirm your plate number: ");
                var input = Console.ReadLine();

                var zar = carStore.GetCarByPlateNumber(input);
                if (zar == null)
                {
                    Console.WriteLine("Car Not Found");
                }
                else
                {
                    Console.WriteLine("Car Match");
                    Console.WriteLine($"Model = {zar.Model}");
                    Console.WriteLine($"Platenumber = {zar.PlateNumber}");
                    Console.WriteLine($"Age = {zar.Age}");
                    Console.WriteLine($"Colour = {zar.Colour}");
                }
            }
        }
    }
}