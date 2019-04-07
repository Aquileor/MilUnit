using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MilUnitTestProject
{
    [TestClass]
    public class UnitTest1
    { 

        [TestMethod]
        public void TestMethod1()
        {
            Medivac();
            mission.Medivac();
            MilUnitTestProject.mission.Medivac();

            mission Mis = new mission();
            Mis.Medivac();
        }

       
    }
}
