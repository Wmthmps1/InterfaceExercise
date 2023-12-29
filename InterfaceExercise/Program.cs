using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        public static void PrintCompanyDescription(ICompany vehicle)
        {
            Console.Write($"{vehicle.OriginCountry} made {vehicle.CompanyName} ");
        }

        public static void PrintVehicleDescription(IVehicle vehicle) {

            string driveableText = (vehicle.IsDriveable) ? "it runs like a champ." : "it doesn't run, so we probably shouldn't be selling it.";

            Console.Write($"{vehicle.Model} from {vehicle.Year}. This is a beautiful {vehicle.Color} ");

            if (vehicle is Car)
            {
                string compactText = (((Car)vehicle).IsCompact) ? "compact " : "standard sized ";
                string sedanText = (((Car)vehicle).IsSedan) ? "4 door sedan. " : "2 door coupe ";
                Console.Write($"car. It's a {compactText} {sedanText}");
                
            } else if (vehicle is SUV)
            {
                string jeepText = (((SUV)vehicle).IsJeep) ? "jeep" : "SUV";
                string thirdRowText = (((SUV)vehicle).HasThirdRow) ? " with a third row. " : ". While it doesn't have a third row, it has extra trunk space. ";
                Console.Write($"{jeepText}{thirdRowText}");
            } else if (vehicle is Truck)
            {
                string camperText = (((Truck)vehicle).HasCamper) ? "a camper. " : "with no camper. ";
                Console.Write($"truck with a {((Truck)vehicle).BedLength} bed length and {camperText}");
            }

            Console.Write($"It has a {vehicle.Engine} engine and {driveableText} ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
        }


        static void Main(string[] args)
        {
            var cruze = new Car()
            {
                CompanyName = "Chevrolet",
                OriginCountry = "USA",
                Model = "Cruze",
                Year = 2015,
                IsDriveable = false,
                Color = "red",
                Engine = "4 Cylinder",
                IsSedan = true,
                IsCompact = false
            };

            var f150 = new Truck()
            {
                CompanyName = "Ford",
                OriginCountry = "USA",
                Model = "F-150",
                Year = 2022,
                IsDriveable = true,
                Color = "black",
                Engine = "V6",
                HasCamper = false,
                BedLength = 44
            };

            var compass = new SUV()
            {
                CompanyName = "Jeep",
                OriginCountry = "USA",
                Model = "Compass",
                Year = 2021,
                IsDriveable = true,
                Color = "black",
                Engine = "4 Cylinder",
                IsJeep = true,
                HasThirdRow = false
            };

            Console.WriteLine("Come on down to our used car lot today. We have a great selection of vehicles:");
            Console.WriteLine();
            Console.Write("Our first vehicle is a ");
            PrintCompanyDescription(compass);
            PrintVehicleDescription(compass);
            Console.Write("Our second vehicle is a ");
            PrintCompanyDescription(f150);
            PrintVehicleDescription(f150);
            Console.Write("Our last vehicle is a ");
            PrintCompanyDescription(cruze);
            PrintVehicleDescription(cruze);
        }
    }
}

/*
 * Car
 * public string CompanyName { get; set; }
		public string OriginCountry { get; set; }
		public int NumberOfWheels { get; set; }
		public int Year { get; set; }
		public bool IsDriveable { get; set; }
		public string Color { get; set; }
		//Specific
		public bool IsSedan { get; set; }
		public bool IsCompact { get; set; }

SUV
public bool IsJeep { get; set; }
        public bool HasThirdRow { get; set; }

Truck
public bool HasCamper { get; set; }
        public int BedLength { get; set; }
*/
