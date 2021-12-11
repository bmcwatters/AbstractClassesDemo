﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public bool HasSideCar { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive");

        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"THis {GetType().Name} is a{GetType().BaseType.Name} is virtually in drive");
        }


    }
}
