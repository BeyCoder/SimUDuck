﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Я летаю!");
        }
    }
}
