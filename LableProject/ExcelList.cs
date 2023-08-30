using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static LableProject.LableDbDataSet;

namespace LableProject
{
    public partial class ExcelList : Form
    {
        public int LableId { get; set; }
        public List<SerialsRow> ListExcel { get; set; }
        public ExcelList(int Id)
        {
            LableId = Id;
            InitializeComponent();
        }

        private void ExcelList_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'lableDbDataSet.Serials' table. You can move, or remove it, as needed.
                this.serialsTableAdapter.FillByID(this.lableDbDataSet.Serials, LableId);
                this.lableTableAdapter1.Fill(this.lableDbDataSet.Lable);
                this.serialScanTableAdapter1.Fill(this.lableDbDataSet.SerialScan);
                ListExcel = this.lableDbDataSet.Serials.ToList().FindAll(t => t.Lable_ID == LableId);
                if (Excel_List_Grid.Rows.Count > 0)
                {
                    Excel_List_Grid.Rows.RemoveAt(Excel_List_Grid.Rows.Count);
                }
                foreach (var item in ListExcel)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Excel_List_Grid);
                    row.Cells[0].Value = item.Serial_ID;
                    row.Cells[1].Value = item.Excel_Path.Split('#').Last();
                    row.Cells[2].Value = this.lableDbDataSet.Lable.ToList().Find(t => t.ID == LableId).Title;
                    Excel_List_Grid.Rows.Insert(Excel_List_Grid.Rows.Count, row);
                    Excel_List_Grid.Update();
                }
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده. مجدد تلاش کنید.");
            }
        }

        private void Excel_List_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    int selectedRowCount = Excel_List_Grid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            var idDelete = int.Parse(Excel_List_Grid.SelectedRows[0].Cells[0].Value.ToString());
                            this.serialsTableAdapter.DeleteById(idDelete);
                            this.serialScanTableAdapter1.DeleteByID(idDelete);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("مشکلی پیش آمده ! لطفا مجدد تلاش کنید.");
                }
            }
        }
    }
}
