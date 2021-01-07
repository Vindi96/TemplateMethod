using System;

namespace TemplateMethod
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A wood table");
            WoodenTable WT = new WoodenTable();
            WT.FindMakeSell();

            Console.WriteLine();
            Console.WriteLine("A plastic table");
            PlasticTable PT = new PlasticTable();
            PT.FindMakeSell();
           
        }
    }
}
