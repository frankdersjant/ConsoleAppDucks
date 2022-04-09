using ConsoleAppDucksAfter.Interfaces;
using System;

namespace ConsoleAppDucks.After
{
    public class MallardDuck : Duck, IFly
    {
        public override void Display()
        {
            Console.WriteLine("Showing Mallard");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
