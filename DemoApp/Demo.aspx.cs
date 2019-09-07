/*
Just adding comments for TP. 
Another one. 
Second one.
 
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace DemoApp
{
    public partial class Demo : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=demo;User Id=root;password=''");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Gender_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(Empid.Text + "</br>");
            Response.Write(txtName.Text + "</br>");

            Response.Write(lstLocation.SelectedItem.Text + "</br>");
            if (chkASP.Checked)
            {
                Response.Write(chkASP.Text + "</br>");
            }
            if (chkC.Checked)
            {
                Response.Write(chkC.Text + "</br>");
            }
            lblTech.Visible = false;
            lbllistbox.Visible = false;
            lblName.Visible = false;
            txtName.Visible = false;
            lstLocation.Visible = false;
            chkC.Visible = false;
            chkASP.Visible = false;
            //rdFemale.Visible = false;
            btnShow.Visible = false;
        }
        protected void Insert(object sender, EventArgs e)
        {
            String tech="";
            if (chkASP.Checked)
            {
                //Response.Write(chkASP.Text + "</br>");
                //String asp = chkASP.Text;
                tech += chkASP.Text;
            }
            if (chkC.Checked)
            {
                tech += ","+chkC.Text;
                //Response.Write(chkC.Text + "</br>");
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO demoapp values('"+Empid.Text+"','"+txtName.Text+"','"+lstLocation.SelectedItem.Text+"','"+tech+"')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void Delete(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from demoapp where Id='"+Empid.Text+"';";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void Update(object sender, EventArgs e)
        {
            String tech = "";
            if (chkASP.Checked)
            {
                //Response.Write(chkASP.Text + "</br>");
                //String asp = chkASP.Text;
                tech += chkASP.Text;
            }
            if (chkC.Checked)
            {
                tech += "," + chkC.Text;
                //Response.Write(chkC.Text + "</br>");
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update demoapp set Name='"+txtName.Text+"', City='"+lstLocation.Text+"',Technology='"+tech+"' where Id='"+Empid.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void ShowRecord(object sender, EventArgs e)
        {
            form1.Visible = false;
            /*Id.Visible = false;
            Empid.Visible = false;
            lblTech.Visible = false;
            lbllistbox.Visible = false;
            lblName.Visible = false;
            txtName.Visible = false;
            lstLocation.Visible = false;
            chkC.Visible = false;
            chkASP.Visible = false;
            btnShow.Visible = false;*/
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from demoapp where Id='" + Empid.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}