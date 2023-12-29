using System;
namespace InterfaceExercise
{
	public class Truck : ICompany, IVehicle
	{
		public Truck()
		{
		}
        public string CompanyName { get; set; }
        public string OriginCountry { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }

        public bool HasCamper { get; set; }
        public int BedLength { get; set; }
    }
}


/* Create 2 members that are specific to each class
 * Example for Car: public bool HasTrunk { get; set; }
 * Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */