using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace HospitalSystem.App_Code
{
    public class Class1
    {
        public DataSet ds = new DataSet();
        public SqlDataAdapter adp = new SqlDataAdapter();
        public DataRow dr;
        public SqlCommandBuilder scb = new SqlCommandBuilder();
        public SqlDataReader drr;
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection con = new SqlConnection();
        public Class1()
        {
            adp.SelectCommand = cmd;
            cmd.Connection = con;
           // con.ConnectionString = @"Data Source=LAPTOP-PE1NJBJG\SQLEXPRESS;Database=hospital management system;User ID=LAPTOP-PE1NJBJG\MANOJ REDDY";
            con.ConnectionString = @"Data Source=LAPTOP-PE1NJBJG\SQLEXPRESS;Database=hospital management system;User ID=se;Password=Pass@123";
        }
        /* public string autoid(string id, string q)
         {
             cmd.CommandText = q;
             ds.Clear();
             ad.Fill(ds, "vt");
             return id + Convert.ToString(ds.Tables["vt"].Rows.Count + 1);
         }
         */

    }
}