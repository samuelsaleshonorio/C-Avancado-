namespace adonaimobi
{
    partial class Form6
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
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label data_vendaLabel;
            System.Windows.Forms.Label id_proprietario_fkLabel;
            System.Windows.Forms.Label id_imovel_fkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.vendaTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.vendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_vendaTextBox = new System.Windows.Forms.TextBox();
            this.data_vendaTextBox = new System.Windows.Forms.TextBox();
            this.id_proprietario_fkTextBox = new System.Windows.Forms.TextBox();
            this.id_imovel_fkTextBox = new System.Windows.Forms.TextBox();
            this.vendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            id_vendaLabel = new System.Windows.Forms.Label();
            data_vendaLabel = new System.Windows.Forms.Label();
            id_proprietario_fkLabel = new System.Windows.Forms.Label();
            id_imovel_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).BeginInit();
            this.vendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Location = new System.Drawing.Point(392, 292);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(55, 13);
            id_vendaLabel.TabIndex = 1;
            id_vendaLabel.Text = "ID Venda:";
            // 
            // data_vendaLabel
            // 
            data_vendaLabel.AutoSize = true;
            data_vendaLabel.Location = new System.Drawing.Point(663, 292);
            data_vendaLabel.Name = "data_vendaLabel";
            data_vendaLabel.Size = new System.Drawing.Size(67, 13);
            data_vendaLabel.TabIndex = 3;
            data_vendaLabel.Text = "Data Venda:";
            // 
            // id_proprietario_fkLabel
            // 
            id_proprietario_fkLabel.AutoSize = true;
            id_proprietario_fkLabel.Location = new System.Drawing.Point(392, 344);
            id_proprietario_fkLabel.Name = "id_proprietario_fkLabel";
            id_proprietario_fkLabel.Size = new System.Drawing.Size(93, 13);
            id_proprietario_fkLabel.TabIndex = 5;
            id_proprietario_fkLabel.Text = "ID Proprietario FK:";
            // 
            // id_imovel_fkLabel
            // 
            id_imovel_fkLabel.AutoSize = true;
            id_imovel_fkLabel.Location = new System.Drawing.Point(663, 344);
            id_imovel_fkLabel.Name = "id_imovel_fkLabel";
            id_imovel_fkLabel.Size = new System.Drawing.Size(71, 13);
            id_imovel_fkLabel.TabIndex = 7;
            id_imovel_fkLabel.Text = "ID Imovel FK:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = this.vendaTableAdapter;
            // 
            // vendaBindingNavigator
            // 
            this.vendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendaBindingNavigator.BindingSource = this.vendaBindingSource;
            this.vendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendaBindingNavigatorSaveItem});
            this.vendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendaBindingNavigator.Name = "vendaBindingNavigator";
            this.vendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendaBindingNavigator.Size = new System.Drawing.Size(1069, 25);
            this.vendaBindingNavigator.TabIndex = 0;
            this.vendaBindingNavigator.Text = "bindingNavigator1";
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
            // vendaBindingNavigatorSaveItem
            // 
            this.vendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendaBindingNavigatorSaveItem.Image")));
            this.vendaBindingNavigatorSaveItem.Name = "vendaBindingNavigatorSaveItem";
            this.vendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendaBindingNavigatorSaveItem.Text = "Save Data";
            this.vendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendaBindingNavigatorSaveItem_Click_1);
            // 
            // id_vendaTextBox
            // 
            this.id_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "id_venda", true));
            this.id_vendaTextBox.Location = new System.Drawing.Point(483, 289);
            this.id_vendaTextBox.Name = "id_vendaTextBox";
            this.id_vendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_vendaTextBox.TabIndex = 2;
            // 
            // data_vendaTextBox
            // 
            this.data_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "data_venda", true));
            this.data_vendaTextBox.Location = new System.Drawing.Point(754, 289);
            this.data_vendaTextBox.Name = "data_vendaTextBox";
            this.data_vendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_vendaTextBox.TabIndex = 4;
            // 
            // id_proprietario_fkTextBox
            // 
            this.id_proprietario_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "id_proprietario_fk", true));
            this.id_proprietario_fkTextBox.Location = new System.Drawing.Point(483, 341);
            this.id_proprietario_fkTextBox.Name = "id_proprietario_fkTextBox";
            this.id_proprietario_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_proprietario_fkTextBox.TabIndex = 6;
            // 
            // id_imovel_fkTextBox
            // 
            this.id_imovel_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "id_imovel_fk", true));
            this.id_imovel_fkTextBox.Location = new System.Drawing.Point(754, 341);
            this.id_imovel_fkTextBox.Name = "id_imovel_fkTextBox";
            this.id_imovel_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imovel_fkTextBox.TabIndex = 8;
            // 
            // vendaDataGridView
            // 
            this.vendaDataGridView.AutoGenerateColumns = false;
            this.vendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vendaDataGridView.DataSource = this.vendaBindingSource;
            this.vendaDataGridView.Location = new System.Drawing.Point(437, 411);
            this.vendaDataGridView.Name = "vendaDataGridView";
            this.vendaDataGridView.Size = new System.Drawing.Size(443, 209);
            this.vendaDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_venda";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_venda";
            this.dataGridViewTextBoxColumn2.HeaderText = "data_venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_proprietario_fk";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_proprietario_fk";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_imovel_fk";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_imovel_fk";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(909, 165);
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
            this.label1.Location = new System.Drawing.Point(634, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vendas";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 803);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vendaDataGridView);
            this.Controls.Add(id_vendaLabel);
            this.Controls.Add(this.id_vendaTextBox);
            this.Controls.Add(data_vendaLabel);
            this.Controls.Add(this.data_vendaTextBox);
            this.Controls.Add(id_proprietario_fkLabel);
            this.Controls.Add(this.id_proprietario_fkTextBox);
            this.Controls.Add(id_imovel_fkLabel);
            this.Controls.Add(this.id_imovel_fkTextBox);
            this.Controls.Add(this.vendaBindingNavigator);
            this.Name = "Form6";
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).EndInit();
            this.vendaBindingNavigator.ResumeLayout(false);
            this.vendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private bd_imobiliariaDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_vendaTextBox;
        private System.Windows.Forms.TextBox data_vendaTextBox;
        private System.Windows.Forms.TextBox id_proprietario_fkTextBox;
        private System.Windows.Forms.TextBox id_imovel_fkTextBox;
        private System.Windows.Forms.DataGridView vendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

    }
}