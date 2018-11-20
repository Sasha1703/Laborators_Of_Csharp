using System;

namespace PractikaC.Properties.Task3
{
    public partial class SuperHero
    {
        private string name;

        public SuperHero(string name)
        {
            this.name = name;
        }

        public void doSleep()
        {
            sleep();
        }

        public void doRun()
        {
            run();
        }

        public void doFight()
        {
            fight();
        }

        public void justUsePoverForce()
        {
            usePowerForce();
        }
        
        partial void sleep()
        {
            Console.WriteLine(name + " is sleep");
        }

        partial void run()
        {
            Console.WriteLine(name + " is run");
        }

        partial void fight()
        {
            Console.WriteLine(name + " is fight");
        }

        partial void usePowerForce()
        {
            Console.WriteLine(name + " use power force");
        }
    }
}