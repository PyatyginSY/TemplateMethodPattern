using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TemplateMethodPattern\n");

            TransformerTemplate transformerTemplate;

            Console.WriteLine("Create transformer power");
            transformerTemplate = new TransformerPower();
            transformerTemplate.CreateTransformer();

            Console.WriteLine("Create transformer distribution");
            transformerTemplate = new TransformerDistribution();
            transformerTemplate.CreateTransformer();

            Console.WriteLine("Create transformer pump");
            transformerTemplate = new TransformerPump();
            transformerTemplate.CreateTransformer();

            Console.ReadLine();
        }
    }
}
