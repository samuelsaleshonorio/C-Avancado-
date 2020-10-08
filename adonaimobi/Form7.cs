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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void notafiscalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notafiscalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.notafiscal' table. You can move, or remove it, as needed.
            this.notafiscalTableAdapter.Fill(this.bd_imobiliariaDataSet.notafiscal);

        }
    }
}
