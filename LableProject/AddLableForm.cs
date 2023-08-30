using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LableProject.LableDbDataSet;

namespace LableProject
{
    public partial class AddLable : Form
    {
        public int LableId { get; set; }
        public LableRow editLable { get; set; }
        public AddLable()
        {
            LableId = -1;
            InitializeComponent();
        }
        public AddLable(int Id)
        {
            LableId = Id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lableTableAdapter.Fill(this.lableDbDataSet.Lable);
            if(LableId >= 0)
            {
                editLable = this.lableDbDataSet.Lable.FindByID(LableId);
                Title_Textbox.Text = editLable.Title;
                Length_Textbox.Text = editLable.Length.ToString();
                Width_Textbox.Text = editLable.Width.ToString();
                Add_Lable.Text = "ثبت تغییرات";
            }
        }

        private void Add_Lable_Click(object sender, EventArgs e)
        {

            LableViewModel model = new LableViewModel();
            model.Title = Title_Textbox.Text;
            model.Length = Convert.ToInt32(Length_Textbox.Text);
            model.Width = Convert.ToInt32(Width_Textbox.Text);

            if(model.Title != null && model.Length != 0 && model.Width!=0)
            {
                if(LableId == -1)
                {
                    this.lableDbDataSet.Lable.AddLableRow(model.Title, model.Length, model.Width);
                    this.lableTableAdapter.Update(this.lableDbDataSet.Lable);
                    this.lableDbDataSet.AcceptChanges();
                    MessageBox.Show("برچسب با موفقیت ثبت شد.");
                    ListLableForm._listLable.ReloadData();
                    this.Close();
                }
                else
                {
                    editLable.ID = LableId;
                    editLable.Title = Title_Textbox.Text;
                    editLable.Length = Convert.ToInt32(Length_Textbox.Text);
                    editLable.Width = Convert.ToInt32(Width_Textbox.Text);
                    this.lableTableAdapter.Update(editLable);
                    this.lableDbDataSet.AcceptChanges();
                    MessageBox.Show("تغییرات برچسب با موفقیت ثبت شد.");
                    ListLableForm._listLable.ReloadData();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("در ثبت برچسب خطایی رخ داد.");
            }

        }
    }
}
