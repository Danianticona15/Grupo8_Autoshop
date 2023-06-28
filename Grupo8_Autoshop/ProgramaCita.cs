using System;
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
    public partial class ProgramaCita : Form
    {
        public ProgramaCita()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManteCliente ma = new ManteCliente();
            ma.Show();
            this.Hide();
        }
    }
}
