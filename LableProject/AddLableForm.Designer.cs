namespace LableProject
{
    partial class AddLable
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
            this.Title_Textbox = new System.Windows.Forms.TextBox();
            this.Length_Textbox = new System.Windows.Forms.TextBox();
            this.Width_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableDbDataSet = new LableProject.LableDbDataSet();
            this.Add_Lable = new System.Windows.Forms.Button();
            this.lableTableAdapter = new LableProject.LableDbDataSetTableAdapters.LableTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Textbox
            // 
            this.Title_Textbox.Location = new System.Drawing.Point(15, 35);
            this.Title_Textbox.Name = "Title_Textbox";
            this.Title_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Title_Textbox.Size = new System.Drawing.Size(207, 20);
            this.Title_Textbox.TabIndex = 0;
            // 
            // Length_Textbox
            // 
            this.Length_Textbox.Location = new System.Drawing.Point(68, 72);
            this.Length_Textbox.Name = "Length_Textbox";
            this.Length_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Length_Textbox.Size = new System.Drawing.Size(76, 20);
            this.Length_Textbox.TabIndex = 1;
            // 
            // Width_Textbox
            // 
            this.Width_Textbox.Location = new System.Drawing.Point(68, 127);
            this.Width_Textbox.Name = "Width_Textbox";
            this.Width_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Width_Textbox.Size = new System.Drawing.Size(76, 20);
            this.Width_Textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(195, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(150, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "طول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(150, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "عرض";
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
            // Add_Lable
            // 
            this.Add_Lable.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_Lable.Location = new System.Drawing.Point(56, 177);
            this.Add_Lable.Name = "Add_Lable";
            this.Add_Lable.Size = new System.Drawing.Size(125, 34);
            this.Add_Lable.TabIndex = 3;
            this.Add_Lable.Text = "اضافه کردن برچسب";
            this.Add_Lable.UseVisualStyleBackColor = false;
            this.Add_Lable.Click += new System.EventHandler(this.Add_Lable_Click);
            // 
            // lableTableAdapter
            // 
            this.lableTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(64, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "میلی متر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(64, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "میلی متر";
            // 
            // AddLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 226);
            this.Controls.Add(this.Length_Textbox);
            this.Controls.Add(this.Width_Textbox);
            this.Controls.Add(this.Add_Lable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title_Textbox);
            this.Name = "AddLable";
            this.Text = "ثبت برچسب جدید";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lableDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title_Textbox;
        private System.Windows.Forms.TextBox Length_Textbox;
        private System.Windows.Forms.TextBox Width_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Lable;
        private LableDbDataSet lableDbDataSet;
        private System.Windows.Forms.BindingSource lableBindingSource;
        private LableDbDataSetTableAdapters.LableTableAdapter lableTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

