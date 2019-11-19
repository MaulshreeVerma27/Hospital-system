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
    public partial class rating : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownList();
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("Loginpage2.aspx");
                }
            }
        }

        private void BindDropDownList()
        {

            //DataTable dt = new DataTable();
            string com = "Select [DoctorID] + '-' + [FirstName] + '-' + [LastName] + '-' + [speciality] as Doctors, DoctorID as DoctorID from Doctor1 where Doctor1.DoctorID IN (select DocID from Appointments where Appointments.PID = '" + Session["user"].ToString()+ "' and IsAccepted = 1 ) ";
            SqlDataAdapter adpt = new SqlDataAdapter(com, c.con);

            c.ds.Clear();
            DataSet dt = new DataSet();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "Doctors";
            
            DropDownList1.DataValueField = "DoctorID";
            DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, new ListItem("----Select Doctor----", "0"));
           
        }
        protected void Rating1_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            lbl_rating.Text = Rating1.CurrentRating.ToString();
             
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Rating1.CurrentRating.ToString();
                int rate = Convert.ToInt32(str);
                //int rate = Convert.ToInt32(str.Trim());
                //string user = Session["user"].ToString();
                //string str = autoid();
                //string str1 = RandomString();
                c.cmd.CommandText = "select * from Rating";
                c.ds.Clear();
                c.adp.Fill(c.ds, "vt");
                c.dr = c.ds.Tables["vt"].NewRow();
                //c.dr["username"] = usernameTextBox.Text.Trim();
                c.dr["Star"] = rate;
                //c.dr["PID"] = user;
                c.dr["Reviews"] = TextBox1.Text.Trim();
                c.dr["PtId"] = Session["user"].ToString();
                
                c.dr["Timing"] = DateTime.Now;
                //c.dr["Time"] = Convert.ToInt32(TextBox3.Text.Trim());
                c.dr["DocId"] = DropDownList1.SelectedValue.ToString();
                
               


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
                lbl_msg.Text = "Rating submitted successfully";
            }

            catch (Exception m)
            {
                lbl_msg.Text = m.ToString();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WelcomePatient.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}