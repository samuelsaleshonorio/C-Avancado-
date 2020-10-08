using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonaimobi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txxUsuario.Text == "adonai" && txxSenha.Text == "Deus")
            {
                FormPrincipal princ = new FormPrincipal();
                princ.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha errados...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
