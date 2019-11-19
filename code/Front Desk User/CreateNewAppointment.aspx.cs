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
    public partial class CreateNewAppointment : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownList();
            
        }
        private void BindDropDownList()
        {
            string com = "select PatientID from Patient1";
            SqlDataAdapter adpt = new SqlDataAdapter(com, c.con);

            c.ds.Clear();
            DataSet dt = new DataSet();
            adpt.Fill(dt);
            DropDownList3.DataSource = dt;
            DropDownList3.DataBind();
            DropDownList3.DataTextField = "PatientID";
            DropDownList3.DataValueField = "PatientID";
            DropDownList3.DataBind();
        }

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string user = Session["user"].ToString();
                //string str = autoid();
                //string str1 = RandomString();
                c.cmd.CommandText = "select * from Appointments";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                c.dr = c.ds.Tables["vt"].NewRow();
                //c.dr["username"] = usernameTextBox.Text.Trim();
                // c.dr["Doc_ID"] = str1;
                //c.dr["PID"] = user;
                c.dr["Reason"] = RsnTxt.Text.Trim();
                c.dr["PID"] = DropDownList3.SelectedValue;
                string Date1 = TextBox1.Text.Trim();
                string Time1 = TextBox2.Text.Trim();
                DateTime result = DateTime.Parse(Date1 + " " + Time1);
                c.dr["starttime"] = result;
                c.dr["IsAccepted"] = 1;
                c.dr["DocID"] = DropDownList2.SelectedValue;
                c.dr["ApprovedBy"] = Session["user"].ToString();

                


                /*if (FileUpload1.HasFile)
                {
                    string p = "~/image/" + FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath(p));
                    c.dr["pic"] = p;

                }*/
                c.ds.Tables["vt"].Rows.Add(c.dr);

                c.scb.DataAdapter = c.adp;
                c.adp.Update(c.ds.Tables["vt"]);
                //Label2.Text = str;
                //Label3.Text = str1;
                Label1.Text = "Appointment created successfully.";
            }

            catch (Exception m)
            {
                Label1.Text = m.ToString();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com = "select FirstName,DoctorID from Doctor1 where speciality = '" + DropDownList1.SelectedValue + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(com, c.con);

            c.ds.Clear();
            DataSet dt = new DataSet();
            adpt.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
            DropDownList2.DataTextField = "FirstName";
            DropDownList2.DataValueField = "DoctorID";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("----Select Doctors----", "0"));
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeP.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WelcomeEmp.aspx");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList2.SelectedValue.ToString();
            //display availability of the selected doctor 
            GridView2.Visible = true;
            GridView3.Visible = true;
            SqlCommand cmd1 = new SqlCommand("Select * from Appointments where IsDeleted = 0 and IsAccepted = 1 and Istreated = 0 and DocID = '" + str + "' ", c.con);
            SqlCommand cmd2 = new SqlCommand("Select * from DocLeaves where IsDeleted = 0 and DocId = '" + str + "' ", c.con);
            SqlDataAdapter adp2 = new SqlDataAdapter();
            adp2.SelectCommand = cmd1;

            using (DataTable dt1 = new DataTable())
            {
                adp2.Fill(dt1);
                GridView2.DataSource = dt1;
                GridView2.DataBind();
            }
            SqlDataAdapter adp3 = new SqlDataAdapter();
            adp3.SelectCommand = cmd2;

            using (DataTable dt2 = new DataTable())
            {
                adp3.Fill(dt2);
                GridView3.DataSource = dt2;
                GridView3.DataBind();
            }
            //adapter = new SqlDataAdapter(cmd);
            //GridView1.DataBind();
            //c.con.Close();
            //adapter = new SqlDataAdapter(cmd);
            //GridView1.DataBind();
            c.con.Close();
        }
    }
}
