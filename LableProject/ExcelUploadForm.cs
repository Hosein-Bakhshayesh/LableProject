using Barcode.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static LableProject.LableDbDataSet;

namespace LableProject
{
    public partial class ExcelUploadForm : Form
    {
        public int IdSelect { get; set; }
        public ExcelFile excelFile { get; set; }
        public List<LableDetailRow> lableDetailList { get; set; }
        public ExcelUploadForm(int Id)
        {
            InitializeComponent();
            IdSelect = Id;
        }

        private void ExcelUploadForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lableDbDataSet.Lable' table. You can move, or remove it, as needed.
            this.lableTableAdapter.Fill(this.lableDbDataSet.Lable);
            this.lableDetailTableAdapter1.Fill(this.lableDbDataSet.LableDetail);
            this.serialScanTableAdapter1.Fill(this.lableDbDataSet.SerialScan);
            Title_Box.SelectedValue = this.IdSelect;
            Title_Box.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Title_Box.SelectedValue.ToString()))
            {
                var select = this.lableDbDataSet.Lable.FindByID(int.Parse(Title_Box.SelectedValue.ToString()));
                lableDetailList = lableDetailTableAdapter1.GetData().ToList().FindAll(t => t.Lable_Id == IdSelect);
            }
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel(*.xlsx)|*.xlsx";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    excelFile = new ExcelFile(fileDialog.FileName, 1);
                    if (excelFile.Range.Columns.Count != lableDetailList.Count)
                    {
                        MessageBox.Show("تعداد ستون های اکسل درست نمیباشد.");
                        return;
                    }
                    var Folder = Path.Combine(Application.StartupPath + "\\ExcelFile\\");
                    if (!Directory.Exists(Folder))
                    {
                        Directory.CreateDirectory(Folder);
                    }
                    Path.GetExtension(fileDialog.FileName);
                    var newFileName = Path.Combine(Application.StartupPath + "\\ExcelFile\\" + Guid.NewGuid().ToString().Replace("-", "") + "#" + fileDialog.FileName.Split('\\').Last().ToString());
                    File.Copy(fileDialog.FileName, newFileName);
                    this.lableDbDataSet.Serials.AddSerialsRow(newFileName, IdSelect);
                    this.serialsTableAdapter1.Update(this.lableDbDataSet.Serials);
                    this.serialsTableAdapter1.Fill(this.lableDbDataSet.Serials);
                    SerialsRow excelTemp = this.lableDbDataSet.Serials.ToList().Find(t => t.Excel_Path == newFileName);
                    this.lableDbDataSet.AcceptChanges();
                    MessageBox.Show("آپلود با موفقیت انجام شد.");
                    ListLableForm._listLable.ReloadData();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("مجدد تلاش کنید.");
                }
            }
        }
    }
}
