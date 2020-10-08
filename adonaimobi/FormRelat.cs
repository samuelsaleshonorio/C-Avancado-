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
    public partial class FormRelat : Form
    {
        public FormRelat()
        {
            InitializeComponent();
        }

        private void FormRelat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.notafiscal' table. You can move, or remove it, as needed.
            this.notafiscalTableAdapter.Fill(this.bd_imobiliariaDataSet.notafiscal);

            this.reportViewer1.RefreshReport();
        }
    }
}
