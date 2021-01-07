using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
   public abstract class DataProcessor
    {
        public void FindMakeSell()
        {
            FindRowMaterials();
            MakeTable();
            Buy();
            Notification();
        }
        public abstract void FindRowMaterials();
        public abstract void MakeTable();
        public void Buy()
        {
            Console.WriteLine("Buy the table");
        }
        public void Notification()
        {
            Console.WriteLine("Recived notifiction");
        }
    }
}
