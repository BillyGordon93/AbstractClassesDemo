﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicles
    {
        public Motorcycle()
        {

        }

        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This { GetType().Name} is a {GetType().BaseType.Name} is virtually in drive.");
        }
    }


}
