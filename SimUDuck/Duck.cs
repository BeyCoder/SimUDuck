using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    abstract class Duck
    {
        public IQuackBehavior quackBehavior { set; get; }
        public IFlyBehavior flyBehavior { set; get; }
        public Duck()
        {

        }
        public abstract void Display();
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("Все утки умеют плавать!");
        }
    }
}
