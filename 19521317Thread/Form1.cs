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

namespace _19521317Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread trd1 = new Thread(new ThreadStart(()=> {
                for (int i = 0; i <= int.Parse(textBox1.Text.Trim()); i++)
                {
                    label1.Text = i.ToString();
                    Thread.Sleep(70);
                }
            }));
            trd1.IsBackground = true;
            Thread trd2 = new Thread(new ThreadStart(()=> {
                for (int i = 0; i <= int.Parse(textBox1.Text.Trim()); i += 2)
                {
                    label2.Text = i.ToString();
                    Thread.Sleep(70);
                }
            }));
            trd2.IsBackground = true;



            trd1.Start();
            trd2.Start();
        }
    }
}
