using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class mission : Military
    {
        public virtual void AirborneOp()
        {
            Console.WriteLine("The mision is an Airborne Operation.");
        }

        public void HostageRescue()
        {
            Console.WriteLine("The mision is a Hostage Rescue.");
        }

        public void Resupply()
        {
            Console.WriteLine("The mision is a Resupply Mission.");
        }

        public void Medivac()
        {
            Console.WriteLine("The mision is to Medvaic Wounded Soliders.");
        }

        public override void Fought()
        {
            Console.WriteLine("You fought and completed the mission.");
        }
    }
}
