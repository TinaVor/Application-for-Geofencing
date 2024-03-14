namespace Geo.Forms
{
    partial class F_Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Graph));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.bt_Graph = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(266, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 75);
            this.label5.TabIndex = 88;
            this.label5.Text = "График заказа №";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(784, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 69);
            this.label1.TabIndex = 89;
            this.label1.Text = "label1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(161, 225);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(843, 274);
            this.cartesianChart1.TabIndex = 90;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // bt_Graph
            // 
            this.bt_Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Graph.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_Graph.Location = new System.Drawing.Point(161, 542);
            this.bt_Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Graph.Name = "bt_Graph";
            this.bt_Graph.Size = new System.Drawing.Size(769, 50);
            this.bt_Graph.TabIndex = 91;
            this.bt_Graph.Text = "Отобразить График";
            this.bt_Graph.UseVisualStyleBackColor = true;
            this.bt_Graph.Click += new System.EventHandler(this.bt_Graph_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 16F);
            this.button1.Location = new System.Drawing.Point(999, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 50);
            this.button1.TabIndex = 92;
            this.button1.Text = "ВЫЙТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Graph);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Graph";
            this.Load += new System.EventHandler(this.F_Graph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button bt_Graph;
        private System.Windows.Forms.Button button1;
    }
}