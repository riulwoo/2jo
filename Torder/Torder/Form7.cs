﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torder
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
