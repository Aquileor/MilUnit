using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Military
    {
        public void Deploy(string TimeToDeploy)
        {
            Console.WriteLine($"Begin Deployment: {TimeToDeploy}");
        }
        public void ComeHome(string TimeToComeHome)
        {
            Console.WriteLine($"\nTime to come home from Deployment: {TimeToComeHome}");
        }
        public virtual void Fought()
        {
            Console.WriteLine("Default implementation of the Fight method");
        }
    }
}
