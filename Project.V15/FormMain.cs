using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            Excel.Application excelApp = new Excel.Application();

            
            Excel.Workbook workbook = excelApp.Workbooks.Add();

            
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            
            worksheet.Cells[1, 1] = textBox1.Text;

            
            workbook.SaveAs("C:\\Users\\Я твой-ты моя\\Desktop\\test.xlsx");

            
            workbook.Close();
            excelApp.Quit();

            
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }
}
