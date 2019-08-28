using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighspeedNetworkEchartsTest1;

namespace Winform.Animation.Train
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent(); 
            animTrainLoadingPartial1.Display();
        }

        private void BTStart_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("123"))
            {
                HighspeedRailwayFrm f1 = new HighspeedRailwayFrm();
                Thread.Sleep(1000);
                f1.Show();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
                label4.Text = "密码错误";
            }
        }

        private void BTStop_Click(object sender, EventArgs e)
        {
            animTrainLoadingPartial1.Display(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
