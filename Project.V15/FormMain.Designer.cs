
namespace Project.V15
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelp_MKD = new System.Windows.Forms.Button();
            this.buttonSave_MKD = new System.Windows.Forms.Button();
            this.buttonOpen_MKD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewOut_MKD = new System.Windows.Forms.DataGridView();
            this.openFileDialog_MKD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_MKD = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_MKD = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MKD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 79);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.buttonHelp_MKD);
            this.groupBox1.Controls.Add(this.buttonSave_MKD);
            this.groupBox1.Controls.Add(this.buttonOpen_MKD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с файлом";
            // 
            // buttonHelp_MKD
            // 
            this.buttonHelp_MKD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MKD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonHelp_MKD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_MKD.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MKD.Image")));
            this.buttonHelp_MKD.Location = new System.Drawing.Point(593, 19);
            this.buttonHelp_MKD.Name = "buttonHelp_MKD";
            this.buttonHelp_MKD.Size = new System.Drawing.Size(51, 44);
            this.buttonHelp_MKD.TabIndex = 0;
            this.toolTip_MKD.SetToolTip(this.buttonHelp_MKD, "Об авторе");
            this.buttonHelp_MKD.UseVisualStyleBackColor = false;
            // 
            // buttonSave_MKD
            // 
            this.buttonSave_MKD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSave_MKD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_MKD.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_MKD.Image")));
            this.buttonSave_MKD.Location = new System.Drawing.Point(60, 19);
            this.buttonSave_MKD.Name = "buttonSave_MKD";
            this.buttonSave_MKD.Size = new System.Drawing.Size(51, 44);
            this.buttonSave_MKD.TabIndex = 0;
            this.toolTip_MKD.SetToolTip(this.buttonSave_MKD, "Сохранить таблицу");
            this.buttonSave_MKD.UseVisualStyleBackColor = false;
            this.buttonSave_MKD.Click += new System.EventHandler(this.buttonSave_MKD_Click);
            // 
            // buttonOpen_MKD
            // 
            this.buttonOpen_MKD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOpen_MKD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_MKD.Image")));
            this.buttonOpen_MKD.Location = new System.Drawing.Point(3, 19);
            this.buttonOpen_MKD.Name = "buttonOpen_MKD";
            this.buttonOpen_MKD.Size = new System.Drawing.Size(51, 44);
            this.buttonOpen_MKD.TabIndex = 0;
            this.toolTip_MKD.SetToolTip(this.buttonOpen_MKD, "Открыть таблицу");
            this.buttonOpen_MKD.UseVisualStyleBackColor = false;
            this.buttonOpen_MKD.Click += new System.EventHandler(this.buttonOpen_MKD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dataGridViewOut_MKD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 371);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewOut_MKD
            // 
            this.dataGridViewOut_MKD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOut_MKD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_MKD.ColumnHeadersVisible = false;
            this.dataGridViewOut_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_MKD.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOut_MKD.Name = "dataGridViewOut_MKD";
            this.dataGridViewOut_MKD.RowHeadersVisible = false;
            this.dataGridViewOut_MKD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOut_MKD.Size = new System.Drawing.Size(656, 371);
            this.dataGridViewOut_MKD.TabIndex = 0;
            // 
            // openFileDialog_MKD
            // 
            this.openFileDialog_MKD.FileName = "openFileDialog1";
            // 
            // toolTip_MKD
            // 
            this.toolTip_MKD.ToolTipTitle = "Помощь";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договорная деятельность организации | Главное меню";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MKD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHelp_MKD;
        private System.Windows.Forms.Button buttonSave_MKD;
        private System.Windows.Forms.Button buttonOpen_MKD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewOut_MKD;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MKD;
        private System.Windows.Forms.ToolTip toolTip_MKD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MKD;
    }
}

