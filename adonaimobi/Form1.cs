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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imobiliariaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imobiliariaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.imobiliaria' table. You can move, or remove it, as needed.
            this.imobiliariaTableAdapter.Fill(this.bd_imobiliariaDataSet.imobiliaria);

        }
    }
}
