namespace adonaimobi
{
    partial class Form5
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
            System.Windows.Forms.Label id_imovelLabel;
            System.Windows.Forms.Label desc_imovelLabel;
            System.Windows.Forms.Label valor_imovelLabel;
            System.Windows.Forms.Label end_imovelLabel;
            System.Windows.Forms.Label id_imob_fkLabel;
            System.Windows.Forms.Label id_proprietario_fkLabel;
            System.Windows.Forms.Label id_comprador_inquilino_fkLabel;
            System.Windows.Forms.Label valor_aluguelLabel;
            System.Windows.Forms.Label bairroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.imovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imovelTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.imovelTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.imovelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.imovelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_imovelTextBox = new System.Windows.Forms.TextBox();
            this.desc_imovelTextBox = new System.Windows.Forms.TextBox();
            this.valor_imovelTextBox = new System.Windows.Forms.TextBox();
            this.end_imovelTextBox = new System.Windows.Forms.TextBox();
            this.id_imob_fkTextBox = new System.Windows.Forms.TextBox();
            this.id_proprietario_fkTextBox = new System.Windows.Forms.TextBox();
            this.id_comprador_inquilino_fkTextBox = new System.Windows.Forms.TextBox();
            this.valor_aluguelTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.imovelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            id_imovelLabel = new System.Windows.Forms.Label();
            desc_imovelLabel = new System.Windows.Forms.Label();
            valor_imovelLabel = new System.Windows.Forms.Label();
            end_imovelLabel = new System.Windows.Forms.Label();
            id_imob_fkLabel = new System.Windows.Forms.Label();
            id_proprietario_fkLabel = new System.Windows.Forms.Label();
            id_comprador_inquilino_fkLabel = new System.Windows.Forms.Label();
            valor_aluguelLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingNavigator)).BeginInit();
            this.imovelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imovelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_imovelLabel
            // 
            id_imovelLabel.AutoSize = true;
            id_imovelLabel.Location = new System.Drawing.Point(396, 283);
            id_imovelLabel.Name = "id_imovelLabel";
            id_imovelLabel.Size = new System.Drawing.Size(55, 13);
            id_imovelLabel.TabIndex = 1;
            id_imovelLabel.Text = "ID Imovel:";
            // 
            // desc_imovelLabel
            // 
            desc_imovelLabel.AutoSize = true;
            desc_imovelLabel.Location = new System.Drawing.Point(396, 309);
            desc_imovelLabel.Name = "desc_imovelLabel";
            desc_imovelLabel.Size = new System.Drawing.Size(92, 13);
            desc_imovelLabel.TabIndex = 3;
            desc_imovelLabel.Text = "Descrição Imovel:";
            // 
            // valor_imovelLabel
            // 
            valor_imovelLabel.AutoSize = true;
            valor_imovelLabel.Location = new System.Drawing.Point(396, 335);
            valor_imovelLabel.Name = "valor_imovelLabel";
            valor_imovelLabel.Size = new System.Drawing.Size(68, 13);
            valor_imovelLabel.TabIndex = 5;
            valor_imovelLabel.Text = "Valor Imovel:";
            // 
            // end_imovelLabel
            // 
            end_imovelLabel.AutoSize = true;
            end_imovelLabel.Location = new System.Drawing.Point(685, 280);
            end_imovelLabel.Name = "end_imovelLabel";
            end_imovelLabel.Size = new System.Drawing.Size(105, 13);
            end_imovelLabel.TabIndex = 7;
            end_imovelLabel.Text = "Endereço do Imovel:";
            // 
            // id_imob_fkLabel
            // 
            id_imob_fkLabel.AutoSize = true;
            id_imob_fkLabel.Location = new System.Drawing.Point(685, 306);
            id_imob_fkLabel.Name = "id_imob_fkLabel";
            id_imob_fkLabel.Size = new System.Drawing.Size(63, 13);
            id_imob_fkLabel.TabIndex = 9;
            id_imob_fkLabel.Text = "ID Imob FK:";
            // 
            // id_proprietario_fkLabel
            // 
            id_proprietario_fkLabel.AutoSize = true;
            id_proprietario_fkLabel.Location = new System.Drawing.Point(685, 332);
            id_proprietario_fkLabel.Name = "id_proprietario_fkLabel";
            id_proprietario_fkLabel.Size = new System.Drawing.Size(93, 13);
            id_proprietario_fkLabel.TabIndex = 11;
            id_proprietario_fkLabel.Text = "ID Proprietario FK:";
            // 
            // id_comprador_inquilino_fkLabel
            // 
            id_comprador_inquilino_fkLabel.AutoSize = true;
            id_comprador_inquilino_fkLabel.Location = new System.Drawing.Point(1012, 280);
            id_comprador_inquilino_fkLabel.Name = "id_comprador_inquilino_fkLabel";
            id_comprador_inquilino_fkLabel.Size = new System.Drawing.Size(133, 13);
            id_comprador_inquilino_fkLabel.TabIndex = 13;
            id_comprador_inquilino_fkLabel.Text = "ID Comprador-Inquilino FK:";
            // 
            // valor_aluguelLabel
            // 
            valor_aluguelLabel.AutoSize = true;
            valor_aluguelLabel.Location = new System.Drawing.Point(1012, 306);
            valor_aluguelLabel.Name = "valor_aluguelLabel";
            valor_aluguelLabel.Size = new System.Drawing.Size(72, 13);
            valor_aluguelLabel.TabIndex = 15;
            valor_aluguelLabel.Text = "Valor Aluguel:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(1012, 332);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 17;
            bairroLabel.Text = "Bairro:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imovelBindingSource
            // 
            this.imovelBindingSource.DataMember = "imovel";
            this.imovelBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // imovelTableAdapter
            // 
            this.imovelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = null;
            this.tableAdapterManager.contratoTableAdapter = null;
            this.tableAdapterManager.corretorTableAdapter = null;
            this.tableAdapterManager.imobiliariaTableAdapter = null;
            this.tableAdapterManager.imovelTableAdapter = this.imovelTableAdapter;
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // imovelBindingNavigator
            // 
            this.imovelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imovelBindingNavigator.BindingSource = this.imovelBindingSource;
            this.imovelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imovelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imovelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.imovelBindingNavigatorSaveItem});
            this.imovelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imovelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imovelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imovelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imovelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imovelBindingNavigator.Name = "imovelBindingNavigator";
            this.imovelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imovelBindingNavigator.Size = new System.Drawing.Size(1232, 25);
            this.imovelBindingNavigator.TabIndex = 0;
            this.imovelBindingNavigator.Text = "bindingNavigator1";
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
            // imovelBindingNavigatorSaveItem
            // 
            this.imovelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imovelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imovelBindingNavigatorSaveItem.Image")));
            this.imovelBindingNavigatorSaveItem.Name = "imovelBindingNavigatorSaveItem";
            this.imovelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imovelBindingNavigatorSaveItem.Text = "Save Data";
            this.imovelBindingNavigatorSaveItem.Click += new System.EventHandler(this.imovelBindingNavigatorSaveItem_Click);
            // 
            // id_imovelTextBox
            // 
            this.id_imovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "id_imovel", true));
            this.id_imovelTextBox.Location = new System.Drawing.Point(526, 280);
            this.id_imovelTextBox.Name = "id_imovelTextBox";
            this.id_imovelTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imovelTextBox.TabIndex = 2;
            // 
            // desc_imovelTextBox
            // 
            this.desc_imovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "desc_imovel", true));
            this.desc_imovelTextBox.Location = new System.Drawing.Point(526, 306);
            this.desc_imovelTextBox.Name = "desc_imovelTextBox";
            this.desc_imovelTextBox.Size = new System.Drawing.Size(141, 20);
            this.desc_imovelTextBox.TabIndex = 4;
            // 
            // valor_imovelTextBox
            // 
            this.valor_imovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "valor_imovel", true));
            this.valor_imovelTextBox.Location = new System.Drawing.Point(526, 332);
            this.valor_imovelTextBox.Name = "valor_imovelTextBox";
            this.valor_imovelTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_imovelTextBox.TabIndex = 6;
            // 
            // end_imovelTextBox
            // 
            this.end_imovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "end_imovel", true));
            this.end_imovelTextBox.Location = new System.Drawing.Point(815, 277);
            this.end_imovelTextBox.Name = "end_imovelTextBox";
            this.end_imovelTextBox.Size = new System.Drawing.Size(166, 20);
            this.end_imovelTextBox.TabIndex = 8;
            // 
            // id_imob_fkTextBox
            // 
            this.id_imob_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "id_imob_fk", true));
            this.id_imob_fkTextBox.Location = new System.Drawing.Point(815, 303);
            this.id_imob_fkTextBox.Name = "id_imob_fkTextBox";
            this.id_imob_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imob_fkTextBox.TabIndex = 10;
            // 
            // id_proprietario_fkTextBox
            // 
            this.id_proprietario_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "id_proprietario_fk", true));
            this.id_proprietario_fkTextBox.Location = new System.Drawing.Point(815, 329);
            this.id_proprietario_fkTextBox.Name = "id_proprietario_fkTextBox";
            this.id_proprietario_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_proprietario_fkTextBox.TabIndex = 12;
            // 
            // id_comprador_inquilino_fkTextBox
            // 
            this.id_comprador_inquilino_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "id_comprador_inquilino_fk", true));
            this.id_comprador_inquilino_fkTextBox.Location = new System.Drawing.Point(1142, 277);
            this.id_comprador_inquilino_fkTextBox.Name = "id_comprador_inquilino_fkTextBox";
            this.id_comprador_inquilino_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_comprador_inquilino_fkTextBox.TabIndex = 14;
            // 
            // valor_aluguelTextBox
            // 
            this.valor_aluguelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "valor_aluguel", true));
            this.valor_aluguelTextBox.Location = new System.Drawing.Point(1142, 303);
            this.valor_aluguelTextBox.Name = "valor_aluguelTextBox";
            this.valor_aluguelTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_aluguelTextBox.TabIndex = 16;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imovelBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(1142, 329);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(164, 20);
            this.bairroTextBox.TabIndex = 18;
            // 
            // imovelDataGridView
            // 
            this.imovelDataGridView.AutoGenerateColumns = false;
            this.imovelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imovelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.imovelDataGridView.DataSource = this.imovelBindingSource;
            this.imovelDataGridView.Location = new System.Drawing.Point(355, 383);
            this.imovelDataGridView.Name = "imovelDataGridView";
            this.imovelDataGridView.Size = new System.Drawing.Size(946, 402);
            this.imovelDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_imovel";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_imovel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "desc_imovel";
            this.dataGridViewTextBoxColumn2.HeaderText = "desc_imovel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor_imovel";
            this.dataGridViewTextBoxColumn3.HeaderText = "valor_imovel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "end_imovel";
            this.dataGridViewTextBoxColumn4.HeaderText = "end_imovel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_imob_fk";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_imob_fk";
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_comprador_inquilino_fk";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_comprador_inquilino_fk";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valor_aluguel";
            this.dataGridViewTextBoxColumn8.HeaderText = "valor_aluguel";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn9.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(1182, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Imovel";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 854);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imovelDataGridView);
            this.Controls.Add(id_imovelLabel);
            this.Controls.Add(this.id_imovelTextBox);
            this.Controls.Add(desc_imovelLabel);
            this.Controls.Add(this.desc_imovelTextBox);
            this.Controls.Add(valor_imovelLabel);
            this.Controls.Add(this.valor_imovelTextBox);
            this.Controls.Add(end_imovelLabel);
            this.Controls.Add(this.end_imovelTextBox);
            this.Controls.Add(id_imob_fkLabel);
            this.Controls.Add(this.id_imob_fkTextBox);
            this.Controls.Add(id_proprietario_fkLabel);
            this.Controls.Add(this.id_proprietario_fkTextBox);
            this.Controls.Add(id_comprador_inquilino_fkLabel);
            this.Controls.Add(this.id_comprador_inquilino_fkTextBox);
            this.Controls.Add(valor_aluguelLabel);
            this.Controls.Add(this.valor_aluguelTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.imovelBindingNavigator);
            this.Name = "Form5";
            this.Text = "Imovel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingNavigator)).EndInit();
            this.imovelBindingNavigator.ResumeLayout(false);
            this.imovelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imovelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource imovelBindingSource;
        private bd_imobiliariaDataSetTableAdapters.imovelTableAdapter imovelTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imovelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton imovelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_imovelTextBox;
        private System.Windows.Forms.TextBox desc_imovelTextBox;
        private System.Windows.Forms.TextBox valor_imovelTextBox;
        private System.Windows.Forms.TextBox end_imovelTextBox;
        private System.Windows.Forms.TextBox id_imob_fkTextBox;
        private System.Windows.Forms.TextBox id_proprietario_fkTextBox;
        private System.Windows.Forms.TextBox id_comprador_inquilino_fkTextBox;
        private System.Windows.Forms.TextBox valor_aluguelTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.DataGridView imovelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}