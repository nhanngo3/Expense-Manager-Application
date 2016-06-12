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
    public partial class frm_Category : Form
    {
        public XmlDocument XmlDoc = new XmlDocument();
        public string filePath = ConfigurationManager.AppSettings["filePathXml"];
        private bool dataGriViChecked;
        public frm_Category()
        {
            InitializeComponent();
            this.btnSaveCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            dataGriViChecked = false;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (ExtraWhiteSpace(this.txtCategory.Text) != " " && ExtraWhiteSpace(this.txtCategory.Text) != "")
            {
                Infomation info = new Infomation();
                info.AddInfo(ExtraWhiteSpace(this.txtCategory.Text));
                RefreshListView();               
            }
            else
            {
                MessageBox.Show("Enter category, please !!!");
            }
            
            this.txtCategory.Text = "";
        }

        private void frm_Category_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void lstvCategory_DoubleClick(object sender, EventArgs e)
        {
            string strCateOld = ExtraWhiteSpace(this.txtCategory.Text);

            frm_EditCategory frmEditCate = new frm_EditCategory();
            frmEditCate.ShowDialog();

            string strCateNew = frmEditCate.GetCateNew();
            strCateNew = ExtraWhiteSpace(strCateNew);

            Infomation info = new Infomation();
            if (strCateNew != "" && strCateNew != " ")
            {
                info.EditInfor(strCateOld, strCateNew);

                RefreshListView();
            }
            else
            {
                MessageBox.Show("Enter category, please !!!");
            }

            this.txtCategory.Text = "";
        }

        private void lstvCategory_Click(object sender, EventArgs e)
        {
            
            String txtSelect = this.lstvCategory.SelectedItems[0].Text;
            this.txtCategory.Text = txtSelect;
            dataGriViChecked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dataGriViChecked == true)
            {
                DialogResult result = MessageBox.Show("Are you sure delete category?", "Waring", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Infomation info = new Infomation();
                    string strCate = this.lstvCategory.SelectedItems[0].Text;
                    this.txtCategory.Text = strCate;

                    info.DeleteInfor(ExtraWhiteSpace(this.txtCategory.Text));

                    RefreshListView();
                    this.txtCategory.Text = "";
                }
            }
            else {
                MessageBox.Show("Choose a category, please !!!");
            }
           
            
        }

        private void UpdateListView()
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);

            XmlNodeList infoNode = XmlDoc.GetElementsByTagName("information");
            for (int i = 0; i < infoNode.Count; i++)
            {
                XmlNodeList cateNode = XmlDoc.GetElementsByTagName("category");

                Infomation info = new Infomation();
                ListViewItem lvi = new ListViewItem(cateNode.Item(i).InnerText);
                this.lstvCategory.Items.Add(lvi);
            }
        }

        private void RefreshListView()
        {
            this.lstvCategory.Items.Clear();
            UpdateListView();
        }

        private string ExtraWhiteSpace(string input)
        {
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }

        public string GetCategory() {
            return this.txtCategory.Text;
        }

      
    }

}