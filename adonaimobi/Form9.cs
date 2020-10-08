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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void contratoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.contrato' table. You can move, or remove it, as needed.
            this.contratoTableAdapter.Fill(this.bd_imobiliariaDataSet.contrato);

        }
    }
}
