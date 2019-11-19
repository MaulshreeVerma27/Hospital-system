using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalSystem.App_Code;
using System.Data;
using System.Data.SqlClient;

namespace HospitalSystem
{
    public partial class Viewourdoctors : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

            BindDropDownList();
        }
        private void BindDropDownList()
        {

            DataTable dt = new DataTable();
        }
        

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Label2.Visible = true;
            DropDownList2.Visible = true;
            string com = "Select [DoctorID] + '-' + [FirstName] + '-' + [LastName] as Doctors, DoctorID as DoctorID from Doctor1  where speciality = '" + DropDownList1.SelectedValue + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(com, c.con);
            c.ds.Clear();
            DataSet dt = new DataSet();
            adpt.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
            DropDownList2.DataTextField = "Doctors";
            DropDownList2.DataValueField = "DoctorID";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("----Select Doctors----", "0"));
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            string str = DropDownList2.SelectedValue.ToString();
            SqlCommand cmd2 = new SqlCommand("Select * from Rating where DocId = '" + str + "' ", c.con);
            SqlDataAdapter adp2 = new SqlDataAdapter();
            adp2.SelectCommand = cmd2;
            using (DataTable dt1 = new DataTable())
            {
                adp2.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
            }
            c.con.Close();
            
        }
    }
}