namespace Geo.Forms
{
    partial class F_Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.link_exit = new System.Windows.Forms.Button();
            this.tinaprov = new Geo.tinaprov();
            this.tinaprovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter = new Geo.tinaprovTableAdapters.provTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datachartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datachart = new Geo.datachart();
            this.provBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.provBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter1 = new Geo.datachartTableAdapters.provTableAdapter();
            this.tinaDataSet1 = new Geo.tinaDataSet1();
            this.provBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter2 = new Geo.tinaDataSet1TableAdapters.provTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tinaprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaprovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datachartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datachart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // link_exit
            // 
            this.link_exit.BackColor = System.Drawing.Color.FloralWhite;
            this.link_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_exit.Location = new System.Drawing.Point(783, 21);
            this.link_exit.Name = "link_exit";
            this.link_exit.Size = new System.Drawing.Size(170, 40);
            this.link_exit.TabIndex = 24;
            this.link_exit.Text = "Выход";
            this.link_exit.UseVisualStyleBackColor = false;
            // 
            // tinaprov
            // 
            this.tinaprov.DataSetName = "tinaprov";
            this.tinaprov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinaprovBindingSource
            // 
            this.tinaprovBindingSource.DataSource = this.tinaprov;
            this.tinaprovBindingSource.Position = 0;
            // 
            // provBindingSource
            // 
            this.provBindingSource.DataMember = "prov";
            this.provBindingSource.DataSource = this.tinaprovBindingSource;
            // 
            // provTableAdapter
            // 
            this.provTableAdapter.ClearBeforeFill = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.provBindingSource3;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(80, 77);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Координаты";
            series2.XValueMember = "Latitude";
            series2.YValueMembers = "Longitude";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(551, 441);
            this.chart2.TabIndex = 45;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // datachartBindingSource
            // 
            this.datachartBindingSource.DataSource = this.datachart;
            this.datachartBindingSource.Position = 0;
            // 
            // datachart
            // 
            this.datachart.DataSetName = "datachart";
            this.datachart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource1
            // 
            this.provBindingSource1.DataMember = "prov";
            this.provBindingSource1.DataSource = this.tinaprovBindingSource;
            // 
            // provBindingSource2
            // 
            this.provBindingSource2.DataMember = "prov";
            this.provBindingSource2.DataSource = this.datachart;
            // 
            // provTableAdapter1
            // 
            this.provTableAdapter1.ClearBeforeFill = true;
            // 
            // tinaDataSet1
            // 
            this.tinaDataSet1.DataSetName = "tinaDataSet1";
            this.tinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource3
            // 
            this.provBindingSource3.DataMember = "prov";
            this.provBindingSource3.DataSource = this.tinaDataSet1;
            // 
            // provTableAdapter2
            // 
            this.provTableAdapter2.ClearBeforeFill = true;
            // 
            // F_Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 576);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.link_exit);
            this.Name = "F_Charts";
            this.Text = "F_Charts";
            this.Load += new System.EventHandler(this.F_Charts_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tinaprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaprovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datachartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datachart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button link_exit;
        private System.Windows.Forms.BindingSource tinaprovBindingSource;
        private tinaprov tinaprov;
        private System.Windows.Forms.BindingSource provBindingSource;
        private tinaprovTableAdapters.provTableAdapter provTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource provBindingSource1;
        private datachart datachart;
        private System.Windows.Forms.BindingSource provBindingSource2;
        private datachartTableAdapters.provTableAdapter provTableAdapter1;
        private System.Windows.Forms.BindingSource datachartBindingSource;
        private tinaDataSet1 tinaDataSet1;
        private System.Windows.Forms.BindingSource provBindingSource3;
        private tinaDataSet1TableAdapters.provTableAdapter provTableAdapter2;
    }
}