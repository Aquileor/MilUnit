using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class vehicles : Military
    {
        public void Tank()
        {
            Console.WriteLine("The vehicle you will use is the Abrahams Tank.");
        }

        public void HMWVV()
        {
            Console.WriteLine("The vehicle you will use is the Amored HMWVV.");
        }

        public void FootPatrol()
        {
            Console.WriteLine("You are Patroling on Foot.");
        }

        public void LMTV()
        {
            Console.WriteLine("The vehicle you will use is the LMTV Truck.");
        }

        public override void Fought()
        {
            Console.WriteLine("You fought and you vecichle broke down.");
        }
    }
}
