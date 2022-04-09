using System;

namespace ConsoleAppDucks.After
{
    public class RubberDuck : Duck //nope cannot fly
    {
        public override void Display()
        {
            Console.WriteLine("Im am rubber duck - I cant fly");
        }
    }
}
