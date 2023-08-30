namespace LableProject
{
    partial class ExcelList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Excel_List_Grid = new System.Windows.Forms.DataGridView();
            this.serialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableDbDataSet = new LableProject.LableDbDataSet();
            this.serialsTableAdapter = new LableProject.LableDbDataSetTableAdapters.SerialsTableAdapter();
            this.lableTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.LableTableAdapter();
            this.Serial_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lable_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialScanTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialScanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Excel_List_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Excel_List_Grid
            // 
            this.Excel_List_Grid.AllowUserToAddRows = false;
            this.Excel_List_Grid.AllowUserToResizeColumns = false;
            this.Excel_List_Grid.AllowUserToResizeRows = false;
            this.Excel_List_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Excel_List_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Excel_List_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Excel_List_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_ID,
            this.ExcelName,
            this.Lable_ID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Excel_List_Grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Excel_List_Grid.Location = new System.Drawing.Point(0, -1);
            this.Excel_List_Grid.Name = "Excel_List_Grid";
            this.Excel_List_Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Excel_List_Grid.Size = new System.Drawing.Size(799, 451);
            this.Excel_List_Grid.TabIndex = 0;
            this.Excel_List_Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Excel_List_Grid_KeyDown);
            // 
            // serialsBindingSource
            // 
            this.serialsBindingSource.DataMember = "Serials";
            this.serialsBindingSource.DataSource = this.lableDbDataSet;
            // 
            // lableDbDataSet
            // 
            this.lableDbDataSet.DataSetName = "LableDbDataSet";
            this.lableDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serialsTableAdapter
            // 
            this.serialsTableAdapter.ClearBeforeFill = true;
            // 
            // lableTableAdapter1
            // 
            this.lableTableAdapter1.ClearBeforeFill = true;
            // 
            // Serial_ID
            // 
            this.Serial_ID.HeaderText = "Serial_ID";
            this.Serial_ID.Name = "Serial_ID";
            this.Serial_ID.Visible = false;
            // 
            // ExcelName
            // 
            this.ExcelName.HeaderText = "نام فایل";
            this.ExcelName.Name = "ExcelName";
            this.ExcelName.ReadOnly = true;
            // 
            // Lable_ID
            // 
            this.Lable_ID.HeaderText = "نام برچسب";
            this.Lable_ID.Name = "Lable_ID";
            this.Lable_ID.ReadOnly = true;
            // 
            // serialScanTableAdapter1
            // 
            this.serialScanTableAdapter1.ClearBeforeFill = true;
            // 
            // ExcelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excel_List_Grid);
            this.Name = "ExcelList";
            this.Text = "لیست فایل های اکسل";
            this.Load += new System.EventHandler(this.ExcelList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Excel_List_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Excel_List_Grid;
        private LableDbDataSet lableDbDataSet;
        private System.Windows.Forms.BindingSource serialsBindingSource;
        private LableDbDataSetTableAdapters.SerialsTableAdapter serialsTableAdapter;
        private LableDbDataSetTableAdapters.LableTableAdapter lableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lable_ID;
        private LableDbDataSetTableAdapters.SerialScanTableAdapter serialScanTableAdapter1;
    }
}