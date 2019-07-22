namespace SalesTaxCalc
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
            this.calcbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.inputcost = new System.Windows.Forms.TextBox();
            this.taxitself = new System.Windows.Forms.Label();
            this.totalcost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearallbutton = new System.Windows.Forms.Button();
            this.GTSOut = new System.Windows.Forms.Label();
            this.GTTOut = new System.Windows.Forms.Label();
            this.GTAOut = new System.Windows.Forms.Label();
            this.TotalItemOut = new System.Windows.Forms.Label();
            this.AvgItemOut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(237, 30);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(75, 54);
            this.calcbutton.TabIndex = 0;
            this.calcbutton.Text = "Calculate";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(328, 30);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 54);
            this.clearbutton.TabIndex = 1;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // inputcost
            // 
            this.inputcost.Location = new System.Drawing.Point(56, 82);
            this.inputcost.Name = "inputcost";
            this.inputcost.Size = new System.Drawing.Size(100, 20);
            this.inputcost.TabIndex = 2;
            this.inputcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxitself
            // 
            this.taxitself.BackColor = System.Drawing.Color.Gold;
            this.taxitself.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxitself.Location = new System.Drawing.Point(56, 161);
            this.taxitself.Name = "taxitself";
            this.taxitself.Size = new System.Drawing.Size(100, 23);
            this.taxitself.TabIndex = 3;
            this.taxitself.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalcost
            // 
            this.totalcost.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalcost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalcost.Location = new System.Drawing.Point(56, 232);
            this.totalcost.Name = "totalcost";
            this.totalcost.Size = new System.Drawing.Size(100, 23);
            this.totalcost.TabIndex = 4;
            this.totalcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Total Pre-Tax Price Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax Owed at  0.0675%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Amount Owed";
            // 
            // clearallbutton
            // 
            this.clearallbutton.Location = new System.Drawing.Point(422, 41);
            this.clearallbutton.Name = "clearallbutton";
            this.clearallbutton.Size = new System.Drawing.Size(75, 33);
            this.clearallbutton.TabIndex = 8;
            this.clearallbutton.Text = "Clear All";
            this.clearallbutton.UseVisualStyleBackColor = true;
            this.clearallbutton.Click += new System.EventHandler(this.clearallbutton_Click);
            // 
            // GTSOut
            // 
            this.GTSOut.BackColor = System.Drawing.Color.FloralWhite;
            this.GTSOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GTSOut.Location = new System.Drawing.Point(20, 58);
            this.GTSOut.Name = "GTSOut";
            this.GTSOut.Size = new System.Drawing.Size(100, 23);
            this.GTSOut.TabIndex = 9;
            this.GTSOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GTTOut
            // 
            this.GTTOut.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.GTTOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GTTOut.Location = new System.Drawing.Point(20, 129);
            this.GTTOut.Name = "GTTOut";
            this.GTTOut.Size = new System.Drawing.Size(100, 23);
            this.GTTOut.TabIndex = 10;
            this.GTTOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GTAOut
            // 
            this.GTAOut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GTAOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GTAOut.Location = new System.Drawing.Point(20, 201);
            this.GTAOut.Name = "GTAOut";
            this.GTAOut.Size = new System.Drawing.Size(100, 23);
            this.GTAOut.TabIndex = 11;
            this.GTAOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalItemOut
            // 
            this.TotalItemOut.BackColor = System.Drawing.Color.Gainsboro;
            this.TotalItemOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalItemOut.Location = new System.Drawing.Point(166, 88);
            this.TotalItemOut.Name = "TotalItemOut";
            this.TotalItemOut.Size = new System.Drawing.Size(100, 23);
            this.TotalItemOut.TabIndex = 12;
            this.TotalItemOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvgItemOut
            // 
            this.AvgItemOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvgItemOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvgItemOut.Location = new System.Drawing.Point(166, 163);
            this.AvgItemOut.Name = "AvgItemOut";
            this.AvgItemOut.Size = new System.Drawing.Size(100, 23);
            this.AvgItemOut.TabIndex = 13;
            this.AvgItemOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AvgItemOut);
            this.groupBox1.Controls.Add(this.TotalItemOut);
            this.groupBox1.Controls.Add(this.GTAOut);
            this.groupBox1.Controls.Add(this.GTTOut);
            this.groupBox1.Controls.Add(this.GTSOut);
            this.groupBox1.Location = new System.Drawing.Point(217, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 244);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grand Total Sale \r\n      (No Tax)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Grand Total Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grand Total Due";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Items Sold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Items Sold";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearallbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalcost);
            this.Controls.Add(this.taxitself);
            this.Controls.Add(this.inputcost);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.calcbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox inputcost;
        private System.Windows.Forms.Label taxitself;
        private System.Windows.Forms.Label totalcost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearallbutton;
        private System.Windows.Forms.Label GTSOut;
        private System.Windows.Forms.Label GTTOut;
        private System.Windows.Forms.Label GTAOut;
        private System.Windows.Forms.Label TotalItemOut;
        private System.Windows.Forms.Label AvgItemOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

