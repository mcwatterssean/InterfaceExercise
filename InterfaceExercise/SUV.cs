using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV: IVehicle, ICompany
    {
        public SUV()
        {

        }

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Explorer";
        public int SeatCount { get; set; } = 7;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Build Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        public string CargoHoldSize { get; set; } = "87.8 cubic feet";

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }




    }
}
