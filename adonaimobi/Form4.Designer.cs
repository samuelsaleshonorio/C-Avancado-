namespace adonaimobi
{
    partial class Form4
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
            System.Windows.Forms.Label id_corretorLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label por_corretagemLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label id_imob_fkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.corretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corretorTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.corretorTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.corretorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.corretorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_corretorTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.por_corretagemTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.id_imob_fkTextBox = new System.Windows.Forms.TextBox();
            this.corretorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            id_corretorLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            por_corretagemLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            id_imob_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingNavigator)).BeginInit();
            this.corretorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corretorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_corretorLabel
            // 
            id_corretorLabel.AutoSize = true;
            id_corretorLabel.Location = new System.Drawing.Point(449, 254);
            id_corretorLabel.Name = "id_corretorLabel";
            id_corretorLabel.Size = new System.Drawing.Size(61, 13);
            id_corretorLabel.TabIndex = 1;
            id_corretorLabel.Text = "ID Corretor:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(710, 243);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // por_corretagemLabel
            // 
            por_corretagemLabel.AutoSize = true;
            por_corretagemLabel.Location = new System.Drawing.Point(916, 246);
            por_corretagemLabel.Name = "por_corretagemLabel";
            por_corretagemLabel.Size = new System.Drawing.Size(90, 13);
            por_corretagemLabel.TabIndex = 5;
            por_corretagemLabel.Text = "% da Corretagem:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(449, 301);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(696, 294);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(916, 293);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "E-mail:";
            // 
            // id_imob_fkLabel
            // 
            id_imob_fkLabel.AutoSize = true;
            id_imob_fkLabel.Location = new System.Drawing.Point(449, 353);
            id_imob_fkLabel.Name = "id_imob_fkLabel";
            id_imob_fkLabel.Size = new System.Drawing.Size(63, 13);
            id_imob_fkLabel.TabIndex = 13;
            id_imob_fkLabel.Text = "ID Imob FK:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corretorBindingSource
            // 
            this.corretorBindingSource.DataMember = "corretor";
            this.corretorBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // corretorTableAdapter
            // 
            this.corretorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = null;
            this.tableAdapterManager.contratoTableAdapter = null;
            this.tableAdapterManager.corretorTableAdapter = this.corretorTableAdapter;
            this.tableAdapterManager.imobiliariaTableAdapter = null;
            this.tableAdapterManager.imovelTableAdapter = null;
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // corretorBindingNavigator
            // 
            this.corretorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.corretorBindingNavigator.BindingSource = this.corretorBindingSource;
            this.corretorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.corretorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.corretorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.corretorBindingNavigatorSaveItem});
            this.corretorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.corretorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.corretorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.corretorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.corretorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.corretorBindingNavigator.Name = "corretorBindingNavigator";
            this.corretorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.corretorBindingNavigator.Size = new System.Drawing.Size(1428, 25);
            this.corretorBindingNavigator.TabIndex = 0;
            this.corretorBindingNavigator.Text = "bindingNavigator1";
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
            // corretorBindingNavigatorSaveItem
            // 
            this.corretorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.corretorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("corretorBindingNavigatorSaveItem.Image")));
            this.corretorBindingNavigatorSaveItem.Name = "corretorBindingNavigatorSaveItem";
            this.corretorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.corretorBindingNavigatorSaveItem.Text = "Save Data";
            this.corretorBindingNavigatorSaveItem.Click += new System.EventHandler(this.corretorBindingNavigatorSaveItem_Click);
            // 
            // id_corretorTextBox
            // 
            this.id_corretorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "id_corretor", true));
            this.id_corretorTextBox.Location = new System.Drawing.Point(536, 251);
            this.id_corretorTextBox.Name = "id_corretorTextBox";
            this.id_corretorTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_corretorTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(754, 247);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(129, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // por_corretagemTextBox
            // 
            this.por_corretagemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "por_corretagem", true));
            this.por_corretagemTextBox.Location = new System.Drawing.Point(1003, 243);
            this.por_corretagemTextBox.Name = "por_corretagemTextBox";
            this.por_corretagemTextBox.Size = new System.Drawing.Size(52, 20);
            this.por_corretagemTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(536, 298);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(137, 20);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(754, 294);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(1003, 290);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(159, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // id_imob_fkTextBox
            // 
            this.id_imob_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corretorBindingSource, "id_imob_fk", true));
            this.id_imob_fkTextBox.Location = new System.Drawing.Point(536, 350);
            this.id_imob_fkTextBox.Name = "id_imob_fkTextBox";
            this.id_imob_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imob_fkTextBox.TabIndex = 14;
            // 
            // corretorDataGridView
            // 
            this.corretorDataGridView.AutoGenerateColumns = false;
            this.corretorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.corretorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.corretorDataGridView.DataSource = this.corretorBindingSource;
            this.corretorDataGridView.Location = new System.Drawing.Point(499, 416);
            this.corretorDataGridView.Name = "corretorDataGridView";
            this.corretorDataGridView.Size = new System.Drawing.Size(744, 401);
            this.corretorDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_corretor";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_corretor";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "por_corretagem";
            this.dataGridViewTextBoxColumn3.HeaderText = "por_corretagem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "endereco";
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_imob_fk";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_imob_fk";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(1224, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(793, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Corretor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.corretorDataGridView);
            this.Controls.Add(id_corretorLabel);
            this.Controls.Add(this.id_corretorTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(por_corretagemLabel);
            this.Controls.Add(this.por_corretagemTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(id_imob_fkLabel);
            this.Controls.Add(this.id_imob_fkTextBox);
            this.Controls.Add(this.corretorBindingNavigator);
            this.Name = "Form4";
            this.Text = "Corretor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingNavigator)).EndInit();
            this.corretorBindingNavigator.ResumeLayout(false);
            this.corretorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corretorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource corretorBindingSource;
        private bd_imobiliariaDataSetTableAdapters.corretorTableAdapter corretorTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator corretorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton corretorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_corretorTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox por_corretagemTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox id_imob_fkTextBox;
        private System.Windows.Forms.DataGridView corretorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}