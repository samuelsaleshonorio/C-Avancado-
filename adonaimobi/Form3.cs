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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void proprietarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proprietarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.proprietario' table. You can move, or remove it, as needed.
            this.proprietarioTableAdapter.Fill(this.bd_imobiliariaDataSet.proprietario);

        }
    }
}
