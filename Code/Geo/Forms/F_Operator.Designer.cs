namespace Geo.Forms
{
    partial class F_Operator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Operator));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_change_pay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_id_zak = new System.Windows.Forms.ComboBox();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinaaa = new Geo.tinaaa();
            this.lb_Square = new System.Windows.Forms.Label();
            this.create_graph = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.площадьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.площадьTableAdapter = new Geo.tinaaaTableAdapters.ПлощадьTableAdapter();
            this.профильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.профильTableAdapter = new Geo.tinaaaTableAdapters.ПрофильTableAdapter();
            this.пикетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пикетTableAdapter = new Geo.tinaaaTableAdapters.ПикетTableAdapter();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.заказTableAdapter = new Geo.tinaaaTableAdapters.ЗаказTableAdapter();
            this.Id_Измерения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Зн_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Зн_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.площадьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пикетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Измерения,
            this.Зн_1,
            this.Зн_2});
            this.dataGridView1.Location = new System.Drawing.Point(22, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 336);
            this.dataGridView1.TabIndex = 107;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(944, 506);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(226, 50);
            this.Exit.TabIndex = 104;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_change_pay
            // 
            this.bt_change_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_change_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_change_pay.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_change_pay.Location = new System.Drawing.Point(677, 506);
            this.bt_change_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_change_pay.Name = "bt_change_pay";
            this.bt_change_pay.Size = new System.Drawing.Size(226, 50);
            this.bt_change_pay.TabIndex = 103;
            this.bt_change_pay.Text = "Внести Данные";
            this.bt_change_pay.UseVisualStyleBackColor = true;
            this.bt_change_pay.Click += new System.EventHandler(this.bt_change_pay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(328, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 54);
            this.label5.TabIndex = 102;
            this.label5.Text = "Обработика измерений";
            // 
            // cb_id_zak
            // 
            this.cb_id_zak.DataSource = this.заказBindingSource;
            this.cb_id_zak.DisplayMember = "Id_Заказа";
            this.cb_id_zak.FormattingEnabled = true;
            this.cb_id_zak.Location = new System.Drawing.Point(928, 227);
            this.cb_id_zak.Name = "cb_id_zak";
            this.cb_id_zak.Size = new System.Drawing.Size(229, 24);
            this.cb_id_zak.TabIndex = 109;
            this.cb_id_zak.ValueMember = "Id_Заказа";
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.tinaaa;
            // 
            // tinaaa
            // 
            this.tinaaa.DataSetName = "tinaaa";
            this.tinaaa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Font = new System.Drawing.Font("Candara", 16F);
            this.lb_Square.Location = new System.Drawing.Point(719, 228);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(131, 33);
            this.lb_Square.TabIndex = 108;
            this.lb_Square.Text = "ID_Заказа";
            // 
            // create_graph
            // 
            this.create_graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.create_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_graph.Font = new System.Drawing.Font("Candara", 16F);
            this.create_graph.Location = new System.Drawing.Point(22, 506);
            this.create_graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_graph.Name = "create_graph";
            this.create_graph.Size = new System.Drawing.Size(580, 50);
            this.create_graph.TabIndex = 120;
            this.create_graph.Text = "Построить график";
            this.create_graph.UseVisualStyleBackColor = true;
            this.create_graph.Click += new System.EventHandler(this.create_graph_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(169, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 33);
            this.label7.TabIndex = 121;
            this.label7.Text = "Внесенные значения";
            // 
            // площадьBindingSource
            // 
            this.площадьBindingSource.DataMember = "Площадь";
            this.площадьBindingSource.DataSource = this.tinaaa;
            // 
            // площадьTableAdapter
            // 
            this.площадьTableAdapter.ClearBeforeFill = true;
            // 
            // профильBindingSource
            // 
            this.профильBindingSource.DataMember = "Профиль";
            this.профильBindingSource.DataSource = this.tinaaa;
            // 
            // профильTableAdapter
            // 
            this.профильTableAdapter.ClearBeforeFill = true;
            // 
            // пикетBindingSource
            // 
            this.пикетBindingSource.DataMember = "Пикет";
            this.пикетBindingSource.DataSource = this.tinaaa;
            // 
            // пикетTableAdapter
            // 
            this.пикетTableAdapter.ClearBeforeFill = true;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_2.Location = new System.Drawing.Point(877, 378);
            this.tb_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_2.Multiline = true;
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(79, 32);
            this.tb_2.TabIndex = 125;
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_1.Location = new System.Drawing.Point(877, 329);
            this.tb_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_1.Multiline = true;
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(79, 32);
            this.tb_1.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(724, 378);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 123;
            this.label6.Text = "Значение_2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(726, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 122;
            this.label8.Text = "Значение_1";
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // Id_Измерения
            // 
            this.Id_Измерения.HeaderText = "Id_Измерения";
            this.Id_Измерения.MinimumWidth = 6;
            this.Id_Измерения.Name = "Id_Измерения";
            this.Id_Измерения.Width = 125;
            // 
            // Зн_1
            // 
            this.Зн_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Зн_1.HeaderText = "Зн_1";
            this.Зн_1.MinimumWidth = 6;
            this.Зн_1.Name = "Зн_1";
            this.Зн_1.Width = 67;
            // 
            // Зн_2
            // 
            this.Зн_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Зн_2.HeaderText = "Зн_2";
            this.Зн_2.MinimumWidth = 6;
            this.Зн_2.Name = "Зн_2";
            this.Зн_2.Width = 67;
            // 
            // F_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.create_graph);
            this.Controls.Add(this.cb_id_zak);
            this.Controls.Add(this.lb_Square);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.bt_change_pay);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Operator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Operator";
            this.Load += new System.EventHandler(this.F_Operator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.площадьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пикетBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_change_pay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_id_zak;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.Button create_graph;
        private System.Windows.Forms.Label label7;
        private tinaaa tinaaa;
        private System.Windows.Forms.BindingSource площадьBindingSource;
        private tinaaaTableAdapters.ПлощадьTableAdapter площадьTableAdapter;
        private System.Windows.Forms.BindingSource профильBindingSource;
        private tinaaaTableAdapters.ПрофильTableAdapter профильTableAdapter;
        private System.Windows.Forms.BindingSource пикетBindingSource;
        private tinaaaTableAdapters.ПикетTableAdapter пикетTableAdapter;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private tinaaaTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Измерения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Зн_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Зн_2;
    }
}