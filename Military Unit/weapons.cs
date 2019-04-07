using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class weapons : Military
    {
        public void M4()
        {
            Console.WriteLine("Your main weapon is the M4 Rifle.");
        }

        public void M9()
        {
            Console.WriteLine("Your main weapon is the M9 HandGun.");
        }

        public void M240B()
        {
            Console.WriteLine("Your main weapon is the M240B Light Machine Gun.");
        }

        public void TankRound()
        {
            Console.WriteLine("Your main weapon is the Tank Round.");
        }

        public override void Fought()
        {
            Console.WriteLine("You fought and suffered 6 casualties.");
        }
    }
}
