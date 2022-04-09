using ConsoleAppDucksAfter.Interfaces;
using System;

namespace ConsoleAppDucks.After
{
    public class RedHeadDuck : Duck, IFly
    {
        public override void Display()
        {
            Console.WriteLine("Showing RedHead");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
