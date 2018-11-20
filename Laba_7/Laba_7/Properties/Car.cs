namespace Laba_7.Properties
{
    public class Car
    {
        private string name;
        private string color;
        private int speed;
        private long age;

        public string Name => name;
        public string Color => color;
        public int Speed => speed;
        public long Age => age;

        public Car(string name, string color, int speed, long age)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            this.age = age;
        }

        public override string ToString()
        {
            return name + " the color is " + color + " this car have max speed = " + speed + " and car was make in " + age;
        }
    }
}