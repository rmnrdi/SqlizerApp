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
        }

        /// <summary>
        /// Converts a string into SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            var inputString = txtString.Text;

            if (inputString.ToLower().Contains("builtsql"))
            {
                Sqlize(inputString);
            }
            else
            {
                Stringify(inputString);
            }
        }

        public void Sqlize(string input)
        {

            //Stripping functions
            string stringInput = input;

            string plusesRemoved = RemoveChars(stringInput, '+');

            string doubleQuotesReplacedWithPercent = plusesRemoved.Replace("''", "%");

            string singleQuotesRemoved = doubleQuotesReplacedWithPercent.Replace('\'', ' ');

            //TODO set up logic to leave text in single quotes
            //string singleQuotesRemoved = string.Join(" ", doubleQuotesReplacedWithStars.Split(' ').Select(x => x.Trim('\'')));

            string fullyStripped = singleQuotesRemoved.Replace(";", "");

            string trailingSemiColonAdded = fullyStripped += ';';

            //Rebuilding functions
            string[] stringAsArray = trailingSemiColonAdded.Split(' ');

            string quotedString = "";
            foreach (string item in stringAsArray)
            {
                if (item.Contains("%"))
                {
                  quotedString +=  item.Replace("%", "'");
                }
                else
                {
                    quotedString += item + " ";
                }
            }

            string[] quotedStringToArray = quotedString.Split(' ');

            string replacedEmptyStrings = "";
            foreach (var item in quotedStringToArray)
            {
                if (item.Contains("''"))
                {
                    replacedEmptyStrings += item.Replace("''", " + ");
                }
                else
                {
                    replacedEmptyStrings += item + " ";
                }
            }

            string[] replacedEmptyStringsToArray = replacedEmptyStrings.Split(' ');

            string dateFunctionRemoved = "";
            foreach (string item in replacedEmptyStringsToArray)
            {
                if (item.Contains("DateTime") && item.Contains("(") && !String.IsNullOrEmpty(item))
                {
                    dateFunctionRemoved += item.Replace(item, "'yyyy-mm-dd 00:00:00.000/23:59:59.999'");
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

            string[] dateFunctionRemovedToArray = dateFunctionRemoved.Split(' ');

            string dateSingleQuotesRemoved = "";
            foreach (var item in dateFunctionRemovedToArray)
            {
                if (item.Contains("'yyyy"))
                {
                    dateSingleQuotesRemoved += item.Replace("'", " " + " ") + " ";
                }
                else if (item.Contains("999'"))
                {
                    dateSingleQuotesRemoved += item.Replace("'", " " + " ") + " ";
                }
                else
                {
                    dateSingleQuotesRemoved += item + " ";
                }
            }


            string finishedSQLString = dateSingleQuotesRemoved;


            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ResultsFormText = finishedSQLString;

            resultsForm.ShowDialog();

        }
       


        public void Stringify(string input)
        {
            var sqlInput = input;

            string[] stringSqlInputAsArray = sqlInput.Split(' ');

            //Adds date function back into string
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
                    builtSqlStringAdded += "BuiltSQL := ' " + line.Trim() + " ';" + Environment.NewLine;
                    iterator++;
                }
                else if (iterator > 0)
                {
                    builtSqlStringAdded += "BuiltSQL := BuiltSQL + '" + line.Trim() + " ';" + Environment.NewLine;
                }
            }

            var finishedString = builtSqlStringAdded;

            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ResultsFormText = finishedString;

            resultsForm.ShowDialog();

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
            txtString.Clear();
        }

       

        private void btnClearStringText_Click(object sender, EventArgs e)
        {
            txtString.Clear();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var inputText = txtString.Text;
            ValidatorForm validator = new ValidatorForm();
            validator.ValidatorFormText = inputText;

            validator.ShowDialog();
        }
    }
}
