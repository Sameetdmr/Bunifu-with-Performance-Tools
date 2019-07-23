using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BunifuProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            float fram = Ram.NextValue();
            float hdd = HDD.NextValue();
            bunifuCircleProgressbar1.Value = (int)fcpu;
            bunifuCustomLabel3.Text = "CPU" + " " + fcpu.ToString() + " " + "%";

            bunifuCircleProgressbar2.Value = (int)fram;
            bunifuCustomLabel5.Text = "Boş Ram Alanı : " + " " + fram.ToString() + " " + "MB";

            bunifuCircleProgressbar4.Value = (int)hdd;
            bunifuCustomLabel6.Text = "HDD Kullanımı :" + " " + hdd.ToString() + " " + "%";
        }
    }
}
