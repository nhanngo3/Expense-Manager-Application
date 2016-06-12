using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Configuration;

namespace Expense_App
{
    public partial class frm_Main : Form
    {
        public XmlDocument XmlDoc = new XmlDocument();
        public string filePath = ConfigurationManager.AppSettings["filePathXml"];
        public frm_Main()
        {
            InitializeComponent();
            this.btnDasboard.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddExpense.BackColor = System.Drawing.Color.Transparent;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frm_Dasboard frm_Dasboard = new frm_Dasboard();
            frm_Dasboard.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frm_Category frm_Category = new frm_Category();
            frm_Category.ShowDialog();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            frm_AddExpense frm_AddExpense = new frm_AddExpense();
            frm_AddExpense.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frm_About frm_Report = new frm_About();
            frm_Report.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frm_Manual frmManu = new frm_Manual();
            frmManu.ShowDialog();
        }

    }
}
