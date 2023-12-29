using System;
namespace InterfaceExercise
{
	public interface ICompany
	{
		public string CompanyName { get; set; }
		public string OriginCountry { get; set; }

	}
}

//In ICompany: 

/* Create 2 members that are specific to each every company
 * regardless of vehicle type.
 * Example: public string Logo { get; set; }
 */