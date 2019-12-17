using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("Я настоящая утка!");
        }
    }
}
