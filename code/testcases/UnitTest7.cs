using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest7
    {
        //unit test for create new appointment by front desk user
        [TestMethod]
        public void TestMethod1()
        {
            //unit test when docid is not selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("", ob.docid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //unit test when docid is selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //unit test when patient is not selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("", ob.patientid);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //unit test when patient is  selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //unit test when fdu is empty
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("", ob.fduid);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //unit test when fdu is selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //unit test when date is not selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("", ob.date);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //unit test when date is not in correct format
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("11-30-2019", ob.date);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //unit test when date is in correct format
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //unit test when time is not selected
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("", ob.time);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //unit test when time is not in correct format
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00:00", ob.time);
        }

        [TestMethod]
        public void TestMethod12()
        {
            //unit test when time is in correct format
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
        }


        [TestMethod]
        public void TestMethod13()
        {
            //unit test when is deleted is false and is accepted and istreated is false 
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(false, ob.isdeleted);
            Assert.AreEqual(false, ob.isaccepted);
            Assert.AreEqual(false, ob.istreated);


        }

        [TestMethod]
        public void TestMethod14()
        {
            //unit test when isaccepted is false and is deleted is true and istreated is false
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(true, ob.isdeleted);
            Assert.AreEqual(false, ob.isaccepted);
            Assert.AreEqual(false, ob.istreated);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //unit test when isaccepted is false and is deleted is false and istreated is true
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(false, ob.isdeleted);
            Assert.AreEqual(false, ob.isaccepted);
            Assert.AreEqual(true, ob.istreated);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //unit test when isaccepted is false and is deleted is true and istreated is true
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(true, ob.isdeleted);
            Assert.AreEqual(false, ob.isaccepted);
            Assert.AreEqual(true, ob.istreated);
        }
        [TestMethod]
        public void TestMethod17()
        {
            //unit test when isaccepted is true and is deleted is true and istreated is false
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(true, ob.isdeleted);
            Assert.AreEqual(true, ob.isaccepted);
            Assert.AreEqual(false, ob.istreated);
        }

        [TestMethod]
        public void TestMethod18()
        {
            //unit test when isaccepted is true and is deleted is false and istreated is true
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(false, ob.isdeleted);
            Assert.AreEqual(true, ob.isaccepted);
            Assert.AreEqual(true, ob.istreated);
        }

        [TestMethod]
        public void TestMethod19()
        {
            //unit test when isaccepted is true and is deleted is true and istreated is true
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(true, ob.isdeleted);
            Assert.AreEqual(true, ob.isaccepted);
            Assert.AreEqual(true, ob.istreated);
        }

        [TestMethod]
        public void TestMethod20()
        {
            //unit test when isaccepted is true and is deleted is false and istreated is false
            AppointmentUnittest ob = new AppointmentUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt2", ob.patientid);
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("30/11/2019", ob.date);
            Assert.AreEqual("9:00 am", ob.time);
            Assert.AreEqual(false, ob.isdeleted);
            Assert.AreEqual(true, ob.isaccepted);
            Assert.AreEqual(false, ob.istreated);
        }
    }
}
