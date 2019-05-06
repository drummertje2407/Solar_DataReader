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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTokenToolStripMenuItem});
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
            this.solidGaugeP_solar.Location = new System.Drawing.Point(154, 27);
            this.solidGaugeP_solar.Name = "solidGaugeP_solar";
            this.solidGaugeP_solar.Size = new System.Drawing.Size(129, 88);
            this.solidGaugeP_solar.TabIndex = 3;
            this.solidGaugeP_solar.Text = "solidGauge1";
            // 
            // solidGaugeP_motor
            // 
            this.solidGaugeP_motor.Location = new System.Drawing.Point(289, 27);
            this.solidGaugeP_motor.Name = "solidGaugeP_motor";
            this.solidGaugeP_motor.Size = new System.Drawing.Size(129, 88);
            this.solidGaugeP_motor.TabIndex = 4;
            this.solidGaugeP_motor.Text = "solidGauge2";
            // 
            // solidGaugeSpeed
            // 
            this.solidGaugeSpeed.Location = new System.Drawing.Point(424, 27);
            this.solidGaugeSpeed.Name = "solidGaugeSpeed";
            this.solidGaugeSpeed.Size = new System.Drawing.Size(129, 88);
            this.solidGaugeSpeed.TabIndex = 5;
            this.solidGaugeSpeed.Text = "solidGauge3";
            // 
            // solidGaugeSOC
            // 
            this.solidGaugeSOC.Location = new System.Drawing.Point(559, 27);
            this.solidGaugeSOC.Name = "solidGaugeSOC";
            this.solidGaugeSOC.Size = new System.Drawing.Size(129, 88);
            this.solidGaugeSOC.TabIndex = 6;
            this.solidGaugeSOC.Text = "solidGauge4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1091, 568);
            this.Controls.Add(this.solidGaugeSOC);
            this.Controls.Add(this.solidGaugeSpeed);
            this.Controls.Add(this.solidGaugeP_motor);
            this.Controls.Add(this.solidGaugeP_solar);
            this.Controls.Add(this.Console_output);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

