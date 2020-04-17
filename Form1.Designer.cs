namespace KalkulatorPodsieci
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAdress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWebAdress = new System.Windows.Forms.TextBox();
            this.tbWebClass = new System.Windows.Forms.TextBox();
            this.tbFullSubnetMask = new System.Windows.Forms.TextBox();
            this.tbBroadcastAdress = new System.Windows.Forms.TextBox();
            this.tbFirstHostAdress = new System.Windows.Forms.TextBox();
            this.tbLastHostAdress = new System.Windows.Forms.TextBox();
            this.tbMaxNbOfHosts = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres IP:";
            // 
            // tbIPAdress
            // 
            this.tbIPAdress.Location = new System.Drawing.Point(108, 28);
            this.tbIPAdress.Name = "tbIPAdress";
            this.tbIPAdress.Size = new System.Drawing.Size(181, 22);
            this.tbIPAdress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaxNbOfHosts);
            this.groupBox1.Controls.Add(this.tbLastHostAdress);
            this.groupBox1.Controls.Add(this.tbFirstHostAdress);
            this.groupBox1.Controls.Add(this.tbBroadcastAdress);
            this.groupBox1.Controls.Add(this.tbFullSubnetMask);
            this.groupBox1.Controls.Add(this.tbWebClass);
            this.groupBox1.Controls.Add(this.tbWebAdress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(308, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(71, 28);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Oblicz";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adres sieci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Klasa sieci:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pełna maska sieci:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adres broadcast:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pierwszy adres hosta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ostatni adres hosta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Maksymalna liczba hostów:";
            // 
            // tbWebAdress
            // 
            this.tbWebAdress.Enabled = false;
            this.tbWebAdress.Location = new System.Drawing.Point(154, 26);
            this.tbWebAdress.Name = "tbWebAdress";
            this.tbWebAdress.Size = new System.Drawing.Size(177, 22);
            this.tbWebAdress.TabIndex = 7;
            // 
            // tbWebClass
            // 
            this.tbWebClass.Enabled = false;
            this.tbWebClass.Location = new System.Drawing.Point(154, 68);
            this.tbWebClass.Name = "tbWebClass";
            this.tbWebClass.Size = new System.Drawing.Size(61, 22);
            this.tbWebClass.TabIndex = 8;
            // 
            // tbFullSubnetMask
            // 
            this.tbFullSubnetMask.Enabled = false;
            this.tbFullSubnetMask.Location = new System.Drawing.Point(155, 108);
            this.tbFullSubnetMask.Name = "tbFullSubnetMask";
            this.tbFullSubnetMask.Size = new System.Drawing.Size(176, 22);
            this.tbFullSubnetMask.TabIndex = 9;
            // 
            // tbBroadcastAdress
            // 
            this.tbBroadcastAdress.Enabled = false;
            this.tbBroadcastAdress.Location = new System.Drawing.Point(154, 150);
            this.tbBroadcastAdress.Name = "tbBroadcastAdress";
            this.tbBroadcastAdress.Size = new System.Drawing.Size(177, 22);
            this.tbBroadcastAdress.TabIndex = 10;
            // 
            // tbFirstHostAdress
            // 
            this.tbFirstHostAdress.Enabled = false;
            this.tbFirstHostAdress.Location = new System.Drawing.Point(154, 197);
            this.tbFirstHostAdress.Name = "tbFirstHostAdress";
            this.tbFirstHostAdress.Size = new System.Drawing.Size(177, 22);
            this.tbFirstHostAdress.TabIndex = 11;
            // 
            // tbLastHostAdress
            // 
            this.tbLastHostAdress.Enabled = false;
            this.tbLastHostAdress.Location = new System.Drawing.Point(155, 246);
            this.tbLastHostAdress.Name = "tbLastHostAdress";
            this.tbLastHostAdress.Size = new System.Drawing.Size(176, 22);
            this.tbLastHostAdress.TabIndex = 12;
            // 
            // tbMaxNbOfHosts
            // 
            this.tbMaxNbOfHosts.Enabled = false;
            this.tbMaxNbOfHosts.Location = new System.Drawing.Point(194, 287);
            this.tbMaxNbOfHosts.Name = "tbMaxNbOfHosts";
            this.tbMaxNbOfHosts.Size = new System.Drawing.Size(89, 22);
            this.tbMaxNbOfHosts.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 426);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbIPAdress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator podsieci";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIPAdress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaxNbOfHosts;
        private System.Windows.Forms.TextBox tbLastHostAdress;
        private System.Windows.Forms.TextBox tbFirstHostAdress;
        private System.Windows.Forms.TextBox tbBroadcastAdress;
        private System.Windows.Forms.TextBox tbFullSubnetMask;
        private System.Windows.Forms.TextBox tbWebClass;
        private System.Windows.Forms.TextBox tbWebAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
    }
}

