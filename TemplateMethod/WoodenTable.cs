using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class WoodenTable:DataProcessor
    {
        
        public override void FindRowMaterials()
        {
            Console.WriteLine("select suitable wood for table");
        }
        public override void MakeTable()
        {
            Console.WriteLine("Send design and give order to produce  wooden table");
        }
        
    }
}
