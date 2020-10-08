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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void corretorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.corretorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.corretor' table. You can move, or remove it, as needed.
            this.corretorTableAdapter.Fill(this.bd_imobiliariaDataSet.corretor);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
