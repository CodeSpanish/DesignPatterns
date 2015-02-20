using System;

namespace Strategy
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
           QuackBehavior = new QuackBehavior();
           FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}