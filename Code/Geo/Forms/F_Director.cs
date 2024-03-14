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
    public partial class F_Director : Form
    {
        string DB_name = ConnectDB.conn;
        public F_Director()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_Director_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.FillBy1(this.tinaDataSet.Пользователь);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.пользовательTableAdapter.FillBy1(this.tinaDataSet.Пользователь);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bt_show_order_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                conn.Open();

                string sql = $"select Id_Пользователя from geo.Пользователь where Логин = '{cb_login.Text}'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                var id_oper = command.ExecuteScalar();


                string sql1 = $"select Id_Заказа, Цена, Оценка_качества_работы_оператора, Зарплата from geo.Заказ as Z " +
                    $"inner join geo.Пользователь as P on Z.Id_Оператора = P.Id_Пользователя where Z.Id_Оператора = {id_oper}";
                SqlCommand command1 = new SqlCommand(sql1, conn);
                SqlDataReader reader = command1.ExecuteReader();

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

        private void bt_change_pay_Click(object sender, EventArgs e)
        {
            if (tb_pay.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();

                    string sql = $"select Id_Пользователя from geo.Пользователь where Логин = '{cb_login.Text}'";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    var id_oper = command.ExecuteScalar();

                    string sql1 = $"update geo.Пользователь set Зарплата = {tb_pay.Text} where Id_Пользователя = {id_oper}";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Зарплата обновлена успешно");

                    conn.Close();

                    ActiveForm.Close();
                    F_Director fcalc = new F_Director();
                    fcalc.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Введите зарплату!");
            }
        }
    }
}
