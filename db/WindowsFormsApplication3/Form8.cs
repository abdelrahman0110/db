﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }
    }
}
