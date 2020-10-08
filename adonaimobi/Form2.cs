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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comprador_inquilinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprador_inquilinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.comprador_inquilino' table. You can move, or remove it, as needed.
            this.comprador_inquilinoTableAdapter.Fill(this.bd_imobiliariaDataSet.comprador_inquilino);

        }
    }
}
