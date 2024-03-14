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
    public partial class F_Operator : Form
    {
        string DB_name = ConnectDB.conn;
        public F_Operator()
        {
            InitializeComponent();
        }

        private void F_Operator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaaa.Заказ". При необходимости она может быть перемещена или удалена.
           // this.заказTableAdapter.Fill(this.tinaaa.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaaa.Пикет". При необходимости она может быть перемещена или удалена.
           // this.пикетTableAdapter.Fill(this.tinaaa.Пикет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaaa.Профиль". При необходимости она может быть перемещена или удалена.
          //  this.профильTableAdapter.Fill(this.tinaaa.Профиль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaaa.Площадь". При необходимости она может быть перемещена или удалена.
          //  this.площадьTableAdapter.Fill(this.tinaaa.Площадь);
            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                conn.Open();

                string sql1 = $"select * prov";
                    

                SqlCommand command1 = new SqlCommand(sql1, conn);
                SqlDataReader reader = command1.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                   

                }
                reader.Close();
                conn.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void tb_prise_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_change_pay_Click(object sender, EventArgs e)
        {
            if (tb_1.Text != "" && tb_2.Text != ""  )
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();


                    string sql1 = $"Insert into prov values ( '{tb_1.Text}',  '{tb_2.Text}')";

                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные внесены успешно");

                    conn.Close();

                    ActiveForm.Close();
                    F_Operator fcalc = new F_Operator();
                    fcalc.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
        }

        private void create_graph_Click(object sender, EventArgs e)
        {
           F_Charts f_Charts = new F_Charts();
            f_Charts.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
