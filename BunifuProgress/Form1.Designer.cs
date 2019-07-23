namespace BunifuProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.Ram = new System.Diagnostics.PerformanceCounter();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.HDD = new System.Diagnostics.PerformanceCounter();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDD)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(19, 18);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(128, 128);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(63, 155);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(29, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "CPU";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "İşlemci";
            this.CPU.CounterName = "% İşlemci Zamanı";
            this.CPU.InstanceName = "_Total";
            // 
            // Ram
            // 
            this.Ram.CategoryName = "Bellek";
            this.Ram.CounterName = "Kullanılabilir MBayt";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(359, 155);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "HDD";
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = false;
            this.bunifuCircleProgressbar4.animationIterval = 5;
            this.bunifuCircleProgressbar4.animationSpeed = 300;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.LabelVisible = true;
            this.bunifuCircleProgressbar4.LineProgressThickness = 8;
            this.bunifuCircleProgressbar4.LineThickness = 5;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(324, 18);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(128, 128);
            this.bunifuCircleProgressbar4.TabIndex = 5;
            this.bunifuCircleProgressbar4.Value = 0;
            // 
            // HDD
            // 
            this.HDD.CategoryName = "MantıksalDisk";
            this.HDD.CounterName = "% Boş Alan";
            this.HDD.InstanceName = "_Total";
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.LabelVisible = true;
            this.bunifuCircleProgressbar2.LineProgressThickness = 8;
            this.bunifuCircleProgressbar2.LineThickness = 5;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(167, 18);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar2.MaxValue = 8192;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(128, 128);
            this.bunifuCircleProgressbar2.TabIndex = 7;
            this.bunifuCircleProgressbar2.Value = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(212, 155);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "RAM";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Olive;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(16, 181);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel3.TabIndex = 9;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Olive;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(177, 181);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel5.TabIndex = 10;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Olive;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(336, 181);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel6.TabIndex = 11;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(4, 196);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(88, 19);
            this.bunifuCustomLabel7.TabIndex = 12;
            this.bunifuCustomLabel7.Text = "Samed DEMİR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 224);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCircleProgressbar2);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCircleProgressbar4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter Ram;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar4;
        public System.Diagnostics.PerformanceCounter HDD;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}

