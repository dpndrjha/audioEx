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
    public partial class FormCrud : Form
    {
        public static int ids;
        public static int newIds;
        string Connection = ConfigurationManager.ConnectionStrings["dp"].ConnectionString;
        public static string Salutation = "", First_Name = "", Last_Name = "", Address = "", Locality_Area = "", Mobile = "", Email = "", Telephone = "", DnD_Status = "", Customer_Group = "", Memo = "", Referred_By = "", Relationship = "", Gender = "", Date_Of_Birth = "", Merital_Status = "", Date_Of_Anniversory = "", Company_Name = "", GST_Classification = "", GSTIN_UIN_No = "", Effective_Date = "", Tax_Identification_No = "", Effective_Date2 = "", Privileged_Customer = "", Privilege_Status = "", Issue_Date = "", Folio_No = "", Expired_Date = "", Loyality_Discount = "";
            
        private void BtnFind_Click(object sender, EventArgs e)
        {
            SearchText();
        }

        private void SearchItem_Enter(object sender, EventArgs e)
        {
            SearchText();
        }

        private void SearchItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SearchText();
        }

        private void FormCrud_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchItem_TextChanged(object sender, EventArgs e)
        {
            SearchText();
        }


        public void SearchText()
        {
            SqlConnection con = new SqlConnection(Connection);
            string str = "select * from Add_New_Customer where First_Name like @First_Name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(str,con);
            sda.SelectCommand.Parameters.AddWithValue("@First_Name", SearchItem.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
            dataGridView1.DataSource = dt;
            }
            else 
            {
                MessageBox.Show("ShorY we Don't Have Data ...");
            }
            con.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newIds = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        public static int Telephones;
        public static int DnD_Statusss;
        public FormCrud()
        {
            InitializeComponent();
            getData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
        public void getData()
        {
            SqlConnection con = new SqlConnection(Connection);
            string str = "select * from Add_New_Customer";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            dl.Show();
        }

        private void referece_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Salutation     = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            First_Name     = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Last_Name      = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Address        = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Locality_Area  = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Mobile         = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Email          = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Telephone      = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            Telephones      = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            //DnD_Statusss     =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
            Customer_Group = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            Memo = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            Referred_By    = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            Relationship   = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            Gender         = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            Date_Of_Birth  = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            Merital_Status = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            Date_Of_Anniversory= dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            Company_Name       = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
            GST_Classification = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            GSTIN_UIN_No       = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
            Effective_Date     = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
            Tax_Identification_No =dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
            Effective_Date2     = dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();
            //Privileged_Customer = dataGridView1.Rows[e.RowIndex].Cells[24].Value.ToString();
            Privilege_Status  = dataGridView1.Rows[e.RowIndex].Cells[25].Value.ToString();
            Issue_Date        = dataGridView1.Rows[e.RowIndex].Cells[26].Value.ToString();
            Folio_No          = dataGridView1.Rows[e.RowIndex].Cells[27].Value.ToString();
            Expired_Date      = dataGridView1.Rows[e.RowIndex].Cells[28].Value.ToString();
            Loyality_Discount = dataGridView1.Rows[e.RowIndex].Cells[29].Value.ToString();
         
            Form2 dr = new Form2();
            dr.Show();
        }
    }
}
