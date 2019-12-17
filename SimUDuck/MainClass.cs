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

            model.flyBehavior = new FlyRocketPowered();
            model.PerformFly();

            RedheadDuck model2 = new RedheadDuck();
            model2.Display();
            model2.PerformFly();
            model2.PerformQuack();
            model2.Swim();
            
            RubberDuck model3 = new RubberDuck();
            model3.Display();
            model3.PerformFly();
            model3.PerformQuack();
            model3.Swim();


        }
    }
}
