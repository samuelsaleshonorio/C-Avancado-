namespace adonaimobi
{
    partial class Form9
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
            System.Windows.Forms.Label id_contratoLabel;
            System.Windows.Forms.Label periodo_contratoLabel;
            System.Windows.Forms.Label id_proprietario_fkLabel;
            System.Windows.Forms.Label id_comprador_inquilinoLabel;
            System.Windows.Forms.Label id_imob_fkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratoTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.contratoTableAdapter();
            this.tableAdapterManager = new adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager();
            this.contratoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contratoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_contratoTextBox = new System.Windows.Forms.TextBox();
            this.periodo_contratoTextBox = new System.Windows.Forms.TextBox();
            this.id_proprietario_fkTextBox = new System.Windows.Forms.TextBox();
            this.id_comprador_inquilinoTextBox = new System.Windows.Forms.TextBox();
            this.id_imob_fkTextBox = new System.Windows.Forms.TextBox();
            this.contratoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_contratoLabel = new System.Windows.Forms.Label();
            periodo_contratoLabel = new System.Windows.Forms.Label();
            id_proprietario_fkLabel = new System.Windows.Forms.Label();
            id_comprador_inquilinoLabel = new System.Windows.Forms.Label();
            id_imob_fkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingNavigator)).BeginInit();
            this.contratoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_contratoLabel
            // 
            id_contratoLabel.AutoSize = true;
            id_contratoLabel.Location = new System.Drawing.Point(499, 292);
            id_contratoLabel.Name = "id_contratoLabel";
            id_contratoLabel.Size = new System.Drawing.Size(64, 13);
            id_contratoLabel.TabIndex = 1;
            id_contratoLabel.Text = "ID Contrato:";
            // 
            // periodo_contratoLabel
            // 
            periodo_contratoLabel.AutoSize = true;
            periodo_contratoLabel.Location = new System.Drawing.Point(474, 321);
            periodo_contratoLabel.Name = "periodo_contratoLabel";
            periodo_contratoLabel.Size = new System.Drawing.Size(89, 13);
            periodo_contratoLabel.TabIndex = 3;
            periodo_contratoLabel.Text = "Periodo Contrato:";
            // 
            // id_proprietario_fkLabel
            // 
            id_proprietario_fkLabel.AutoSize = true;
            id_proprietario_fkLabel.Location = new System.Drawing.Point(470, 347);
            id_proprietario_fkLabel.Name = "id_proprietario_fkLabel";
            id_proprietario_fkLabel.Size = new System.Drawing.Size(93, 13);
            id_proprietario_fkLabel.TabIndex = 5;
            id_proprietario_fkLabel.Text = "ID Proprietario FK:";
            // 
            // id_comprador_inquilinoLabel
            // 
            id_comprador_inquilinoLabel.AutoSize = true;
            id_comprador_inquilinoLabel.Location = new System.Drawing.Point(786, 299);
            id_comprador_inquilinoLabel.Name = "id_comprador_inquilinoLabel";
            id_comprador_inquilinoLabel.Size = new System.Drawing.Size(133, 13);
            id_comprador_inquilinoLabel.TabIndex = 7;
            id_comprador_inquilinoLabel.Text = "ID Comprador Inquilino FK:";
            // 
            // id_imob_fkLabel
            // 
            id_imob_fkLabel.AutoSize = true;
            id_imob_fkLabel.Location = new System.Drawing.Point(856, 325);
            id_imob_fkLabel.Name = "id_imob_fkLabel";
            id_imob_fkLabel.Size = new System.Drawing.Size(63, 13);
            id_imob_fkLabel.TabIndex = 9;
            id_imob_fkLabel.Text = "ID Imob FK:";
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataMember = "contrato";
            this.contratoBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // contratoTableAdapter
            // 
            this.contratoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aluguelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprador_inquilinoTableAdapter = null;
            this.tableAdapterManager.contratoTableAdapter = this.contratoTableAdapter;
            this.tableAdapterManager.corretorTableAdapter = null;
            this.tableAdapterManager.imobiliariaTableAdapter = null;
            this.tableAdapterManager.imovelTableAdapter = null;
            this.tableAdapterManager.notafiscalTableAdapter = null;
            this.tableAdapterManager.proprietarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = adonaimobi.bd_imobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // contratoBindingNavigator
            // 
            this.contratoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contratoBindingNavigator.BindingSource = this.contratoBindingSource;
            this.contratoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contratoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contratoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contratoBindingNavigatorSaveItem});
            this.contratoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contratoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contratoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contratoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contratoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contratoBindingNavigator.Name = "contratoBindingNavigator";
            this.contratoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contratoBindingNavigator.Size = new System.Drawing.Size(1329, 25);
            this.contratoBindingNavigator.TabIndex = 0;
            this.contratoBindingNavigator.Text = "bindingNavigator1";
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
            // contratoBindingNavigatorSaveItem
            // 
            this.contratoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contratoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contratoBindingNavigatorSaveItem.Image")));
            this.contratoBindingNavigatorSaveItem.Name = "contratoBindingNavigatorSaveItem";
            this.contratoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contratoBindingNavigatorSaveItem.Text = "Save Data";
            this.contratoBindingNavigatorSaveItem.Click += new System.EventHandler(this.contratoBindingNavigatorSaveItem_Click);
            // 
            // id_contratoTextBox
            // 
            this.id_contratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "id_contrato", true));
            this.id_contratoTextBox.Location = new System.Drawing.Point(569, 292);
            this.id_contratoTextBox.Name = "id_contratoTextBox";
            this.id_contratoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_contratoTextBox.TabIndex = 2;
            // 
            // periodo_contratoTextBox
            // 
            this.periodo_contratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "periodo_contrato", true));
            this.periodo_contratoTextBox.Location = new System.Drawing.Point(569, 318);
            this.periodo_contratoTextBox.Name = "periodo_contratoTextBox";
            this.periodo_contratoTextBox.Size = new System.Drawing.Size(100, 20);
            this.periodo_contratoTextBox.TabIndex = 4;
            // 
            // id_proprietario_fkTextBox
            // 
            this.id_proprietario_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "id_proprietario_fk", true));
            this.id_proprietario_fkTextBox.Location = new System.Drawing.Point(569, 344);
            this.id_proprietario_fkTextBox.Name = "id_proprietario_fkTextBox";
            this.id_proprietario_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_proprietario_fkTextBox.TabIndex = 6;
            // 
            // id_comprador_inquilinoTextBox
            // 
            this.id_comprador_inquilinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "id_comprador_inquilino", true));
            this.id_comprador_inquilinoTextBox.Location = new System.Drawing.Point(925, 296);
            this.id_comprador_inquilinoTextBox.Name = "id_comprador_inquilinoTextBox";
            this.id_comprador_inquilinoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_comprador_inquilinoTextBox.TabIndex = 8;
            // 
            // id_imob_fkTextBox
            // 
            this.id_imob_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "id_imob_fk", true));
            this.id_imob_fkTextBox.Location = new System.Drawing.Point(925, 322);
            this.id_imob_fkTextBox.Name = "id_imob_fkTextBox";
            this.id_imob_fkTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_imob_fkTextBox.TabIndex = 10;
            // 
            // contratoDataGridView
            // 
            this.contratoDataGridView.AutoGenerateColumns = false;
            this.contratoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.contratoDataGridView.DataSource = this.contratoBindingSource;
            this.contratoDataGridView.Location = new System.Drawing.Point(501, 389);
            this.contratoDataGridView.Name = "contratoDataGridView";
            this.contratoDataGridView.Size = new System.Drawing.Size(543, 239);
            this.contratoDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_contrato";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_contrato";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "periodo_contrato";
            this.dataGridViewTextBoxColumn2.HeaderText = "periodo_contrato";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_comprador_inquilino";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_comprador_inquilino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_imob_fk";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_imob_fk";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Contrato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adonaimobi.Properties.Resources.Capturaraaa;
            this.pictureBox1.Location = new System.Drawing.Point(1045, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 95);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contratoDataGridView);
            this.Controls.Add(id_contratoLabel);
            this.Controls.Add(this.id_contratoTextBox);
            this.Controls.Add(periodo_contratoLabel);
            this.Controls.Add(this.periodo_contratoTextBox);
            this.Controls.Add(id_proprietario_fkLabel);
            this.Controls.Add(this.id_proprietario_fkTextBox);
            this.Controls.Add(id_comprador_inquilinoLabel);
            this.Controls.Add(this.id_comprador_inquilinoTextBox);
            this.Controls.Add(id_imob_fkLabel);
            this.Controls.Add(this.id_imob_fkTextBox);
            this.Controls.Add(this.contratoBindingNavigator);
            this.Name = "Form9";
            this.Text = "Contrato";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingNavigator)).EndInit();
            this.contratoBindingNavigator.ResumeLayout(false);
            this.contratoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private bd_imobiliariaDataSetTableAdapters.contratoTableAdapter contratoTableAdapter;
        private bd_imobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contratoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contratoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_contratoTextBox;
        private System.Windows.Forms.TextBox periodo_contratoTextBox;
        private System.Windows.Forms.TextBox id_proprietario_fkTextBox;
        private System.Windows.Forms.TextBox id_comprador_inquilinoTextBox;
        private System.Windows.Forms.TextBox id_imob_fkTextBox;
        private System.Windows.Forms.DataGridView contratoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}