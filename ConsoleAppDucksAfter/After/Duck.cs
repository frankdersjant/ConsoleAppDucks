using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDucks.After
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
    }
}
