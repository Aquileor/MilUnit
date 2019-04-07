using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Personnel : Military
    {
        public void Infantry()
        {
            Console.WriteLine("You are an Inafantry Squad.");
        }

        public void Intel()
        {
            Console.WriteLine("You are an Intel Pesronal.");
        }
        public void Medics()
        {
            Console.WriteLine("You are a Doctor.");
        }
        public void Supply()
        {
            Console.WriteLine("You are a Supply NCO.");
        }

        
        public override void Fought()
        {
            Console.WriteLine("You fought and did not resuce the hostages.");
        }
    }
}
