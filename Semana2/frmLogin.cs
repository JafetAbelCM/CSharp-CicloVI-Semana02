using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] users = { "Jafet" };

            string usuario = "jafet";
            string pass = "54321";

            if (txtUsuario.Text.Equals(usuario) && txtPassword.Text.Equals(pass))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            } 
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
