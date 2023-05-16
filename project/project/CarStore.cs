using System.Collections.Generic;

namespace project
{
    public class CarStore
    {
        private List<Car> CarList;

        public CarStore()
        {
            CarList = new List<Car>();
        }

        public void AddCar(Car car)
        {
            CarList.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return CarList;
        }

        public Car GetCarByPlateNumber(string plateNumber)
        {
            //return CarList.Find(c => c.PlateNumber == plateNumber);
            Car carToFind = null;
            foreach (var car in CarList)
            {
                if (car.PlateNumber.ToLower() == plateNumber.ToLower())
                {
                    carToFind = car;
                }
            }
            return carToFind;
        }
    }
}