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
    public partial class SqlizerForm : Form
    {
        public SqlizerForm()
        {
            InitializeComponent();
            chkUseResultsForm.Checked = true;
        }

        /// <summary>
        /// Converts SQL into string a string for use by Delphi SQL String Builder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStringify_Click(object sender, EventArgs e)
        {
            var sqlInput = txtSql.Text;

            string[] stringSqlInputAsArray = sqlInput.Split(' ');

            //Adds date function back into
            string dateFunctionAdded = "";
            foreach (string item in stringSqlInputAsArray)
            {
                if (item.Contains("---") && !String.IsNullOrEmpty(item))
                {
                    dateFunctionAdded += item.Replace(item, "''' + DateTimeToPVStr(---startDate/endDate---) + '''");
                }
                else if (item.Contains("BuiltSQL") || item.Contains(":="))
                {
                    dateFunctionAdded += item.Replace(item, "");
                }
                else
                {
                    dateFunctionAdded += item + " ";
                }
            }

            //Prepends "BuiltSQL" to the output string and appends single quotes and semicolons.
            var builtSqlStringAdded = "";
            int iterator = 0;
            foreach (var line in dateFunctionAdded.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (iterator == 0)
                {
                    builtSqlStringAdded += "BuiltSQL := ' " + line.Trim() + "';" + Environment.NewLine;
                    iterator++;
                }
                else if (iterator > 0)
                {
                    builtSqlStringAdded += "BuiltSQL := BuiltSQL + '" + line.Trim() + "';" + Environment.NewLine;
                }
            }

            var finishedString = builtSqlStringAdded;

            if (chkUseResultsForm.Checked)
            {
                ResultsForm resultsForm = new ResultsForm();
                resultsForm.ResultsFormText = finishedString;

                resultsForm.ShowDialog();
            }
            else
            {
                //ClearBothTextBoxes();

                txtSql.Text = finishedString;
            }

            
        }

        /// <summary>
        /// Converts a string into SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSqlize_Click(object sender, EventArgs e)
        {
            string stringInput = txtString.Text;

            string plusesRemoved = RemoveChars(stringInput, '+', '\'');

            string singleQuotesRemoved = string.Join(" ", plusesRemoved.Split(' ').Select(x => x.Trim('\'')));

            string preStripped = singleQuotesRemoved.Trim('\'', ';');

            string fullyStripped = preStripped.Replace(";", "");

            string semicolonAdded = fullyStripped += ';';

            string[] stringAsArray = semicolonAdded.Split(' ');


            string dateFunctionRemoved = "";
            foreach (string item in stringAsArray)
            {
                if (item.Contains("Date") && item.Contains("(") && !String.IsNullOrEmpty(item))
                {
                    dateFunctionRemoved += item.Replace(item, "'---Date---'");
                }
                else if (item.ToLower().Contains("builtsql") || item.Contains(":="))
                {
                    dateFunctionRemoved += item.Replace(item, "");
                }
                else
                {
                    dateFunctionRemoved += item + " ";
                }
            }

            string finishedSQLString = dateFunctionRemoved;

            if (chkUseResultsForm.Checked)
            {
                ResultsForm resultsForm = new ResultsForm();
                resultsForm.ResultsFormText = finishedSQLString;

                resultsForm.ShowDialog();
            }
            else
            {
                txtSql.Text = finishedSQLString;
            }
        }
        

        /// <summary>
        /// Removes character/s from a string based on the params passed in. 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public string RemoveChars(string input, params char[] chars)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (!chars.Contains(input[i]))
                    sb.Append(input[i]);
            }
            return sb.ToString();
        }

        public void ClearBothTextBoxes()
        {
            txtSql.Clear();
            txtString.Clear();
        }

        private void btnClearSqlText_Click(object sender, EventArgs e)
        {
            txtSql.Clear();
        }

        private void btnClearStringText_Click(object sender, EventArgs e)
        {
            txtString.Clear();
        }

        private void btnClearBothTextBoxes_Click(object sender, EventArgs e)
        {
            ClearBothTextBoxes();
        }
    }
}
