namespace HolidayApps
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_tim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name_group = new System.Windows.Forms.TextBox();
            this.txt_name_en = new System.Windows.Forms.TextBox();
            this.txt_name_vi = new System.Windows.Forms.TextBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.txt_updated_by = new System.Windows.Forms.TextBox();
            this.txt_updated_date = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_holiday_date = new System.Windows.Forms.Label();
            this.lb_holiday_name_group = new System.Windows.Forms.Label();
            this.lb_holiday_name_en = new System.Windows.Forms.Label();
            this.lb_holiday_name_vi = new System.Windows.Forms.Label();
            this.lb_remark = new System.Windows.Forms.Label();
            this.lb_updated_by = new System.Windows.Forms.Label();
            this.lb_updated_date = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(190, 347);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(110, 36);
            this.btn_tim.TabIndex = 1;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lb_tieude);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 64);
            this.panel1.TabIndex = 3;
            // 
            // lb_tieude
            // 
            this.lb_tieude.AutoSize = true;
            this.lb_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieude.ForeColor = System.Drawing.Color.Goldenrod;
            this.lb_tieude.Location = new System.Drawing.Point(576, 15);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(151, 38);
            this.lb_tieude.TabIndex = 0;
            this.lb_tieude.Text = "Holidays";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(153, 101);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(484, 22);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name_group
            // 
            this.txt_name_group.Location = new System.Drawing.Point(153, 232);
            this.txt_name_group.Name = "txt_name_group";
            this.txt_name_group.Size = new System.Drawing.Size(484, 22);
            this.txt_name_group.TabIndex = 5;
            // 
            // txt_name_en
            // 
            this.txt_name_en.Location = new System.Drawing.Point(153, 293);
            this.txt_name_en.Name = "txt_name_en";
            this.txt_name_en.Size = new System.Drawing.Size(484, 22);
            this.txt_name_en.TabIndex = 6;
            // 
            // txt_name_vi
            // 
            this.txt_name_vi.Location = new System.Drawing.Point(796, 98);
            this.txt_name_vi.Name = "txt_name_vi";
            this.txt_name_vi.Size = new System.Drawing.Size(484, 22);
            this.txt_name_vi.TabIndex = 7;
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(796, 162);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(484, 22);
            this.txt_remark.TabIndex = 8;
            // 
            // txt_updated_by
            // 
            this.txt_updated_by.Location = new System.Drawing.Point(796, 232);
            this.txt_updated_by.Name = "txt_updated_by";
            this.txt_updated_by.Size = new System.Drawing.Size(484, 22);
            this.txt_updated_by.TabIndex = 9;
            // 
            // txt_updated_date
            // 
            this.txt_updated_date.Location = new System.Drawing.Point(796, 293);
            this.txt_updated_date.Name = "txt_updated_date";
            this.txt_updated_date.Size = new System.Drawing.Size(484, 22);
            this.txt_updated_date.TabIndex = 10;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(13, 104);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 16);
            this.lb_id.TabIndex = 11;
            this.lb_id.Text = "Id";
            // 
            // lb_holiday_date
            // 
            this.lb_holiday_date.AutoSize = true;
            this.lb_holiday_date.Location = new System.Drawing.Point(13, 168);
            this.lb_holiday_date.Name = "lb_holiday_date";
            this.lb_holiday_date.Size = new System.Drawing.Size(85, 16);
            this.lb_holiday_date.TabIndex = 12;
            this.lb_holiday_date.Text = "holiday_date";
            // 
            // lb_holiday_name_group
            // 
            this.lb_holiday_name_group.AutoSize = true;
            this.lb_holiday_name_group.Location = new System.Drawing.Point(13, 235);
            this.lb_holiday_name_group.Name = "lb_holiday_name_group";
            this.lb_holiday_name_group.Size = new System.Drawing.Size(134, 16);
            this.lb_holiday_name_group.TabIndex = 13;
            this.lb_holiday_name_group.Text = "holiday_name_group";
            // 
            // lb_holiday_name_en
            // 
            this.lb_holiday_name_en.AutoSize = true;
            this.lb_holiday_name_en.Location = new System.Drawing.Point(13, 299);
            this.lb_holiday_name_en.Name = "lb_holiday_name_en";
            this.lb_holiday_name_en.Size = new System.Drawing.Size(114, 16);
            this.lb_holiday_name_en.TabIndex = 14;
            this.lb_holiday_name_en.Text = "holiday_name_en";
            // 
            // lb_holiday_name_vi
            // 
            this.lb_holiday_name_vi.AutoSize = true;
            this.lb_holiday_name_vi.Location = new System.Drawing.Point(671, 107);
            this.lb_holiday_name_vi.Name = "lb_holiday_name_vi";
            this.lb_holiday_name_vi.Size = new System.Drawing.Size(109, 16);
            this.lb_holiday_name_vi.TabIndex = 15;
            this.lb_holiday_name_vi.Text = "holiday_name_vi";
            // 
            // lb_remark
            // 
            this.lb_remark.AutoSize = true;
            this.lb_remark.Location = new System.Drawing.Point(671, 167);
            this.lb_remark.Name = "lb_remark";
            this.lb_remark.Size = new System.Drawing.Size(49, 16);
            this.lb_remark.TabIndex = 16;
            this.lb_remark.Text = "remark";
            // 
            // lb_updated_by
            // 
            this.lb_updated_by.AutoSize = true;
            this.lb_updated_by.Location = new System.Drawing.Point(671, 235);
            this.lb_updated_by.Name = "lb_updated_by";
            this.lb_updated_by.Size = new System.Drawing.Size(79, 16);
            this.lb_updated_by.TabIndex = 17;
            this.lb_updated_by.Text = "updated_by";
            // 
            // lb_updated_date
            // 
            this.lb_updated_date.AutoSize = true;
            this.lb_updated_date.Location = new System.Drawing.Point(671, 296);
            this.lb_updated_date.Name = "lb_updated_date";
            this.lb_updated_date.Size = new System.Drawing.Size(91, 16);
            this.lb_updated_date.TabIndex = 18;
            this.lb_updated_date.Text = "updated_date";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(445, 347);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 36);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(701, 347);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 36);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(991, 347);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 36);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(484, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 645);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lb_updated_date);
            this.Controls.Add(this.lb_updated_by);
            this.Controls.Add(this.lb_remark);
            this.Controls.Add(this.lb_holiday_name_vi);
            this.Controls.Add(this.lb_holiday_name_en);
            this.Controls.Add(this.lb_holiday_name_group);
            this.Controls.Add(this.lb_holiday_date);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.txt_updated_date);
            this.Controls.Add(this.txt_updated_by);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.txt_name_vi);
            this.Controls.Add(this.txt_name_en);
            this.Controls.Add(this.txt_name_group);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_tieude;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name_group;
        private System.Windows.Forms.TextBox txt_name_en;
        private System.Windows.Forms.TextBox txt_name_vi;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.TextBox txt_updated_by;
        private System.Windows.Forms.TextBox txt_updated_date;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_holiday_date;
        private System.Windows.Forms.Label lb_holiday_name_group;
        private System.Windows.Forms.Label lb_holiday_name_en;
        private System.Windows.Forms.Label lb_holiday_name_vi;
        private System.Windows.Forms.Label lb_remark;
        private System.Windows.Forms.Label lb_updated_by;
        private System.Windows.Forms.Label lb_updated_date;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

