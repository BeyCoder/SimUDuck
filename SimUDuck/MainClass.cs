using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class MainClass
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();

            Console.WriteLine();

            ModelDuck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.PerformQuack();
            model.Swim();
        }
    }
}
