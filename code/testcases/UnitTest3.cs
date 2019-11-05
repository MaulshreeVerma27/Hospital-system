using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChangePassUnittest ob = new ChangePassUnittest();
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual("abcde1234",ob.oldpswd);
            
          

        }

        [TestMethod]
        public void TestMethod2()
        {
            ChangePassUnittest ob = new ChangePassUnittest();
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual("abcde1234", ob.oldpswd);
            Assert.AreEqual("1234",ob.newpswd);
            Assert.AreEqual("1234",ob.cnfrmpswd);



        }
        [TestMethod]
        public void TestMethod3()
        {
            ChangePassUnittest ob = new ChangePassUnittest();
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual("abcde1234", ob.oldpswd);
            Assert.AreEqual("1234", ob.newpswd);
            Assert.AreEqual("1234", ob.cnfrmpswd);



        }
    }
}
