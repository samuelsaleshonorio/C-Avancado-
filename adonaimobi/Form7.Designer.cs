namespace adonaimobi
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_nfLabel;
            System.Windows.Forms.Label id_imovel_fkLabel;
            System.Windows.Forms.Label forma_pagamentoLabel;
            System.Windows.Forms.Label id_imob_fkLabel;
            System.Windows.Forms.Label id_comprador_inquilino_fkLabel;
            System.Windows.Forms.Label id_proprietario_fkLabel;
            System.Windows.Forms.Label valor_imovel_fkLabel;
            System.Windows.Forms.Label data_venda_fkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.notafiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notafiscalTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.notafiscalTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.notafiscalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.notafiscalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_nfTextBox = new System.Windows.Forms.TextBox();
            this.id_imovel_fkTextBox = new System.Windows.Forms.TextBox();
            this.forma_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.id_imob_fkTextBox = new System.Windows.Forms.TextBox();
            this.id_comprador_inquilino_fkTextBox = new System.Windows.Forms.TextBox();
            this.id_proprietario_fkTextBox = new System.Windows.Forms.TextBox();
            this.valor_imovel_fkTextBox = new System.Windows.Forms.TextBox();
            this.data_venda_fkTextBox = new System.Windows.Forms.TextBox();
            this.notafiscalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_nfLabel = new System.Windows.Forms.Label();
            id_imovel_fkLabel = new System.Windows.Forms.Label();
            forma_pagamentoLabel = new System.Windows.Forms.Label();
            id_imob_fkLabel = new System.Windows.Forms.Label();
            id_comprador_inquilino_fkLabel = new System.Windows.Forms.Label();
            id_proprietario_fkLabel = new System.Windows.Forms.Label();
            valor_imovel_fkLabel = new System.Windows.Forms.Label();
            data_venda_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalBindingNavigator)).BeginInit();
            this.notafiscalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_nfLabel
            // 
            id_nfLabel.AutoSize = true;
            id_nfLabel.Location = new System.Drawing.Point(409, 260);
            id_nfLabel.Name = "id_nfLabel";
            id_nfLabel.Size = new System.Drawing.Size(47, 13);
            id_nfLabel.TabIndex = 1;
            id_nfLabel.Text = "ID Nota:";
            // 
            // id_imovel_fkLabel
            // 
            id_imovel_fkLabel.AutoSize = true;
            id_imovel_fkLabel.Location = new System.Drawing.Point(385, 289);
            id_imovel_fkLabel.Name = "id_imovel_fkLabel";
            id_imovel_fkLabel.Size = new System.Drawing.Size(71, 13);
            id_imovel_fkLabel.TabIndex = 3;
            id_imovel_fkLabel.Text = "ID Imovel FK:";
            // 
            // forma_pagamentoLabel
            // 
            forma_pagamentoLabel.AutoSize = true;
            forma_pagamentoLabel.Location = new System.Drawing.Point(600, 263);
            forma_pagamentoLabel.Name = "forma_pagamentoLabel";
            forma_pagamentoLabel.Size = new System.Drawing.Size(111, 13);
            forma_pagamentoLabel.TabIndex = 5;
            forma_pagamentoLabel.Text = "Forma de Pagamento:";
            // 
            // id_imob_fkLabel
            // 
            id_imob_fkLabel.AutoSize = true;
            id_imob_fkLabel.Location = new System.Drawing.Point(648, 289);
            id_imob_fkLabel.Name = "id_imob_fkLabel";
            id_imob_fkLabel.Size = new System.Drawing.Size(63, 13);
            id_imob_fkLabel.TabIndex = 7;
            id_imob_fkLabel.Text = "ID Imob FK:";
            // 
            // id_comprador_inquilino_fkLabel
            // 
            id_comprador_inquilino_fkLabel.AutoSize = true;
            id_comprador_inquilino_fkLabel.Location = new System.Drawing.Point(323, 315);
            id_comprador_inquilino_fkLabel.Name = "id_comprador_inquilino_fkLabel";
            id_comprador_inquilino_fkLabel.Size = new System.Drawing.Size(133, 13);
            id_comprador_inquilino_fkLabel.TabIndex = 9;
            id_comprador_inquilino_fkLabel.Text = "ID Comprador-Inquilino FK:";
            // 
            // id_proprietario_fkLabel
            // 
            id_proprietario_fkLabel.AutoSize = true;
            id_proprietario_fkLabel.Location = new System.Drawing.Point(873, 263);
            id_proprietario_fkLabel.Name = "id_proprietario_fkLabel";
            id_proprietario_fkLabel.Size = new System.Drawing.Size(93, 13);
            id_proprietario_fkLabel.TabIndex = 11;
            id_proprietario_fkLabel.Text = "ID Proprietario FK:";
            // 
            // valor_imovel_fkLabel
            // 
            valor_imovel_fkLabel.AutoSize = true;
            valor_imovel_fkLabel.Location = new System.Drawing.Point(867, 289);
            valor_imovel_fkLabel.Name = "valor_imovel_fkLabel";
            valor_imovel_fkLabel.Size = new System.Drawing.Size(99, 13);
            valor_imovel_fkLabel.TabIndex = 13;
            valor_imovel_fkLabel.Text = "Valor do Imovel FK:";
            // 
            // data_venda_fkLabel
            // 
            data_venda_fkLabel.AutoSize = true;
            data_venda_fkLabel.Location = new System.Drawing.Point(613, 315);
            data_venda_fkLabel.Name = "data_venda_fkLabel";
            data_venda_fkLabel.Size = new System.Drawing.Size(98, 13);
            data_venda_fkLabel.TabIndex = 15;
            data_venda_fkLabel.Text = "Data da Venda FK:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notafiscalBindingSource
            // 
            this.notafiscalBindingSource.DataMember = "notafiscal";
            this.notafiscalBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // notafiscalTableAdapter
            // 
            this.notafiscalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = null;
            this.tableAdapterManager.contratoTableAdapter = null;
            this.tableAdapterManager.corretorTableAdapter = null;
            this.tableAdapterManager.imobiliariaTableAdapter = null;
            this.tableAdapterManager.imovelTableAdapter = null;
            this.tableAdapterManager.notafiscalTableAdapter = this.notafiscalTableAdapter;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // notafiscalBindingNavigator
            // 
            this.notafiscalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notafiscalBindingNavigator.BindingSource = this.notafiscalBindingSource;
            this.notafiscalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notafiscalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notafiscalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.notafiscalBindingNavigatorSaveItem});
            this.notafiscalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notafiscalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notafiscalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notafiscalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notafiscalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notafiscalBindingNavigator.Name = "notafiscalBindingNavigator";
            this.notafiscalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notafiscalBindingNavigator.Size = new System.Drawing.Size(1258, 25);
            this.notafiscalBindingNavigator.TabIndex = 0;
            this.notafiscalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // notafiscalBindingNavigatorSaveItem
            // 
            this.notafiscalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notafiscalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notafiscalBindingNavigatorSaveItem.Image")));
            this.notafiscalBindingNavigatorSaveItem.Name = "notafiscalBindingNavigatorSaveItem";
            this.notafiscalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notafiscalBindingNavigatorSaveItem.Text = "Save Data";
            this.notafiscalBindingNavigatorSaveItem.Click += new System.EventHandler(this.notafiscalBindingNavigatorSaveItem_Click);
            // 
            // id_nfTextBox
            // 
            this.id_nfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "id_nf", true));
            this.id_nfTextBox.Location = new System.Drawing.Point(462, 260);
            this.id_nfTextBox.Name = "id_nfTextBox";
            this.id_nfTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_nfTextBox.TabIndex = 2;
            // 
            // id_imovel_fkTextBox
            // 
            this.id_imovel_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "id_imovel_fk", true));
            this.id_imovel_fkTextBox.Location = new System.Drawing.Point(462, 286);
            this.id_imovel_fkTextBox.Name = "id_imovel_fkTextBox";
            this.id_imovel_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imovel_fkTextBox.TabIndex = 4;
            // 
            // forma_pagamentoTextBox
            // 
            this.forma_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "forma_pagamento", true));
            this.forma_pagamentoTextBox.Location = new System.Drawing.Point(730, 260);
            this.forma_pagamentoTextBox.Name = "forma_pagamentoTextBox";
            this.forma_pagamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.forma_pagamentoTextBox.TabIndex = 6;
            // 
            // id_imob_fkTextBox
            // 
            this.id_imob_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "id_imob_fk", true));
            this.id_imob_fkTextBox.Location = new System.Drawing.Point(730, 286);
            this.id_imob_fkTextBox.Name = "id_imob_fkTextBox";
            this.id_imob_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imob_fkTextBox.TabIndex = 8;
            // 
            // id_comprador_inquilino_fkTextBox
            // 
            this.id_comprador_inquilino_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "id_comprador_inquilino_fk", true));
            this.id_comprador_inquilino_fkTextBox.Location = new System.Drawing.Point(462, 312);
            this.id_comprador_inquilino_fkTextBox.Name = "id_comprador_inquilino_fkTextBox";
            this.id_comprador_inquilino_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_comprador_inquilino_fkTextBox.TabIndex = 10;
            // 
            // id_proprietario_fkTextBox
            // 
            this.id_proprietario_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "id_proprietario_fk", true));
            this.id_proprietario_fkTextBox.Location = new System.Drawing.Point(981, 260);
            this.id_proprietario_fkTextBox.Name = "id_proprietario_fkTextBox";
            this.id_proprietario_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_proprietario_fkTextBox.TabIndex = 12;
            // 
            // valor_imovel_fkTextBox
            // 
            this.valor_imovel_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "valor_imovel_fk", true));
            this.valor_imovel_fkTextBox.Location = new System.Drawing.Point(981, 286);
            this.valor_imovel_fkTextBox.Name = "valor_imovel_fkTextBox";
            this.valor_imovel_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_imovel_fkTextBox.TabIndex = 14;
            // 
            // data_venda_fkTextBox
            // 
            this.data_venda_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notafiscalBindingSource, "data_venda_fk", true));
            this.data_venda_fkTextBox.Location = new System.Drawing.Point(730, 312);
            this.data_venda_fkTextBox.Name = "data_venda_fkTextBox";
            this.data_venda_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_venda_fkTextBox.TabIndex = 16;
            // 
            // notafiscalDataGridView
            // 
            this.notafiscalDataGridView.AutoGenerateColumns = false;
            this.notafiscalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notafiscalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.notafiscalDataGridView.DataSource = this.notafiscalBindingSource;
            this.notafiscalDataGridView.Location = new System.Drawing.Point(305, 379);
            this.notafiscalDataGridView.Name = "notafiscalDataGridView";
            this.notafiscalDataGridView.Size = new System.Drawing.Size(843, 210);
            this.notafiscalDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_nf";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_nf";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_imovel_fk";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_imovel_fk";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "forma_pagamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "forma_pagamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_imob_fk";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_imob_fk";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_comprador_inquilino_fk";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_comprador_inquilino_fk";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_proprietario_fk";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_proprietario_fk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor_imovel_fk";
            this.dataGridViewTextBoxColumn7.HeaderText = "valor_imovel_fk";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "data_venda_fk";
            this.dataGridViewTextBoxColumn8.HeaderText = "data_venda_fk";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Notas Fiscais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(1054, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.notafiscalDataGridView);
            this.Controls.Add(id_nfLabel);
            this.Controls.Add(this.id_nfTextBox);
            this.Controls.Add(id_imovel_fkLabel);
            this.Controls.Add(this.id_imovel_fkTextBox);
            this.Controls.Add(forma_pagamentoLabel);
            this.Controls.Add(this.forma_pagamentoTextBox);
            this.Controls.Add(id_imob_fkLabel);
            this.Controls.Add(this.id_imob_fkTextBox);
            this.Controls.Add(id_comprador_inquilino_fkLabel);
            this.Controls.Add(this.id_comprador_inquilino_fkTextBox);
            this.Controls.Add(id_proprietario_fkLabel);
            this.Controls.Add(this.id_proprietario_fkTextBox);
            this.Controls.Add(valor_imovel_fkLabel);
            this.Controls.Add(this.valor_imovel_fkTextBox);
            this.Controls.Add(data_venda_fkLabel);
            this.Controls.Add(this.data_venda_fkTextBox);
            this.Controls.Add(this.notafiscalBindingNavigator);
            this.Name = "Form7";
            this.Text = "Notas Fiscais ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalBindingNavigator)).EndInit();
            this.notafiscalBindingNavigator.ResumeLayout(false);
            this.notafiscalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource notafiscalBindingSource;
        private bd_imobiliariaDataSetTableAdapters.notafiscalTableAdapter notafiscalTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notafiscalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton notafiscalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_nfTextBox;
        private System.Windows.Forms.TextBox id_imovel_fkTextBox;
        private System.Windows.Forms.TextBox forma_pagamentoTextBox;
        private System.Windows.Forms.TextBox id_imob_fkTextBox;
        private System.Windows.Forms.TextBox id_comprador_inquilino_fkTextBox;
        private System.Windows.Forms.TextBox id_proprietario_fkTextBox;
        private System.Windows.Forms.TextBox valor_imovel_fkTextBox;
        private System.Windows.Forms.TextBox data_venda_fkTextBox;
        private System.Windows.Forms.DataGridView notafiscalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}