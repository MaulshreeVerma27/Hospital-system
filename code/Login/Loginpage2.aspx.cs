using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalSystem.App_Code;

namespace HospitalSystem
{
    public partial class Loginpage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            string str = loginTextBox.Text.Trim();
            Label2.Text = str.Substring(0, 1);
            if (Equals(str.Substring(0,1),"d")==true)
                {

                c.cmd.CommandText = "Select * from Doctor1 where DoctorID='" + loginTextBox.Text + "' and pswd='" + passTextBox.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label1.Text = "Username or Password does not exist! Try again";
                }
                else
                {
                    Session["user"] = loginTextBox.Text;
                    Response.Redirect("WelcomeDoctor.aspx");
                }
                //c.ds.Clear();
                //c.adp.Fill(c.ds, "vt");

            }
            else if(Equals(str.Substring(0, 1),"p")==true)
            {
                c.cmd.CommandText = "Select * from Patient1 where PatientID='" + loginTextBox.Text + "' and pswd='" + passTextBox.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label1.Text = "Username or Password does not exist! Try again";
                }
                else
                {
                    Session["user"] = loginTextBox.Text;
                    Response.Redirect("WelcomePatient.aspx");
                }
            }
            else if (Equals(str.Substring(0, 1),"e")==true)
            {
                c.cmd.CommandText = "Select * from Persons where EmployeeID='" + loginTextBox.Text + "' and pswd='" + passTextBox.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label1.Text = "Username or Password does not exist! Try again";
                }
                else
                {
                    Session["user"] = loginTextBox.Text;
                    Response.Redirect("WelcomeEmp.aspx");
                }
            }

            else if (Equals(str.Substring(0, 1), "a") == true)
            {
                c.cmd.CommandText = "Select * from tableadmin where Adminid='" + loginTextBox.Text + "' and password='" + passTextBox.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label1.Text = "Username or Password does not exist! Try again";
                }
                else
                {
                    Session["user"] = loginTextBox.Text;
                    Response.Redirect("WelcomeEmp.aspx");
                }
            }

            else
            {
                Label1.Text = "Invalid Userid";
            }
            

            /*if (c.ds.Tables["vt"].Rows.Count > 0)
            {
                Class2.username = textBox1.Text.Trim().ToUpper();
                //this.Hide();
                MDIParent1 window = new MDIParent1();
                window.Show();

            }
            else
            {
                label1.Text = "Login Failed";
            }
            */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}