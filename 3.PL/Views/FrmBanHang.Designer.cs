namespace _3.PL.Views
{
    partial class FrmBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NewBill = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.dgrid_Order = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_BillWait = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TKVL = new System.Windows.Forms.TextBox();
            this.dgrid_SP = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_TienThua = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Tienkhachdua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Mahd = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Order)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_BillWait)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SP)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NewBill);
            this.groupBox1.Controls.Add(this.btn_Order);
            this.groupBox1.Controls.Add(this.btn_XoaSP);
            this.groupBox1.Controls.Add(this.dgrid_Order);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // btn_NewBill
            // 
            this.btn_NewBill.Location = new System.Drawing.Point(451, 316);
            this.btn_NewBill.Name = "btn_NewBill";
            this.btn_NewBill.Size = new System.Drawing.Size(110, 50);
            this.btn_NewBill.TabIndex = 1;
            this.btn_NewBill.Text = "New bill";
            this.btn_NewBill.UseVisualStyleBackColor = true;
            this.btn_NewBill.Click += new System.EventHandler(this.btn_NewBill_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(267, 316);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(110, 50);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Clear Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Location = new System.Drawing.Point(80, 316);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(110, 50);
            this.btn_XoaSP.TabIndex = 1;
            this.btn_XoaSP.Text = "Remove Material";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // dgrid_Order
            // 
            this.dgrid_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Order.Location = new System.Drawing.Point(0, 26);
            this.dgrid_Order.Name = "dgrid_Order";
            this.dgrid_Order.RowHeadersWidth = 51;
            this.dgrid_Order.RowTemplate.Height = 29;
            this.dgrid_Order.Size = new System.Drawing.Size(815, 267);
            this.dgrid_Order.TabIndex = 0;
            this.dgrid_Order.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Order_CellValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_BillWait);
            this.groupBox2.Location = new System.Drawing.Point(824, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill waiting";
            // 
            // dgrid_BillWait
            // 
            this.dgrid_BillWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_BillWait.Location = new System.Drawing.Point(31, 26);
            this.dgrid_BillWait.Name = "dgrid_BillWait";
            this.dgrid_BillWait.RowHeadersWidth = 51;
            this.dgrid_BillWait.RowTemplate.Height = 29;
            this.dgrid_BillWait.Size = new System.Drawing.Size(535, 340);
            this.dgrid_BillWait.TabIndex = 0;
            this.dgrid_BillWait.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_BillWait_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_TKVL);
            this.groupBox3.Controls.Add(this.dgrid_SP);
            this.groupBox3.Location = new System.Drawing.Point(1, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(919, 330);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Material";
            // 
            // txt_TKVL
            // 
            this.txt_TKVL.Location = new System.Drawing.Point(57, 38);
            this.txt_TKVL.Multiline = true;
            this.txt_TKVL.Name = "txt_TKVL";
            this.txt_TKVL.Size = new System.Drawing.Size(320, 34);
            this.txt_TKVL.TabIndex = 1;
            // 
            // dgrid_SP
            // 
            this.dgrid_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SP.Location = new System.Drawing.Point(0, 97);
            this.dgrid_SP.Name = "dgrid_SP";
            this.dgrid_SP.RowHeadersWidth = 51;
            this.dgrid_SP.RowTemplate.Height = 29;
            this.dgrid_SP.Size = new System.Drawing.Size(919, 233);
            this.dgrid_SP.TabIndex = 0;
            this.dgrid_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SP_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ThanhToan);
            this.groupBox4.Controls.Add(this.lb_Mahd);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lb_TienThua);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lb_TongTien);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_Tienkhachdua);
            this.groupBox4.Location = new System.Drawing.Point(926, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 330);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tiền khách đưa";
            // 
            // lb_TienThua
            // 
            this.lb_TienThua.AutoSize = true;
            this.lb_TienThua.Location = new System.Drawing.Point(276, 198);
            this.lb_TienThua.Name = "lb_TienThua";
            this.lb_TienThua.Size = new System.Drawing.Size(18, 20);
            this.lb_TienThua.TabIndex = 1;
            this.lb_TienThua.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Change";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Location = new System.Drawing.Point(276, 110);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(18, 20);
            this.lb_TongTien.TabIndex = 1;
            this.lb_TongTien.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total amount";
            // 
            // txt_Tienkhachdua
            // 
            this.txt_Tienkhachdua.Location = new System.Drawing.Point(276, 155);
            this.txt_Tienkhachdua.Name = "txt_Tienkhachdua";
            this.txt_Tienkhachdua.Size = new System.Drawing.Size(145, 27);
            this.txt_Tienkhachdua.TabIndex = 0;
            this.txt_Tienkhachdua.TextChanged += new System.EventHandler(this.txt_Tienkhachdua_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // lb_Mahd
            // 
            this.lb_Mahd.AutoSize = true;
            this.lb_Mahd.Location = new System.Drawing.Point(276, 63);
            this.lb_Mahd.Name = "lb_Mahd";
            this.lb_Mahd.Size = new System.Drawing.Size(18, 20);
            this.lb_Mahd.TabIndex = 2;
            this.lb_Mahd.Text = "...";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(210, 255);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(121, 56);
            this.btn_ThanhToan.TabIndex = 3;
            this.btn_ThanhToan.Text = "OK";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 736);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Order)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_BillWait)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrid_Order;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_BillWait;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_SP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_NewBill;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.TextBox txt_TKVL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_TienThua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tienkhachdua;
        private System.Windows.Forms.Label lb_Mahd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThanhToan;
    }
}