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
    public partial class WelcomeEmp : System.Web.UI.Page
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
                    c.cmd.CommandText = "Select * from Persons where EmployeeID='" + Session["user"].ToString() + "'";
                    c.ds.Clear();
                    c.adp.Fill(c.ds, "vt");
                    Label1.Text = c.ds.Tables["vt"].Rows[0]["EmployeeID"].ToString();


                }

            }
            //Unit testing
            WelcomeEmployeeUnittest we = new WelcomeEmployeeUnittest();
                 
            Response.Write(we.imagepath);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("appointmentrequests.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Loginpage2.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeP.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            DropDownList1.Visible = true;
            FileUpload1.Visible = true;
            Button7.Visible = true;
            string com = "select PatientID from Patient1";
            SqlDataAdapter adpt = new SqlDataAdapter(com, c.con);

            c.ds.Clear();
            DataSet dt = new DataSet();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "PatientID";
            DropDownList1.DataValueField = "PatientID";
            DropDownList1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {

                c.cmd.CommandText = "select * from Receipt";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                c.dr = c.ds.Tables["vt"].NewRow();
                c.dr["EmployeeId"] = Session["user"].ToString();
                c.dr["Day"] = DateTime.Now;
                c.dr["PatientID"] = DropDownList1.SelectedValue;



                if (FileUpload1.HasFile)
                {
                    string p = "~/images/" + FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath(p));
                    c.dr["Image"] = p;

                }
                c.ds.Tables["vt"].Rows.Add(c.dr);

                c.scb.DataAdapter = c.adp;
                c.adp.Update(c.ds.Tables["vt"]);
                //Label2.Text = str;
                //Label3.Text = str1;
                Label5.Text = "Receipt Uploaded successfully";
            }

            catch (Exception m)
            {
                Label1.Text = m.ToString();

            }
        }
    }
}