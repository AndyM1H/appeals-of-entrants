using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantsProj
{
    public class ExcelExport
    {

        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

        private void Export_Data_To_Excel(string filename, DataGridView dgv)
        {
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = ExcelWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range range = null;
            int indexRange = 0;
            // перенос DataGridView в Excel
            string[] cell = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value;
                    ExcelApp.Cells[1, j + 1] = dgv.Columns[j].HeaderText;
                    range = ExcelWorkSheet.Range[string.Concat(cell[j], j + 1)];
                    range.ColumnWidth = dgv.Columns[j].Width / 4;
                }
                if (i==dgv.Rows.Count-1)
                    ExcelApp.Cells[i + 4, 1] = $"Дата: {DateTime.Now.ToString("d")}";
            }
            // Отобразить Excel
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
          
            DateTime date = new DateTime();
            date = DateTime.Now;
            //границы 
            int rows_count = dgv.Rows.Count + 1;
            range = ExcelWorkSheet.Range["A1", cell[dgv.ColumnCount-1] + rows_count];
         
            range.Borders.ColorIndex = 0;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            range.HorizontalAlignment = 3;

            //вызов Excel 
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
            //save the file

            ExcelWorkBook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
        public void CloseReport()
        {
            //Close process
            if (ExcelWorkBook != null)
            {
                ExcelWorkBook.Close(false, Type.Missing, Type.Missing);
                ExcelApp.Workbooks.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelWorkBook);
            }

            ExcelApp.Quit();
            GC.Collect();
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ExcelApp);
        }

        public void CreateReport(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Excel Documents (*.xlsx)|*.xls";

            sfd.FileName = $"Абитуриенты {DateTime.Now.ToString("d")}.xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Excel(sfd.FileName, dgv);
            }
        }


    }
}

