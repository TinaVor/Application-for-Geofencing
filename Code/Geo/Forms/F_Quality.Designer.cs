namespace Geo.Forms
{
    partial class F_Quality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Quality));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_mark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_add_mark = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Square = new System.Windows.Forms.Label();
            this.tinaDataSet = new Geo.tinaDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Geo.tinaDataSetTableAdapters.ЗаказTableAdapter();
            this.ID_Заказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия_Оператора = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценка_качества = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb_zak = new System.Windows.Forms.ComboBox();
            this.заказBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tinaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinaaa = new Geo.tinaaa();
            this.tinaaaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter1 = new Geo.tinaaaTableAdapters.ЗаказTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaaaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(197, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 108;
            this.label1.Text = "Данные о заказах";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Заказа,
            this.Фамилия_Оператора,
            this.Цена,
            this.Оценка_качества});
            this.dataGridView1.Location = new System.Drawing.Point(18, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 336);
            this.dataGridView1.TabIndex = 107;
            // 
            // tb_mark
            // 
            this.tb_mark.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mark.Location = new System.Drawing.Point(936, 348);
            this.tb_mark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mark.Multiline = true;
            this.tb_mark.Name = "tb_mark";
            this.tb_mark.Size = new System.Drawing.Size(229, 36);
            this.tb_mark.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16F);
            this.label4.Location = new System.Drawing.Point(680, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 33);
            this.label4.TabIndex = 105;
            this.label4.Text = "Оценка";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(1008, 534);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(157, 50);
            this.Exit.TabIndex = 104;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_add_mark
            // 
            this.bt_add_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_add_mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_mark.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_add_mark.Location = new System.Drawing.Point(686, 417);
            this.bt_add_mark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add_mark.Name = "bt_add_mark";
            this.bt_add_mark.Size = new System.Drawing.Size(479, 50);
            this.bt_add_mark.TabIndex = 103;
            this.bt_add_mark.Text = "Внести Оценку";
            this.bt_add_mark.UseVisualStyleBackColor = true;
            this.bt_add_mark.Click += new System.EventHandler(this.bt_add_mark_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(190, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(786, 75);
            this.label5.TabIndex = 102;
            this.label5.Text = "ОЦЕНКА КАЧЕСТВА РАБОТЫ";
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Font = new System.Drawing.Font("Candara", 16F);
            this.lb_Square.Location = new System.Drawing.Point(680, 294);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(123, 33);
            this.lb_Square.TabIndex = 100;
            this.lb_Square.Text = "ID Заказа";
            // 
            // tinaDataSet
            // 
            this.tinaDataSet.DataSetName = "tinaDataSet";
            this.tinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.tinaDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // ID_Заказа
            // 
            this.ID_Заказа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Заказа.HeaderText = "ID_Заказа";
            this.ID_Заказа.MinimumWidth = 6;
            this.ID_Заказа.Name = "ID_Заказа";
            this.ID_Заказа.Width = 104;
            // 
            // Фамилия_Оператора
            // 
            this.Фамилия_Оператора.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Фамилия_Оператора.HeaderText = "Фамилия_Оператора";
            this.Фамилия_Оператора.MinimumWidth = 6;
            this.Фамилия_Оператора.Name = "Фамилия_Оператора";
            this.Фамилия_Оператора.Width = 175;
            // 
            // Цена
            // 
            this.Цена.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 6;
            this.Цена.Name = "Цена";
            this.Цена.Width = 69;
            // 
            // Оценка_качества
            // 
            this.Оценка_качества.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Оценка_качества.HeaderText = "Оценка_качества";
            this.Оценка_качества.MinimumWidth = 6;
            this.Оценка_качества.Name = "Оценка_качества";
            this.Оценка_качества.Width = 153;
            // 
            // заказBindingSource1
            // 
            this.заказBindingSource1.DataMember = "Заказ";
            this.заказBindingSource1.DataSource = this.tinaDataSet;
            // 
            // cb_zak
            // 
            this.cb_zak.DataSource = this.заказBindingSource3;
            this.cb_zak.DisplayMember = "Id_Заказа";
            this.cb_zak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_zak.FormattingEnabled = true;
            this.cb_zak.Location = new System.Drawing.Point(936, 294);
            this.cb_zak.Name = "cb_zak";
            this.cb_zak.Size = new System.Drawing.Size(229, 37);
            this.cb_zak.TabIndex = 109;
            this.cb_zak.ValueMember = "Id_Заказа";
            // 
            // заказBindingSource2
            // 
            this.заказBindingSource2.DataMember = "Заказ";
            this.заказBindingSource2.DataSource = this.tinaDataSet;
            // 
            // tinaDataSetBindingSource
            // 
            this.tinaDataSetBindingSource.DataSource = this.tinaDataSet;
            this.tinaDataSetBindingSource.Position = 0;
            // 
            // tinaaa
            // 
            this.tinaaa.DataSetName = "tinaaa";
            this.tinaaa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinaaaBindingSource
            // 
            this.tinaaaBindingSource.DataSource = this.tinaaa;
            this.tinaaaBindingSource.Position = 0;
            // 
            // заказBindingSource3
            // 
            this.заказBindingSource3.DataMember = "Заказ";
            this.заказBindingSource3.DataSource = this.tinaaaBindingSource;
            // 
            // заказTableAdapter1
            // 
            this.заказTableAdapter1.ClearBeforeFill = true;
            // 
            // F_Quality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.cb_zak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_mark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.bt_add_mark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Square);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Quality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Quality";
            this.Load += new System.EventHandler(this.F_Quality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaaaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_mark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_add_mark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Square;
        private tinaDataSet tinaDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private tinaDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Заказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия_Оператора;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценка_качества;
        private System.Windows.Forms.BindingSource заказBindingSource1;
        private System.Windows.Forms.ComboBox cb_zak;
        private System.Windows.Forms.BindingSource tinaaaBindingSource;
        private tinaaa tinaaa;
        private System.Windows.Forms.BindingSource заказBindingSource2;
        private System.Windows.Forms.BindingSource tinaDataSetBindingSource;
        private System.Windows.Forms.BindingSource заказBindingSource3;
        private tinaaaTableAdapters.ЗаказTableAdapter заказTableAdapter1;
    }
}