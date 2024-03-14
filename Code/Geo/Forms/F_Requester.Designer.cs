namespace Geo.Forms
{
    partial class F_Requester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Requester));
            this.cb_Square = new System.Windows.Forms.ComboBox();
            this.площадьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinaDataSet = new Geo.tinaDataSet();
            this.lb_Square = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.пикетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.профильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_prise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Заказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Площади = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оператор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.площадьTableAdapter = new Geo.tinaDataSetTableAdapters.ПлощадьTableAdapter();
            this.профильTableAdapter = new Geo.tinaDataSetTableAdapters.ПрофильTableAdapter();
            this.пикетTableAdapter = new Geo.tinaDataSetTableAdapters.ПикетTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_oper = new System.Windows.Forms.ComboBox();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new Geo.tinaDataSetTableAdapters.ПользовательTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.рольBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рольTableAdapter = new Geo.tinaDataSetTableAdapters.РольTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.площадьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пикетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рольBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Square
            // 
            this.cb_Square.DataSource = this.площадьBindingSource;
            this.cb_Square.DisplayMember = "Id_Площади";
            this.cb_Square.FormattingEnabled = true;
            this.cb_Square.Location = new System.Drawing.Point(941, 224);
            this.cb_Square.Name = "cb_Square";
            this.cb_Square.Size = new System.Drawing.Size(229, 24);
            this.cb_Square.TabIndex = 72;
            // 
            // площадьBindingSource
            // 
            this.площадьBindingSource.DataMember = "Площадь";
            this.площадьBindingSource.DataSource = this.tinaDataSet;
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
            this.lb_Square.Location = new System.Drawing.Point(695, 228);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(123, 33);
            this.lb_Square.TabIndex = 71;
            this.lb_Square.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(378, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 75);
            this.label5.TabIndex = 73;
            this.label5.Text = "ВАШИ ЗАКАЗЫ";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(1025, 544);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(145, 48);
            this.Exit.TabIndex = 75;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_create
            // 
            this.bt_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_create.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_create.Location = new System.Drawing.Point(678, 407);
            this.bt_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(234, 83);
            this.bt_create.TabIndex = 74;
            this.bt_create.Text = "Создать заказ";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // пикетBindingSource
            // 
            this.пикетBindingSource.DataMember = "Пикет";
            this.пикетBindingSource.DataSource = this.tinaDataSetBindingSource;
            // 
            // tinaDataSetBindingSource
            // 
            this.tinaDataSetBindingSource.DataSource = this.tinaDataSet;
            this.tinaDataSetBindingSource.Position = 0;
            // 
            // профильBindingSource
            // 
            this.профильBindingSource.DataMember = "Профиль";
            this.профильBindingSource.DataSource = this.tinaDataSet;
            // 
            // tb_prise
            // 
            this.tb_prise.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_prise.Location = new System.Drawing.Point(941, 343);
            this.tb_prise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_prise.Multiline = true;
            this.tb_prise.Name = "tb_prise";
            this.tb_prise.Size = new System.Drawing.Size(229, 32);
            this.tb_prise.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F);
            this.label3.Location = new System.Drawing.Point(695, 343);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 81;
            this.label3.Text = "Цена";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Заказа,
            this.ID_Площади,
            this.Цена,
            this.Оператор});
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 417);
            this.dataGridView1.TabIndex = 84;
            // 
            // ID_Заказа
            // 
            this.ID_Заказа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Заказа.HeaderText = "ID_Заказа";
            this.ID_Заказа.MinimumWidth = 6;
            this.ID_Заказа.Name = "ID_Заказа";
            this.ID_Заказа.Width = 104;
            // 
            // ID_Площади
            // 
            this.ID_Площади.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Площади.HeaderText = "ID_Площади";
            this.ID_Площади.MinimumWidth = 6;
            this.ID_Площади.Name = "ID_Площади";
            this.ID_Площади.Width = 115;
            // 
            // Цена
            // 
            this.Цена.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 6;
            this.Цена.Name = "Цена";
            this.Цена.Width = 69;
            // 
            // Оператор
            // 
            this.Оператор.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Оператор.HeaderText = "Оператор";
            this.Оператор.MinimumWidth = 6;
            this.Оператор.Name = "Оператор";
            this.Оператор.Width = 101;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 16F);
            this.button1.Location = new System.Drawing.Point(936, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 83);
            this.button1.TabIndex = 85;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // площадьTableAdapter
            // 
            this.площадьTableAdapter.ClearBeforeFill = true;
            // 
            // профильTableAdapter
            // 
            this.профильTableAdapter.ClearBeforeFill = true;
            // 
            // пикетTableAdapter
            // 
            this.пикетTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16F);
            this.label6.Location = new System.Drawing.Point(695, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 86;
            this.label6.Text = "Оператор";
            // 
            // cb_oper
            // 
            this.cb_oper.DataSource = this.пользовательBindingSource;
            this.cb_oper.DisplayMember = "Фамилия";
            this.cb_oper.FormattingEnabled = true;
            this.cb_oper.Location = new System.Drawing.Point(941, 297);
            this.cb_oper.Name = "cb_oper";
            this.cb_oper.Size = new System.Drawing.Size(229, 24);
            this.cb_oper.TabIndex = 87;
            this.cb_oper.ValueMember = "Id_Пользователя";
            this.cb_oper.SelectedIndexChanged += new System.EventHandler(this.cb_oper_SelectedIndexChanged);
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.tinaDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1190, 25);
            this.fillByToolStrip.TabIndex = 88;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByToolStrip_ItemClicked);
            // 
            // рольBindingSource
            // 
            this.рольBindingSource.DataMember = "Роль";
            this.рольBindingSource.DataSource = this.tinaDataSet;
            // 
            // рольTableAdapter
            // 
            this.рольTableAdapter.ClearBeforeFill = true;
            // 
            // F_Requester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 612);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cb_oper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_prise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Square);
            this.Controls.Add(this.lb_Square);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Requester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Requester";
            this.Load += new System.EventHandler(this.F_Requester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.площадьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пикетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рольBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Square;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.TextBox tb_prise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private tinaDataSet tinaDataSet;
        private System.Windows.Forms.BindingSource площадьBindingSource;
        private tinaDataSetTableAdapters.ПлощадьTableAdapter площадьTableAdapter;
        private System.Windows.Forms.BindingSource профильBindingSource;
        private tinaDataSetTableAdapters.ПрофильTableAdapter профильTableAdapter;
        private System.Windows.Forms.BindingSource tinaDataSetBindingSource;
        private System.Windows.Forms.BindingSource пикетBindingSource;
        private tinaDataSetTableAdapters.ПикетTableAdapter пикетTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_oper;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private tinaDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.BindingSource рольBindingSource;
        private tinaDataSetTableAdapters.РольTableAdapter рольTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Заказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Площади;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оператор;
    }
}