using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Deafault make";
        public string model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); //stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in drive");
        }
    }
}
