using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_App
{
    public partial class frm_EditCategory : Form
    {

        public frm_EditCategory()
        {
            InitializeComponent();
        }

        private void btnSaveNewCate_Click(object sender, EventArgs e)
        {            
                this.Hide();       
        }

        private string ExtraWhiteSpace(string input)
        {
            string pattern = "\\s+";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }
        public string GetCateNew()
        {
            return this.txtNewCate.Text;
        }      
    }
}
