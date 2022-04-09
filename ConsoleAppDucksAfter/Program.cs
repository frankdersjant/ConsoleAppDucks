using ConsoleAppDucks.After;
using ConsoleAppDucksAfter.Interfaces;
using System;

namespace ConsoleAppDucksAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Fly();

            //Also
            IFly duck = new MallardDuck();
            //duck.Display() - Nope
            duck.Fly();

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
        }
    }
}
