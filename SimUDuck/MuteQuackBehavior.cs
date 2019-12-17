
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class MuteQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...тишина...");
        }
    }
}
