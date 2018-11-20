using System;

namespace PractikaC.Properties.Task2
{
    public class American : Human
    {
            public American()
            {
                walk();
                sleep();
                talk();
            }

            public override void walk()
            {
                Console.WriteLine("I am american boy and i walking");
            }
        
            protected override void sleep()
            {
                Console.WriteLine("I am american boy and i sleeping");
            }
        
            private void talk()
            {
                Console.WriteLine("I am american boy and i talk");
            }
    }
}