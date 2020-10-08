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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void aluguelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aluguelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.aluguel' table. You can move, or remove it, as needed.
            this.aluguelTableAdapter.Fill(this.bd_imobiliariaDataSet.aluguel);

        }
    }
}
