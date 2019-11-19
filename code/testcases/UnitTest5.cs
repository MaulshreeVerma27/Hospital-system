using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        //Unit test for Login functionality
        [TestMethod]
        public void TestMethod1()
        {
            //unit test when userid field is empty
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("", ob.docid);
            Assert.AreEqual("zxcvb", ob.docpswd);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            //unit test when password field is empty
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("", ob.docpswd);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //unit test when both fields is empty
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("", ob.docpswd);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //unit test when invalid userid
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("xyz", ob.docid);
            Assert.AreEqual("zxcvb", ob.docpswd);
        }

        ////unit test when invalid password for doctor
        [TestMethod]
        public void TestMethod5()
        {
            //unit test when invalid userid
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("zxcvn", ob.docpswd);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //unit test with correct doctor credentials
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("zxcvb", ob.docpswd);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //unit test with incorrect admin id
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("admin1234", ob.adminid);
            Assert.AreEqual("passwordqwerty", ob.adminpswd);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //unit test with correct admin id but incorrect password
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("admin123", ob.adminid);
            Assert.AreEqual("passwordqwert", ob.adminpswd);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //unit test with correct admin id and password
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("admin123", ob.adminid);
            Assert.AreEqual("passwordqwerty", ob.adminpswd);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //unit test with incorrect employeeid
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("emp2", ob.fduid);
            Assert.AreEqual("abcde", ob.fdupswd);
        }

        [TestMethod]
        public void TestMethod11()
        {
            //unit test with correct fdu id but incorrect password
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("emp1", ob.fduid);
            Assert.AreEqual("abcdef", ob.fdupswd);
        }

        [TestMethod]
        public void TestMethod12()
        {
            //unit test with correct fdu id and  password
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("emp1", ob.fduid);
            Assert.AreEqual("abcde", ob.fdupswd);
        }

        [TestMethod]
        public void TestMethod13()
        {
            //unit test with incorrect patient id  
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("pt1", ob.patientid);
            Assert.AreEqual("1234", ob.ptpswd);
        }

        [TestMethod]
        public void TestMethod14()
        {
            //unit test with correct patient id and incorrect password
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual("12345", ob.ptpswd);
        }

        [TestMethod]
        public void TestMethod15()
        {
            //unit test with correct patient id and correct password
            LoginUnittest ob = new LoginUnittest();
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual("1234", ob.ptpswd);
        }
    }
}
