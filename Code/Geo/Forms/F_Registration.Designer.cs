namespace Geo.Forms
{
    partial class F_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Registration));
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_Reg = new System.Windows.Forms.Button();
            this.tb_ot = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_DoublePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tinaDataSet = new Geo.tinaDataSet();
            this.рольBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рольTableAdapter = new Geo.tinaDataSetTableAdapters.РольTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рольBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(345, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 75);
            this.label5.TabIndex = 64;
            this.label5.Text = "РЕГИСТРАЦИЯ";
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Surname.Location = new System.Drawing.Point(600, 111);
            this.tb_Surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Surname.Multiline = true;
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(229, 32);
            this.tb_Surname.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(273, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 33);
            this.label7.TabIndex = 61;
            this.label7.Text = "Фамилия";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(1011, 542);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 50);
            this.Exit.TabIndex = 57;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_Reg
            // 
            this.bt_Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reg.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_Reg.Location = new System.Drawing.Point(279, 523);
            this.bt_Reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Reg.Name = "bt_Reg";
            this.bt_Reg.Size = new System.Drawing.Size(555, 50);
            this.bt_Reg.TabIndex = 55;
            this.bt_Reg.Text = "Зарегистрироваться";
            this.bt_Reg.UseVisualStyleBackColor = true;
            this.bt_Reg.Click += new System.EventHandler(this.bt_Reg_Click);
            // 
            // tb_ot
            // 
            this.tb_ot.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ot.Location = new System.Drawing.Point(600, 212);
            this.tb_ot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ot.Multiline = true;
            this.tb_ot.Name = "tb_ot";
            this.tb_ot.Size = new System.Drawing.Size(229, 32);
            this.tb_ot.TabIndex = 54;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Name.Location = new System.Drawing.Point(600, 163);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(229, 32);
            this.tb_Name.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F);
            this.label2.Location = new System.Drawing.Point(271, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 48;
            this.label2.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(273, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 47;
            this.label1.Text = "Имя";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(600, 326);
            this.tb_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(229, 32);
            this.tb_login.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 16F);
            this.label8.Location = new System.Drawing.Point(271, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 33);
            this.label8.TabIndex = 67;
            this.label8.Text = "Логин";
            // 
            // cb_rol
            // 
            this.cb_rol.DataSource = this.рольBindingSource;
            this.cb_rol.DisplayMember = "Название";
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(600, 269);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(229, 24);
            this.cb_rol.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16F);
            this.label6.Location = new System.Drawing.Point(273, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 33);
            this.label6.TabIndex = 69;
            this.label6.Text = "Роль";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(600, 379);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(229, 32);
            this.tb_password.TabIndex = 74;
            // 
            // tb_DoublePassword
            // 
            this.tb_DoublePassword.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_DoublePassword.Location = new System.Drawing.Point(600, 438);
            this.tb_DoublePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_DoublePassword.Multiline = true;
            this.tb_DoublePassword.Name = "tb_DoublePassword";
            this.tb_DoublePassword.PasswordChar = '*';
            this.tb_DoublePassword.Size = new System.Drawing.Size(229, 32);
            this.tb_DoublePassword.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16F);
            this.label4.Location = new System.Drawing.Point(269, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 73;
            this.label4.Text = "Повторите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F);
            this.label3.Location = new System.Drawing.Point(271, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 71;
            this.label3.Text = "Пароль";
            // 
            // tinaDataSet
            // 
            this.tinaDataSet.DataSetName = "tinaDataSet";
            this.tinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // F_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_DoublePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_rol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.bt_Reg);
            this.Controls.Add(this.tb_ot);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Registration";
            this.Load += new System.EventHandler(this.F_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рольBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_Reg;
        private System.Windows.Forms.TextBox tb_ot;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_DoublePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private tinaDataSet tinaDataSet;
        private System.Windows.Forms.BindingSource рольBindingSource;
        private tinaDataSetTableAdapters.РольTableAdapter рольTableAdapter;
    }
}