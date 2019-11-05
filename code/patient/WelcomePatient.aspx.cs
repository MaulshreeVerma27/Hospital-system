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
                    Image1.ImageUrl = c.ds.Tables["vt"].Rows[0]["image"].ToString();


                }
                fillDataGrid();
            }
        }

        public void fillDataGrid()
        {
            string str = Session["user"].ToString();
            //Sql command for approved appontments
            SqlCommand cmd = new SqlCommand("Select * from Appointments where IsDeleted = 0 and IsAccepted = 1 and Istreated = 0 and PID = '" + str + "' ", c.con);
            //sql command for pending appointments 
            SqlCommand cmd1 = new SqlCommand("Select * from Appointments where IsDeleted = 0 and IsAccepted = 0 and Istreated = 0 and PID = '" + str + "' ", c.con);
            //sql command for prescriptions
            SqlCommand cmd2 = new SqlCommand("Select * from Prescription where Ptid = '" + str + "' ", c.con);
            //sql command for receipt
            SqlCommand cmd3 = new SqlCommand("Select * from Receipt where PatientID = '" + str + "' ", c.con);


            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr;

            //declaring data adapters for different gridviews
            SqlDataAdapter adp1 = new SqlDataAdapter();
            SqlDataAdapter adp2 = new SqlDataAdapter();
            SqlDataAdapter adp3 = new SqlDataAdapter();
            SqlDataAdapter adp4 = new SqlDataAdapter();

            adp1.SelectCommand = cmd;
            adp2.SelectCommand = cmd1;
            adp3.SelectCommand = cmd2;
            adp4.SelectCommand = cmd3;

            using (DataTable dt = new DataTable())
            {
                adp1.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            using (DataTable dt1 = new DataTable())
            {
                adp2.Fill(dt1);

                GridView2.DataSource = dt1;
                GridView2.DataBind();
            }
            using (DataTable dt2 = new DataTable())
            {
                adp3.Fill(dt2);

                GridView3.DataSource = dt2;
                GridView3.DataBind();
                
            }
            using (DataTable dt3 = new DataTable())
            {
                adp4.Fill(dt3);

                GridView4.DataSource = dt3;
                GridView4.DataBind();

            }
            //adapter = new SqlDataAdapter(cmd);
            //GridView1.DataBind();
            c.con.Close();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView3.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView4.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePass.aspx");
        }
    }
}