namespace LableProject
{
    partial class ExcelUploadForm
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
            this.Title_Box = new System.Windows.Forms.ComboBox();
            this.lableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableDbDataSet = new LableProject.LableDbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.lableTableAdapter = new LableProject.LableDbDataSetTableAdapters.LableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lableDetailTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.LableDetailTableAdapter();
            this.serialsTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialsTableAdapter();
            this.serialScanTableAdapter1 = new LableProject.LableDbDataSetTableAdapters.SerialScanTableAdapter();
            this.Upload_Progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Box
            // 
            this.Title_Box.DataSource = this.lableBindingSource;
            this.Title_Box.DisplayMember = "Title";
            this.Title_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Title_Box.FormattingEnabled = true;
            this.Title_Box.Location = new System.Drawing.Point(38, 69);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Title_Box.Size = new System.Drawing.Size(203, 24);
            this.Title_Box.TabIndex = 0;
            this.Title_Box.ValueMember = "ID";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(258, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان";
            // 
            // lableTableAdapter
            // 
            this.lableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(79, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "انتخاب فایل و آپلود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lableDetailTableAdapter1
            // 
            this.lableDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // serialsTableAdapter1
            // 
            this.serialsTableAdapter1.ClearBeforeFill = true;
            // 
            // serialScanTableAdapter1
            // 
            this.serialScanTableAdapter1.ClearBeforeFill = true;
            // 
            // Upload_Progress
            // 
            this.Upload_Progress.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Upload_Progress.Location = new System.Drawing.Point(36, 226);
            this.Upload_Progress.Name = "Upload_Progress";
            this.Upload_Progress.Size = new System.Drawing.Size(268, 23);
            this.Upload_Progress.TabIndex = 3;
            this.Upload_Progress.Visible = false;
            // 
            // ExcelUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.Upload_Progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title_Box);
            this.Name = "ExcelUploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آپلود فایل اکسل";
            this.Load += new System.EventHandler(this.ExcelUploadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Title_Box;
        private System.Windows.Forms.Label label1;
        private LableDbDataSet lableDbDataSet;
        private System.Windows.Forms.BindingSource lableBindingSource;
        private LableDbDataSetTableAdapters.LableTableAdapter lableTableAdapter;
        private System.Windows.Forms.Button button1;
        private LableDbDataSetTableAdapters.LableDetailTableAdapter lableDetailTableAdapter1;
        private LableDbDataSetTableAdapters.SerialsTableAdapter serialsTableAdapter1;
        private LableDbDataSetTableAdapters.SerialScanTableAdapter serialScanTableAdapter1;
        private System.Windows.Forms.ProgressBar Upload_Progress;
    }
}