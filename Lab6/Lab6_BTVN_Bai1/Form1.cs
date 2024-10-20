using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_BTVN_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.Items.Add("Hiển thị thời gian");
            toolStripComboBox1.Items.Add("Hiển thị ngày");
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem.ToString() == "Hiển thị thời gian")
            {
                tg.Text = DateTime.Now.ToString("hh:mm:ss");
            }
            if (toolStripComboBox1.SelectedItem.ToString() == "Hiển thị ngày")
            {
                ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tg.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
