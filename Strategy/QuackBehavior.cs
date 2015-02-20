using System;

namespace Strategy
{
    public class QuackBehavior:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}