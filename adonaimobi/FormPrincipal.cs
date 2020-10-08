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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void imobiliariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Imob = new Form1();
            Imob.ShowDialog();
        }

        private void compradorInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ComInq = new Form2();
            ComInq.ShowDialog();
        }

        private void proprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 prop = new Form3();
            prop.ShowDialog();
        }

        private void corretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 corr = new Form4();
            corr.ShowDialog();
        }

        private void imovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 imov = new Form5();
            imov.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 vend = new Form6();
            vend.ShowDialog();
        }

        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ntfs = new Form7();
            ntfs.ShowDialog();
        }

        private void alugueisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 alug = new Form8();
            alug.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 cont = new Form9();
            cont.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contadoParaSuporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContato contato = new FormContato();
            contato.ShowDialog();
        }

        private void relatorioDasNotasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelat relntf = new FormRelat();
            relntf.ShowDialog();
        }

        private void relatorioDosContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelat2 relcont = new FormRelat2();
            relcont.ShowDialog();
        }
    }
}
