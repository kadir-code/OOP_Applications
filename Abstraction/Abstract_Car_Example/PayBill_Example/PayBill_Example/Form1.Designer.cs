
namespace PayBill_Example
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.btnPayElectric = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKwUsage = new System.Windows.Forms.TextBox();
            this.txtKw = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGasUsage = new System.Windows.Forms.TextBox();
            this.txtGasPayBill = new System.Windows.Forms.TextBox();
            this.btnGasCalculate = new System.Windows.Forms.Button();
            this.btnGasPay = new System.Windows.Forms.Button();
            this.lblGasUsage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKw);
            this.groupBox1.Location = new System.Drawing.Point(46, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Electric Usage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kw Usage :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(168, 97);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTotalBill);
            this.groupBox2.Controls.Add(this.btnPayElectric);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKwUsage);
            this.groupBox2.Location = new System.Drawing.Point(387, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pay Electric";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Bill :";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(293, 53);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(22, 17);
            this.lblTotalBill.TabIndex = 8;
            this.lblTotalBill.Text = "- -";
            // 
            // btnPayElectric
            // 
            this.btnPayElectric.Location = new System.Drawing.Point(213, 162);
            this.btnPayElectric.Name = "btnPayElectric";
            this.btnPayElectric.Size = new System.Drawing.Size(102, 32);
            this.btnPayElectric.TabIndex = 6;
            this.btnPayElectric.Text = "Pay";
            this.btnPayElectric.UseVisualStyleBackColor = true;
            this.btnPayElectric.Click += new System.EventHandler(this.btnPayElectric_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pay Bill";
            // 
            // txtKwUsage
            // 
            this.txtKwUsage.Location = new System.Drawing.Point(213, 99);
            this.txtKwUsage.Name = "txtKwUsage";
            this.txtKwUsage.Size = new System.Drawing.Size(100, 22);
            this.txtKwUsage.TabIndex = 4;
            // 
            // txtKw
            // 
            this.txtKw.Location = new System.Drawing.Point(168, 45);
            this.txtKw.Name = "txtKw";
            this.txtKw.Size = new System.Drawing.Size(100, 22);
            this.txtKw.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGasCalculate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtGasUsage);
            this.groupBox3.Location = new System.Drawing.Point(46, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gas Usage";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblGasUsage);
            this.groupBox4.Controls.Add(this.btnGasPay);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtGasPayBill);
            this.groupBox4.Location = new System.Drawing.Point(387, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 230);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pay Gas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gas Usage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Bill :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kw Usage :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pay Bill :";
            // 
            // txtGasUsage
            // 
            this.txtGasUsage.Location = new System.Drawing.Point(168, 49);
            this.txtGasUsage.Name = "txtGasUsage";
            this.txtGasUsage.Size = new System.Drawing.Size(100, 22);
            this.txtGasUsage.TabIndex = 4;
            // 
            // txtGasPayBill
            // 
            this.txtGasPayBill.Location = new System.Drawing.Point(215, 98);
            this.txtGasPayBill.Name = "txtGasPayBill";
            this.txtGasPayBill.Size = new System.Drawing.Size(100, 22);
            this.txtGasPayBill.TabIndex = 4;
            // 
            // btnGasCalculate
            // 
            this.btnGasCalculate.Location = new System.Drawing.Point(168, 110);
            this.btnGasCalculate.Name = "btnGasCalculate";
            this.btnGasCalculate.Size = new System.Drawing.Size(100, 31);
            this.btnGasCalculate.TabIndex = 5;
            this.btnGasCalculate.Text = "Calculate";
            this.btnGasCalculate.UseVisualStyleBackColor = true;
            this.btnGasCalculate.Click += new System.EventHandler(this.btnGasCalculate_Click);
            // 
            // btnGasPay
            // 
            this.btnGasPay.Location = new System.Drawing.Point(215, 163);
            this.btnGasPay.Name = "btnGasPay";
            this.btnGasPay.Size = new System.Drawing.Size(100, 31);
            this.btnGasPay.TabIndex = 5;
            this.btnGasPay.Text = "Pay";
            this.btnGasPay.UseVisualStyleBackColor = true;
            this.btnGasPay.Click += new System.EventHandler(this.btnGasPay_Click);
            // 
            // lblGasUsage
            // 
            this.lblGasUsage.AutoSize = true;
            this.lblGasUsage.Location = new System.Drawing.Point(291, 52);
            this.lblGasUsage.Name = "lblGasUsage";
            this.lblGasUsage.Size = new System.Drawing.Size(22, 17);
            this.lblGasUsage.TabIndex = 6;
            this.lblGasUsage.Text = "- -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 685);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtKw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Button btnPayElectric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKwUsage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGasCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGasUsage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGasUsage;
        private System.Windows.Forms.Button btnGasPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGasPayBill;
    }
}

