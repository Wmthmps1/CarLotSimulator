using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            CarLot lot = new CarLot();
            Car firstCar = new Car();
            Car secondCar = new Car();
            Car thirdCar = new Car();

            // Car 1
            string engineNoise = "VROOM";
            string honkNoise = "HONK";
            firstCar.Year = 2001;
            firstCar.Make = "Honda";
            firstCar.Model = "Accord";
            firstCar.EngineNoise = engineNoise;
            firstCar.HonkNoise = honkNoise;
            firstCar.IsDriveable = true;

            lot.CarList.Add(firstCar);

            // Car 2 One of the most unreliable cars
            engineNoise = "There is no sound.";
            honkNoise = "meep";
            secondCar.Year = 1976;
            secondCar.Make = "Chevrolet";
            secondCar.Model = "Chevette";
            secondCar.EngineNoise = engineNoise;
            secondCar.HonkNoise = honkNoise;
            secondCar.IsDriveable = false;

            lot.CarList.Add(secondCar);

            // Car 3
            engineNoise = "VROOOOOOOOOOOOM!!!!!!";
            honkNoise = "HOOOOOOONNNNNK!!!!!!";
            thirdCar.Year = 2021;
            thirdCar.Make = "McLaren";
            thirdCar.Model = "Sabre";
            thirdCar.EngineNoise = engineNoise;
            thirdCar.HonkNoise = honkNoise;
            thirdCar.IsDriveable = true;

            lot.CarList.Add(thirdCar);

            lot.PrintCars(lot.CarList);

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
