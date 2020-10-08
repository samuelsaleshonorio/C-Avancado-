namespace adonaimobi
{
    partial class Form8
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
            System.Windows.Forms.Label id_aluguelLabel;
            System.Windows.Forms.Label data_inicialLabel;
            System.Windows.Forms.Label data_finalLabel;
            System.Windows.Forms.Label valor_entradaLabel;
            System.Windows.Forms.Label valor_aluguelLabel;
            System.Windows.Forms.Label id_imovel_fkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.aluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluguelTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.aluguelTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.aluguelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aluguelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_aluguelTextBox = new System.Windows.Forms.TextBox();
            this.data_inicialTextBox = new System.Windows.Forms.TextBox();
            this.data_finalTextBox = new System.Windows.Forms.TextBox();
            this.valor_entradaTextBox = new System.Windows.Forms.TextBox();
            this.valor_aluguelTextBox = new System.Windows.Forms.TextBox();
            this.id_imovel_fkTextBox = new System.Windows.Forms.TextBox();
            this.aluguelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_aluguelLabel = new System.Windows.Forms.Label();
            data_inicialLabel = new System.Windows.Forms.Label();
            data_finalLabel = new System.Windows.Forms.Label();
            valor_entradaLabel = new System.Windows.Forms.Label();
            valor_aluguelLabel = new System.Windows.Forms.Label();
            id_imovel_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingNavigator)).BeginInit();
            this.aluguelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_aluguelLabel
            // 
            id_aluguelLabel.AutoSize = true;
            id_aluguelLabel.Location = new System.Drawing.Point(428, 242);
            id_aluguelLabel.Name = "id_aluguelLabel";
            id_aluguelLabel.Size = new System.Drawing.Size(59, 13);
            id_aluguelLabel.TabIndex = 1;
            id_aluguelLabel.Text = "ID Aluguel:";
            // 
            // data_inicialLabel
            // 
            data_inicialLabel.AutoSize = true;
            data_inicialLabel.Location = new System.Drawing.Point(428, 268);
            data_inicialLabel.Name = "data_inicialLabel";
            data_inicialLabel.Size = new System.Drawing.Size(63, 13);
            data_inicialLabel.TabIndex = 3;
            data_inicialLabel.Text = "Data Inicial:";
            // 
            // data_finalLabel
            // 
            data_finalLabel.AutoSize = true;
            data_finalLabel.Location = new System.Drawing.Point(428, 294);
            data_finalLabel.Name = "data_finalLabel";
            data_finalLabel.Size = new System.Drawing.Size(58, 13);
            data_finalLabel.TabIndex = 5;
            data_finalLabel.Text = "Data Final:";
            // 
            // valor_entradaLabel
            // 
            valor_entradaLabel.AutoSize = true;
            valor_entradaLabel.Location = new System.Drawing.Point(763, 239);
            valor_entradaLabel.Name = "valor_entradaLabel";
            valor_entradaLabel.Size = new System.Drawing.Size(89, 13);
            valor_entradaLabel.TabIndex = 7;
            valor_entradaLabel.Text = "Valor de Entrada:";
            // 
            // valor_aluguelLabel
            // 
            valor_aluguelLabel.AutoSize = true;
            valor_aluguelLabel.Location = new System.Drawing.Point(766, 268);
            valor_aluguelLabel.Name = "valor_aluguelLabel";
            valor_aluguelLabel.Size = new System.Drawing.Size(87, 13);
            valor_aluguelLabel.TabIndex = 9;
            valor_aluguelLabel.Text = "Valor do Aluguel:";
            // 
            // id_imovel_fkLabel
            // 
            id_imovel_fkLabel.AutoSize = true;
            id_imovel_fkLabel.Location = new System.Drawing.Point(781, 294);
            id_imovel_fkLabel.Name = "id_imovel_fkLabel";
            id_imovel_fkLabel.Size = new System.Drawing.Size(71, 13);
            id_imovel_fkLabel.TabIndex = 11;
            id_imovel_fkLabel.Text = "ID Imovel FK:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aluguelBindingSource
            // 
            this.aluguelBindingSource.DataMember = "aluguel";
            this.aluguelBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // aluguelTableAdapter
            // 
            this.aluguelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = this.aluguelTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = null;
            this.tableAdapterManager.contratoTableAdapter = null;
            this.tableAdapterManager.corretorTableAdapter = null;
            this.tableAdapterManager.imobiliariaTableAdapter = null;
            this.tableAdapterManager.imovelTableAdapter = null;
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // aluguelBindingNavigator
            // 
            this.aluguelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aluguelBindingNavigator.BindingSource = this.aluguelBindingSource;
            this.aluguelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aluguelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aluguelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aluguelBindingNavigatorSaveItem});
            this.aluguelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aluguelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aluguelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aluguelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aluguelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aluguelBindingNavigator.Name = "aluguelBindingNavigator";
            this.aluguelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aluguelBindingNavigator.Size = new System.Drawing.Size(1101, 25);
            this.aluguelBindingNavigator.TabIndex = 0;
            this.aluguelBindingNavigator.Text = "bindingNavigator1";
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
            // aluguelBindingNavigatorSaveItem
            // 
            this.aluguelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aluguelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aluguelBindingNavigatorSaveItem.Image")));
            this.aluguelBindingNavigatorSaveItem.Name = "aluguelBindingNavigatorSaveItem";
            this.aluguelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aluguelBindingNavigatorSaveItem.Text = "Save Data";
            this.aluguelBindingNavigatorSaveItem.Click += new System.EventHandler(this.aluguelBindingNavigatorSaveItem_Click);
            // 
            // id_aluguelTextBox
            // 
            this.id_aluguelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguelBindingSource, "id_aluguel", true));
            this.id_aluguelTextBox.Location = new System.Drawing.Point(506, 239);
            this.id_aluguelTextBox.Name = "id_aluguelTextBox";
            this.id_aluguelTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_aluguelTextBox.TabIndex = 2;
            // 
            // data_inicialTextBox
            // 
            this.data_inicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguelBindingSource, "data_inicial", true));
            this.data_inicialTextBox.Location = new System.Drawing.Point(506, 265);
            this.data_inicialTextBox.Name = "data_inicialTextBox";
            this.data_inicialTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_inicialTextBox.TabIndex = 4;
            // 
            // data_finalTextBox
            // 
            this.data_finalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguelBindingSource, "data_final", true));
            this.data_finalTextBox.Location = new System.Drawing.Point(506, 291);
            this.data_finalTextBox.Name = "data_finalTextBox";
            this.data_finalTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_finalTextBox.TabIndex = 6;
            // 
            // valor_entradaTextBox
            // 
            this.valor_entradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguelBindingSource, "valor_entrada", true));
            this.valor_entradaTextBox.Location = new System.Drawing.Point(859, 239);
            this.valor_entradaTextBox.Name = "valor_entradaTextBox";
            this.valor_entradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_entradaTextBox.TabIndex = 8;
            // 
            // valor_aluguelTextBox
            // 
            this.valor_aluguelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguelBindingSource, "valor_aluguel", true));
            this.valor_aluguelTextBox.Location = new System.Drawing.Point(859, 265);
            this.valor_aluguelTextBox.Name = "valor_aluguelTextBox";
            this.valor_aluguelTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_aluguelTextBox.TabIndex = 10;
            // 
            // id_imovel_fkTextBox
            // 
            this.id_imovel_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguelBindingSource, "id_imovel_fk", true));
            this.id_imovel_fkTextBox.Location = new System.Drawing.Point(859, 291);
            this.id_imovel_fkTextBox.Name = "id_imovel_fkTextBox";
            this.id_imovel_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imovel_fkTextBox.TabIndex = 12;
            // 
            // aluguelDataGridView
            // 
            this.aluguelDataGridView.AutoGenerateColumns = false;
            this.aluguelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aluguelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.aluguelDataGridView.DataSource = this.aluguelBindingSource;
            this.aluguelDataGridView.Location = new System.Drawing.Point(409, 329);
            this.aluguelDataGridView.Name = "aluguelDataGridView";
            this.aluguelDataGridView.Size = new System.Drawing.Size(643, 237);
            this.aluguelDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_aluguel";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_aluguel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_inicial";
            this.dataGridViewTextBoxColumn2.HeaderText = "data_inicial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_final";
            this.dataGridViewTextBoxColumn3.HeaderText = "data_final";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_entrada";
            this.dataGridViewTextBoxColumn4.HeaderText = "valor_entrada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor_aluguel";
            this.dataGridViewTextBoxColumn5.HeaderText = "valor_aluguel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_imovel_fk";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_imovel_fk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Aluguel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(998, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 739);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aluguelDataGridView);
            this.Controls.Add(id_aluguelLabel);
            this.Controls.Add(this.id_aluguelTextBox);
            this.Controls.Add(data_inicialLabel);
            this.Controls.Add(this.data_inicialTextBox);
            this.Controls.Add(data_finalLabel);
            this.Controls.Add(this.data_finalTextBox);
            this.Controls.Add(valor_entradaLabel);
            this.Controls.Add(this.valor_entradaTextBox);
            this.Controls.Add(valor_aluguelLabel);
            this.Controls.Add(this.valor_aluguelTextBox);
            this.Controls.Add(id_imovel_fkLabel);
            this.Controls.Add(this.id_imovel_fkTextBox);
            this.Controls.Add(this.aluguelBindingNavigator);
            this.Name = "Form8";
            this.Text = "Aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingNavigator)).EndInit();
            this.aluguelBindingNavigator.ResumeLayout(false);
            this.aluguelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource aluguelBindingSource;
        private bd_imobiliariaDataSetTableAdapters.aluguelTableAdapter aluguelTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aluguelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aluguelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_aluguelTextBox;
        private System.Windows.Forms.TextBox data_inicialTextBox;
        private System.Windows.Forms.TextBox data_finalTextBox;
        private System.Windows.Forms.TextBox valor_entradaTextBox;
        private System.Windows.Forms.TextBox valor_aluguelTextBox;
        private System.Windows.Forms.TextBox id_imovel_fkTextBox;
        private System.Windows.Forms.DataGridView aluguelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}