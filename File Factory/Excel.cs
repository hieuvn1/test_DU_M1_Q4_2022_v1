using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreTest.File_Factory
{
    internal class Excel
    {
        public static bool ToExcel(ListView listview)
        {
            try 
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                { Filter = "Excel Workbook|*.xls", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = true;
                        ws.Cells[1, 1] = "STT";
                        ws.Cells[1, 2] = "Item Name";
                        ws.Cells[1, 3] = "Time";
                        ws.Cells[1, 4] = "Result";
                        int i = 2;
                        foreach (ListViewItem item in listview.Items)
                        {
                            ws.Cells[i, 1] = item.SubItems[0].Text;
                            ws.Cells[i, 2] = item.SubItems[1].Text;
                            ws.Cells[i, 3] = item.SubItems[2].Text;
                            ws.Cells[i, 4] = item.SubItems[3].Text;
                            i++;
                        }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange);
                        app.Quit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
