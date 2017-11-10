namespace Sqlizer
{
    partial class ValidatorForm
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
            this.rtxtValidated = new System.Windows.Forms.RichTextBox();
            this.rtxtErrorMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtValidated
            // 
            this.rtxtValidated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtValidated.Location = new System.Drawing.Point(12, 12);
            this.rtxtValidated.Name = "rtxtValidated";
            this.rtxtValidated.Size = new System.Drawing.Size(1494, 611);
            this.rtxtValidated.TabIndex = 0;
            this.rtxtValidated.Text = "";
            // 
            // rtxtErrorMessage
            // 
            this.rtxtErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.rtxtErrorMessage.Location = new System.Drawing.Point(12, 629);
            this.rtxtErrorMessage.Name = "rtxtErrorMessage";
            this.rtxtErrorMessage.ReadOnly = true;
            this.rtxtErrorMessage.Size = new System.Drawing.Size(451, 122);
            this.rtxtErrorMessage.TabIndex = 1;
            this.rtxtErrorMessage.Text = "";
            // 
            // ValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 779);
            this.Controls.Add(this.rtxtErrorMessage);
            this.Controls.Add(this.rtxtValidated);
            this.Name = "ValidatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validator Form";
            this.Load += new System.EventHandler(this.ValidatorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtValidated;
        private System.Windows.Forms.RichTextBox rtxtErrorMessage;
    }
}