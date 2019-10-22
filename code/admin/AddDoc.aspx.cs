using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using HospitalSystem.App_Code;

namespace Hospitalsystem
{
    
    public partial class AddDoc : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                autoid();
            }

        }

        public string RandomString()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 10; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public string autoid()
        {
            string did = "doc";
            string doctid;
            int n;
            // c.cmd2.CommandText = "select max(Convert(int,substring(" + column + "," + Convert.ToInt32(text.Length + 1) + ",len(" + column + ")))) from " + table;
            //c.cmd2.CommandText = "Select max(ID) from Patient";
           // SqlCommand cmd = new SqlCommand("Select max(ID) from Doctor", c.con);
            c.cmd.CommandText = "Select max(ID) from Doctor1";
            c.con.Open();
            if (c.cmd.ExecuteScalar() == DBNull.Value)
            {
                n = 1;
            }
            else
            {
                n = Convert.ToInt32(c.cmd.ExecuteScalar());
                n = n + 1;
            }
            c.con.Close();

            doctid = did + n.ToString();
            return doctid;
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string str = autoid();
                string str1 = RandomString();
                c.cmd.CommandText = "select * from Doctor1";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                c.dr = c.ds.Tables["vt"].NewRow();
                //c.dr["username"] = usernameTextBox.Text.Trim();
                c.dr["pswd"] = str1;
                c.dr["LastName"] = TextBox2.Text.Trim();
                c.dr["FirstName"] = nameTxt.Text.Trim();
                c.dr["phoneno"] = mobileTxt.Text.Trim();
                c.dr["Age"] = Convert.ToInt32(TextBox3.Text.Trim());
                c.dr["DoctorID"] = str;
                //c.dr["emailid"] = emailTxt.Text.Trim();
                c.dr["speciality"] = spList.SelectedValue;
                c.dr["experience"] = TextBox4.Text.Trim();
                //c.dr["ans"] = yourAnsTxt.Text;
                c.dr["Gender"] = RadioButtonList1.SelectedItem.ToString();
                c.dr["joiningdate"] = DateTime.Now;
                c.dr["Addrs"] = addressTxt.Text.Trim();


                /*if (FileUpload1.HasFile)
                {
                    string p = "~/image/" + FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath(p));
                    c.dr["pic"] = p;

                }*/
                c.ds.Tables["vt"].Rows.Add(c.dr);

                c.scb.DataAdapter = c.adp;
                c.adp.Update(c.ds.Tables["vt"]);
                Label2.Text = str;
                Label3.Text = str1;
                Label1.Text = "Registration Successful";
            }

            catch(Exception m)
            {
                Label1.Text = m.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");

        }

        protected void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
