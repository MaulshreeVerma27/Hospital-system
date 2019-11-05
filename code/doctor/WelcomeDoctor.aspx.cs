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
    
    public partial class WelcomeDoctor : System.Web.UI.Page
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
                    c.cmd.CommandText = "Select * from Doctor1 where DoctorID='" + Session["user"].ToString() + "'";
                    c.ds.Clear();
                    c.adp.Fill(c.ds, "vt");
                    Label1.Text = c.ds.Tables["vt"].Rows[0]["DoctorID"].ToString();

                    
                }

                BindDropDownList();
            }
            //unit test for apply for leave
            WelcomeDoctorUnittest wd = new WelcomeDoctorUnittest();
            Response.Write(wd.docid);
            Response.Write(wd.startdate);
            Response.Write(wd.starttime);
            Response.Write(wd.enddate);
            Response.Write(wd.endtime);
            Response.Write(wd.imagepath);
            //unit test ends

        }

        private void BindDropDownList()
        {

            DataTable dt = new DataTable();
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Loginpage2.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Docapp.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            RadioButtonList1.Visible = true;
            Label2.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePageDoc.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Loginpage2.aspx");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str= RadioButtonList1.SelectedItem.ToString();
            if (str.Equals("Half Day")==true)
            {
                Calendar1.Visible = true;
                Label3.Text = "Select the day for half day";
                DropDownList2.Visible = true;
                Label7.Visible = true;
                Button8.Visible = true;
                Label3.Visible = false;
                Label6.Visible = false;
                Calendar2.Visible = false;
            }
            else if (str.Equals("1 Day") == true)
            {
                Calendar1.Visible = true;
                Label3.Text = "Select the day for Leave day";
                Button8.Visible = true;
                DropDownList2.Visible = false;
                Label7.Visible = false;
                Label6.Visible = false;
                Calendar2.Visible = false;
            }
            else if (str.Equals("Greater than 1") == true)
            {
                Label3.Visible = true;
                Label6.Visible = true;
                Label3.Text = "Select the start day for leave";
                Label6.Text = "Select the end day for leave";
                Calendar1.Visible = true;
                Calendar2.Visible = true;
                DropDownList2.Visible = false;
                Label7.Visible = false;
                Button8.Visible = true;
            }
            else
            {
                Label3.Text = "Please select an option for leave type";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
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

                c.cmd.CommandText = "select * from Prescription";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                c.dr = c.ds.Tables["vt"].NewRow();
                c.dr["DocId"] = Session["user"].ToString();
                c.dr["Day"] = DateTime.Now;
                c.dr["Ptid"] = DropDownList1.SelectedValue;



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
                Label5.Text = "Prescription Uploaded successfully";
            }

            catch (Exception m)
            {
                Label1.Text = m.ToString();

            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
            TextBox1.Visible = true;
            Label3.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
            Calendar2.Visible = false;
            TextBox2.Visible = true;
            //Label3.Visible = false;
            Label6.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int seconds = 0;
           TimeSpan a=TimeSpan.FromSeconds(seconds);
            DateTime d1;
            DateTime d2;
            string tm = "";
            string tm1 = "";
            //checking that the end leave date should be greater than start leave date
            d1 = Convert.ToDateTime(TextBox1.Text);
            //if more than one number of leave days
            if (TextBox2.Text.ToString() != null)
            {
                d2 = Convert.ToDateTime(TextBox2.Text);
                a = d2-d1;
            }
            //If leave dates are correct.
            if(a.Days>=0)
            {
                try
                {
                    c.cmd.CommandText = "select * from DocLeaves";
                    c.ds.Clear();
                    c.adp.Fill(c.ds, "vt");
                    c.dr = c.ds.Tables["vt"].NewRow();
                    c.dr["DocId"] = Session["user"].ToString();
                    c.dr["start date"] = TextBox1.Text.ToString();
                    c.dr["end date"] = TextBox2.Text.ToString();
                    if (DropDownList2.SelectedValue.Equals("8am-12pm") == true)
                    {
                        tm = "8:00:00 am";
                        tm1 = "12:00:00 pm";
                    }
                    else if (DropDownList2.SelectedValue.Equals("1pm-5pm") == true)
                    {
                        tm = "1:00:00 pm";
                        tm1 = "5:00:00 pm";
                    }
                    else
                    {
                        tm = "";
                        tm1 = "";
                    }
                    c.dr["starttime"] = tm;
                    c.dr["endtime"] = tm1;
                    c.dr["isdeleted"] = 0;
                    c.ds.Tables["vt"].Rows.Add(c.dr);
                    c.scb.DataAdapter = c.adp;
                    c.adp.Update(c.ds.Tables["vt"]);
                    //Label2.Text = str;
                    //Label3.Text = str1;
                    
                    Label5.Text = "Leave Submitted Successfully";
                    Button8.Visible = false;
                    DropDownList2.Visible = false;
                    TextBox1.Visible = false;
                    TextBox2.Visible = false;
                    Label6.Visible = false;
                }
                catch (Exception m)
                {
                    Label3.Text = m.ToString();

                }
                
            }
            else
            {
                Label5.Text = "Leave start date is greater than leave end date. Invalid dates";
                Calendar1.Visible = true;
                Calendar2.Visible = true;
                Label6.Visible = true;
                Label3.Visible = true;
            }
            
            //making all the controls invisible
            
        }
    }
}