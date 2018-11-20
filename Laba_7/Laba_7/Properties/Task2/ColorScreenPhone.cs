using System;

namespace Laba_7.Properties.Task2
{
    public class ColorScreenPhone : BlackAndWhiteScreenPhone
    {
        public void colorScreen()
        {
            Console.WriteLine("Color screen");
            blackAndWhiteScreen();
        }
    }
}