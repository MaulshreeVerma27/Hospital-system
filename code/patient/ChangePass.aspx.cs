using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalSystem.App_Code;
namespace HospitalSystem
{
    public partial class ChangePass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //unit test
            ChangePassUnittest cp = new ChangePassUnittest();
            Response.Write(cp.oldpswd);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            
            
            string pass1 = "";
            string pass2 = "";
            string str = Session["user"].ToString();

            if (Equals(str.Substring(0, 1), "d") == true)
            {

                c.cmd.CommandText = "Select * from Doctor1 where DoctorID='" + str + "' and pswd='" + TextBox2.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label5.Text = "Old Password Incorrect. Try Again!";
                }
                else
                {
                    //Session["user"] = loginTextBox.Text;
                    //Response.Redirect("WelcomeDoctor.aspx");
                    pass1 = TextBox3.Text.Trim();
                    pass2 = TextBox4.Text.Trim();
                    if(Equals(pass1,pass2)==true)
                    {
                        c.dr = c.ds.Tables["vt"].Rows[0];
                        c.dr["pswd"] = TextBox3.Text.Trim();
                        c.scb.DataAdapter = c.adp;
                        c.adp.Update(c.ds.Tables["vt"]);
                        Label5.Text = "Password Updated Successfully";
                    }
                    else
                    {
                        Label5.Text = "Passwords do not match";
                    }
                }
                //c.ds.Clear();
                //c.adp.Fill(c.ds, "vt");

            }
            else if (Equals(str.Substring(0, 1), "p") == true)
            {
                c.cmd.CommandText = "Select * from Patient1 where PatientID='" + str + "' and pswd='" + TextBox2.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label5.Text = "Old Password Incorrect. Try Again!";
                }
                else
                {
                    //Response.Redirect("WelcomeDoctor.aspx");
                    pass1 = TextBox3.Text.Trim();
                    pass2 = TextBox4.Text.Trim();
                    if (Equals(pass1, pass2) == true)
                    {
                        c.dr = c.ds.Tables["vt"].Rows[0];
                        c.dr["pswd"] = TextBox3.Text.Trim();
                        c.scb.DataAdapter = c.adp;
                        c.adp.Update(c.ds.Tables["vt"]);
                        Label5.Text = "Password Updated Successfully";
                    }
                    else
                    {
                        Label5.Text = "Passwords do not match";
                    }
                }
            }
            else if (Equals(str.Substring(0, 1), "e") == true)
            {
                c.cmd.CommandText = "Select * from Persons where EmployeeID='" + str + "' and pswd='" + TextBox2.Text + "'";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                if (c.ds.Tables["vt"].Rows.Count == 0)
                {
                    Label5.Text = "Old Password Incorrect! Try again";
                }
                else
                {
                    //Response.Redirect("WelcomeDoctor.aspx");
                    pass1 = TextBox3.Text.Trim();
                    pass2 = TextBox4.Text.Trim();
                    if (Equals(pass1, pass2) == true)
                    {
                        c.dr = c.ds.Tables["vt"].Rows[0];
                        c.dr["pswd"] = TextBox3.Text.Trim();
                        c.scb.DataAdapter = c.adp;
                        c.adp.Update(c.ds.Tables["vt"]);
                        Label5.Text = "Password Updated Successfully";
                    }
                    else
                    {
                        Label5.Text = "Passwords do not match";
                    }
                }
            }
            else
            {
                Label5.Text = "Invalid Userid";
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = Session["user"].ToString();
            if (Equals(str.Substring(0, 1), "d") == true)
            {
                Response.Redirect("WelcomeDoctor.aspx");
            }
            else if (Equals(str.Substring(0, 1), "p") == true)
            {
                Response.Redirect("WelcomePatient.aspx");
            }
            else
            {
                Response.Redirect("WelcomeEmployee.aspx");
            }

                
        }
    }
}