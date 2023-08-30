using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LableProject
{
    public partial class ListLableForm : Form
    {
        public static ListLableForm _listLable { get; set; }
        public string lableId { get; set; }
        public ListLableForm()
        {
            InitializeComponent();
            _listLable = this;
        }

        private void ListLableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lableDbDataSet.Lable' table. You can move, or remove it, as needed.
            this.lableTableAdapter.Fill(this.lableDbDataSet.Lable);
            this.serialsTableAdapter1.Fill(this.lableDbDataSet.Serials);
            this.serialScanTableAdapter1.Fill(this.lableDbDataSet.SerialScan);
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            LableList.Columns.Add(btnDelete);
            btnDelete.Width = 110;
            btnDelete.HeaderText = "حذف";
            btnDelete.Text = "حذف برچسب";
            btnDelete.Name = "Delete_Btn";
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.DefaultCellStyle.SelectionBackColor = Color.Red;
            btnDelete.DefaultCellStyle.SelectionForeColor = Color.White;
            btnDelete.DefaultCellStyle.BackColor = Color.Red;
            btnDelete.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnExcel = new DataGridViewButtonColumn();
            LableList.Columns.Add(btnExcel);
            btnExcel.Width = 110;
            btnExcel.HeaderText = "آپلود اکسل";
            btnExcel.Text = "آپلود اکسل";
            btnExcel.Name = "Delete_Btn";
            btnExcel.FlatStyle = FlatStyle.Popup;
            btnExcel.DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            btnExcel.DefaultCellStyle.BackColor = Color.ForestGreen;
            btnExcel.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnScan = new DataGridViewButtonColumn();
            LableList.Columns.Add(btnScan);
            btnScan.Width = 110;
            btnScan.HeaderText = "چاپ بارکد";
            btnScan.Text = "شروع اسکن";
            btnScan.Name = "Scan_Btn";
            btnScan.FlatStyle = FlatStyle.Popup;
            btnScan.DefaultCellStyle.SelectionBackColor = Color.Blue;
            btnScan.DefaultCellStyle.BackColor = Color.Blue;
            btnScan.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnEditLable = new DataGridViewButtonColumn();
            LableList.Columns.Add(btnEditLable);
            btnEditLable.Width = 110;
            btnEditLable.HeaderText = "تغییرات";
            btnEditLable.Text = "تغییر سطر";
            btnEditLable.Name = "Edit_Row";
            btnEditLable.FlatStyle = FlatStyle.Popup;
            btnEditLable.DefaultCellStyle.SelectionBackColor = Color.Orange;
            btnEditLable.DefaultCellStyle.SelectionForeColor = Color.White;
            btnEditLable.DefaultCellStyle.BackColor = Color.Orange;
            btnEditLable.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnExcelList = new DataGridViewButtonColumn();
            LableList.Columns.Add(btnExcelList);
            btnExcelList.Width = 110;
            btnExcelList.HeaderText = "فایل های اکسل";
            btnExcelList.Text = "مشاهده فایل‌ها";
            btnExcelList.Name = "ExcelList_Row";
            btnExcelList.FlatStyle = FlatStyle.Popup;
            btnExcelList.DefaultCellStyle.SelectionBackColor = Color.Orange;
            btnExcelList.DefaultCellStyle.SelectionForeColor = Color.White;
            btnExcelList.DefaultCellStyle.BackColor = Color.Orange;
            btnExcelList.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnDeleteDetail = new DataGridViewButtonColumn();
            LableDetailList.Columns.Add(btnDeleteDetail);
            btnDeleteDetail.Width = 110;
            btnDeleteDetail.HeaderText = "حذف سطر";
            btnDeleteDetail.Text = "حذف سطر";
            btnDeleteDetail.Name = "Delete_Row";
            btnDeleteDetail.FlatStyle = FlatStyle.Popup;
            btnDeleteDetail.DefaultCellStyle.SelectionBackColor = Color.Red;
            btnDeleteDetail.DefaultCellStyle.SelectionForeColor = Color.White;
            btnDeleteDetail.DefaultCellStyle.BackColor = Color.Red;
            btnDeleteDetail.UseColumnTextForButtonValue = true;

        }
        // دکمه اضافه کردن برچسب
        private void addLableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLable addLable = new AddLable();
            addLable.ShowDialog();
        }
        //بارگیری مجدد داده ها
        public void ReloadData()
        {
            this.lableTableAdapter.Fill(this.lableDbDataSet.Lable);
            this.serialsTableAdapter1.Fill(this.lableDbDataSet.Serials);
            this.serialScanTableAdapter1.Fill(this.lableDbDataSet.SerialScan);
        }
        // دکمه های داخل گرید
        private void LableList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DialogResult DeleteResult = MessageBox.Show("آیا برای حذف اطمینان دارید ؟", "حذف برچسب", MessageBoxButtons.YesNo);
                if (DeleteResult == DialogResult.Yes)
                {
                    try
                    {
                        var getId = LableList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        var selectRow = lableDbDataSet.Lable.FindByID(int.Parse(getId));
                        this.lableDbDataSet.Lable.RemoveLableRow(selectRow);
                        this.lableDetailTableAdapter.FillByFilter(this.lableDbDataSet.LableDetail, int.Parse(getId));
                        var detailList = this.lableDbDataSet.LableDetail.ToList().FindAll(t => t.Lable_Id == int.Parse(getId));
                        foreach (var item in detailList)
                        {
                            this.lableDetailTableAdapter.DeleteByID(item.LD_ID);
                        }

                        var Excellist = this.lableDbDataSet.Serials.ToList().FindAll(t => t.Lable_ID == int.Parse(getId));
                        foreach (var item in Excellist)
                        {
                            this.serialsTableAdapter1.DeleteById(item.Serial_ID);
                            this.serialScanTableAdapter1.DeleteByID(item.Serial_ID);
                        }
                        this.lableDbDataSet.Serials.AcceptChanges();
                        this.lableDbDataSet.LableDetail.AcceptChanges();
                        this.lableDbDataSet.SerialScan.AcceptChanges();
                        this.lableDbDataSet.Lable.AcceptChanges();
                        this.lableTableAdapter.Update(lableDbDataSet.Lable);
                        this.lableDetailTableAdapter.Update(this.lableDbDataSet.LableDetail);
                        this.serialsTableAdapter1.Update(this.lableDbDataSet.Serials);
                        this.serialScanTableAdapter1.Update(this.lableDbDataSet.SerialScan);
                        var result = this.lableTableAdapter.DeleteById(int.Parse(getId));
                        if (result == 0)
                        {
                            MessageBox.Show("حذف با موفقیت انجام شد.");
                            this.ReloadData();
                        }
                        else
                        {
                            MessageBox.Show("مشکلی پیش آمد.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("مشکلی پیش آمده.");
                    }
                }

            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var getId = LableList.Rows[e.RowIndex].Cells[0].Value.ToString();
                ExcellUpload(int.Parse(getId));
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                var getId = LableList.Rows[e.RowIndex].Cells[0].Value.ToString();
                PrintBarcode(int.Parse(getId));
            }
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                var getId = LableList.Rows[e.RowIndex].Cells[0].Value.ToString();
                AddLable addLable = new AddLable(int.Parse(getId));
                addLable.ShowDialog();
            }
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                var getId = LableList.Rows[e.RowIndex].Cells[0].Value.ToString();
                ExcelList excelList = new ExcelList(int.Parse(getId));
                excelList.ShowDialog();
            }

            if (e.ColumnIndex < 4 && e.RowIndex >= 0)
            {
                lableId = LableList.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.lableDetailTableAdapter.FillByFilter(this.lableDbDataSet.LableDetail, int.Parse(lableId));
                var data = lableDetailTableAdapter.GetData().ToList().FindAll(t => t.Lable_Id == int.Parse(lableId));
                Scan_ComboList.Items.Clear();
                Scan_ComboList.SelectedItem = null;
                Scan_ComboList.ResetText();
                foreach (var item in data)
                {
                    Scan_ComboList.Items.Add(item.LD_Name);
                    if (item.LD_Scan == true)
                    {
                        Scan_ComboList.SelectedItem = item.LD_Name;
                    }
                }
            }


        }
        //باز شدن فرم چاپ بارکد
        private void PrintBarcode(int Id)
        {
            PrintBarcodeForm printBarcodeForm = new PrintBarcodeForm(Id);
            this.Hide();
            printBarcodeForm.Show();
        }

        // بازشدن فرم آپلود اکسل
        private void ExcellUpload(int Id)
        {
            ExcelUploadForm formExcel = new ExcelUploadForm(Id);
            formExcel.Show();
        }
        // دکمه ثبت تغییرات
        private void SubmitColumn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in this.lableDbDataSet.LableDetail)
                {
                    item.Lable_Id = int.Parse(lableId);
                }
                this.lableDetailTableAdapter.Update(this.lableDbDataSet.LableDetail);
                this.lableDbDataSet.AcceptChanges();
                this.lableDetailTableAdapter.FillByFilter(this.lableDbDataSet.LableDetail, int.Parse(lableId));
                MessageBox.Show("تغییرات با موفقیت ثبت شد.");
                ReloadCombolistItems();
            }
            catch
            {
                for (int i = 0; i < LableDetailList.Rows.Count; i++)
                {
                    if (LableDetailList.Rows[i].Cells[4].Value == null)
                    {
                        string error = ("شماره ستون اکسل برای ردیف " + i + " خالی میباشد. لطفا این فیلد را پر کنید.");
                        MessageBox.Show(error);
                        return;
                    }
                }
                MessageBox.Show("مشکلی پیش آمده ! \n مطمعن شوید که از جدول بالا سطر درست انتخاب شده است.");
            }
        }
        //کمبولیست مربوط به اسکن
        private void Scan_ComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var scan = Scan_ComboList.SelectedItem.ToString();
            if (scan != null)
            {
                foreach (var item in this.lableDbDataSet.LableDetail)
                {
                    item.LD_Scan = false;
                }
                this.lableDbDataSet.LableDetail.First(t => t.LD_Name == scan).LD_Scan = true;
                this.lableDetailTableAdapter.Update(this.lableDbDataSet.LableDetail);
                lableDbDataSet.AcceptChanges();
            }
        }
        //تغییر حالت ماوس زمان ورود روی دکمه گرید
        private void LableList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                dataGridView.Cursor = Cursors.Hand;
            }
            else
                dataGridView.Cursor = Cursors.Default;
        }
        // بارگزاری مجدد کمبو لیست
        private void ReloadCombolistItems()
        {
            var data = lableDetailTableAdapter.GetData().ToList().FindAll(t => t.Lable_Id == int.Parse(lableId));
            Scan_ComboList.Items.Clear();
            Scan_ComboList.SelectedItem = null;
            Scan_ComboList.ResetText();
            foreach (var item in data)
            {
                Scan_ComboList.Items.Add(item.LD_Name);
                if (item.LD_Scan == true)
                {
                    Scan_ComboList.SelectedItem = item.LD_Name;
                }
            }
        }
        // کلیک برروی دکمه های جدول جزئیات
        private void LableDetailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                DialogResult DeleteDetailResult = MessageBox.Show("آیا برای حذف اطمینان دارید ؟", "حذف سطر", MessageBoxButtons.YesNo);
                try
                {
                    if (DeleteDetailResult == DialogResult.Yes)
                    {
                        var getId = LableDetailList.Rows[e.RowIndex].Cells[5].Value.ToString();
                        var selectRow = lableDbDataSet.LableDetail.FindByLD_ID(int.Parse(getId));
                        this.lableDbDataSet.LableDetail.RemoveLableDetailRow(selectRow);
                        this.lableDbDataSet.LableDetail.AcceptChanges();
                        this.lableDetailTableAdapter.Update(lableDbDataSet.LableDetail);
                        this.lableDetailTableAdapter.DeleteByID(int.Parse(getId));
                    }
                }
                catch
                {
                    MessageBox.Show("در فرایند حذف مشکلی پیش آمد. مجدد تلاش کنید.");
                }
            }
        }
    }

}
