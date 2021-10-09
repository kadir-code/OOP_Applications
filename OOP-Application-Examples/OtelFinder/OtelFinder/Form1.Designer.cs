
namespace OtelFinder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateCustomerSurname = new System.Windows.Forms.TextBox();
            this.btnSaveCustomerInformations = new System.Windows.Forms.Button();
            this.txtCreateCustomerName = new System.Windows.Forms.TextBox();
            this.lblSuccessMessage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFindOtel = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOtelName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCreateCustomerSurname);
            this.groupBox1.Controls.Add(this.btnSaveCustomerInformations);
            this.groupBox1.Controls.Add(this.txtCreateCustomerName);
            this.groupBox1.Controls.Add(this.lblSuccessMessage);
            this.groupBox1.Location = new System.Drawing.Point(45, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer İnformations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname :";
            // 
            // txtCreateCustomerSurname
            // 
            this.txtCreateCustomerSurname.Location = new System.Drawing.Point(138, 99);
            this.txtCreateCustomerSurname.Name = "txtCreateCustomerSurname";
            this.txtCreateCustomerSurname.Size = new System.Drawing.Size(100, 22);
            this.txtCreateCustomerSurname.TabIndex = 1;
            // 
            // btnSaveCustomerInformations
            // 
            this.btnSaveCustomerInformations.Location = new System.Drawing.Point(138, 157);
            this.btnSaveCustomerInformations.Name = "btnSaveCustomerInformations";
            this.btnSaveCustomerInformations.Size = new System.Drawing.Size(100, 30);
            this.btnSaveCustomerInformations.TabIndex = 2;
            this.btnSaveCustomerInformations.Text = "Save";
            this.btnSaveCustomerInformations.UseVisualStyleBackColor = true;
            this.btnSaveCustomerInformations.Click += new System.EventHandler(this.btnSaveCustomerInformations_Click);
            // 
            // txtCreateCustomerName
            // 
            this.txtCreateCustomerName.Location = new System.Drawing.Point(138, 54);
            this.txtCreateCustomerName.Name = "txtCreateCustomerName";
            this.txtCreateCustomerName.Size = new System.Drawing.Size(100, 22);
            this.txtCreateCustomerName.TabIndex = 1;
            // 
            // lblSuccessMessage
            // 
            this.lblSuccessMessage.AutoSize = true;
            this.lblSuccessMessage.Location = new System.Drawing.Point(31, 208);
            this.lblSuccessMessage.Name = "lblSuccessMessage";
            this.lblSuccessMessage.Size = new System.Drawing.Size(0, 17);
            this.lblSuccessMessage.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Montserrat Subrayada", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Traveller Hotel Finder";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1146, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbFindOtel);
            this.groupBox2.Location = new System.Drawing.Point(431, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Otel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Otel List :";
            // 
            // cmbFindOtel
            // 
            this.cmbFindOtel.FormattingEnabled = true;
            this.cmbFindOtel.Location = new System.Drawing.Point(127, 59);
            this.cmbFindOtel.Name = "cmbFindOtel";
            this.cmbFindOtel.Size = new System.Drawing.Size(121, 24);
            this.cmbFindOtel.TabIndex = 4;
            this.cmbFindOtel.SelectedIndexChanged += new System.EventHandler(this.cmbFindOtel_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.lblPrice);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblOtelName);
            this.groupBox4.Controls.Add(this.lblLocation);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(804, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 502);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otel Informations :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::OtelFinder.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(34, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 198);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(126, 372);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(18, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price :";
            // 
            // lblOtelName
            // 
            this.lblOtelName.AutoSize = true;
            this.lblOtelName.Location = new System.Drawing.Point(120, 277);
            this.lblOtelName.Name = "lblOtelName";
            this.lblOtelName.Size = new System.Drawing.Size(18, 17);
            this.lblOtelName.TabIndex = 0;
            this.lblOtelName.Text = "--";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(120, 327);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(18, 17);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Otel Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Location :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reservate Hotel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelFinder.Properties.Resources.Ekran_görüntüsü_2021_10_09_222428;
            this.ClientSize = new System.Drawing.Size(1369, 766);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateCustomerSurname;
        private System.Windows.Forms.Button btnSaveCustomerInformations;
        private System.Windows.Forms.TextBox txtCreateCustomerName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFindOtel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSuccessMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOtelName;
        private System.Windows.Forms.Label lblLocation;
    }
}

