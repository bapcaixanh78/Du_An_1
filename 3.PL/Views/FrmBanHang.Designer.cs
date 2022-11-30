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
            this.dgrid_Order = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_BillWait = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrid_SP = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_TKVL = new System.Windows.Forms.TextBox();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_NewBill = new System.Windows.Forms.Button();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CSdt = new System.Windows.Forms.TextBox();
            this.rtb_MoTa = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TienThua = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.rtb_MoTa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_CSdt);
            this.groupBox1.Controls.Add(this.txt_CName);
            this.groupBox1.Controls.Add(this.btn_NewBill);
            this.groupBox1.Controls.Add(this.btn_Order);
            this.groupBox1.Controls.Add(this.btn_XoaSP);
            this.groupBox1.Controls.Add(this.dgrid_Order);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // dgrid_Order
            // 
            this.dgrid_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Order.Location = new System.Drawing.Point(0, 26);
            this.dgrid_Order.Name = "dgrid_Order";
            this.dgrid_Order.RowHeadersWidth = 51;
            this.dgrid_Order.RowTemplate.Height = 29;
            this.dgrid_Order.Size = new System.Drawing.Size(678, 267);
            this.dgrid_Order.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_BillWait);
            this.groupBox2.Location = new System.Drawing.Point(985, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 395);
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
            this.dgrid_BillWait.Size = new System.Drawing.Size(354, 340);
            this.dgrid_BillWait.TabIndex = 0;
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
            // dgrid_SP
            // 
            this.dgrid_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SP.Location = new System.Drawing.Point(0, 97);
            this.dgrid_SP.Name = "dgrid_SP";
            this.dgrid_SP.RowHeadersWidth = 51;
            this.dgrid_SP.RowTemplate.Height = 29;
            this.dgrid_SP.Size = new System.Drawing.Size(919, 233);
            this.dgrid_SP.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lb_TienThua);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lb_TongTien);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_GhiChu);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(926, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 330);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            // 
            // txt_TKVL
            // 
            this.txt_TKVL.Location = new System.Drawing.Point(57, 38);
            this.txt_TKVL.Multiline = true;
            this.txt_TKVL.Name = "txt_TKVL";
            this.txt_TKVL.Size = new System.Drawing.Size(320, 34);
            this.txt_TKVL.TabIndex = 1;
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Location = new System.Drawing.Point(80, 316);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(110, 50);
            this.btn_XoaSP.TabIndex = 1;
            this.btn_XoaSP.Text = "Remove Material";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(267, 316);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(110, 50);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Clear Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            // 
            // btn_NewBill
            // 
            this.btn_NewBill.Location = new System.Drawing.Point(451, 316);
            this.btn_NewBill.Name = "btn_NewBill";
            this.btn_NewBill.Size = new System.Drawing.Size(110, 50);
            this.btn_NewBill.TabIndex = 1;
            this.btn_NewBill.Text = "New bill";
            this.btn_NewBill.UseVisualStyleBackColor = true;
            // 
            // txt_CName
            // 
            this.txt_CName.Location = new System.Drawing.Point(810, 63);
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(125, 27);
            this.txt_CName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number";
            // 
            // txt_CSdt
            // 
            this.txt_CSdt.Location = new System.Drawing.Point(810, 111);
            this.txt_CSdt.Name = "txt_CSdt";
            this.txt_CSdt.Size = new System.Drawing.Size(125, 27);
            this.txt_CSdt.TabIndex = 2;
            // 
            // rtb_MoTa
            // 
            this.rtb_MoTa.Location = new System.Drawing.Point(721, 192);
            this.rtb_MoTa.Name = "rtb_MoTa";
            this.rtb_MoTa.Size = new System.Drawing.Size(198, 174);
            this.rtb_MoTa.TabIndex = 4;
            this.rtb_MoTa.Text = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(211, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 27);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(211, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 27);
            this.textBox5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Cash give";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total amount";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Location = new System.Drawing.Point(211, 152);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(18, 20);
            this.lb_TongTien.TabIndex = 1;
            this.lb_TongTien.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Change";
            // 
            // lb_TienThua
            // 
            this.lb_TienThua.AutoSize = true;
            this.lb_TienThua.Location = new System.Drawing.Point(211, 197);
            this.lb_TienThua.Name = "lb_TienThua";
            this.lb_TienThua.Size = new System.Drawing.Size(18, 20);
            this.lb_TienThua.TabIndex = 1;
            this.lb_TienThua.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ghi chú";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(211, 237);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(145, 27);
            this.txt_GhiChu.TabIndex = 0;
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
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RichTextBox rtb_MoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CSdt;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.Button btn_NewBill;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.TextBox txt_TKVL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_TienThua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}