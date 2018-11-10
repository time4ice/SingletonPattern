using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Rider
    {
        public void RideCar()
        {
            Car car = Car.CurrCar;
            Menu();
            string condition;
            Console.WriteLine("Input number of function you wanna choose.");
            condition =Console.ReadLine();
            while(true)
            {
                if (condition == "1")
                    car.Start();
                if (condition == "2")
                    car.Stop();
                if (condition =="3")
                {
                    Console.WriteLine("Input required speed.");
                    double speed = Convert.ToDouble(Console.ReadLine());
                    car.ChangeSpeed(speed);
                }
                if (condition =="4")
                {
                    Console.WriteLine("Input required angle.");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    car.TurnLeft(angle);
                }
                if (condition == "5")
                {
                    Console.WriteLine("Input required angle.");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    car.TurnRight(angle);
                }
                if(condition == "6")
                {
                    if(car.IsOn()) Console.WriteLine("Can`t exit if motor is on.");
                    else break;
                }
                Console.WriteLine("Input number of function you wanna choose.");
                condition = Console.ReadLine();
            }
           

        }

        private void Menu()
        {
            Console.WriteLine("-------------Menu-------------------");
            Console.WriteLine("1.Turn on the motor.");
            Console.WriteLine("2.Turn off the motor.");
            Console.WriteLine("3.Change speed.");
            Console.WriteLine("4.Turn left.");
            Console.WriteLine("5.Turn right.");
            Console.WriteLine("6.Exit.");
        }

    }

}
