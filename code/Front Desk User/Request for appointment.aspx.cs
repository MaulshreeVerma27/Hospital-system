using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalSystem.App_Code;
using System.Data;
using System.Data.SqlClient;
namespace Hospitalsystem
{
    public partial class Request_for_appointment : System.Web.UI.Page
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
                c.dr["PID"] = Session["user"].ToString();
                string Date1 = TextBox1.Text.Trim();
                string Time1 = TextBox2.Text.Trim();
                DateTime result = DateTime.Parse(Date1 + " " + Time1);
                c.dr["starttime"] = result;
                //c.dr["Time"] = Convert.ToInt32(TextBox3.Text.Trim());
                c.dr["DocID"] = DropDownList2.SelectedValue;
                //c.dr["emailid"] = emailTxt.Text.Trim();
                //c.dr["speciality"] = spList.SelectedValue;
                //c.dr["experience"] = TextBox4.Text.Trim();
                //c.dr["ans"] = yourAnsTxt.Text;
                //c.dr["Gender"] = RadioButtonList1.SelectedItem.ToString();
                //c.dr["joiningdate"] = DateTime.Now;
                //c.dr["Addrs"] = addressTxt.Text.Trim();


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
                Label1.Text = "Request sent.Plz wait for response";
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
        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WelcomePatient.aspx");
        }
    }
}