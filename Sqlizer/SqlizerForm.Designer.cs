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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearStringText = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(1042, 698);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(230, 75);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 14);
            this.txtString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(1509, 676);
            this.txtString.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 2;
            // 
            // btnClearStringText
            // 
            this.btnClearStringText.Location = new System.Drawing.Point(1291, 698);
            this.btnClearStringText.Name = "btnClearStringText";
            this.btnClearStringText.Size = new System.Drawing.Size(230, 75);
            this.btnClearStringText.TabIndex = 4;
            this.btnClearStringText.Text = "Clear";
            this.btnClearStringText.UseVisualStyleBackColor = true;
            this.btnClearStringText.Click += new System.EventHandler(this.btnClearStringText_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(12, 698);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(168, 75);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // SqlizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 789);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnClearStringText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtString);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SqlizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Sqlizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearStringText;
        private System.Windows.Forms.Button btnValidate;
    }
}

