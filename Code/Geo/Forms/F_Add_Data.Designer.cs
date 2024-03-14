namespace Geo.Forms
{
    partial class F_Add_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Add_Data));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_pik = new System.Windows.Forms.Button();
            this.bt_plo = new System.Windows.Forms.Button();
            this.bt_prof = new System.Windows.Forms.Button();
            this.tb_pik_x = new System.Windows.Forms.TextBox();
            this.tb_pik_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_plo_y = new System.Windows.Forms.TextBox();
            this.tb_plo_x = new System.Windows.Forms.TextBox();
            this.cb_pik = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_prof = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_prof_y = new System.Windows.Forms.TextBox();
            this.tb_prof_x = new System.Windows.Forms.TextBox();
            this.tinaDataSet = new Geo.tinaDataSet();
            this.пикетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пикетTableAdapter = new Geo.tinaDataSetTableAdapters.ПикетTableAdapter();
            this.площадьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.площадьTableAdapter = new Geo.tinaDataSetTableAdapters.ПлощадьTableAdapter();
            this.Exit = new System.Windows.Forms.Button();
            this.профильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.профильTableAdapter = new Geo.tinaDataSetTableAdapters.ПрофильTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пикетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.площадьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профильBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(314, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 75);
            this.label5.TabIndex = 65;
            this.label5.Text = "ДОБАВИТЬ ДАННЫЕ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(141, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 35);
            this.label4.TabIndex = 95;
            this.label4.Text = "Пикет";
            // 
            // bt_pik
            // 
            this.bt_pik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_pik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pik.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_pik.Location = new System.Drawing.Point(44, 435);
            this.bt_pik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_pik.Name = "bt_pik";
            this.bt_pik.Size = new System.Drawing.Size(317, 50);
            this.bt_pik.TabIndex = 96;
            this.bt_pik.Text = "Добавить пикет";
            this.bt_pik.UseVisualStyleBackColor = true;
            this.bt_pik.Click += new System.EventHandler(this.bt_pik_Click);
            // 
            // bt_plo
            // 
            this.bt_plo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_plo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_plo.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_plo.Location = new System.Drawing.Point(808, 435);
            this.bt_plo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_plo.Name = "bt_plo";
            this.bt_plo.Size = new System.Drawing.Size(317, 50);
            this.bt_plo.TabIndex = 97;
            this.bt_plo.Text = "Добавить площадь";
            this.bt_plo.UseVisualStyleBackColor = true;
            this.bt_plo.Click += new System.EventHandler(this.bt_plo_Click);
            // 
            // bt_prof
            // 
            this.bt_prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prof.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_prof.Location = new System.Drawing.Point(426, 435);
            this.bt_prof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_prof.Name = "bt_prof";
            this.bt_prof.Size = new System.Drawing.Size(317, 50);
            this.bt_prof.TabIndex = 98;
            this.bt_prof.Text = "Добавить профиль";
            this.bt_prof.UseVisualStyleBackColor = true;
            this.bt_prof.Click += new System.EventHandler(this.bt_prof_Click);
            // 
            // tb_pik_x
            // 
            this.tb_pik_x.Location = new System.Drawing.Point(209, 292);
            this.tb_pik_x.Multiline = true;
            this.tb_pik_x.Name = "tb_pik_x";
            this.tb_pik_x.Size = new System.Drawing.Size(121, 22);
            this.tb_pik_x.TabIndex = 99;
            // 
            // tb_pik_y
            // 
            this.tb_pik_y.Location = new System.Drawing.Point(209, 360);
            this.tb_pik_y.Multiline = true;
            this.tb_pik_y.Name = "tb_pik_y";
            this.tb_pik_y.Size = new System.Drawing.Size(121, 22);
            this.tb_pik_y.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(106, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 33);
            this.label1.TabIndex = 101;
            this.label1.Text = "Х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F);
            this.label2.Location = new System.Drawing.Point(106, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 33);
            this.label2.TabIndex = 102;
            this.label2.Text = "У";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F);
            this.label3.Location = new System.Drawing.Point(835, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 33);
            this.label3.TabIndex = 106;
            this.label3.Text = "У";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16F);
            this.label6.Location = new System.Drawing.Point(834, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 33);
            this.label6.TabIndex = 105;
            this.label6.Text = "Х";
            // 
            // tb_plo_y
            // 
            this.tb_plo_y.Location = new System.Drawing.Point(992, 361);
            this.tb_plo_y.Multiline = true;
            this.tb_plo_y.Name = "tb_plo_y";
            this.tb_plo_y.Size = new System.Drawing.Size(121, 22);
            this.tb_plo_y.TabIndex = 104;
            // 
            // tb_plo_x
            // 
            this.tb_plo_x.Location = new System.Drawing.Point(992, 304);
            this.tb_plo_x.Multiline = true;
            this.tb_plo_x.Name = "tb_plo_x";
            this.tb_plo_x.Size = new System.Drawing.Size(121, 22);
            this.tb_plo_x.TabIndex = 103;
            // 
            // cb_pik
            // 
            this.cb_pik.DataSource = this.пикетBindingSource;
            this.cb_pik.DisplayMember = "Id_пикета";
            this.cb_pik.FormattingEnabled = true;
            this.cb_pik.Location = new System.Drawing.Point(592, 245);
            this.cb_pik.Name = "cb_pik";
            this.cb_pik.Size = new System.Drawing.Size(121, 24);
            this.cb_pik.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(439, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 33);
            this.label7.TabIndex = 108;
            this.label7.Text = "ID Пикета";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 16F);
            this.label8.Location = new System.Drawing.Point(802, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 33);
            this.label8.TabIndex = 114;
            this.label8.Text = "ID Профиля";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(899, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 35);
            this.label11.TabIndex = 115;
            this.label11.Text = "Площадь";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(527, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 35);
            this.label12.TabIndex = 116;
            this.label12.Text = "Профиль";
            // 
            // cb_prof
            // 
            this.cb_prof.DataSource = this.профильBindingSource;
            this.cb_prof.DisplayMember = "Id_Профиля";
            this.cb_prof.FormattingEnabled = true;
            this.cb_prof.Location = new System.Drawing.Point(992, 245);
            this.cb_prof.Name = "cb_prof";
            this.cb_prof.Size = new System.Drawing.Size(121, 24);
            this.cb_prof.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 16F);
            this.label10.Location = new System.Drawing.Point(475, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 33);
            this.label10.TabIndex = 120;
            this.label10.Text = "У";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 16F);
            this.label13.Location = new System.Drawing.Point(474, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 33);
            this.label13.TabIndex = 119;
            this.label13.Text = "Х";
            // 
            // tb_prof_y
            // 
            this.tb_prof_y.Location = new System.Drawing.Point(592, 362);
            this.tb_prof_y.Multiline = true;
            this.tb_prof_y.Name = "tb_prof_y";
            this.tb_prof_y.Size = new System.Drawing.Size(121, 22);
            this.tb_prof_y.TabIndex = 118;
            // 
            // tb_prof_x
            // 
            this.tb_prof_x.Location = new System.Drawing.Point(592, 305);
            this.tb_prof_x.Multiline = true;
            this.tb_prof_x.Name = "tb_prof_x";
            this.tb_prof_x.Size = new System.Drawing.Size(121, 22);
            this.tb_prof_x.TabIndex = 117;
            // 
            // tinaDataSet
            // 
            this.tinaDataSet.DataSetName = "tinaDataSet";
            this.tinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пикетBindingSource
            // 
            this.пикетBindingSource.DataMember = "Пикет";
            this.пикетBindingSource.DataSource = this.tinaDataSet;
            // 
            // пикетTableAdapter
            // 
            this.пикетTableAdapter.ClearBeforeFill = true;
            // 
            // площадьBindingSource
            // 
            this.площадьBindingSource.DataMember = "Площадь";
            this.площадьBindingSource.DataSource = this.tinaDataSet;
            // 
            // площадьTableAdapter
            // 
            this.площадьTableAdapter.ClearBeforeFill = true;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(1002, 542);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(157, 50);
            this.Exit.TabIndex = 122;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // профильBindingSource
            // 
            this.профильBindingSource.DataMember = "Профиль";
            this.профильBindingSource.DataSource = this.tinaDataSet;
            // 
            // профильTableAdapter
            // 
            this.профильTableAdapter.ClearBeforeFill = true;
            // 
            // F_Add_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.cb_prof);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_prof_y);
            this.Controls.Add(this.tb_prof_x);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_pik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_plo_y);
            this.Controls.Add(this.tb_plo_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pik_y);
            this.Controls.Add(this.tb_pik_x);
            this.Controls.Add(this.bt_prof);
            this.Controls.Add(this.bt_plo);
            this.Controls.Add(this.bt_pik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Add_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Add_Data";
            this.Load += new System.EventHandler(this.F_Add_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пикетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.площадьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профильBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_pik;
        private System.Windows.Forms.Button bt_plo;
        private System.Windows.Forms.Button bt_prof;
        private System.Windows.Forms.TextBox tb_pik_x;
        private System.Windows.Forms.TextBox tb_pik_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_plo_y;
        private System.Windows.Forms.TextBox tb_plo_x;
        private System.Windows.Forms.ComboBox cb_pik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_prof;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_prof_y;
        private System.Windows.Forms.TextBox tb_prof_x;
        private tinaDataSet tinaDataSet;
        private System.Windows.Forms.BindingSource пикетBindingSource;
        private tinaDataSetTableAdapters.ПикетTableAdapter пикетTableAdapter;
        private System.Windows.Forms.BindingSource площадьBindingSource;
        private tinaDataSetTableAdapters.ПлощадьTableAdapter площадьTableAdapter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.BindingSource профильBindingSource;
        private tinaDataSetTableAdapters.ПрофильTableAdapter профильTableAdapter;
    }
}