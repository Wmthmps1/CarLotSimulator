﻿using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}
		public int Year { get; set; }
		public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
			Console.WriteLine($"You rev the engine: {engineNoise}");
		}
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"You honk the horn: {honkNoise}");
        }
    }
}

//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property