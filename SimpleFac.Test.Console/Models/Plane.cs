using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFac.Test.ConsoleApp.Models
{
    public class Plane: IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }
    }
}
