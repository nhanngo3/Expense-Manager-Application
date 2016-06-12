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
using System.Xml.Serialization;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Configuration;

namespace Expense_App
{
    public partial class frm_Dasboard : Form
    {
        public XmlDocument XmlDoc = new XmlDocument();
        public string filePath = ConfigurationManager.AppSettings["filePathXml"];

        public frm_Dasboard()
        {
            InitializeComponent();
            
        }

        private void frm_Dasboard_Load(object sender, EventArgs e)
        {
            ViewExpenseAll(this.dataGridView);
            UpdateCombCate();
        }

        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridViewp2.Rows.Clear();
            ViewExpenseWhenSelectCate(this.cbCate.SelectedItem.ToString());
        }

        private void UpdateCombCate()
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);
            XmlNodeList infoNode = XmlDoc.GetElementsByTagName("information");
            for (int i = 0; i < infoNode.Count; i++)
            {
                XmlNodeList cateNode = XmlDoc.GetElementsByTagName("category");
                this.cbCate.Items.Add(cateNode.Item(i).InnerText);
            }
        }

        private void ViewExpenseAll(DataGridView dataview)
        {
            try
            {
                DataSet ds = new DataSet();
                //ds.ReadXml("data.xml");
                ds.ReadXml(filePath);
                dataview.DataSource = ds.Tables[1].DefaultView;

                TotalAmount(this.dataGridView, this.lbTotal);
                this.btnDelete.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ViewExpenseWhenSelectCate(string strCate)
        {
            for (int i = 0; i < this.dataGridView.Rows.Count; i++)
            {
                if (this.dataGridView.Rows[i].Cells["categorymain"].Value.ToString() == strCate)
                {
                    this.dataGridView.Hide();
                    this.btnDelete.Hide();
                    this.dataGridViewp2.Show();
                    DataGridViewRow row = this.dataGridView.Rows[i];

                    this.dataGridViewp2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString(),
                                                   row.Cells[4].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[5].Value.ToString());
                    TotalAmount(this.dataGridViewp2, this.lbTotal);
                    //break;
                }
                else
                    if (strCate == "All")
                    {
                        this.btnDelete.Show();
                        this.dataGridView.Show();
                        TotalAmount(this.dataGridView, this.lbTotal);
                        break;
                    }
            }

            
        }

        private void TotalAmount(DataGridView dataview, Label lbtotal)
        {
            double[] columdata = (from DataGridViewRow row in dataview.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();
            lbtotal.Text = "Total : " + columdata.Sum().ToString();
        }

        private void ViewExpenseToday()
        {

            DateTime now = DateTime.Now;

            if (this.dataGridViewToday.Rows.Count == 0)
            {
                for (int i = 0; i < this.dataGridView.Rows.Count; i++)
                {
                    if (this.dataGridView.Rows[i].Cells["date"].Value.ToString() == now.ToString(("dd-MM-yyyy")))
                    {
                        DataGridViewRow row = this.dataGridView.Rows[i];

                        this.dataGridViewToday.Rows.Add(row.Cells[0].Value.ToString(),
                                                       row.Cells[1].Value.ToString(),
                                                       row.Cells[2].Value.ToString(),
                                                       row.Cells[4].Value.ToString(),
                                                       row.Cells[3].Value.ToString(),
                                                       row.Cells[5].Value.ToString());
                    }
                }
            }

        }

        private void ViewExpenseYesterday()
        {
            DateTime now = DateTime.Now;

            if (this.dataGridViewYes.Rows.Count == 0)
            {
                for (int i = 0; i < this.dataGridView.Rows.Count; i++)
                {
                    if (this.dataGridView.Rows[i].Cells["date"].Value.ToString() == now.AddDays(-1).ToString(("dd-MM-yyyy")))
                    {
                        DataGridViewRow row = this.dataGridView.Rows[i];

                        this.dataGridViewYes.Rows.Add(row.Cells[0].Value.ToString(),
                                                       row.Cells[1].Value.ToString(),
                                                       row.Cells[2].Value.ToString(),
                                                       row.Cells[4].Value.ToString(),
                                                       row.Cells[3].Value.ToString(),
                                                       row.Cells[5].Value.ToString());
                    }
                }
            }

        }

        private void ViewExpenseLastWeek()
        {

            if (this.dataGridViewLastWeek.Rows.Count == 0)
            {
                DateTime date = DateTime.Now;
                DateTime mondayOfLastWeek = date.AddDays(-(int)date.DayOfWeek - 6);

                for (int i = 0; i < this.dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (this.dataGridView.Rows[i].Cells["date"].Value.ToString() == mondayOfLastWeek.AddDays(j).ToString(("dd-MM-yyyy")))
                        {
                            DataGridViewRow row = this.dataGridView.Rows[i];

                            this.dataGridViewLastWeek.Rows.Add(row.Cells[0].Value.ToString(),
                                                           row.Cells[1].Value.ToString(),
                                                           row.Cells[2].Value.ToString(),
                                                           row.Cells[4].Value.ToString(),
                                                           row.Cells[3].Value.ToString(),
                                                           row.Cells[5].Value.ToString());
                        }
                    }

                }
            }
        }


        private void ViewExpenseLastMonth()
        {

            if (this.dataGridViewLastMonth.Rows.Count == 0)
            {
                DateTime date = DateTime.Now;
                DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                DateTime firstDayOfLastMonth = firstDayOfMonth.AddMonths(-1);

                for (int i = 0; i < this.dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 31; j++)
                    {
                        if (this.dataGridView.Rows[i].Cells["date"].Value.ToString() == firstDayOfLastMonth.AddDays(j).ToString(("dd-MM-yyyy")))
                        {
                            DataGridViewRow row = this.dataGridView.Rows[i];

                            this.dataGridViewLastMonth.Rows.Add(row.Cells[0].Value.ToString(),
                                                           row.Cells[1].Value.ToString(),
                                                           row.Cells[2].Value.ToString(),
                                                           row.Cells[4].Value.ToString(),
                                                           row.Cells[3].Value.ToString(),
                                                           row.Cells[5].Value.ToString());
                        }
                    }

                }
            }
        }

        private void ViewExpenseDateRange(DateTime startDate, DateTime endDate)
        {

            if (this.dataGridViewCustomRange.Rows.Count == 0)
            {
                for (int i = 0; i < (endDate.DayOfYear - startDate.DayOfYear) + 1; i++)
                {
                    for (int j = 0; j < this.dataGridView.Rows.Count; j++)
                    {
                        if (this.dataGridView.Rows[j].Cells["date"].Value.ToString() == startDate.AddDays(i).ToString("dd-MM-yyyy"))
                        {
                            DataGridViewRow row = this.dataGridView.Rows[j];

                            this.dataGridViewCustomRange.Rows.Add(row.Cells[0].Value.ToString(),
                                                           row.Cells[1].Value.ToString(),
                                                           row.Cells[2].Value.ToString(),
                                                           row.Cells[4].Value.ToString(),
                                                           row.Cells[3].Value.ToString(),
                                                           row.Cells[5].Value.ToString());

                        }

                    }

                }

            }

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                ViewExpenseYesterday();
                TotalAmount(this.dataGridViewYes, this.lbTotalYest);
            }
            else
                if (tabControl1.SelectedIndex == 1)
                {
                    ViewExpenseToday();
                    TotalAmount(this.dataGridViewToday, this.lbTotalToday);
                }
                else
                    if (tabControl1.SelectedIndex == 3)
                    {
                        ViewExpenseLastWeek();
                        TotalAmount(this.dataGridViewLastWeek, this.lbTotalLastWeek);
                    }
                    else
                        if (tabControl1.SelectedIndex == 4)
                        {
                            ViewExpenseLastMonth();
                            TotalAmount(this.dataGridViewLastMonth, this.lbTotalLastMonth);
                        }
                        else
                            if (tabControl1.SelectedIndex == 5)
                            {
                                ViewExpenseDateRange(StringToDate(this.dateTimePickerStart.Text), StringToDate(this.dateTimePickerEnd.Text));
                                TotalAmount(this.dataGridViewCustomRange, this.lbTotalCustomRange);
                            }
        }

        private DateTime StringToDate(string strdate)
        {
            string dateTimeString = Regex.Replace(strdate, @"[^\u0000-\u007F]", string.Empty);
            DateTime dateTime = DateTime.ParseExact(dateTimeString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            return dateTime;
        }


        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dataGridViewCustomRange.Rows.Clear();
            ViewExpenseDateRange(StringToDate(this.dateTimePickerStart.Text), StringToDate(this.dateTimePickerEnd.Text));
            TotalAmount(this.dataGridViewCustomRange, this.lbTotalCustomRange);

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            this.dataGridViewCustomRange.Rows.Clear();
            ViewExpenseDateRange(StringToDate(this.dateTimePickerStart.Text), StringToDate(this.dateTimePickerEnd.Text));
            TotalAmount(this.dataGridViewCustomRange, this.lbTotalCustomRange);
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure delete expense?", "Waring", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product prod = new Product();
                prod.DeleteProduct(getValueCate(), getValueDate(), getValueItemName(), getValueItemQuanti(), getValueUnit(), getValueAmount());
                int rowIndex = dataGridView.CurrentCell.RowIndex;
                this.dataGridView.Rows.RemoveAt(rowIndex);                
            }
        }


       private string getValueCate() {
           return this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
       }

       private string getValueDate() {
           return this.dataGridView.SelectedRows[0].Cells[1].Value.ToString();
       }

       private string getValueItemName() {
           return this.dataGridView.SelectedRows[0].Cells[2].Value.ToString();
       }

       private string getValueItemQuanti() {
           return this.dataGridView.SelectedRows[0].Cells[4].Value.ToString();
       }

       private string getValueUnit() {
            return this.dataGridView.SelectedRows[0].Cells[3].Value.ToString();
       }

       private string getValueAmount()
       {
           return this.dataGridView.SelectedRows[0].Cells[5].Value.ToString();
       }
        

       
    }
}
