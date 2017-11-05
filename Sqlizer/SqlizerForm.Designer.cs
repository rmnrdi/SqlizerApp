namespace Sqlizer
{
    partial class SqlizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlizerForm));
            this.txtSql = new System.Windows.Forms.TextBox();
            this.btnStringify = new System.Windows.Forms.Button();
            this.btnSqlize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearSqlText = new System.Windows.Forms.Button();
            this.btnClearStringText = new System.Windows.Forms.Button();
            this.pbxUpArrow = new System.Windows.Forms.PictureBox();
            this.pbxDownArrow = new System.Windows.Forms.PictureBox();
            this.chkUseResultsForm = new System.Windows.Forms.CheckBox();
            this.btnClearBothTextBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(18, 38);
            this.txtSql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSql.Size = new System.Drawing.Size(1519, 376);
            this.txtSql.TabIndex = 0;
            // 
            // btnStringify
            // 
            this.btnStringify.Location = new System.Drawing.Point(18, 426);
            this.btnStringify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStringify.Name = "btnStringify";
            this.btnStringify.Size = new System.Drawing.Size(230, 75);
            this.btnStringify.TabIndex = 1;
            this.btnStringify.Text = "Stringify";
            this.btnStringify.UseVisualStyleBackColor = true;
            this.btnStringify.Click += new System.EventHandler(this.btnStringify_Click);
            // 
            // btnSqlize
            // 
            this.btnSqlize.Location = new System.Drawing.Point(1065, 511);
            this.btnSqlize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqlize.Name = "btnSqlize";
            this.btnSqlize.Size = new System.Drawing.Size(230, 75);
            this.btnSqlize.TabIndex = 1;
            this.btnSqlize.Text = "Sqlize";
            this.btnSqlize.UseVisualStyleBackColor = true;
            this.btnSqlize.Click += new System.EventHandler(this.btnSqlize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Put SQL Here";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(23, 594);
            this.txtString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(1519, 273);
            this.txtString.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 564);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Put String Here";
            // 
            // btnClearSqlText
            // 
            this.btnClearSqlText.Location = new System.Drawing.Point(266, 426);
            this.btnClearSqlText.Name = "btnClearSqlText";
            this.btnClearSqlText.Size = new System.Drawing.Size(230, 75);
            this.btnClearSqlText.TabIndex = 3;
            this.btnClearSqlText.Text = "Clear ";
            this.btnClearSqlText.UseVisualStyleBackColor = true;
            this.btnClearSqlText.Click += new System.EventHandler(this.btnClearSqlText_Click);
            // 
            // btnClearStringText
            // 
            this.btnClearStringText.Location = new System.Drawing.Point(1312, 511);
            this.btnClearStringText.Name = "btnClearStringText";
            this.btnClearStringText.Size = new System.Drawing.Size(230, 75);
            this.btnClearStringText.TabIndex = 4;
            this.btnClearStringText.Text = "Clear";
            this.btnClearStringText.UseVisualStyleBackColor = true;
            this.btnClearStringText.Click += new System.EventHandler(this.btnClearStringText_Click);
            // 
            // pbxUpArrow
            // 
            this.pbxUpArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbxUpArrow.Image")));
            this.pbxUpArrow.Location = new System.Drawing.Point(864, 419);
            this.pbxUpArrow.Name = "pbxUpArrow";
            this.pbxUpArrow.Size = new System.Drawing.Size(194, 167);
            this.pbxUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUpArrow.TabIndex = 5;
            this.pbxUpArrow.TabStop = false;
            // 
            // pbxDownArrow
            // 
            this.pbxDownArrow.Image = global::Sqlizer.Properties.Resources.Download_grey_inverse_256x;
            this.pbxDownArrow.Location = new System.Drawing.Point(502, 426);
            this.pbxDownArrow.Name = "pbxDownArrow";
            this.pbxDownArrow.Size = new System.Drawing.Size(186, 163);
            this.pbxDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDownArrow.TabIndex = 6;
            this.pbxDownArrow.TabStop = false;
            // 
            // chkUseResultsForm
            // 
            this.chkUseResultsForm.AutoSize = true;
            this.chkUseResultsForm.Location = new System.Drawing.Point(700, 437);
            this.chkUseResultsForm.Name = "chkUseResultsForm";
            this.chkUseResultsForm.Size = new System.Drawing.Size(148, 24);
            this.chkUseResultsForm.TabIndex = 7;
            this.chkUseResultsForm.Text = "UseResultsForm";
            this.chkUseResultsForm.UseVisualStyleBackColor = true;
            // 
            // btnClearBothTextBoxes
            // 
            this.btnClearBothTextBoxes.Location = new System.Drawing.Point(700, 488);
            this.btnClearBothTextBoxes.Name = "btnClearBothTextBoxes";
            this.btnClearBothTextBoxes.Size = new System.Drawing.Size(148, 76);
            this.btnClearBothTextBoxes.TabIndex = 8;
            this.btnClearBothTextBoxes.Text = "Clear Both Text Boxes";
            this.btnClearBothTextBoxes.UseVisualStyleBackColor = true;
            this.btnClearBothTextBoxes.Click += new System.EventHandler(this.btnClearBothTextBoxes_Click);
            // 
            // SqlizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 881);
            this.Controls.Add(this.btnClearBothTextBoxes);
            this.Controls.Add(this.chkUseResultsForm);
            this.Controls.Add(this.pbxDownArrow);
            this.Controls.Add(this.pbxUpArrow);
            this.Controls.Add(this.btnClearStringText);
            this.Controls.Add(this.btnClearSqlText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSqlize);
            this.Controls.Add(this.btnStringify);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtSql);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SqlizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sqlizer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDownArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Button btnStringify;
        private System.Windows.Forms.Button btnSqlize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearSqlText;
        private System.Windows.Forms.Button btnClearStringText;
        private System.Windows.Forms.PictureBox pbxUpArrow;
        private System.Windows.Forms.PictureBox pbxDownArrow;
        private System.Windows.Forms.CheckBox chkUseResultsForm;
        private System.Windows.Forms.Button btnClearBothTextBoxes;
    }
}

