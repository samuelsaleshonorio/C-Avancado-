namespace adonaimobi
{
    partial class Form1
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
            System.Windows.Forms.Label id_imobLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label razao_socialLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.imobiliariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imobiliariaTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.imobiliariaTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.imobiliariaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.imobiliariaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_imobTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.razao_socialTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.imobiliariaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_imobLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            razao_socialLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliariaBindingNavigator)).BeginInit();
            this.imobiliariaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliariaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_imobLabel
            // 
            id_imobLabel.AutoSize = true;
            id_imobLabel.Location = new System.Drawing.Point(539, 249);
            id_imobLabel.Name = "id_imobLabel";
            id_imobLabel.Size = new System.Drawing.Size(68, 13);
            id_imobLabel.TabIndex = 1;
            id_imobLabel.Text = "Id Imobiliaria:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(751, 246);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 3;
            cnpjLabel.Text = "CNPJ:";
            // 
            // razao_socialLabel
            // 
            razao_socialLabel.AutoSize = true;
            razao_socialLabel.Location = new System.Drawing.Point(539, 282);
            razao_socialLabel.Name = "razao_socialLabel";
            razao_socialLabel.Size = new System.Drawing.Size(73, 13);
            razao_socialLabel.TabIndex = 5;
            razao_socialLabel.Text = "Razão Social:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(751, 279);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(982, 243);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "Telefone:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imobiliariaBindingSource
            // 
            this.imobiliariaBindingSource.DataMember = "imobiliaria";
            this.imobiliariaBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // imobiliariaTableAdapter
            // 
            this.imobiliariaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = null;
            this.tableAdapterManager.contratoTableAdapter = null;
            this.tableAdapterManager.corretorTableAdapter = null;
            this.tableAdapterManager.imobiliariaTableAdapter = this.imobiliariaTableAdapter;
            this.tableAdapterManager.imovelTableAdapter = null;
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // imobiliariaBindingNavigator
            // 
            this.imobiliariaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imobiliariaBindingNavigator.BindingSource = this.imobiliariaBindingSource;
            this.imobiliariaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imobiliariaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imobiliariaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.imobiliariaBindingNavigatorSaveItem});
            this.imobiliariaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imobiliariaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imobiliariaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imobiliariaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imobiliariaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imobiliariaBindingNavigator.Name = "imobiliariaBindingNavigator";
            this.imobiliariaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imobiliariaBindingNavigator.Size = new System.Drawing.Size(1604, 25);
            this.imobiliariaBindingNavigator.TabIndex = 0;
            this.imobiliariaBindingNavigator.Text = "bindingNavigator1";
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
            // imobiliariaBindingNavigatorSaveItem
            // 
            this.imobiliariaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imobiliariaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imobiliariaBindingNavigatorSaveItem.Image")));
            this.imobiliariaBindingNavigatorSaveItem.Name = "imobiliariaBindingNavigatorSaveItem";
            this.imobiliariaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imobiliariaBindingNavigatorSaveItem.Text = "Save Data";
            this.imobiliariaBindingNavigatorSaveItem.Click += new System.EventHandler(this.imobiliariaBindingNavigatorSaveItem_Click);
            // 
            // id_imobTextBox
            // 
            this.id_imobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imobiliariaBindingSource, "id_imob", true));
            this.id_imobTextBox.Location = new System.Drawing.Point(611, 246);
            this.id_imobTextBox.Name = "id_imobTextBox";
            this.id_imobTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imobTextBox.TabIndex = 2;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imobiliariaBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(823, 243);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 4;
            // 
            // razao_socialTextBox
            // 
            this.razao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imobiliariaBindingSource, "razao_social", true));
            this.razao_socialTextBox.Location = new System.Drawing.Point(611, 279);
            this.razao_socialTextBox.Name = "razao_socialTextBox";
            this.razao_socialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razao_socialTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imobiliariaBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(823, 276);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(130, 20);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imobiliariaBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(1054, 240);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // imobiliariaDataGridView
            // 
            this.imobiliariaDataGridView.AutoGenerateColumns = false;
            this.imobiliariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imobiliariaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.imobiliariaDataGridView.DataSource = this.imobiliariaBindingSource;
            this.imobiliariaDataGridView.Location = new System.Drawing.Point(537, 316);
            this.imobiliariaDataGridView.Name = "imobiliariaDataGridView";
            this.imobiliariaDataGridView.Size = new System.Drawing.Size(543, 220);
            this.imobiliariaDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_imob";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_imob";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn2.HeaderText = "cnpj";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "razao_social";
            this.dataGridViewTextBoxColumn3.HeaderText = "razao_social";
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Imobiliaria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(1059, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imobiliariaDataGridView);
            this.Controls.Add(id_imobLabel);
            this.Controls.Add(this.id_imobTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(razao_socialLabel);
            this.Controls.Add(this.razao_socialTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.imobiliariaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Imobiliaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliariaBindingNavigator)).EndInit();
            this.imobiliariaBindingNavigator.ResumeLayout(false);
            this.imobiliariaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliariaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource imobiliariaBindingSource;
        private bd_imobiliariaDataSetTableAdapters.imobiliariaTableAdapter imobiliariaTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imobiliariaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton imobiliariaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_imobTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox razao_socialTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.DataGridView imobiliariaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

