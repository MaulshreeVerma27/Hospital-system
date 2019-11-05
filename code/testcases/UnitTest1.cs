using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //WelcomeDoctor Unit test for uploading Leaves
            //unit test for testing the format of time
           WelcomeDoctorUnittest ob = new WelcomeDoctorUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("11/27/2019", ob.startdate);
            Assert.AreEqual("12/27/2019", ob.enddate);
            Assert.AreEqual("00:00:00", ob.starttime);
            Assert.AreEqual("00:00:00", ob.endtime);
           // Assert.AreEqual("~/ images / Screenshot(108).png",ob.imagepath);

            




        }
        [TestMethod]
        public void TestMethod2()
        {
            WelcomeDoctorUnittest ob = new WelcomeDoctorUnittest();
            Assert.AreEqual("doc1",ob.doctid);
            Assert.AreEqual("pt1",ob.patientId);
            Assert.AreEqual(Convert.ToDateTime("11-04-2019 01:00:00"), ob.day);
            Assert.AreEqual("~/ images / Screenshot(108).png", ob.imagepath);
        }
    }
}
