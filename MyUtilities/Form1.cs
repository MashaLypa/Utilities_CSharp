using System;
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
        public MyForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа: Мои утилиты, \nсодержит ряд небольших программ, \nкоторые могут пригодиться в жизни. \nА главное, научить меня основам \nпрограммирования на C#. \nАвтор: Мария Липа.", "О программе");
        }
    }
}
