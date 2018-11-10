using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{

    public sealed class Car
    {
        private double speed;
        private double angle;
        private bool isMotorOn;

        private Car()
        {
            speed = 0;
            angle = 90;
            isMotorOn = false;

        }

        private static Car currentCar = null;

        public static Car CurrCar
        {
            get
            {
                if (currentCar == null)
                    currentCar = new Car();
                return currentCar;
            }
        }

        public void Start()
        {
            if(CurrCar.isMotorOn == true) Console.WriteLine("Motor is already on!");
            else
            {
                CurrCar.isMotorOn = true;
                Console.WriteLine("Motor is on!");
            }
        }

        public void Stop()
        {
            if (CurrCar.isMotorOn == false)
            { Console.WriteLine("Motor is already off!"); return; }
            if (CurrCar.speed != 0)
            { Console.WriteLine("Spped should be 0 to stop! Now it is {0}", CurrCar.speed); return; }
            CurrCar.isMotorOn = false;
            Console.WriteLine("Motor is off!");
        }

        public void ChangeSpeed(double newspeed)
        {
            if (CurrCar.isMotorOn == false)
            { Console.WriteLine("Motor is off! Can't change speed!"); return; }
            Console.WriteLine("Speed was changed from {0} to {1}!", CurrCar.speed, newspeed);
            CurrCar.speed = newspeed;
        }

        

        public void TurnLeft(double newangle)
        {
            if (CurrCar.isMotorOn == false) { Console.WriteLine("Motor is off! Can't turn!"); return; }
            Console.WriteLine("Car turned left. Angle was changed from {0} to {1}!",
                              CurrCar.angle, BalanceAngle(CurrCar.angle + newangle));
            CurrCar.angle = BalanceAngle(CurrCar.angle + newangle);
        }

        public void TurnRight(double newangle)
        {
            if (CurrCar.isMotorOn == false) { Console.WriteLine("Motor is off! Can't turn!"); return; }
            Console.WriteLine("Car turned right. Angle was changed from {0} to {1}!",
                              CurrCar.angle, BalanceAngle(CurrCar.angle -newangle));
            CurrCar.angle = BalanceAngle(CurrCar.angle - newangle);
        }

        private double BalanceAngle(double angle)
        {
            return angle >= 360 ? angle - 360 : angle;
        }

        public bool IsOn()
        {
            return CurrCar.isMotorOn;
        }
    }
}

