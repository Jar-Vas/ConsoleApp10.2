using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Auto : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine start...");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopt.");
        }
    }
    internal class Motocikle : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine start...");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopt.");
        }
    }
}
