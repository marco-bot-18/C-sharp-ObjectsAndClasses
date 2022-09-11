using System;

namespace ClassesAndObjects
{

    class Program
    {
        private string X;
        private string Y;
        public Program (string y, string x) // <-------- Constructor
        {
            this.X = x;
            this.Y = y;
        }

        public Program(string y) : this(y, "Unknown") // <-- Overloading Constructor
        {
            Console.WriteLine("overloaded constructor.");
        }

        static void Main(string[] args)
        {
            Car();
            Console.WriteLine("---------------------------------");
            Motor();
            Console.WriteLine("---------------------------------");

            Program objProgram = new Program("Sample String", "asd");
            Console.WriteLine(objProgram.X + " " + objProgram.Y);

            Program objProgram1 = new Program("");
            Console.WriteLine(objProgram1.X + " " + objProgram1.Y);

        }

        static void Car()
        {
            Car car = new Car();
            car.Brand = "Volvo"; //"class Brand" in Car.cs and so on.....
            car.Price = -0;
            car.HorsePower = 1000;
            car.Speed = 80;
            Console.WriteLine($"Brand: {car.Brand} \nPrice: {car.Price} \nHorsepower: {car.HorsePower} \nInitial Speed: {car.Speed} \nDecreased Speed in Break: {car.DecreaseSpeed(2)}");
        }

        static void Motor()
        {
            Motor motor = new Motor();
            motor.HorsePowerMotor = 1000;
            motor.Type = "BigBike";
            Console.WriteLine($"{motor.Type} \n{motor.HorsePowerMotor} cc");
        }

    }
}
