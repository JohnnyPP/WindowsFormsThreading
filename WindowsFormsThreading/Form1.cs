using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsThreading
{
    public partial class Form1 : Form
    {
        int length = 10000;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1Loop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < length; i++)
            {
                label1.Text = i.ToString();
                label1.Refresh();
            }

            for (int i = 0; i < length; i++)
            {
                label2.Text = i.ToString();
                label2.Refresh();
                Thread.Sleep(5);
            }
        }

        private void button2Loop_Click(object sender, EventArgs e)
        {
            int i = 9;
            label2.Text = i.ToString();
        }
    }
}
