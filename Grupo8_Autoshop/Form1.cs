﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo8_Autoshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManteRepuesto da = new ManteRepuesto();
            da.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgramaCita da = new ProgramaCita();
            da.Show();
            this.Hide();
;
        }
    }
}
