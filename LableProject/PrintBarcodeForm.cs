using Barcode.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LableProject.LableDbDataSet;
using Excel = Microsoft.Office.Interop.Excel;

namespace LableProject
{
    public partial class PrintBarcodeForm : Form
    {
        public int SelectId { get; set; }
        ExcelFile excelFile { get; set; }
        public List<SerialScanRow> serialScanRows { get; set; }
        public PrintPageEventArgs print { get; set; }
        public List<SerialsRow> excelList { get; set; }
        public List<LableDetailRow> lableDetailList { get; set; }
        public LableRow selectLable { get; set; }
        public int IndexRow { get; set; }
        public int pageWidth { get; set; }
        public int pageLength { get; set; }
        public bool Landscape { get; set; }

        //define data table for bind to ScansDataGridView
        private DataTable dt = new DataTable();

        private SerialsRow excelTemp;


        public PrintBarcodeForm(int Id)
        {
            InitializeComponent();
            SelectId = Id;
        }

        private void PrintBarcodeForm_Load(object sender, EventArgs e)
        {
            this.lableTableAdapter1.Fill(this.lableDbDataSet1.Lable);
            this.lableDetailTableAdapter1.FillByFilter(this.lableDbDataSet1.LableDetail, SelectId);
            this.serialsTableAdapter1.Fill(this.lableDbDataSet1.Serials);
            this.serialScanTableAdapter1.Fill(this.lableDbDataSet1.SerialScan);
            selectLable = this.lableDbDataSet1.Lable.FindByID(SelectId);
            Title_Textbox.Text = selectLable.Title;
            excelList = this.lableDbDataSet1.Serials.ToList().FindAll(t => t.Lable_ID == SelectId);
            lableDetailList = this.lableDbDataSet1.LableDetail.ToList().FindAll(t => t.Lable_Id == SelectId);
            foreach (var item in excelList)
            {
                Excel_Combobox.Items.Add(item.Excel_Path.ToString().Split('#').Last());
            }
            if (Excel_Combobox.Items.Count != 0)
            {
                Excel_Combobox.SelectedItem = excelList.Last().Excel_Path.ToString().Split('#').Last();
            }
            Landscape = false;
            dt.Columns.Clear();
            //add columns to data table
            dt.Columns.Add("SerialId".ToString());
            dt.Columns.Add("Scans".ToString());
            dt.Columns.Add("RowIndex".ToString());

            excelTemp = this.lableDbDataSet1.Serials.NewSerialsRow();
            var selectedCombo = Excel_Combobox.SelectedItem.ToString();
            excelTemp = this.lableDbDataSet1.Serials.ToList().First(t => t.Excel_Path.Contains(selectedCombo));
            excelFile = new ExcelFile(excelTemp.Excel_Path, 1);
            //import scanned fields
            var scanSerialsList = this.lableDbDataSet1.SerialScan.Where(t => t.Serial_ID == excelTemp.Serial_ID).ToList();
            foreach (var scanSerial in scanSerialsList)
            {
                //add new row to ScansDataGridView
                DataRow dr = dt.NewRow();
                dr["SerialId"] = scanSerial.Serial_ID;
                dr["Scans"] = scanSerial.Scan_Field;
                dr["RowIndex"] = scanSerial.Row_Number;
                dt.Rows.Add(dr);

            }
            ScansDataGridView.DataSource = dt;
            ScansDataGridView.Columns[0].Visible = false;
            ScansDataGridView.Columns[2].Visible = false;
        }

