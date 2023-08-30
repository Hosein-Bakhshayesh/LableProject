namespace LableProject
{
    partial class PrintBarcodeForm
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
            this.Title_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Excel_Combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Scan_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lableDbDataSet1 = new LableProject.LableDbDataSet();
            this.serialsTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialsTableAdapter();
            this.lableDetailTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.LableDetailTableAdapter();
            this.lableTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.LableTableAdapter();
            this.serialScanTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialScanTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.LandScape_Checkbox = new System.Windows.Forms.CheckBox();
            this.ScansDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.ExcelExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScansDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Textbox
            // 
            this.Title_Textbox.Location = new System.Drawing.Point(296, 48);
            this.Title_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Title_Textbox.Name = "Title_Textbox";
            this.Title_Textbox.ReadOnly = true;
            this.Title_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Title_Textbox.Size = new System.Drawing.Size(174, 20);
            this.Title_Textbox.TabIndex = 0;
            this.Title_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(365, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Excel_Combobox
            // 
            this.Excel_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Excel_Combobox.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Excel_Combobox.FormattingEnabled = true;
            this.Excel_Combobox.Location = new System.Drawing.Point(31, 44);
            this.Excel_Combobox.Margin = new System.Windows.Forms.Padding(2);
            this.Excel_Combobox.Name = "Excel_Combobox";
            this.Excel_Combobox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Excel_Combobox.Size = new System.Drawing.Size(168, 29);
            this.Excel_Combobox.TabIndex = 2;
            this.Excel_Combobox.SelectedIndexChanged += new System.EventHandler(this.Excel_Combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(70, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام فایل اکسل :";
            // 
            // Scan_Textbox
            // 
            this.Scan_Textbox.Enabled = false;
            this.Scan_Textbox.Font = new System.Drawing.Font("B Nazanin", 9F);
            this.Scan_Textbox.Location = new System.Drawing.Point(4, 251);
            this.Scan_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Scan_Textbox.Name = "Scan_Textbox";
            this.Scan_Textbox.Size = new System.Drawing.Size(506, 25);
            this.Scan_Textbox.TabIndex = 8;
            this.Scan_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scan_Textbox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(472, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسکن :";
            // 
            // lableDbDataSet1
            // 
            this.lableDbDataSet1.DataSetName = "LableDbDataSet";
            this.lableDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serialsTableAdapter1
            // 
            this.serialsTableAdapter1.ClearBeforeFill = true;
            // 
            // lableDetailTableAdapter1
            // 
            this.lableDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // lableTableAdapter1
            // 
            this.lableTableAdapter1.ClearBeforeFill = true;
            // 
            // serialScanTableAdapter1
            // 
            this.serialScanTableAdapter1.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // LandScape_Checkbox
            // 
            this.LandScape_Checkbox.AutoSize = true;
            this.LandScape_Checkbox.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LandScape_Checkbox.Location = new System.Drawing.Point(383, 132);
            this.LandScape_Checkbox.Name = "LandScape_Checkbox";
            this.LandScape_Checkbox.Size = new System.Drawing.Size(87, 27);
            this.LandScape_Checkbox.TabIndex = 6;
            this.LandScape_Checkbox.Text = "چاپ عمودی";
            this.LandScape_Checkbox.UseVisualStyleBackColor = true;
            // 
            // ScansDataGridView
            // 
            this.ScansDataGridView.AllowUserToAddRows = false;
            this.ScansDataGridView.AllowUserToDeleteRows = false;
            this.ScansDataGridView.AllowUserToOrderColumns = true;
            this.ScansDataGridView.AllowUserToResizeColumns = false;
            this.ScansDataGridView.AllowUserToResizeRows = false;
            this.ScansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScansDataGridView.Location = new System.Drawing.Point(4, 291);
            this.ScansDataGridView.MultiSelect = false;
            this.ScansDataGridView.Name = "ScansDataGridView";
            this.ScansDataGridView.ReadOnly = true;
            this.ScansDataGridView.Size = new System.Drawing.Size(504, 212);
            this.ScansDataGridView.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContainerTextBox);
            this.groupBox1.Controls.Add(this.LandScape_Checkbox);
            this.groupBox1.Controls.Add(this.Excel_Combobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Title_Textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(504, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پرینت اسکن ها";
            // 
            // ContainerTextBox
            // 
            this.ContainerTextBox.Location = new System.Drawing.Point(31, 135);
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.Size = new System.Drawing.Size(168, 20);
            this.ContainerTextBox.TabIndex = 7;
            this.ContainerTextBox.Leave += new System.EventHandler(this.ContainerTextBox_Leave);
            // 
            // ExcelExportButton
            // 
            this.ExcelExportButton.Enabled = false;
            this.ExcelExportButton.Location = new System.Drawing.Point(4, 509);
            this.ExcelExportButton.Name = "ExcelExportButton";
            this.ExcelExportButton.Size = new System.Drawing.Size(124, 37);
            this.ExcelExportButton.TabIndex = 9;
            this.ExcelExportButton.Text = "خروجی اکسل";
            this.ExcelExportButton.UseVisualStyleBackColor = true;
            this.ExcelExportButton.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // PrintBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 558);
            this.Controls.Add(this.ExcelExportButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScansDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Scan_Textbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrintBarcodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرینت بارکد";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintBarcodeForm_FormClosing);
            this.Load += new System.EventHandler(this.PrintBarcodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScansDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Excel_Combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Scan_Textbox;
        private System.Windows.Forms.Label label3;
        private LableDbDataSet lableDbDataSet1;
        private LableDbDataSetTableAdapters.SerialsTableAdapter serialsTableAdapter1;
        private LableDbDataSetTableAdapters.LableDetailTableAdapter lableDetailTableAdapter1;
        private LableDbDataSetTableAdapters.LableTableAdapter lableTableAdapter1;
        private LableDbDataSetTableAdapters.SerialScanTableAdapter serialScanTableAdapter1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckBox LandScape_Checkbox;
        private System.Windows.Forms.DataGridView ScansDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ContainerTextBox;
        private System.Windows.Forms.Button ExcelExportButton;
    }
}