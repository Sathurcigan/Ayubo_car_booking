namespace Rent_a_Car_Service
{
    partial class Rent_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent_payment));
            this.label1 = new System.Windows.Forms.Label();
            this.bas_amountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.driver_chargeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detailBox = new System.Windows.Forms.TextBox();
            this.rent_idBox = new System.Windows.Forms.ComboBox();
            this.cusNameBox = new System.Windows.Forms.ComboBox();
            this.rent_typeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.totalChargeBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.noOf_dayBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pay_typeBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic amount :";
            // 
            // bas_amountBox
            // 
            this.bas_amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bas_amountBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.bas_amountBox.Location = new System.Drawing.Point(117, 38);
            this.bas_amountBox.Name = "bas_amountBox";
            this.bas_amountBox.Size = new System.Drawing.Size(220, 15);
            this.bas_amountBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Driver charge :";
            // 
            // driver_chargeBox
            // 
            this.driver_chargeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_chargeBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.driver_chargeBox.Location = new System.Drawing.Point(117, 85);
            this.driver_chargeBox.Name = "driver_chargeBox";
            this.driver_chargeBox.Size = new System.Drawing.Size(220, 15);
            this.driver_chargeBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(72, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date :";
            // 
            // dateBox
            // 
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateBox.Location = new System.Drawing.Point(117, 195);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(220, 15);
            this.dateBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.detailBox);
            this.groupBox1.Controls.Add(this.rent_idBox);
            this.groupBox1.Controls.Add(this.pay_typeBox);
            this.groupBox1.Controls.Add(this.cusNameBox);
            this.groupBox1.Controls.Add(this.rent_typeBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fillBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.totalChargeBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.noOf_dayBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.driver_chargeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bas_amountBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // detailBox
            // 
            this.detailBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailBox.ForeColor = System.Drawing.Color.Blue;
            this.detailBox.Location = new System.Drawing.Point(343, 9);
            this.detailBox.Multiline = true;
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(157, 173);
            this.detailBox.TabIndex = 6;
            // 
            // rent_idBox
            // 
            this.rent_idBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.rent_idBox.FormattingEnabled = true;
            this.rent_idBox.Location = new System.Drawing.Point(117, 10);
            this.rent_idBox.Name = "rent_idBox";
            this.rent_idBox.Size = new System.Drawing.Size(165, 23);
            this.rent_idBox.TabIndex = 5;
            // 
            // cusNameBox
            // 
            this.cusNameBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cusNameBox.FormattingEnabled = true;
            this.cusNameBox.Location = new System.Drawing.Point(117, 144);
            this.cusNameBox.Name = "cusNameBox";
            this.cusNameBox.Size = new System.Drawing.Size(220, 23);
            this.cusNameBox.TabIndex = 4;
            // 
            // rent_typeBox
            // 
            this.rent_typeBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.rent_typeBox.FormattingEnabled = true;
            this.rent_typeBox.Location = new System.Drawing.Point(117, 57);
            this.rent_typeBox.Name = "rent_typeBox";
            this.rent_typeBox.Size = new System.Drawing.Size(220, 23);
            this.rent_typeBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(43, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rent Type :";
            // 
            // fillBtn
            // 
            this.fillBtn.BackColor = System.Drawing.Color.Gray;
            this.fillBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.fillBtn.ForeColor = System.Drawing.Color.Aqua;
            this.fillBtn.Location = new System.Drawing.Point(288, 9);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(49, 24);
            this.fillBtn.TabIndex = 2;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = false;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Gray;
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.Aqua;
            this.saveBtn.Location = new System.Drawing.Point(381, 185);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // totalChargeBox
            // 
            this.totalChargeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalChargeBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalChargeBox.Location = new System.Drawing.Point(117, 125);
            this.totalChargeBox.Name = "totalChargeBox";
            this.totalChargeBox.Size = new System.Drawing.Size(220, 15);
            this.totalChargeBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(-3, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Rent Charge :";
            // 
            // noOf_dayBox
            // 
            this.noOf_dayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noOf_dayBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.noOf_dayBox.Location = new System.Drawing.Point(117, 105);
            this.noOf_dayBox.Name = "noOf_dayBox";
            this.noOf_dayBox.Size = new System.Drawing.Size(220, 15);
            this.noOf_dayBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(39, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "No of Days :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(55, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rent ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(189, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rent Total Charge";
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(12, 299);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.Size = new System.Drawing.Size(560, 200);
            this.loadTable.TabIndex = 5;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(15, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID :";
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.BackColor = System.Drawing.Color.Transparent;
            this.idText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.idText.ForeColor = System.Drawing.Color.Aqua;
            this.idText.Location = new System.Drawing.Point(46, 279);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(14, 15);
            this.idText.TabIndex = 6;
            this.idText.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(22, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Payment Type :";
            // 
            // pay_typeBox
            // 
            this.pay_typeBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.pay_typeBox.FormattingEnabled = true;
            this.pay_typeBox.Items.AddRange(new object[] {
            "Cash",
            "Credit card",
            "Visa card",
            "Master card",
            "eZ cash"});
            this.pay_typeBox.Location = new System.Drawing.Point(117, 169);
            this.pay_typeBox.Name = "pay_typeBox";
            this.pay_typeBox.Size = new System.Drawing.Size(220, 23);
            this.pay_typeBox.TabIndex = 4;
            // 
            // Rent_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Rent_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent_payment";
            this.Load += new System.EventHandler(this.Rent_payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DataGridView loadTable;
        internal System.Windows.Forms.Label idText;
        internal System.Windows.Forms.TextBox bas_amountBox;
        internal System.Windows.Forms.TextBox driver_chargeBox;
        internal System.Windows.Forms.TextBox dateBox;
        internal System.Windows.Forms.ComboBox rent_typeBox;
        private System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.TextBox noOf_dayBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox rent_idBox;
        internal System.Windows.Forms.ComboBox cusNameBox;
        internal System.Windows.Forms.TextBox detailBox;
        internal System.Windows.Forms.TextBox totalChargeBox;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox pay_typeBox;
        private System.Windows.Forms.Label label11;
    }
}