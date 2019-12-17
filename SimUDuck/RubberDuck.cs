using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new SqueakBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("Я резиновая утка!");
        }
    }
}
