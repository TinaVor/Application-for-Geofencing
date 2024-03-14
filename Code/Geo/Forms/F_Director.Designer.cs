namespace Geo.Forms
{
    partial class F_Director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Director));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_pay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_change_pay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_login = new System.Windows.Forms.ComboBox();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinaDataSet = new Geo.tinaDataSet();
            this.lb_Square = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_show_order = new System.Windows.Forms.Button();
            this.пользовательTableAdapter = new Geo.tinaDataSetTableAdapters.ПользовательTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ID_заказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Зарплата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_заказа,
            this.Цена,
            this.Оценка,
            this.Зарплата});
            this.dataGridView1.Location = new System.Drawing.Point(23, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 336);
            this.dataGridView1.TabIndex = 98;
            // 
            // tb_pay
            // 
            this.tb_pay.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pay.Location = new System.Drawing.Point(929, 361);
            this.tb_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pay.Multiline = true;
            this.tb_pay.Name = "tb_pay";
            this.tb_pay.Size = new System.Drawing.Size(229, 39);
            this.tb_pay.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16F);
            this.label4.Location = new System.Drawing.Point(650, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 33);
            this.label4.TabIndex = 94;
            this.label4.Text = "Новая Зарплата";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(1013, 542);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(157, 50);
            this.Exit.TabIndex = 89;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_change_pay
            // 
            this.bt_change_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_change_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_change_pay.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_change_pay.Location = new System.Drawing.Point(903, 425);
            this.bt_change_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_change_pay.Name = "bt_change_pay";
            this.bt_change_pay.Size = new System.Drawing.Size(267, 97);
            this.bt_change_pay.TabIndex = 88;
            this.bt_change_pay.Text = "Изменить Зарплату";
            this.bt_change_pay.UseVisualStyleBackColor = true;
            this.bt_change_pay.Click += new System.EventHandler(this.bt_change_pay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(288, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(621, 75);
            this.label5.TabIndex = 87;
            this.label5.Text = "ЗАКАЗЫ И ЗАРПЛАТЫ";
            // 
            // cb_login
            // 
            this.cb_login.DataSource = this.пользовательBindingSource;
            this.cb_login.DisplayMember = "Логин";
            this.cb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_login.FormattingEnabled = true;
            this.cb_login.Location = new System.Drawing.Point(929, 295);
            this.cb_login.Name = "cb_login";
            this.cb_login.Size = new System.Drawing.Size(229, 39);
            this.cb_login.TabIndex = 86;
            this.cb_login.ValueMember = "Логин";
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.tinaDataSet;
            // 
            // tinaDataSet
            // 
            this.tinaDataSet.DataSetName = "tinaDataSet";
            this.tinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Font = new System.Drawing.Font("Candara", 16F);
            this.lb_Square.Location = new System.Drawing.Point(650, 298);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(215, 33);
            this.lb_Square.TabIndex = 85;
            this.lb_Square.Text = "Логин Работника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(117, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 99;
            this.label1.Text = "Данные о заказах работника";
            // 
            // bt_show_order
            // 
            this.bt_show_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_show_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_show_order.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_show_order.Location = new System.Drawing.Point(649, 425);
            this.bt_show_order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_show_order.Name = "bt_show_order";
            this.bt_show_order.Size = new System.Drawing.Size(237, 97);
            this.bt_show_order.TabIndex = 100;
            this.bt_show_order.Text = "Показать Заказы";
            this.bt_show_order.UseVisualStyleBackColor = true;
            this.bt_show_order.Click += new System.EventHandler(this.bt_show_order_Click);
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1190, 25);
            this.fillBy1ToolStrip.TabIndex = 101;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // ID_заказа
            // 
            this.ID_заказа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_заказа.HeaderText = "ID_заказа";
            this.ID_заказа.MinimumWidth = 6;
            this.ID_заказа.Name = "ID_заказа";
            this.ID_заказа.Width = 103;
            // 
            // Цена
            // 
            this.Цена.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 6;
            this.Цена.Name = "Цена";
            this.Цена.Width = 69;
            // 
            // Оценка
            // 
            this.Оценка.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Оценка.HeaderText = "Оценка";
            this.Оценка.MinimumWidth = 6;
            this.Оценка.Name = "Оценка";
            this.Оценка.Width = 85;
            // 
            // Зарплата
            // 
            this.Зарплата.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Зарплата.HeaderText = "Зарплата";
            this.Зарплата.MinimumWidth = 6;
            this.Зарплата.Name = "Зарплата";
            // 
            // F_Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 612);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.bt_show_order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_pay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.bt_change_pay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_login);
            this.Controls.Add(this.lb_Square);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Director";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Director";
            this.Load += new System.EventHandler(this.F_Director_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_pay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_change_pay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_login;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_show_order;
        private tinaDataSet tinaDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private tinaDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_заказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Зарплата;
    }
}