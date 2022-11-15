using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace YYX.WFATest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                this.Enabled = false;

            }
            else
            {
                //this.Activate();
            }

            this.Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventInfo eventInfo = textBox1.GetType().GetEvent("ReadOnlyChanged");
            if (eventInfo != null)
            {
                Delegate.CreateDelegate(textBox1, eventHandler);
                Delegate handler = Delegatt;
                eventInfo.AddEventHandler(textBox1, handler);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(@"TextBox");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(@"Form");
        }
    }
}
