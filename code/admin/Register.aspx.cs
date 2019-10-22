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
using System.Data;



namespace HospitalSystem
{

    public partial class Register : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                autoid();
                /*TextBox4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                DropDownList1.Visible = false;
                DropDownList2.Visible = false;
                Calendar1.Visible = false;
               
                DataSet year = new DataSet();
                year.ReadXml(Server.MapPath("~/years.xml"));
                DropDownList1.DataSource = year;
                    DropDownList1.DataTextField = "number";
                DropDownList1.DataValueField = "number";
                DataSet months = new DataSet();
                months.ReadXml(Server.MapPath("~/month.xml"));
                DropDownList2.DataSource = months;
                DropDownList2.DataTextField = "name";
                DropDownList2.DataValueField = "number";*/
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
            string pid = "pt";
            string ptid;
            int n;
            // c.cmd2.CommandText = "select max(Convert(int,substring(" + column + "," + Convert.ToInt32(text.Length + 1) + ",len(" + column + ")))) from " + table;
            //c.cmd2.CommandText = "Select max(ID) from Patient";
            c.cmd.CommandText = "Select max(ID) from Patient1";
           
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
            
            ptid = pid + n.ToString();
            return ptid;
        }
            protected void submitBtn_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd1 = new SqlCommand();
            if (CheckBox1.Checked == true)
            {

                try
                {
                   // int k=0;
                    string str = autoid();
                    string str1 = RandomString();
                    SqlCommand cmd1 = new SqlCommand();
                   // cmd1.CommandText = "Select EmailID from Patient1 where EmailID= '"+ emailTxt +"' ";
                   
                    c.cmd.CommandText = "select * from Patient1";
                    c.ds.Clear();
                    c.adp.Fill(c.ds, "vt");
                    c.dr = c.ds.Tables["vt"].NewRow();
                    //c.dr["username"] = usernameTextBox.Text.Trim();
                    c.dr["pswd"] = str1;
                    c.dr["LastName"] = TextBox2.Text.Trim();
                    c.dr["FirstName"] = nameTxt.Text.Trim();
                    c.dr["phoneno"] = mobileTxt.Text.Trim();
                    c.dr["EmailID"] = emailTxt.Text.Trim();
                    c.dr["Age"] = Convert.ToInt32(TextBox3.Text.Trim());
                    c.dr["PatientID"] = str;
                    c.dr["DOB"] =Convert.ToDateTime(TextBox4.Text.Trim());
                    //c.dr["emailid"] = emailTxt.Text.Trim();
                    //c.dr["sq"] = spList.SelectedValue.Trim();
                   // c.dr["ans"] = yourAnsTxt.Text;
                    c.dr["Gender"] = RadioButtonList1.SelectedItem.ToString();
                    //c.dr["joiningdate"] = DateTime.Now;
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
                    Label3.Text = str;
                    Label4.Text = str1;
                    Label1.Text = "Registration Successful";
                }

                catch (Exception m)
                {
                    Label1.Text = m.ToString();

                }
                 
               

            }

            else
            {
                Label1.Visible = true;
                Label1.Text = "please accept terms and conditions";
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");

        }

      /*  protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

                TextBox4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                Calendar1.Visible = true;
            

            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yr = Convert.ToInt32(DropDownList1.SelectedValue);
            int mnth = Convert.ToInt32(DropDownList2.SelectedValue);
            Calendar1.VisibleDate = new DateTime(yr, mnth, 1);
            Calendar1.SelectedDate= new DateTime(yr, mnth, 1); 

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yr = Convert.ToInt32(DropDownList1.SelectedValue);
            int mnth = Convert.ToInt32(DropDownList2.SelectedValue);
            Calendar1.VisibleDate = new DateTime(yr, mnth, 1);
            Calendar1.SelectedDate = new DateTime(yr, mnth, 1);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar1.SelectedDate.ToShortDateString();
            Label5.Visible = false;
            Label6.Visible = false;
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
        }*/
    }
}