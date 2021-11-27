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
    public partial class Form2 : Form
    {
        string Connection = ConfigurationManager.ConnectionStrings["dp"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
            getDatas();
        }
        public void getDatas()
        {
            txtSalu.Text = FormCrud.Salutation;
            txtFirst.Text = FormCrud.First_Name;
            txtLast.Text = FormCrud.Last_Name;
            txtAdd.Text = FormCrud.Address;
            txtLocal.Text = FormCrud.Locality_Area;
            txtMobile2.Text = FormCrud.Mobile;
            txtEmail.Text = FormCrud.Email;
            txtTelephone.Text = FormCrud.Telephone;
            //CheckDnd.Checked = FormCrud.DnD_Statusss;
            CheckDnd.Checked = false;
            txtCusto.Text = FormCrud.Customer_Group;
            txtMemo.Text = FormCrud.Memo;
            txtReff.Text = FormCrud.Referred_By;
            txtRelation.Text = FormCrud.Relationship;
            txtGender.Text = FormCrud.Gender;
            txtDateBirth.Text = FormCrud.Date_Of_Birth;
            txtMerital.Text = FormCrud.Merital_Status;
            txtAnniv.Text = FormCrud.Date_Of_Anniversory;
            txtCompany.Text = FormCrud.Company_Name;
            txtGstClassification.Text = FormCrud.GST_Classification;
            txtGSTIN.Text = FormCrud.GSTIN_UIN_No;
            txtEffective1.Text = FormCrud.Effective_Date;
            txtTaxIdentifications.Text = FormCrud.Tax_Identification_No;
            txtEffective2.Text = FormCrud.Effective_Date2;
            checkPrivileged.Checked = true;
            //checkPrivileged.Checked = bool.Parse(FormCrud.Privileged_Customer);
            txtPrivilege.Text = FormCrud.Privilege_Status;
            txtIssueDate.Text = FormCrud.Issue_Date;
            txtFolio.Text = FormCrud.Folio_No;
            txtExpiredDate.Text = FormCrud.Expired_Date;
            txtLoyality.Text = FormCrud.Loyality_Discount;


        }
        public void add()
        {
            int Idss = FormCrud.ids;
            SqlConnection con = new SqlConnection(Connection);
            string str = "update Add_New_Customer set Salutation=@Salutation,First_Name=@First_Name,Last_Name=@Last_Name,Address=@Address,Locality_Area=@Locality_Area,Mobile=@Mobile,Email=@Email,Telephone=@Telephone,DnD_Status=@DnD_Status,Customer_Group=@Customer_Group,Memo=@Memo,Referred_By=@Referred_By,Relationship=@Relationship,Gender=@Gender,Date_Of_Birth=@Date_Of_Birth,Merital_Status=@Merital_Status,Date_Of_Anniversory=@Date_Of_Anniversory,Company_Name=@Company_Name,GST_Classification=@GST_Classification,GSTIN_UIN_No=@GSTIN_UIN_No,Effective_Date=@Effective_Date,Tax_Identification_No=@Tax_Identification_No,Effective_Date2=@Effective_Date2,Privileged_Customer=@Privileged_Customer,Privilege_Status=@Privilege_Status,Issue_Date=@Issue_Date,Folio_No=@Folio_No,Expired_Date=@Expired_Date,Loyality_Discount=@Loyality_Discount where ID=@ID";
            string str1 = $"update Add_New_Customer set Salutation={txtSalu},First_Name={txtFirst},Last_Name={txtLast},Address={txtAdd},Locality_Area={txtLocal},Mobile={txtMobile2},Email={txtEmail},Telephone={txtTelephone},DnD_Status={CheckDnd},Customer_Group={txtCusto},Memo={txtMemo},Referred_By={txtReff},Relationship={txtRelation},Gender={txtGender},Date_Of_Birth={txtDateBirth},Merital_Status={txtMerital},Date_Of_Anniversory={txtAnniv},Company_Name={txtCompany},GST_Classification={txtGstClassification},GSTIN_UIN_No={txtGSTIN},Effective_Date={txtEffective1},Tax_Identification_No={txtTaxIdentification},Effective_Date2={txtEffective2},Privileged_Customer={checkPrivileged},Privilege_Status={txtPrivilege},Issue_Date={txtIssueDate},Folio_No={txtFolio},Expired_Date={txtExpiredDate},Loyality_Discount={txtLoyality} where ID={Idss})";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@ID", Idss);
            cmd.Parameters.AddWithValue("@Salutation", txtSalu.Text);
            cmd.Parameters.AddWithValue("@First_Name", txtFirst.Text);
            cmd.Parameters.AddWithValue("@Last_Name", txtLast.Text);
            cmd.Parameters.AddWithValue("@Address", txtAdd.Text);
            cmd.Parameters.AddWithValue("@Locality_Area", txtLocal.Text);
            cmd.Parameters.AddWithValue("@Mobile",  txtMobile2.Text);
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
            cmd.Parameters.AddWithValue("@Tax_Identification_No", txtTaxIdentification.Text);
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
                MessageBox.Show("Customer Updated Successfully...");
                this.Close();
            }
            else
            {
                MessageBox.Show("not Updated...");
            }

            con.Close();
        }









        private void btnUpdate_Click(object sender, EventArgs e)
        {
            add();
        }








        private void Form2_Load(object sender, EventArgs e)
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
