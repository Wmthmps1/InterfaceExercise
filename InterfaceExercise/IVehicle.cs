using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
    }
}

//In your IVehicle:

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: public int NumberOfWheels { get; set; }
 */

/*
 * public int NumberOfWheels { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
        public string Color { get; set; }
 * public string CompanyName { get; set; }
		public string OriginCountry { get; set; }
 * 
 * 
 */