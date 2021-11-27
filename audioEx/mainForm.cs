using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace audioEx
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            customizeDesign();
         }
        

        #region=>Visibility
        private void customizeDesign()
        {
            panelMedia.Visible = false;
            panelPlayList.Visible = false;
            panelEquelizer.Visible = false;
            panelTools.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelMedia.Visible == true)
                panelMedia.Visible = false;
            if (panelPlayList.Visible == true)
                panelPlayList.Visible = false;
            if (panelEquelizer.Visible == true)
                panelEquelizer.Visible = false;
            if (panelTools.Visible == true)
                panelTools.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion
       
        #region=>Media
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMedia);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeForm = null;
            openChildForm(new MediaBox1());
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCrud fr = new FormCrud();
            fr.Show();
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region=>PlayList
        private void btnPlayList_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlayList);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activeForm = null;
            openChildForm(new FormPlayList());
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region=>Equelizer
        private void btnEquelizer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEquelizer);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region=>Tools
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTools);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion


        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else 
            { 
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelTextArea.Controls.Add(childForm);
                panelTextArea.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void panelTextArea_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
