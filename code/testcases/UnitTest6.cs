using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            //when doctor id is not selected
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("", ob.docid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //when doctor id is selected
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("doc1", ob.docid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //when  patient id is null
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("", ob.patientid);

        }
        [TestMethod]
        public void TestMethod4()
        {
            //when  patient id is selected
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt10", ob.patientid);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //when  rating is greater than 5
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual(6, ob.rating);

        }

        [TestMethod]
        public void TestMethod6()
        {
            //when no rating is given
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual(0 , ob.rating);

        }

        [TestMethod]
        public void TestMethod7()
        {
            //when  rating is greater than 5
            Ratingunittest ob = new Ratingunittest();
            Assert.AreEqual("doc1", ob.docid);
            Assert.AreEqual("pt10", ob.patientid);
            Assert.AreEqual(3, ob.rating);

        }
    }
}
