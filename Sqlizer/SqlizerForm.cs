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

  //          string sqlString = @"'SELECT A1.*, StatusItem.Name as StatusName FROM ' +
  //            '(SELECT RxNum, Account, RSphere, LSphere, RCyl, LCyl, RAdd, LAdd, Patient, RxDate, RxTime, ShipDate, ShipTime, OperatorID, TermCode FROM RxArchive ' +
  //            'WHERE Termcode > 3 AND Termcode <> 7 AND ShipDate BETWEEN ''' + DateTimeToPVStr(startDate) + ''' AND ''' + DateTimeToPVStr(endDate) + ''') AS A1 ' +
  //            'INNER JOIN StatusItem ON A1.TermCode = StatusItem.Num WHERE StatusItem.SeqNum2 & 1 = 0 ORDER BY Patient, RxNum;';";

  //          string rawSql = @"SELECT A1.*, StatusItem.Name as StatusName FROM  
  //            (SELECT RxNum, Account, RSphere, LSphere, RCyl, LCyl, RAdd, LAdd, Patient, RxDate, RxTime, ShipDate, ShipTime, OperatorID, TermCode FROM RxArchive  
  //            WHERE Termcode > 3 AND Termcode <> 7 AND ShipDate BETWEEN   '**INSERT DATE VALUE HERE**'  AND   '**INSERT DATE VALUE HERE**' ) AS A1  
  //            INNER JOIN StatusItem ON A1.TermCode = StatusItem.Num WHERE StatusItem.SeqNum2 & 1 = 0 ORDER BY Patient, RxNum; ";

  //          string builtSqlString = @"  BuiltSQL := 'SELECT FrameAttr.AttrName as Collection, AllSaveCollection.* FROM FrameAttr '; 
  //BuiltSQL := BuiltSQL + 'RIGHT OUTER JOIN '; 
  //BuiltSQL := BuiltSQL + '(SELECT MfrName, StyleName, ColorName, SKU, Eye, Bridge, Temple, Price, Cost, (Cost * OnHand) AS Valuation, Bin, OnHand, OnOrder, Flags, CollID FROM';
  //BuiltSQL := BuiltSQL + '(SELECT ItemsMfrStyle.*, FrameColor.Name as ColorName FROM ';
  //BuiltSQL := BuiltSQL + '(SELECT ItemsMFR.*, FrameStyle.StyleName, FrameStyle.UType as CollID FROM ';
  //BuiltSQL := BuiltSQL + '(SELECT FrameMFR.Name as MfrName, Sku, Temple, Bridge, Eye, Color as ColorNum, FrameItem as StyleNum, ManufacturerNumber as MfrNum, Price1 as Cost, Cost as Price, Bin, OnHand, OnOrder, Flags '; 
  //BuiltSQL := BuiltSQL + 'FROM FrameItem ';
  //{Handle frame item flags}
  //BuiltSQL := BuiltSQL + 'INNER JOIN FrameMFR ON MfrNum = FrameMFR.Num WHERE ';
  //BuiltSQL := BuiltSQL + 'flags & ' + IntToStr(flagInt) + ' = 0 AND (';
  //if Manufacturers <> '' then begin
  //  BuiltSQL := BuiltSQL + '(Name = ''' + ChopOff(Manufacturers, ';') + ''') ';
  //  while Manufacturers <> '' do begin
  //    BuiltSQL := BuiltSQL + 'OR (Name = ''' + ChopOff(Manufacturers, ';') + ''') ';
  //  end;
  //end;
  //BuiltSQL := BuiltSQL + ')) AS ItemsMFR ';
  //BuiltSQL := BuiltSQL + 'INNER JOIN FrameStyle ON ItemsMFR.MfrNum = FrameStyle.MfrNum AND ItemsMFR.StyleNum = FrameStyle.StyleNum) AS ItemsMFRStyle ';
  //BuiltSQL := BuiltSQL + 'INNER JOIN FrameColor ON ItemsMFRStyle.ColorNum = FrameColor.ColorNum AND ItemsMFRStyle.StyleNum = FrameColor.ColorName AND ItemsMFRStyle.MfrNum = FrameColor.MfrNum) AS Frames ';
  //BuiltSQL := BuiltSQL + 'GROUP BY MfrName, StyleName, ColorName, SKU, Eye, Bridge, Temple, Bin, Price, Cost, OnHand, OnOrder, Flags, CollID) AS AllSaveCollection ';
  //BuiltSQL := BuiltSQL + 'ON FrameAttr.AttrID = CollID ';
  //BuiltSQL := BuiltSQL + 'ORDER BY MfrName, StyleName, ColorName, SKU';";

            //txtSql.Text = rawSql;

            //txtSql.Text = rawSql;
        }

        /// <summary>
        /// Converts SQL into string a string for use by Delphi SQL String Builder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStringify_Click(object sender, EventArgs e)
        {
            var sqlInput = txtSql.Text;

            string[] stringAsArray = sqlInput.Split(' ');


            string dateFunctionAdded = "";
            foreach (string item in stringAsArray)
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

            //string[] withDateAdded = dateFunctionAdded.Split(' ');

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

            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ResultsFormText = finishedString;

            resultsForm.ShowDialog();

            //ClearBothTextBoxes();

            //txtString.Text = finishedString;
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
                    dateFunctionRemoved += item.Replace(item, "'---Insert-Date-Here---'");
                }
                else if (item.Contains("BuiltSQL") || item.Contains(":="))
                {
                    dateFunctionRemoved += item.Replace(item, "");
                }
                else
                {
                    dateFunctionRemoved += item + " ";
                }
            }

            string finishedSQLString = dateFunctionRemoved;

            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ResultsFormText = finishedSQLString;

            resultsForm.ShowDialog();

            //ClearBothTextBoxes();

            //txtSql.Text = finalSqlString;
        }
        public void ClearBothTextBoxes()
        {
            txtSql.Clear();
            txtString.Clear();
        }

        /// <summary>
        /// Removes any characters passed in as a param
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

        private void btnClearSqlText_Click(object sender, EventArgs e)
        {
            txtSql.Clear();
        }

        private void btnClearStringText_Click(object sender, EventArgs e)
        {
            txtString.Clear();
        }
    }
}
