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
    public partial class F_Quality : Form
    {
        string DB_name = ConnectDB.conn;
        public F_Quality()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                conn.Open();
                string sql = $"select Id_Заказа, Фамилия, Цена, Оценка_качества_работы_оператора from Geo.Заказ as Z " +
                    $"inner join geo.Пользователь as P on Z.Id_Оператора = P.Id_Пользователя";

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();

                }
                reader.Close();
                conn.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_Quality_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaaa.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter1.Fill(this.tinaaa.Заказ);
        }

        private void bt_add_mark_Click(object sender, EventArgs e)
        {
            if (tb_mark.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();

                    string sql = $"select Id_Пользователя from geo.Пользователь where Логин = '{cb_zak.Text}'";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    var id_oper = command.ExecuteScalar();

                    string sql1 = $"update geo.Заказ set Оценка_качества_работы_оператора  = {tb_mark.Text} where Id_Заказа = {cb_zak.Text}";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Оценка поставлена успешно");

                    conn.Close();

                    ActiveForm.Close();
                    F_Quality fcalc = new F_Quality();
                    fcalc.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Введите оценку!");
            }
        }

        private void cb_zak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
