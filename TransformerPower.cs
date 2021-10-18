using System;

namespace TemplateMethodPattern
{
    public class TransformerPower : TransformerTemplate
    {
        protected override void CreateMagneticCore()
        {
            Console.WriteLine("Create magnetic core for transformer power by himself");
        }

        protected override void CreateTank()
        {
            Console.WriteLine("Create tank for transformer power");
        }

        protected override void CreateWindingHighVoltage()
        {
            Console.WriteLine("Create winding high voltage for transformer power");
        }

        protected override void CreateWindingLowVoltage()
        {
            Console.WriteLine("Create winding low voltage for transformer power");
        }

        protected override void CreateWindingTapVoltage()
        {
            Console.WriteLine("Create winding tap voltage for transformer power");
        }
    }
}
