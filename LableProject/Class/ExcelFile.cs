using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode.Classes
{
    public class ExcelFile
    {
        string Path;
        public Excel.Range Range;
        Excel._Application excel = new Excel.Application();

        Excel.Workbook wb;
        Excel.Worksheet ws;

        public ExcelFile(string Path, int Sheet)
        {
            this.Path = Path;
            wb = excel.Workbooks.Open(Path);
            ws = (Excel.Worksheet)wb.Worksheets[Sheet];
            Range = ws.UsedRange;
        }

        public string ReadCell(int i, int j)
        {
            if (ws.Cells[i, j].value2.ToString() != null)
            {
                return ws.Cells[i, j].value2.ToString();
            }
            return string.Empty;
        }

        public int search(string searchField, int columnIndex)
        {

            var res = ws.Cells.Find(searchField);
            if (res == null)
            {
                return -1;
            }
            if (columnIndex != res.Column)
            {
                return -1;
            }
            return res.Row;
        }

        public double? ReadIntCell(int i, int j)
        {
            if (ws.Cells[i, j].value2 != null)
            {
                return ws.Cells[i, j].value2;
            }
            return null;
        }

        public List<string> RowContent(int rowIndex)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= Range.Columns.Count; i++)
            {
                list.Add(ws.Cells[rowIndex, i].value2);
            }
            return list;
        }

        public void CloseWB()
        {
            excel.Workbooks.Close();

        }
    }
}
