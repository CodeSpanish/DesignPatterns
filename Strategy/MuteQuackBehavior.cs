using System;

namespace Strategy
{
    public class MuteQuackBehavior: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}