
namespace Project.V15
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.textBoxInfo_MKD = new System.Windows.Forms.TextBox();
            this.buttonOKInfo_MKD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo_MKD
            // 
            this.textBoxInfo_MKD.Location = new System.Drawing.Point(13, 13);
            this.textBoxInfo_MKD.Multiline = true;
            this.textBoxInfo_MKD.Name = "textBoxInfo_MKD";
            this.textBoxInfo_MKD.ReadOnly = true;
            this.textBoxInfo_MKD.Size = new System.Drawing.Size(361, 104);
            this.textBoxInfo_MKD.TabIndex = 0;
            this.textBoxInfo_MKD.Text = resources.GetString("textBoxInfo_MKD.Text");
            // 
            // buttonOKInfo_MKD
            // 
            this.buttonOKInfo_MKD.Location = new System.Drawing.Point(326, 123);
            this.buttonOKInfo_MKD.Name = "buttonOKInfo_MKD";
            this.buttonOKInfo_MKD.Size = new System.Drawing.Size(48, 23);
            this.buttonOKInfo_MKD.TabIndex = 1;
            this.buttonOKInfo_MKD.Text = "ОК";
            this.buttonOKInfo_MKD.UseVisualStyleBackColor = true;
            this.buttonOKInfo_MKD.Click += new System.EventHandler(this.buttonOKInfo_MKD_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 153);
            this.Controls.Add(this.buttonOKInfo_MKD);
            this.Controls.Add(this.textBoxInfo_MKD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсказка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_MKD;
        private System.Windows.Forms.Button buttonOKInfo_MKD;
    }
}