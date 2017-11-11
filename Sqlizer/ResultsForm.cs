using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlizer
{
    public partial class ResultsForm : Form
    {
        public string ResultsFormText { get; set; }

        public ResultsForm()    
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            
            txtResults.Text = ResultsFormText.ToString();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResults.Text);
        }
    }
}
