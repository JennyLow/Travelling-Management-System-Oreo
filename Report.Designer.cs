namespace WindowsFormsApplication15
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.FlightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IOOPDataSet1 = new WindowsFormsApplication15.IOOPDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FlightsTableAdapter = new WindowsFormsApplication15.IOOPDataSet1TableAdapters.FlightsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IOOPDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightsBindingSource
            // 
            this.FlightsBindingSource.DataMember = "Flights";
            this.FlightsBindingSource.DataSource = this.IOOPDataSet1;
            // 
            // IOOPDataSet1
            // 
            this.IOOPDataSet1.DataSetName = "IOOPDataSet1";
            this.IOOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FlightsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication15.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // FlightsTableAdapter
            // 
            this.FlightsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IOOPDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FlightsBindingSource;
        private IOOPDataSet1 IOOPDataSet1;
        private IOOPDataSet1TableAdapters.FlightsTableAdapter FlightsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}