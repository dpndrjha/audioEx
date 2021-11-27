using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace audioEx
{
    public partial class Delete : Form
    {
        string Connection = ConfigurationManager.ConnectionStrings["dp"].ConnectionString;
        public Delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idss = FormCrud.newIds;
            SqlConnection con = new SqlConnection(Connection);
            String strr = "delete from Add_New_Customer where ID=@ID";
            SqlCommand cmd = new SqlCommand(strr, con);
            cmd.Parameters.AddWithValue("@ID", idss);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                this.Close();
                MessageBox.Show("Successfully Deleted Data...");
            }
            else
            {
                MessageBox.Show("Not Deleted Data...");
            }

        }
    }
}