        private void Excel_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SaveDtToAccess();
                var selectedCombo = Excel_Combobox.SelectedItem.ToString();
                excelTemp = this.lableDbDataSet1.Serials.ToList().First(t => t.Excel_Path.Contains(selectedCombo));
                excelFile = new ExcelFile(excelTemp.Excel_Path, 1);
                serialScanRows = this.lableDbDataSet1.SerialScan.ToList().FindAll(t => t.Serial_ID == excelTemp.Serial_ID);
                ScansDataGridView.DataSource = null;
                ScansDataGridView.Rows.Clear();
                ScansDataGridView.Columns.Clear();
                dt.Columns.Clear();
                dt.Rows.Clear();
                //add columns to data table
                dt.Columns.Add("SerialId".ToString());
                dt.Columns.Add("Scans".ToString());
                dt.Columns.Add("RowIndex".ToString());
                var scanSerialsList = this.lableDbDataSet1.SerialScan.Where(t => t.Serial_ID == excelTemp.Serial_ID).ToList();
                foreach (var scanSerial in scanSerialsList)
                {
                    //add new row to ScansDataGridView
                    DataRow dr = dt.NewRow();
                    dr["SerialId"] = scanSerial.Serial_ID;
                    dr["Scans"] = scanSerial.Scan_Field;
                    dr["RowIndex"] = scanSerial.Row_Number;
                    dt.Rows.Add(dr);

                }
                ScansDataGridView.DataSource = dt;
                ScansDataGridView.Columns[0].Visible = false;
                ScansDataGridView.Columns[2].Visible = false;
            }
            catch
            {
                MessageBox.Show("در پر کردن جدول اسکن شده ها مشکلی پیش آمد.");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (LandScape_Checkbox.Checked == false)
                {
                    int leftPoint = pageLength - 20;
                    int topPoint = (pageWidth / 20) * 4;
                    int stepNumber = Convert.ToInt32(pageWidth / lableDetailList.FindAll(t => t.LD_PrintTitle == true).Count);
                    StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                    foreach (var item in lableDetailList)
                    {
                        if (item.LD_PrintTitle == true)
                        {
                            var valueTemp = excelFile.ReadCell(IndexRow, item.LD_Excell);
                            e.Graphics.DrawString(item.LD_Name + " : ", new Font("B Titr", pageLength / 25), Brushes.Black, new Point(leftPoint, topPoint + stepNumber / 6), format);
                            if (item.LD_Barcode == true)
                            {
                                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                                Image barcodeImage = barcode.Draw(valueTemp, 30);
                                e.Graphics.DrawImage(barcodeImage, new Point(pageLength - ((pageLength / 20) * 19), topPoint + 3));
                                e.Graphics.DrawString(valueTemp, new Font("Calibri", pageLength / 30, FontStyle.Bold), Brushes.Black, new Point(pageLength - ((pageLength / 20) * 19), topPoint + barcodeImage.Height + stepNumber / 8));
                                topPoint += stepNumber / 4;
                            }
                            else
                            {
                                e.Graphics.DrawString(valueTemp, new Font("Calibri", pageLength / 25, FontStyle.Bold), Brushes.Black, new Point(pageLength - ((pageLength / 20) * 19), topPoint + stepNumber / 7));

                            }
                            topPoint += Convert.ToInt32(stepNumber / 1.5);
                        }
                    }
                }
                else
                {
                    int leftPoint = pageWidth - 10;
                    int topPoint = (pageWidth / 20) * 2;
                    int stepNumber = Convert.ToInt32(pageWidth / (lableDetailList.FindAll(t => t.LD_PrintTitle == true).Count + lableDetailList.FindAll(t => t.LD_Barcode == true).Count));
                    StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                    foreach (var item in lableDetailList)
                    {
                        if (item.LD_PrintTitle == true)
                        {
                            var valueTemp = excelFile.ReadCell(IndexRow, item.LD_Excell);
                            e.Graphics.DrawString(item.LD_Name + " : ", new Font("B Titr", pageLength / 30), Brushes.Black, new Point(leftPoint, topPoint), format);
                            topPoint += stepNumber;
                            if (item.LD_Barcode == true)
                            {
                                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                                Image barcodeImage = barcode.Draw(valueTemp, 30);
                                e.Graphics.DrawImage(barcodeImage, new Point(pageLength - ((pageLength / 20) * 19), topPoint + 3));
                                e.Graphics.DrawString(valueTemp, new Font("Calibri", pageLength / 40, FontStyle.Bold), Brushes.Black, new Point(pageLength - ((pageLength / 20) * 19), topPoint + barcodeImage.Height + stepNumber / 10));
                                topPoint += stepNumber;
                            }
                            else
                            {
                                e.Graphics.DrawString(valueTemp, new Font("Calibri", pageLength / 30, FontStyle.Bold), Brushes.Black, new Point(pageLength - ((pageLength / 20) * 19), topPoint + stepNumber / 9));

                            }
                            topPoint += Convert.ToInt32(stepNumber);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده است.");
            }

        }

        private int mmToPixel(float mm, float dpi)
        {
            return (int)Math.Round((mm / 25.4) * dpi);
        }

        private void PrintBarcodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDtToAccess();
            ListLableForm._listLable.Show();
        }

        private void SaveDtToAccess()
        {
            try
            {
                //save ScansDataGridView data in access
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!this.lableDbDataSet1.SerialScan.Any(t => t.Scan_Field == dt.Rows[i][1].ToString()))
                        {
                            this.lableDbDataSet1.SerialScan.AddSerialScanRow(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1].ToString(), Convert.ToInt32(dt.Rows[i][2]));
                        }
                    }
                }
                this.serialScanTableAdapter1.Update(this.lableDbDataSet1.SerialScan);
                this.lableDbDataSet1.SerialScan.AcceptChanges();
            }
            catch
            {

            }
        }

        private void Scan_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(Scan_Textbox.Text) == false)
                    {
                        int cellIndex = lableDetailList.Find(t => t.LD_Scan == true).LD_Excell;
                        int rowindex = excelFile.search(Scan_Textbox.Text, cellIndex);
                        if (rowindex == -1)
                        {
                            MessageBox.Show("یافت نشد");
                        }
                        else
                        {
                            IndexRow = rowindex;
                            float dpi = 96;
                            pageWidth = mmToPixel(float.Parse(selectLable.Width.ToString()), dpi);
                            pageLength = mmToPixel(float.Parse(selectLable.Length.ToString()), dpi);
                            if (LandScape_Checkbox.Checked == true)
                            {
                                printDocument1.DefaultPageSettings.Landscape = true;
                            }
                            else
                            {
                                printDocument1.DefaultPageSettings.Landscape = false;
                            }
                            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("mySize", pageLength, pageWidth);
                            printDocument1.Print();



                            //check scan code is exist in ScansDataGridView
                            bool IsExist = false;
                            foreach (DataGridViewRow row in this.ScansDataGridView.Rows)
                            {
                                if (row.Cells[1].Value.Equals(Scan_Textbox.Text))
                                {
                                    // row exists
                                    IsExist = true;
                                    break;
                                }
                            }

                            if (!IsExist)
                            {
                                //add new row to ScansDataGridView
                                DataRow dr = dt.NewRow();
                                dr["SerialId"] = excelTemp.Serial_ID;
                                dr["Scans"] = Scan_Textbox.Text;
                                dr["RowIndex"] = IndexRow;
                                dt.Rows.Add(dr);
                                ScansDataGridView.DataSource = dt;
                                ScansDataGridView.Columns[0].Visible = false;
                                ScansDataGridView.Columns[2].Visible = false;
                            }
                            ScansDataGridView.Rows.OfType<DataGridViewRow>().Last().Selected = true;
                            ScansDataGridView.FirstDisplayedScrollingRowIndex = ScansDataGridView.RowCount - 1;
                            Scan_Textbox.Text = null;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده است.");
            }
        }

        private void ContainerTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ContainerTextBox.Text) == false)
            {
                Scan_Textbox.Enabled = true;
                ExcelExportButton.Enabled = true;
                Scan_Textbox.Focus();
            }
        }

        private void ExcelExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtToExcel = new DataTable();
                for (int i = 1; i <= excelFile.Range.Columns.Count; i++)
                {
                    dtToExcel.Columns.Add(excelFile.ReadCell(1, i));
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    List<string> list = new List<string>();
                    list = excelFile.RowContent(Convert.ToInt32(dt.Rows[i][2]));
                    DataRow dataRow = dtToExcel.NewRow();
                    dataRow[0] = list[0];
                    dataRow[1] = list[1];
                    dataRow[2] = list[2];
                    dataRow[3] = list[3];
                    dtToExcel.Rows.Add(dataRow);
                }

                // Start Excel and get Application object.  
                var excel = new Excel.Application();
                // for making Excel visible  
                excel.Visible = false;
                excel.DisplayAlerts = false;
                // Creation a new Workbook  
                var excelworkBook = excel.Workbooks.Add(Type.Missing);
                // Workk sheet  
                var excelSheet = (Excel.Worksheet)excelworkBook.ActiveSheet;
                var usedRange = excelSheet.UsedRange;
                excelSheet.Name = ContainerTextBox.Text;
                excelSheet.Cells[1, 1] = dtToExcel.Columns[0].ColumnName;
                excelSheet.Cells[1, 2] = dtToExcel.Columns[1].ColumnName;
                excelSheet.Cells[1, 3] = dtToExcel.Columns[2].ColumnName;
                excelSheet.Cells[1, 4] = dtToExcel.Columns[3].ColumnName;
                for (int i = 0; i < dtToExcel.Rows.Count; i++)
                {
                    for (int j = 0; j < dtToExcel.Rows.Count; j++)
                    {
                        excelSheet.Cells[j + 2, 1] = dtToExcel.Rows[i][0];
                        excelSheet.Cells[j + 2, 2] = dtToExcel.Rows[i][1];
                        excelSheet.Cells[j + 2, 3] = dtToExcel.Rows[i][2];
                        excelSheet.Cells[j + 2, 4] = dtToExcel.Rows[i][3];
                    }
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = ContainerTextBox.Text;
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.Filter = "Excel(*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelworkBook.SaveAs(Path.Combine(saveFileDialog.FileName));
                    MessageBox.Show("با موفقیت ذخیره شد.");
                }






            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است.");
            }
        }
    }
}
