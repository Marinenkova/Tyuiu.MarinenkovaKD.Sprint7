
namespace Project.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.Image")));
            this.pictureBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(139, 173);
            this.pictureBoxAbout.TabIndex = 0;
            this.pictureBoxAbout.TabStop = false;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(158, 13);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(285, 138);
            this.textBoxAbout.TabIndex = 1;
            this.textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(378, 156);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(56, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 191);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.pictureBoxAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Button buttonOK;
    }
}