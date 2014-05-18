using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFac.Test.ConsoleApp.Models
{
    public class AngryBird: IFlying
    {
        public void Fly()
        {
            Console.WriteLine("AngryBird is flying in game");
        }
    }
}
