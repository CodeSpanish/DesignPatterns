using System;

namespace Strategy
{
    public class SqueakBehavior:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak.");
        }
    }
}