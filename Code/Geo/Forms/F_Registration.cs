using Geo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo.Forms
{
    public partial class F_Registration : Form
    {
        string DB_name = ConnectDB.conn;
        public F_Registration()
        {
            InitializeComponent();
        }

        private bool PrLogin(SqlConnection conn)
        {
            conn.Open();
            SqlCommand Com = new SqlCommand($"select count(*) from Geo.Пользователь where '{tb_login}' = ЛОГИН", conn);
            var value = Com.ExecuteScalar();
            conn.Close();
            if (Convert.ToInt32(value) > 0) return false;
            else return true;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Reg_Click(object sender, EventArgs e)
        {
            if ((tb_Surname.Text == "") || (tb_Name.Text == "") || (tb_ot.Text == "") || (tb_login.Text == "") || (tb_password.Text == "") || (tb_DoublePassword.Text =="") || (cb_rol.Text == ""))
            {
                MessageBox.Show("Введите данные !");
            }

            if (tb_password.Text != tb_DoublePassword.Text)
            {
                MessageBox.Show("Пароль не совпадает");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                
                    if (PrLogin(conn))
                    {
                        conn.Open();

                        string sql = $"Select Id_роли from Geo.Роль where Название = '{cb_rol.Text}'";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        var id_rol = command.ExecuteScalar();

                        string sql1 = $"INSERT INTO Geo.Пользователь VALUES ('{tb_Surname.Text}',  '{tb_Name.Text}', '{tb_ot.Text}', '{tb_login.Text}', '{tb_password.Text}', '{id_rol}', '0')";
                        SqlCommand command1 = new SqlCommand(sql1, conn);
                        command1.ExecuteNonQuery();
                        MessageBox.Show("Регистрация завершена успешно");
                        ActiveForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь уже существует");
                    }
                    conn.Close();
                
            }
        }

        private void F_Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Роль". При необходимости она может быть перемещена или удалена.
            this.рольTableAdapter.Fill(this.tinaDataSet.Роль);

        }
    }
}
