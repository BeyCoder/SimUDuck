using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack-quack!");
        }
    }
}
