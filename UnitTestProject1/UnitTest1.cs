using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    class Military
        {
            [TestMethod]
            public void Deploy(string TimeToDeploy)
            {
                Console.WriteLine($"Begin Deployment: {TimeToDeploy}");
            }
            [TestMethod]
            public void ComeHome(string TimeToComeHome)
            {
                Console.WriteLine($"\nTime to come home from Deployment: {TimeToComeHome}");
            }
            [TestMethod]
            public virtual void Fought()
            {
                Console.WriteLine("Default implementation of the Fight method");
            }
        }

    }

