using System;

namespace TemplateMethodPattern
{
    public abstract class TransformerTemplate
    {
        public void CreateTransformer()
        {
            CreateWindingLowVoltage();
            CreateWindingHighVoltage();
            CreateWindingTapVoltage();
            CreateMagneticCore();
            CreateTank();
            Console.WriteLine("Create transformer!\n");
        }

        protected abstract void CreateWindingTapVoltage();

        protected abstract void CreateTank();

        protected virtual void CreateMagneticCore()
        {
            Console.WriteLine("Create magnetic core for transformer all");
        }

        protected abstract void CreateWindingHighVoltage();

        protected abstract void CreateWindingLowVoltage();
    }
}
