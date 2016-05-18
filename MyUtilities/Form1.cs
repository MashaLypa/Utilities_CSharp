﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyUtilities
{
    public partial class MyForm : Form
    {
        int count = 0;
        Random rnd;

        public MyForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа: Мои утилиты, \nсодержит ряд небольших программ, \nкоторые могут пригодиться в жизни. \nА главное, научить меня основам \nпрограммирования на C#. \nАвтор: Мария Липа.", "О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
            lblRandom.Text = n.ToString();

            if (cbRandom.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                    i++;
                    if (i > 1000) 
                        break;
                }
                if(i <= 1000)
                   tbRandom.AppendText(n + "\n");
            }
            else
                tbRandom.AppendText(n + "\n");
        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }
    }
}
