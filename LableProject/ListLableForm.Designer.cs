namespace LableProject
{
    partial class ListLableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LableList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableDbDataSet = new LableProject.LableDbDataSet();
            this.LableDetailList = new System.Windows.Forms.DataGridView();
            this.lDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDBarcodeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lDPrintTitleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lDScanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lDExcellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lableDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addLableToolStripMenuItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Scan_ComboList = new System.Windows.Forms.ComboBox();
            this.SubmitColumn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lableTableAdapter = new LableProject.LableDbDataSetTableAdapters.LableTableAdapter();
            this.lableDetailTableAdapter = new LableProject.LableDbDataSetTableAdapters.LableDetailTableAdapter();
            this.serialsTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialsTableAdapter();
            this.serialScanTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialScanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LableDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LableList
            // 
            this.LableList.AllowUserToAddRows = false;
            this.LableList.AllowUserToDeleteRows = false;
            this.LableList.AllowUserToResizeColumns = false;
            this.LableList.AllowUserToResizeRows = false;
            this.LableList.AutoGenerateColumns = false;
            this.LableList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LableList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.titleDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn});
            this.LableList.DataSource = this.lableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LableList.DefaultCellStyle = dataGridViewCellStyle2;
            this.LableList.Location = new System.Drawing.Point(7, 11);
            this.LableList.MultiSelect = false;
            this.LableList.Name = "LableList";
            this.LableList.ReadOnly = true;
            this.LableList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Zar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LableList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LableList.RowHeadersVisible = false;
            this.LableList.RowHeadersWidth = 51;
            this.LableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LableList.Size = new System.Drawing.Size(997, 268);
            this.LableList.TabIndex = 0;
            this.LableList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LableList_CellClick);
            this.LableList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.LableList_CellMouseEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "شماره آیدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "عنوان";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "طول (میلی متر)";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "عرض (میلی متر)";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lableBindingSource
            // 
            this.lableBindingSource.DataMember = "Lable";
            this.lableBindingSource.DataSource = this.lableDbDataSet;
            // 
            // lableDbDataSet
            // 
            this.lableDbDataSet.DataSetName = "LableDbDataSet";
            this.lableDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LableDetailList
            // 
            this.LableDetailList.AllowUserToResizeColumns = false;
            this.LableDetailList.AllowUserToResizeRows = false;
            this.LableDetailList.AutoGenerateColumns = false;
            this.LableDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LableDetailList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LableDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LableDetailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lDNameDataGridViewTextBoxColumn,
            this.lDBarcodeDataGridViewCheckBoxColumn,
            this.lDPrintTitleDataGridViewCheckBoxColumn,
            this.lDScanDataGridViewCheckBoxColumn,
            this.lDExcellDataGridViewTextBoxColumn,
            this.LD_ID});
            this.LableDetailList.DataSource = this.lableDetailBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LableDetailList.DefaultCellStyle = dataGridViewCellStyle5;
            this.LableDetailList.Location = new System.Drawing.Point(89, 358);
            this.LableDetailList.MultiSelect = false;
            this.LableDetailList.Name = "LableDetailList";
            this.LableDetailList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Zar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LableDetailList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.LableDetailList.RowHeadersVisible = false;
            this.LableDetailList.RowHeadersWidth = 51;
            this.LableDetailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LableDetailList.Size = new System.Drawing.Size(837, 242);
            this.LableDetailList.TabIndex = 2;
            this.LableDetailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LableDetailList_CellContentClick);
            // 
            // lDNameDataGridViewTextBoxColumn
            // 
            this.lDNameDataGridViewTextBoxColumn.DataPropertyName = "LD_Name";
            this.lDNameDataGridViewTextBoxColumn.HeaderText = "نام ستون";
            this.lDNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lDNameDataGridViewTextBoxColumn.Name = "lDNameDataGridViewTextBoxColumn";
            // 
            // lDBarcodeDataGridViewCheckBoxColumn
            // 
            this.lDBarcodeDataGridViewCheckBoxColumn.DataPropertyName = "LD_Barcode";
            this.lDBarcodeDataGridViewCheckBoxColumn.HeaderText = "بارکد";
            this.lDBarcodeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lDBarcodeDataGridViewCheckBoxColumn.Name = "lDBarcodeDataGridViewCheckBoxColumn";
            // 
            // lDPrintTitleDataGridViewCheckBoxColumn
            // 
            this.lDPrintTitleDataGridViewCheckBoxColumn.DataPropertyName = "LD_PrintTitle";
            this.lDPrintTitleDataGridViewCheckBoxColumn.HeaderText = "چاپ عنوان";
            this.lDPrintTitleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lDPrintTitleDataGridViewCheckBoxColumn.Name = "lDPrintTitleDataGridViewCheckBoxColumn";
            // 
            // lDScanDataGridViewCheckBoxColumn
            // 
            this.lDScanDataGridViewCheckBoxColumn.DataPropertyName = "LD_Scan";
            this.lDScanDataGridViewCheckBoxColumn.HeaderText = "اسکن";
            this.lDScanDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lDScanDataGridViewCheckBoxColumn.Name = "lDScanDataGridViewCheckBoxColumn";
            this.lDScanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lDExcellDataGridViewTextBoxColumn
            // 
            this.lDExcellDataGridViewTextBoxColumn.DataPropertyName = "LD_Excell";
            this.lDExcellDataGridViewTextBoxColumn.HeaderText = "شماره ستون اکسل";
            this.lDExcellDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lDExcellDataGridViewTextBoxColumn.Name = "lDExcellDataGridViewTextBoxColumn";
            // 
            // LD_ID
            // 
            this.LD_ID.DataPropertyName = "LD_ID";
            this.LD_ID.HeaderText = "LD_ID";
            this.LD_ID.MinimumWidth = 6;
            this.LD_ID.Name = "LD_ID";
            this.LD_ID.ReadOnly = true;
            this.LD_ID.Visible = false;
            // 
            // lableDetailBindingSource
            // 
            this.lableDetailBindingSource.DataMember = "LableDetail";
            this.lableDetailBindingSource.DataSource = this.lableDbDataSet;
            // 
            // addLableToolStripMenuItem
            // 
            this.addLableToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.addLableToolStripMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLableToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLableToolStripMenuItem.Font = new System.Drawing.Font("B Titr", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addLableToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addLableToolStripMenuItem.Location = new System.Drawing.Point(988, 284);
            this.addLableToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.addLableToolStripMenuItem.Name = "addLableToolStripMenuItem";
            this.addLableToolStripMenuItem.Size = new System.Drawing.Size(19, 20);
            this.addLableToolStripMenuItem.TabIndex = 3;
            this.addLableToolStripMenuItem.Text = "+";
            this.addLableToolStripMenuItem.UseCompatibleTextRendering = true;
            this.addLableToolStripMenuItem.UseVisualStyleBackColor = false;
            this.addLableToolStripMenuItem.Click += new System.EventHandler(this.addLableToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(808, 612);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "کدام ستون اسکن شود ؟";
            // 
            // Scan_ComboList
            // 
            this.Scan_ComboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scan_ComboList.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Scan_ComboList.FormattingEnabled = true;
            this.Scan_ComboList.Location = new System.Drawing.Point(616, 613);
            this.Scan_ComboList.Margin = new System.Windows.Forms.Padding(2);
            this.Scan_ComboList.Name = "Scan_ComboList";
            this.Scan_ComboList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Scan_ComboList.Size = new System.Drawing.Size(175, 29);
            this.Scan_ComboList.TabIndex = 4;
            this.Scan_ComboList.SelectedIndexChanged += new System.EventHandler(this.Scan_ComboList_SelectedIndexChanged);
            // 
            // SubmitColumn
            // 
            this.SubmitColumn.AutoSize = true;
            this.SubmitColumn.BackColor = System.Drawing.Color.DarkOrange;
            this.SubmitColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitColumn.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SubmitColumn.Location = new System.Drawing.Point(89, 607);
            this.SubmitColumn.Name = "SubmitColumn";
            this.SubmitColumn.Size = new System.Drawing.Size(78, 35);
            this.SubmitColumn.TabIndex = 6;
            this.SubmitColumn.Text = "ثبت تغییرات";
            this.SubmitColumn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubmitColumn.UseVisualStyleBackColor = false;
            this.SubmitColumn.Click += new System.EventHandler(this.SubmitColumn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(793, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "مشخصات برچسب انتخابی :";
            // 
            // lableTableAdapter
            // 
            this.lableTableAdapter.ClearBeforeFill = true;
            // 
            // lableDetailTableAdapter
            // 
            this.lableDetailTableAdapter.ClearBeforeFill = true;
            // 
            // serialsTableAdapter1
            // 
            this.serialsTableAdapter1.ClearBeforeFill = true;
            // 
            // serialScanTableAdapter1
            // 
            this.serialScanTableAdapter1.ClearBeforeFill = true;
            // 
            // ListLableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scan_ComboList);
            this.Controls.Add(this.addLableToolStripMenuItem);
            this.Controls.Add(this.LableDetailList);
            this.Controls.Add(this.LableList);
            this.Name = "ListLableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست برچسب ها";
            this.Load += new System.EventHandler(this.ListLableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LableDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LableList;
        private LableDbDataSet lableDbDataSet;
        private System.Windows.Forms.BindingSource lableBindingSource;
        private LableDbDataSetTableAdapters.LableTableAdapter lableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView LableDetailList;
        private System.Windows.Forms.BindingSource lableDetailBindingSource;
        private LableDbDataSetTableAdapters.LableDetailTableAdapter lableDetailTableAdapter;
        private System.Windows.Forms.Button addLableToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Scan_ComboList;
        private System.Windows.Forms.Button SubmitColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lDBarcodeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lDPrintTitleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lDScanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDExcellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LD_ID;
        private LableDbDataSetTableAdapters.SerialsTableAdapter serialsTableAdapter1;
        private LableDbDataSetTableAdapters.SerialScanTableAdapter serialScanTableAdapter1;
    }
}