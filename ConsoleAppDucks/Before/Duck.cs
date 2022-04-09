using System;

namespace ConsoleAppDucks
{
    public abstract class Duck
    {
        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }

        public void Quack() 
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Im Flying");
        }
    }
}
