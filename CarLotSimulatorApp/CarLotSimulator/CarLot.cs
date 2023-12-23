using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{
			
		}

		public static int NumberOfCars {get; set;}

		public List<Car> CarList = new List<Car>();

		public void PrintCars(List<Car> CarList)
		{
			foreach (var car in CarList)
			{
				string isDriveableText;

				if(car.IsDriveable == true)
				{
					isDriveableText = "is driveable.";
				}
				else{
                    isDriveableText = "is not driveable.";
                }

				Console.WriteLine($"The {car.Year} {car.Make} {car.Model} {isDriveableText}");
				car.MakeEngineNoise(car.EngineNoise);
				car.MakeHonkNoise(car.HonkNoise);
                NumberOfCars++;
				string writeStatement = (NumberOfCars == 1) ? $"There is {NumberOfCars} car in the lot." : $"There are {NumberOfCars} cars in the lot.";
                Console.WriteLine(writeStatement);
                Console.WriteLine("----------------------------------------------------------");
                

            }
		}
	}
}
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
