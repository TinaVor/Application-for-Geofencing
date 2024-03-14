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
    public partial class F_Add_Data : Form
    {
        string DB_name = ConnectDB.conn;
        public F_Add_Data()
        {
            InitializeComponent();
        }

        private void F_Add_Data_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Профиль". При необходимости она может быть перемещена или удалена.
            this.профильTableAdapter.Fill(this.tinaDataSet.Профиль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Площадь". При необходимости она может быть перемещена или удалена.
            this.площадьTableAdapter.Fill(this.tinaDataSet.Площадь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Пикет". При необходимости она может быть перемещена или удалена.
            this.пикетTableAdapter.Fill(this.tinaDataSet.Пикет);

        }

        private void bt_pik_Click(object sender, EventArgs e)
        {
            if (tb_pik_x.Text != "" && tb_pik_y.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();

                    string sql1 = $"INSERT INTO Geo.Пикет VALUES ('1', '{tb_pik_x.Text}',  '{tb_pik_y.Text}')";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные внесены успешно");
              
                    conn.Close();
                    ActiveForm.Close();
                    F_Add_Data fcalc = new F_Add_Data();
                    fcalc.ShowDialog();
                }

            } else {
                MessageBox.Show("Введите данные!");
            }
        }

        private void bt_prof_Click(object sender, EventArgs e)
        {
            if (tb_prof_x.Text != "" && tb_prof_y.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();

                    string sql1 = $"INSERT INTO Geo.Профиль VALUES ('{cb_pik.Text}', '{tb_prof_x.Text}',  '{tb_prof_y.Text}')";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные внесены успешно");

                    conn.Close();

                    ActiveForm.Close();
                    F_Add_Data fcalc = new F_Add_Data();
                    fcalc.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void bt_plo_Click(object sender, EventArgs e)
        {
            if (tb_plo_x.Text != "" && tb_plo_y.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();

                    string sql1 = $"INSERT INTO Geo.Площадь VALUES ('{cb_prof.Text}', '{tb_plo_x.Text}',  '{tb_plo_y.Text}')";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные внесены успешно");

                    conn.Close ();

                    ActiveForm.Close();
                    F_Add_Data fcalc = new F_Add_Data();
                    fcalc.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
