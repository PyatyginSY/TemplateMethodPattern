using System;

namespace TemplateMethodPattern
{
    public class TransformerPump : TransformerTemplate
    {
        protected override void CreateTank()
        {
            Console.WriteLine("Create tank for transformer pump");
        }

        protected override void CreateWindingHighVoltage()
        {
            Console.WriteLine("Create winding high voltage for transformer pump");
        }

        protected override void CreateWindingLowVoltage()
        {
            Console.WriteLine("Create winding low voltage for transformer pump");
        }

        protected override void CreateWindingTapVoltage()
        {
        }
    }
}
