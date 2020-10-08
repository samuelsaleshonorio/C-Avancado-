namespace adonaimobi
{
    partial class FormRelat
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
            this.notafiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_imobiliariaDataSet = new adonaimobi.bd_imobiliariaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.notafiscalTableAdapter = new adonaimobi.bd_imobiliariaDataSetTableAdapters.notafiscalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // notafiscalBindingSource
            // 
            this.notafiscalBindingSource.DataMember = "notafiscal";
            this.notafiscalBindingSource.DataSource = this.bd_imobiliariaDataSet;
            // 
            // bd_imobiliariaDataSet
            // 
            this.bd_imobiliariaDataSet.DataSetName = "bd_imobiliariaDataSet";
            this.bd_imobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            reportDataSource1.Name = "Relatorio_ntf";
            reportDataSource1.Value = this.notafiscalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "adonaimobi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1580, 805);
            this.reportViewer1.TabIndex = 0;
            // 
            // notafiscalTableAdapter
            // 
            this.notafiscalTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 851);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelat";
            this.Text = "Relatório de Notas Fiscais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRelat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notafiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_imobiliariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource notafiscalBindingSource;
        private bd_imobiliariaDataSet bd_imobiliariaDataSet;
        private bd_imobiliariaDataSetTableAdapters.notafiscalTableAdapter notafiscalTableAdapter;
    }
}