﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void imovelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imovelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_imobiliariaDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_imobiliariaDataSet.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter.Fill(this.bd_imobiliariaDataSet.imovel);

        }
    }
}
