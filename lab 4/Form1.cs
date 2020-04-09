using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f1 = new Add();
            f1.Show();
        }

        private void viewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new allApplication();
            f2.Show();
        }

        private void changePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f4 = new password();
            f4.Show();
        }

        private void Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f5 = new search();
            f5.Show();
        }

        private void Fee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f6 = new fee();
            f6.Show();
        }

        private void modifyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f3 = new modify();
            f3.Show();
        }
    }
}
