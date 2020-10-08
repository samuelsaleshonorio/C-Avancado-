namespace adonaimobi
{
    partial class Form2
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
            System.Windows.Forms.Label id_comprador_inquilinoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cpf_cnpjLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.comprador_inquilinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprador_inquilinoTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.comprador_inquilinoTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.comprador_inquilinoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.comprador_inquilinoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_comprador_inquilinoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cpf_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.comprador_inquilinoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            id_comprador_inquilinoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cpf_cnpjLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprador_inquilinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprador_inquilinoBindingNavigator)).BeginInit();
            this.comprador_inquilinoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprador_inquilinoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_comprador_inquilinoLabel
            // 
            id_comprador_inquilinoLabel.AutoSize = true;
            id_comprador_inquilinoLabel.Location = new System.Drawing.Point(396, 307);
            id_comprador_inquilinoLabel.Name = "id_comprador_inquilinoLabel";
            id_comprador_inquilinoLabel.Size = new System.Drawing.Size(123, 13);
            id_comprador_inquilinoLabel.TabIndex = 1;
            id_comprador_inquilinoLabel.Text = "ID Comprador - Inquilino:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(664, 300);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(866, 300);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "Endereço:";
            // 
            // cpf_cnpjLabel
            // 
            cpf_cnpjLabel.AutoSize = true;
            cpf_cnpjLabel.Location = new System.Drawing.Point(451, 349);
            cpf_cnpjLabel.Name = "cpf_cnpjLabel";
            cpf_cnpjLabel.Size = new System.Drawing.Size(66, 13);
            cpf_cnpjLabel.TabIndex = 7;
            cpf_cnpjLabel.Text = "CPF - CNPJ:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(650, 352);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(866, 352);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "E-mail:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprador_inquilinoBindingSource
            // 
            this.comprador_inquilinoBindingSource.DataMember = "comprador_inquilino";
            this.comprador_inquilinoBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // comprador_inquilinoTableAdapter
            // 
            this.comprador_inquilinoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = this.comprador_inquilinoTableAdapter;
            this.tableAdapterManager.contratoTableAdapter = null;
            this.tableAdapterManager.corretorTableAdapter = null;
            this.tableAdapterManager.imobiliariaTableAdapter = null;
            this.tableAdapterManager.imovelTableAdapter = null;
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // comprador_inquilinoBindingNavigator
            // 
            this.comprador_inquilinoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.comprador_inquilinoBindingNavigator.BindingSource = this.comprador_inquilinoBindingSource;
            this.comprador_inquilinoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.comprador_inquilinoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.comprador_inquilinoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.comprador_inquilinoBindingNavigatorSaveItem});
            this.comprador_inquilinoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.comprador_inquilinoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.comprador_inquilinoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.comprador_inquilinoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.comprador_inquilinoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.comprador_inquilinoBindingNavigator.Name = "comprador_inquilinoBindingNavigator";
            this.comprador_inquilinoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.comprador_inquilinoBindingNavigator.Size = new System.Drawing.Size(1146, 25);
            this.comprador_inquilinoBindingNavigator.TabIndex = 0;
            this.comprador_inquilinoBindingNavigator.Text = "bindingNavigator1";
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
            // comprador_inquilinoBindingNavigatorSaveItem
            // 
            this.comprador_inquilinoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.comprador_inquilinoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("comprador_inquilinoBindingNavigatorSaveItem.Image")));
            this.comprador_inquilinoBindingNavigatorSaveItem.Name = "comprador_inquilinoBindingNavigatorSaveItem";
            this.comprador_inquilinoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.comprador_inquilinoBindingNavigatorSaveItem.Text = "Save Data";
            this.comprador_inquilinoBindingNavigatorSaveItem.Click += new System.EventHandler(this.comprador_inquilinoBindingNavigatorSaveItem_Click);
            // 
            // id_comprador_inquilinoTextBox
            // 
            this.id_comprador_inquilinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprador_inquilinoBindingSource, "id_comprador_inquilino", true));
            this.id_comprador_inquilinoTextBox.Location = new System.Drawing.Point(523, 304);
            this.id_comprador_inquilinoTextBox.Name = "id_comprador_inquilinoTextBox";
            this.id_comprador_inquilinoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_comprador_inquilinoTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprador_inquilinoBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(708, 300);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprador_inquilinoBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(928, 297);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(157, 20);
            this.enderecoTextBox.TabIndex = 6;
            // 
            // cpf_cnpjTextBox
            // 
            this.cpf_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprador_inquilinoBindingSource, "cpf_cnpj", true));
            this.cpf_cnpjTextBox.Location = new System.Drawing.Point(523, 349);
            this.cpf_cnpjTextBox.Name = "cpf_cnpjTextBox";
            this.cpf_cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpf_cnpjTextBox.TabIndex = 8;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprador_inquilinoBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(708, 349);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprador_inquilinoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(910, 349);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(157, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // comprador_inquilinoDataGridView
            // 
            this.comprador_inquilinoDataGridView.AllowDrop = true;
            this.comprador_inquilinoDataGridView.AutoGenerateColumns = false;
            this.comprador_inquilinoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprador_inquilinoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.comprador_inquilinoDataGridView.DataSource = this.comprador_inquilinoBindingSource;
            this.comprador_inquilinoDataGridView.Location = new System.Drawing.Point(399, 391);
            this.comprador_inquilinoDataGridView.Name = "comprador_inquilinoDataGridView";
            this.comprador_inquilinoDataGridView.Size = new System.Drawing.Size(650, 379);
            this.comprador_inquilinoDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_comprador_inquilino";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_comprador_inquilino";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cpf_cnpj";
            this.dataGridViewTextBoxColumn4.HeaderText = "cpf_cnpj";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(758, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Imobiliaria";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 815);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comprador_inquilinoDataGridView);
            this.Controls.Add(id_comprador_inquilinoLabel);
            this.Controls.Add(this.id_comprador_inquilinoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(cpf_cnpjLabel);
            this.Controls.Add(this.cpf_cnpjTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.comprador_inquilinoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Comprador/Inquilino";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprador_inquilinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprador_inquilinoBindingNavigator)).EndInit();
            this.comprador_inquilinoBindingNavigator.ResumeLayout(false);
            this.comprador_inquilinoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprador_inquilinoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource comprador_inquilinoBindingSource;
        private bd_imobiliariaDataSetTableAdapters.comprador_inquilinoTableAdapter comprador_inquilinoTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator comprador_inquilinoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton comprador_inquilinoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_comprador_inquilinoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cpf_cnpjTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView comprador_inquilinoDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}