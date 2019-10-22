using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalSystem.App_Code;
namespace HospitalSystem
{
    public partial class Docapp : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillDataGrid();
            }

        }
        public void fillDataGrid()
        {
            SqlCommand cmd = new SqlCommand("Select * from Appointments where IsDeleted = 0 and IsAccepted = 1 and Istreated = 0 and DocID='" + Session["user"].ToString() + "'", c.con);


            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr;
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;

            using (DataTable dt = new DataTable())
            {
                adp1.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            //adapter = new SqlDataAdapter(cmd);
            //GridView1.DataBind();
            c.con.Close();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            fillDataGrid();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // int index = Convert.ToInt32(e.RowIndex);
            //SqlCommand cmd2 = new SqlCommand("Update table Appointments set IsDeleted=1 where e.  ");
            //c.con.Close();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int rowno = Convert.ToInt32(e.CommandArgument);

                try
                {
                    string ID = GridView1.Rows[rowno].Cells[0].Text.ToString();
                    //c.con = new SqlConnection(myconnectionString);
                    c.cmd = new SqlCommand("Update Appointments set IsDeleted = 1 where ID='" + ID + "'", c.con);
                    c.con.Open();
                    c.cmd.ExecuteNonQuery();
                    c.con.Close();
                    Label1.Text = "Deleted Successfully.";
                    fillDataGrid();
                }
                catch (Exception ex)
                {

                    Label1.Text = ex.Message.ToString();
                    fillDataGrid();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {

                CheckBox status = (row.Cells[3].FindControl("CheckBox1") as CheckBox);
                //string ID = GridView1.Rows[rowno].Cells[0].Text.ToString();
                int ID = Convert.ToInt32(row.Cells[0].Text.ToString());
                if (status.Checked)
                {
                    updaterow(ID, 1);
                }
                else
                {
                    updaterow(ID, 0);

                }
            }
            Label1.Text = "Appointments have Been completed Successfully";
        }

        private void updaterow(int applicationid, int approval)
        {
            //String mycon = "Data Source=HP-PC\\SQLEXPRESS; Initial Catalog=LeaveApplication; Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand("Update Appointments set IsTreated='" + approval + "'  where ID=" + applicationid, c.con);
            //c.con = new SqlConnection(c.c);
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd1.CommandText = updatedata;
            //cmd.Connection = con;
            c.con.Open();
            cmd1.ExecuteNonQuery();
            c.con.Close();
            Label1.Text = "Approved Successfully.";
            fillDataGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePageDoc.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WelcomeDoctor.aspx");
        }


        /*protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[0].Text;
                foreach (Button button in e.Row.Cells[2].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
        }/*

       

        

        /*protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/
    }
}
