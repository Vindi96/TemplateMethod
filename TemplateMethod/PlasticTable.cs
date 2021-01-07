using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class PlasticTable:DataProcessor
    {
      
        public override void FindRowMaterials()
        {
            Console.WriteLine("Select the correct material of plastic");
        }
        public override void MakeTable()
        {
            Console.WriteLine("Send design and give order to produce plastic table");
        }
      
    }
}
