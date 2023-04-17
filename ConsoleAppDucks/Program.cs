using ConsoleAppDucks.Before;

namespace ConsoleAppDucks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Also
            //Duck duck = new MallardDuck();
            //duck.Fly();

            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Fly();

            

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Fly(); //- > wait what - rubberducks can fly???
        }
    }
}
