using System;

namespace CarChallenge
{
    class Program
    {

         class Car
        {
            string mark;
            string model;
            string color;
            string regNumber;
            int fuelTank;
            int odo;

            public Car(string _mark, string _model, string _color, string _regNumber)
            {
                mark = _mark;
                model = _model;
                color = _color;
                
                if(_regNumber.Length != 6)
                {
                    regNumber = "undefined";
                }
                else
                {
                    regNumber = _regNumber;
                }
                fuelTank = 60;
                odo = 0;

            
            }

            public string Model
            {
                get { return model; }
            }

            public string Mark
            {
                get { return mark; }
            }
            public string Color
            {
                get { return color; }
            }
            
            public string RegNumber
            {
                get { return regNumber; }
            }

            public int Odo
            {
                get { return odo; }
            }
            
            public int FuelTank
            {
                get { return fuelTank; }
            }
            public void Drive()
            {
                odo += 100;
                fuelTank -= 5;

            }
            
            public void ShowCarDetails()
            {
                Console.WriteLine($"Model: {model};\n Mark: {mark};\n Color: {color};\n RegNumber: {regNumber};\n FuelTank: {fuelTank};\n OdoMeter: {odo};\n");
            }
         }
        static void Main(string[] args)
        {
            Car newCar = new Car("toyota", "supra", "black", "483FJV");
            Console.WriteLine("Your Car Is ready!");
            while (newCar.FuelTank != 0)
            {
                newCar.Drive();
            }

            Console.WriteLine("Get out of the Car!");
            newCar.ShowCarDetails();
        }
    }
}
