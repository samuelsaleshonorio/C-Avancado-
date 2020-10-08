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
    public partial class FormRelat2 : Form
    {
        public FormRelat2()
        {
            InitializeComponent();
        }

        private void FormRelat2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.contrato' table. You can move, or remove it, as needed.
            this.contratoTableAdapter.Fill(this.bd_imobiliariaDataSet.contrato);

            this.reportViewer1.RefreshReport();
        }
    }
}
