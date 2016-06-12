using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Expense_App
{
     
    public partial class frm_AddExpense : Form
    {
        public XmlDocument XmlDoc = new XmlDocument();
        public string filePath = ConfigurationManager.AppSettings["filePathXml"];
        public frm_AddExpense()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            string txtDefault = this.cbCategory.Text;
            string strCate="";
            if (txtDefault != "Pick category")
            {
                strCate = ExtraWhiteSpace(this.cbCategory.SelectedItem.ToString());
            }
            else {
                strCate = txtDefault;
            }
            
            string strDate = ExtraWhiteSpace(this.dateTimePicker.Text);
            string strUnit = ExtraWhiteSpace(this.txtUnit.Text);
            string strItName = ExtraWhiteSpace(this.txtItemname.Text);
            string strItQuan = ExtraWhiteSpace(this.txtItemquantity.Text);
            string strAmo = ExtraWhiteSpace(this.txtAmount.Text);

            if (strCate == "Pick category")
            {
                MessageBox.Show("Pick category, please !!!");
            }

            if (strUnit == " ")
            {
                MessageBox.Show("Enter unit, please !!!");
            }
            
            if (strItName == " ")
            {
                MessageBox.Show("Enter item name, please !!!");
            }
            if (strUnit != " " && strItName != " " && strCate != " ")
            {
                prod.AddProduct(strCate, strDate, strUnit, strItName, strItQuan, strAmo);   
            }
                   
            RefreshForm();
        }

        private void txtItemAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void frm_AddExpense_Load(object sender, EventArgs e)
        {
            UpdateCombCate();
        }

        private void UpdateCombCate() {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);

            XmlNodeList infoNode = XmlDoc.GetElementsByTagName("information");
            for (int i = 0; i < infoNode.Count; i++)
            {
                XmlNodeList cateNode = XmlDoc.GetElementsByTagName("category");
                this.cbCategory.Items.Add(cateNode.Item(i).InnerText);
            }
            this.txtItemquantity.Text = "0";
            this.txtAmount.Text = "0";
        }

        private void RefreshForm() {
            this.txtItemquantity.Text = "0";
            this.txtAmount.Text = "0";
            this.txtItemname.Text = "";
            this.txtUnit.Text = "";          
        }

        private string ExtraWhiteSpace(string input)
        {
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }

    }
}
