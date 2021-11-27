using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace audioEx
{
    public partial class Form1 : Form
    {
        string Connection = ConfigurationManager.ConnectionStrings["dp"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        public void add()
        {
            SqlConnection con = new SqlConnection(Connection);
            string str = "insert into Add_New_Customer values(@Salutation,@First_Name,@Last_Name,@Address,@Locality_Area,@Mobile,@Email,@Telephone,@DnD_Status,@Customer_Group,@Memo,@Referred_By,@Relationship,@Gender,@Date_Of_Birth,@Merital_Status,@Date_Of_Anniversory,@Company_Name,@GST_Classification,@GSTIN_UIN_No,@Effective_Date,@Tax_Identification_No,@Effective_Date2,@Privileged_Customer,@Privilege_Status,@Issue_Date,@Folio_No,@Expired_Date,@Loyality_Discount)";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Salutation", txtSalu.Text);
            cmd.Parameters.AddWithValue("@First_Name", txtFirst.Text);
            cmd.Parameters.AddWithValue("@Last_Name", txtLast.Text);
            cmd.Parameters.AddWithValue("@Address", txtAdd.Text);
            cmd.Parameters.AddWithValue("@Locality_Area", txtLocal.Text);
            cmd.Parameters.AddWithValue("@Mobile", "+" + txtMobile1.Text + " " + txtMobile2.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
            cmd.Parameters.AddWithValue("@DnD_Status", CheckDnd.Checked);
            cmd.Parameters.AddWithValue("@Customer_Group", txtCusto.Text);
            cmd.Parameters.AddWithValue("@Memo", txtMemo.Text);
            cmd.Parameters.AddWithValue("@Referred_By", txtReff.Text);
            cmd.Parameters.AddWithValue("@Relationship", txtRelation.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@Date_Of_Birth", txtDateBirth.Text);
            cmd.Parameters.AddWithValue("@Merital_Status", txtMerital.Text);
            cmd.Parameters.AddWithValue("@Date_Of_Anniversory", txtAnniv.Text);
            cmd.Parameters.AddWithValue("@Company_Name", txtCompany.Text);
            cmd.Parameters.AddWithValue("@GST_Classification", txtGstClassification.Text);
            cmd.Parameters.AddWithValue("@GSTIN_UIN_No", txtGSTIN.Text);
            cmd.Parameters.AddWithValue("@Effective_Date", txtEffective1.Text);
            cmd.Parameters.AddWithValue("@Tax_Identification_No", txtTaxIdentifications.Text);
            cmd.Parameters.AddWithValue("@Effective_Date2", txtEffective2.Text);
            cmd.Parameters.AddWithValue("@Privileged_Customer", checkPrivileged.Checked);
            cmd.Parameters.AddWithValue("@Privilege_Status", txtPrivilege.Text);
            cmd.Parameters.AddWithValue("@Issue_Date", txtIssueDate.Text);
            cmd.Parameters.AddWithValue("@Folio_No", txtFolio.Text);
            cmd.Parameters.AddWithValue("@Expired_Date", txtExpiredDate.Text);
            cmd.Parameters.AddWithValue("@Loyality_Discount", txtLoyality.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Customer Add Successfully...");
                this.Close();

            }
            else
            {
                MessageBox.Show("not inserted");
            }

            con.Close();
        }









        private void Save_Click(object sender, EventArgs e)
        {
            add();
        }








        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
