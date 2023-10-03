using System;
using System.Globalization;

namespace Horsepower_calculator
{
    internal class Calculator
    {
        public int Constant = 5252;
        public double Torque {  get; set; }
        public double Rpm { get; set; }
        public double Horsepower { get; private set; }


        public Calculator(double torque, double rpm)
        {
            this.Torque = torque * 7.233;
            this.Rpm = rpm;
        }

        public double Calculate()
        {
            Horsepower = (Torque * Rpm) / Constant;
            return Horsepower;
        }

        public override string ToString()
        {
            return "Potência máxima (HP): " + Calculate().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
