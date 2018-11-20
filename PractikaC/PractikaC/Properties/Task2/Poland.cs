using System;

namespace PractikaC.Properties.Task2
{
    public class Poland : Human
    {
        public Poland()
        {
            walk();
            sleep();
            talk();
        }
        
        public override void walk()
        {
            Console.WriteLine("I am poland boy and i walking");
        }
        
        protected override void sleep()
        {
            Console.WriteLine("I am poland boy and i sleeping");
        }
        
        private void talk()
        {
            Console.WriteLine("I am poland boy and i talk");
        }
    }
}