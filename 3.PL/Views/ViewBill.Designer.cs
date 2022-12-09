namespace _3.PL.Views
{
    partial class ViewBill
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
            this.dtg_bill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.bt_upđate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_unpaid = new System.Windows.Forms.RadioButton();
            this.rd_paid = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_seach = new System.Windows.Forms.DateTimePicker();
            this.bt_seach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_bill
            // 
            this.dtg_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_bill.Location = new System.Drawing.Point(12, 207);
            this.dtg_bill.Name = "dtg_bill";
            this.dtg_bill.RowHeadersWidth = 51;
            this.dtg_bill.RowTemplate.Height = 29;
            this.dtg_bill.Size = new System.Drawing.Size(703, 188);
            this.dtg_bill.TabIndex = 0;
            this.dtg_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_bill_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(159, 36);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(207, 81);
            this.tb_note.TabIndex = 2;
            // 
            // bt_upđate
            // 
            this.bt_upđate.Location = new System.Drawing.Point(434, 36);
            this.bt_upđate.Name = "bt_upđate";
            this.bt_upđate.Size = new System.Drawing.Size(102, 81);
            this.bt_upđate.TabIndex = 3;
            this.bt_upđate.Text = "Update";
            this.bt_upđate.UseVisualStyleBackColor = true;
            this.bt_upđate.Click += new System.EventHandler(this.bt_upđate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // rd_unpaid
            // 
            this.rd_unpaid.AutoSize = true;
            this.rd_unpaid.Location = new System.Drawing.Point(46, 93);
            this.rd_unpaid.Name = "rd_unpaid";
            this.rd_unpaid.Size = new System.Drawing.Size(78, 24);
            this.rd_unpaid.TabIndex = 4;
            this.rd_unpaid.TabStop = true;
            this.rd_unpaid.Text = "Unpaid";
            this.rd_unpaid.UseVisualStyleBackColor = true;
            // 
            // rd_paid
            // 
            this.rd_paid.AutoSize = true;
            this.rd_paid.Location = new System.Drawing.Point(46, 52);
            this.rd_paid.Name = "rd_paid";
            this.rd_paid.Size = new System.Drawing.Size(58, 24);
            this.rd_paid.TabIndex = 4;
            this.rd_paid.TabStop = true;
            this.rd_paid.Text = "Paid";
            this.rd_paid.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search by date";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtp_seach
            // 
            this.dtp_seach.Location = new System.Drawing.Point(139, 160);
            this.dtp_seach.Name = "dtp_seach";
            this.dtp_seach.Size = new System.Drawing.Size(253, 27);
            this.dtp_seach.TabIndex = 6;
            this.dtp_seach.ValueChanged += new System.EventHandler(this.dtp_seach_ValueChanged);
            // 
            // bt_seach
            // 
            this.bt_seach.Location = new System.Drawing.Point(574, 36);
            this.bt_seach.Name = "bt_seach";
            this.bt_seach.Size = new System.Drawing.Size(102, 81);
            this.bt_seach.TabIndex = 3;
            this.bt_seach.Text = "Seach";
            this.bt_seach.UseVisualStyleBackColor = true;
            this.bt_seach.Click += new System.EventHandler(this.bt_upđate_Click);
            // 
            // ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 407);
            this.Controls.Add(this.dtp_seach);
            this.Controls.Add(this.rd_paid);
            this.Controls.Add(this.rd_unpaid);
            this.Controls.Add(this.bt_seach);
            this.Controls.Add(this.bt_upđate);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_bill);
            this.Name = "ViewBill";
            this.Text = "ViewBill";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Button bt_upđate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_unpaid;
        private System.Windows.Forms.RadioButton rd_paid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_seach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bt_seach;
    }
}