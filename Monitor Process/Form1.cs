using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor_Process;
using System.IO;

namespace Monitor_Process
{
    public partial class Form1 : Form
    {
        private MonitorProcess _objMonitor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _objMonitor = new MonitorProcess(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            _objMonitor.startProcess();
            dataGridView1.Rows.Add(_objMonitor.getSomeData());
            dataGridView1.Rows.Add(_objMonitor.getProcessExitCode().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(_objMonitor.getProcessExitCode().ToString());
        }
    }
}
