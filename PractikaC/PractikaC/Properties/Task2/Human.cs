using System;

namespace PractikaC.Properties.Task2
{
    public class Human
    {
        public virtual void walk()
        {
            Console.WriteLine("I am human and i walking");
        }

        protected virtual void sleep()
        {
            Console.WriteLine("I am human and i sleeping");
        }
        
        private void talk()
        {
            Console.WriteLine("I am human and i talk");
        }
    }
}