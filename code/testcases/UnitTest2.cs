using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Checking format of Datetime and folder name
            WelcomeEmployeeUnittest ob = new WelcomeEmployeeUnittest();
            Assert.AreEqual("emp1", ob.Employeeid);
            Assert.AreEqual("pt1", ob.patientId);
            Assert.AreEqual("11-04-2019 01:00:00", ob.day);
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Checking format of Datetime
            WelcomeEmployeeUnittest ob = new WelcomeEmployeeUnittest();
            Assert.AreEqual("emp1", ob.Employeeid);
            Assert.AreEqual("pt1", ob.patientId);
            Assert.AreEqual(Convert.ToDateTime("11-04-2019 01:00:00"), ob.day);
            
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Checking format of Datetime
            WelcomeEmployeeUnittest ob = new WelcomeEmployeeUnittest();
            Assert.AreEqual("emp1", ob.Employeeid);
            Assert.AreEqual("pt1", ob.patientId);
            Assert.AreEqual(Convert.ToDateTime("11-04-2019 01:00:00"), ob.day);
            Assert.AreEqual("~/ images / Screenshot(108).png",ob.imagepath);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Checking format of Datetime
            WelcomeEmployeeUnittest ob = new WelcomeEmployeeUnittest();
            Assert.AreEqual("emp1", ob.Employeeid);
            Assert.AreEqual("pt1", ob.patientId);
            Assert.AreEqual(Convert.ToDateTime("11-04-2019 01:00:00"), ob.day);
            Assert.AreEqual("~/ images / Screenshot(108).png", ob.imagepath2);

        }

    }

}
