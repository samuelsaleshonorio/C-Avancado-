namespace adonaimobi
{
    partial class FormRelat2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contratoTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.contratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataMember = "contrato";
            this.contratoBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "relatoriocontrato";
            reportDataSource1.Value = this.contratoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "adonaimobi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1579, 818);
            this.reportViewer1.TabIndex = 0;
            // 
            // contratoTableAdapter
            // 
            this.contratoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 842);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelat2";
            this.Text = "Relatório de Contratos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRelat2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private bd_imobiliariaDataSetTableAdapters.contratoTableAdapter contratoTableAdapter;
    }
}