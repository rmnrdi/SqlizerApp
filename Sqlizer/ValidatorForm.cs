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
    public partial class ValidatorForm : Form
    {
        public object ValidatorFormText { get; set; }

        public ValidatorForm()
        {
            InitializeComponent();

        }

        private void ValidatorForm_Load(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var stringFromSqlizer = ValidatorFormText.ToString();

            var openParenCount = stringFromSqlizer.Count(x => x == '(');
            var closeParenCount = stringFromSqlizer.Count(x => x == ')');

            var singleQuoteCount = stringFromSqlizer.Count(x => x == '\'');

            rtxtValidated.Text = stringFromSqlizer;

            ColorizeChars(rtxtValidated, '(', Color.Black, Color.LightGreen);
            ColorizeChars(rtxtValidated, ')', Color.Black, Color.LightSalmon);

            if (openParenCount > closeParenCount)
            {
                stringBuilder.AppendLine("You're missing a closing parenthesis => ) ");
            }
            if (openParenCount < closeParenCount)
            {
                stringBuilder.AppendLine("You're missing an opening parenthesis => ( ");
            }
            if (singleQuoteCount % 2 != 0)
            {
                stringBuilder.AppendLine("You're missing a single quote => ' ");
            }

            rtxtErrorMessage.Text = stringBuilder.ToString();

            rtxtValidated.Select(rtxtValidated.Text.Length, 0);

        }


        private void ColorizeChars(RichTextBox richText, char charToColor, Color selectColor, Color backColor)
        {
            for (int i = 0; i < richText.Text.Length; i++)
            {
                if (richText.Text[i] == charToColor)
                {
                    richText.SelectionStart = i;
                    richText.SelectionLength = 1;
                    richText.SelectionColor = selectColor;
                    richText.SelectionBackColor = backColor;
                }
            }
        }
    }
}
