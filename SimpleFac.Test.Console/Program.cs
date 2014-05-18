using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleFac.Test.ConsoleApp.Models;

namespace SimpleFac.Test.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //RegisterAnimal();
            RegisterMachine();
            var vehicle = SimpleFac.GetInstance().Resolve<IFlying>();
            vehicle.Fly();
        }

        static void RegisterAnimal()
        {
            SimpleFac.GetInstance().Register(typeof(IFlying), typeof(AngryBird));
        }

        static void RegisterMachine()
        {
            SimpleFac.GetInstance().Register(typeof(IFlying), typeof(Plane));
        }
    }
}
