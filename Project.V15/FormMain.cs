using System;
using System.Windows.Forms;
using System.IO;
using Project.V15.Lib;
using System.Text;

namespace Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataService ds = new DataService();
        static string[,] arrayValues;
        string openFilePath;

        private void buttonOpen_MKD_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_MKD.ShowDialog();
                openFilePath = openFileDialog_MKD.FileName;
                arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewOut_MKD.Rows.Clear();

                int rows = arrayValues.GetUpperBound(0) + 1;
                int colums = arrayValues.Length / rows;

                dataGridViewOut_MKD.ColumnCount = colums;
                dataGridViewOut_MKD.RowCount = rows;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < colums; c++)
                    {
                        dataGridViewOut_MKD.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                dataGridViewOut_MKD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                buttonSave_MKD.Enabled = true;
                

            }
            catch
            {
                MessageBox.Show("Не получилось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_MKD_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_MKD.FileName = "Документ.csv";
                saveFileDialog_MKD.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_MKD.ShowDialog();

                string path = saveFileDialog_MKD.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewOut_MKD.RowCount;
                int columns = dataGridViewOut_MKD.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_MKD.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_MKD.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Не получилось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MKD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        
    }
}

    

