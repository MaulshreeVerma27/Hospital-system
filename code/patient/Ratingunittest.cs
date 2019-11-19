using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem
{
    public class Ratingunittest
    {
        public string docid;
        public string patientid;
        public int rating;

        public Ratingunittest()
        {
            this.patientid = "pt10";
            this.docid = "doc1";
            this.rating = 3;
        }
    }
}