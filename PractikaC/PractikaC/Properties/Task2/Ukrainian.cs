using System;

namespace PractikaC.Properties.Task2
{
    public class Ukrainian : Human
    {
        public Ukrainian()
        {
            walk();
            sleep();
            talk();
        }

        public override void walk()
        {
            Console.WriteLine("I am ukrainian and i walking");
        }
        
        protected override void sleep()
        {
            Console.WriteLine("I am ukrainian and i sleeping");
        }
        
        private void talk()
        {
            Console.WriteLine("I am ukrainian and i talk");
        }
    }
}