namespace Solar_DataReader
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
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Console_output = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidGaugeP_solar = new LiveCharts.WinForms.SolidGauge();
            this.solidGaugeP_motor = new LiveCharts.WinForms.SolidGauge();
            this.solidGaugeSpeed = new LiveCharts.WinForms.SolidGauge();
            this.solidGaugeSOC = new LiveCharts.WinForms.SolidGauge();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.solidGauge_MPPT2_U = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge_MPPT1_U = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge_I_BAT = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge_MPPT2_I = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge_MPPT1_I = new LiveCharts.WinForms.SolidGauge();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(0, 510);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(149, 38);
            this.Btn_Connect.TabIndex = 0;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Console_output
            // 
            this.Console_output.BackColor = System.Drawing.Color.Black;
            this.Console_output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console_output.ForeColor = System.Drawing.Color.Green;
            this.Console_output.Location = new System.Drawing.Point(0, 27);
            this.Console_output.Name = "Console_output";
            this.Console_output.ReadOnly = true;
            this.Console_output.Size = new System.Drawing.Size(149, 477);
            this.Console_output.TabIndex = 1;
            this.Console_output.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTokenToolStripMenuItem,
            this.dataLocationToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // changeTokenToolStripMenuItem
            // 
            this.changeTokenToolStripMenuItem.Name = "changeTokenToolStripMenuItem";
            this.changeTokenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changeTokenToolStripMenuItem.Text = "Change Token";
            this.changeTokenToolStripMenuItem.Click += new System.EventHandler(this.changeTokenToolStripMenuItem_Click);
            // 
            // solidGaugeP_solar
            // 
            this.solidGaugeP_solar.Location = new System.Drawing.Point(141, 6);
            this.solidGaugeP_solar.Name = "solidGaugeP_solar";
            this.solidGaugeP_solar.Size = new System.Drawing.Size(129, 88);
            this.solidGaugeP_solar.TabIndex = 3;
            this.solidGaugeP_solar.Text = "solidGauge1";
            // 
            // solidGaugeP_motor
            // 
            this.solidGaugeP_motor.Location = new System.Drawing.Point(6, 6);
            this.solidGaugeP_motor.Name = "solidGaugeP_motor";
            this.solidGaugeP_motor.Size = new System.Drawing.Size(129, 88);
            this.solidGaugeP_motor.TabIndex = 4;
            this.solidGaugeP_motor.Text = "solidGauge2";
            // 
            // solidGaugeSpeed
            // 
            this.solidGaugeSpeed.Location = new System.Drawing.Point(155, 27);
            this.solidGaugeSpeed.Name = "solidGaugeSpeed";
            this.solidGaugeSpeed.Size = new System.Drawing.Size(173, 130);
            this.solidGaugeSpeed.TabIndex = 5;
            this.solidGaugeSpeed.Text = "solidGauge3";
            // 
            // solidGaugeSOC
            // 
            this.solidGaugeSOC.Location = new System.Drawing.Point(155, 175);
            this.solidGaugeSOC.Name = "solidGaugeSOC";
            this.solidGaugeSOC.Size = new System.Drawing.Size(173, 111);
            this.solidGaugeSOC.TabIndex = 6;
            this.solidGaugeSOC.Text = "solidGauge4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Speed (km/h)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "SOC (%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(392, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 509);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.solidGaugeP_motor);
            this.tabPage1.Controls.Add(this.solidGauge_MPPT2_U);
            this.tabPage1.Controls.Add(this.solidGauge_MPPT1_U);
            this.tabPage1.Controls.Add(this.solidGauge_I_BAT);
            this.tabPage1.Controls.Add(this.solidGauge_MPPT2_I);
            this.tabPage1.Controls.Add(this.solidGauge_MPPT1_I);
            this.tabPage1.Controls.Add(this.solidGaugeP_solar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "U solarpanel 2 (V)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "I battery (A)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "I solarpanel 2 (A)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "U solarpanel 1 (V)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "I solarpanel 1 (A)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "P solar (W)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "P motor (W)";
            // 
            // solidGauge_MPPT2_U
            // 
            this.solidGauge_MPPT2_U.Location = new System.Drawing.Point(411, 113);
            this.solidGauge_MPPT2_U.Name = "solidGauge_MPPT2_U";
            this.solidGauge_MPPT2_U.Size = new System.Drawing.Size(129, 88);
            this.solidGauge_MPPT2_U.TabIndex = 3;
            this.solidGauge_MPPT2_U.Text = "solidGauge1";
            // 
            // solidGauge_MPPT1_U
            // 
            this.solidGauge_MPPT1_U.Location = new System.Drawing.Point(276, 113);
            this.solidGauge_MPPT1_U.Name = "solidGauge_MPPT1_U";
            this.solidGauge_MPPT1_U.Size = new System.Drawing.Size(129, 88);
            this.solidGauge_MPPT1_U.TabIndex = 3;
            this.solidGauge_MPPT1_U.Text = "solidGauge1";
            // 
            // solidGauge_I_BAT
            // 
            this.solidGauge_I_BAT.Location = new System.Drawing.Point(546, 6);
            this.solidGauge_I_BAT.Name = "solidGauge_I_BAT";
            this.solidGauge_I_BAT.Size = new System.Drawing.Size(129, 88);
            this.solidGauge_I_BAT.TabIndex = 3;
            this.solidGauge_I_BAT.Text = "solidGauge1";
            // 
            // solidGauge_MPPT2_I
            // 
            this.solidGauge_MPPT2_I.Location = new System.Drawing.Point(411, 6);
            this.solidGauge_MPPT2_I.Name = "solidGauge_MPPT2_I";
            this.solidGauge_MPPT2_I.Size = new System.Drawing.Size(129, 88);
            this.solidGauge_MPPT2_I.TabIndex = 3;
            this.solidGauge_MPPT2_I.Text = "solidGauge1";
            // 
            // solidGauge_MPPT1_I
            // 
            this.solidGauge_MPPT1_I.Location = new System.Drawing.Point(276, 6);
            this.solidGauge_MPPT1_I.Name = "solidGauge_MPPT1_I";
            this.solidGauge_MPPT1_I.Size = new System.Drawing.Size(129, 88);
            this.solidGauge_MPPT1_I.TabIndex = 3;
            this.solidGauge_MPPT1_I.Text = "solidGauge1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Solar_DataReader.Properties.Resources.Erroricon404;
            this.pictureBox1.Location = new System.Drawing.Point(154, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "GPS lock";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(155, 504);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Savedata";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataLocationToolStripMenuItem
            // 
            this.dataLocationToolStripMenuItem.Name = "dataLocationToolStripMenuItem";
            this.dataLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataLocationToolStripMenuItem.Text = "Data Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1114, 568);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.solidGaugeSOC);
            this.Controls.Add(this.solidGaugeSpeed);
            this.Controls.Add(this.Console_output);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.RichTextBox Console_output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTokenToolStripMenuItem;
        private LiveCharts.WinForms.SolidGauge solidGaugeP_solar;
        private LiveCharts.WinForms.SolidGauge solidGaugeP_motor;
        private LiveCharts.WinForms.SolidGauge solidGaugeSpeed;
        private LiveCharts.WinForms.SolidGauge solidGaugeSOC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.SolidGauge solidGauge_MPPT2_U;
        private LiveCharts.WinForms.SolidGauge solidGauge_MPPT1_U;
        private LiveCharts.WinForms.SolidGauge solidGauge_MPPT2_I;
        private LiveCharts.WinForms.SolidGauge solidGauge_MPPT1_I;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private LiveCharts.WinForms.SolidGauge solidGauge_I_BAT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem dataLocationToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

