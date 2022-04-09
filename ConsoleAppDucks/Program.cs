using ConsoleAppDucks.Before;
using System;

namespace ConsoleAppDucks
{
    class Program
    {
        static void Main(string[] args)
        {

            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Fly();

            //Also
            //Duck duck = new MallardDuck();
            //duck.Fly();

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Fly(); //- > wait what - rubberducks can fly???
        }
    }
}
