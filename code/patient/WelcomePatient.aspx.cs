using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalSystem.App_Code;

namespace HospitalSystem
{
    public partial class WelcomePatient : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("Loginpage2.aspx");
                }
                else
                {
                    c.cmd.CommandText = "Select * from Patient1 where PatientID='" + Session["user"].ToString() + "'";
                    c.ds.Clear();
                    c.adp.Fill(c.ds, "vt");
                    Label1.Text = c.ds.Tables["vt"].Rows[0]["PatientID"].ToString();


                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Request for appointment.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Loginpage2.aspx");
        }
    }
}