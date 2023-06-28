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
    public partial class Login : Form
    {
        string Usuario = "Administrador";
        string Contraseña = "Hola";
        public Login()
        {
            InitializeComponent();
        }

        private void bTNACCEDER_Click(object sender, EventArgs e)
        {
            if(txtaceptar.Text != Usuario && txtcontraseña.Text != Contraseña)
            {
                if(txtaceptar.Text != Usuario)
                {
                    MessageBox.Show("usuario incorrecto");
                    txtaceptar.Clear();
                    txtaceptar.Focus();
                    return;
                       
                }if(txtcontraseña.Text != Contraseña)
                {
                    MessageBox.Show("contraseña incorrecto");
                    txtcontraseña.Clear();
                    txtcontraseña.Focus();
                    return;
                }

            }
            else
            {
                txtaceptar.Clear();
                txtcontraseña.Clear();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }
    }
}
