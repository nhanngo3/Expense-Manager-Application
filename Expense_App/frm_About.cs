using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_App
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
