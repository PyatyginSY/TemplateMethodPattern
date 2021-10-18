using System;

namespace TemplateMethodPattern
{
    public class TransformerDistribution : TransformerTemplate
    {
        protected override void CreateTank()
        {
            Console.WriteLine("Create tank for transformer distribution");
        }

        protected override void CreateWindingHighVoltage()
        {
            Console.WriteLine("Create winding high voltage for transformer distribution");
        }

        protected override void CreateWindingLowVoltage()
        {
            Console.WriteLine("Create winding low voltage for transformer distribution");
        }
    }
}
