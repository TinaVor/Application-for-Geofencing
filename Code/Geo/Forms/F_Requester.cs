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
using System.Data.OleDb;

namespace Geo.Forms
{
    public partial class F_Requester : Form
    {
        string DB_name = ConnectDB.conn;
        public int idUser;
        public F_Requester(int id_user)
        {
            idUser = id_user;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                conn.Open();
                string sql = $"select ID_Заказа, Id_Площади, Цена, G.Фамилия from Geo.Заказ as Z " +
                    $"inner join Geo.Пользователь as G on G.Id_Пользователя = Z.Id_Оператора where Z.Id_Заказщика = {idUser}";

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

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

        private void bt_create_Click(object sender, EventArgs e)
        {
            if (tb_prise.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(DB_name))
                {
                    conn.Open();

                    string sql1 = $"select Id_Пользователя from Geo.Пользователь where Фамилия = '{cb_oper.Text}'";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.ExecuteNonQuery();
                    var id_oper = command1.ExecuteScalar();

                
                    string sql = $"INSERT INTO Geo.Заказ VALUES ( '{cb_Square.Text}', '{tb_prise.Text}', '{idUser}','{id_oper}', '0')";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();

                    string sql4 = $" select Id_Заказа from geo.Заказ where Id_Площади = '{cb_Square.Text}' and Цена = '{tb_prise.Text}' and Id_Заказщика = '{idUser}'";
                    SqlCommand command4 = new SqlCommand(sql4, conn);
                    command4.ExecuteNonQuery();
                    var id_zak = command4.ExecuteScalar();

                    string sql3 = $"INSERT INTO Geo.Измерения VALUES ('0','0','0', '0', '0','0','0', '0', '0', '0', '{id_zak}')";
                    SqlCommand command3 = new SqlCommand(sql3, conn);
                    command3.ExecuteNonQuery();


                    MessageBox.Show("Заказ создан успешно");

                    conn.Close();

                    ActiveForm.Close();
                    F_Requester fcalc = new F_Requester(idUser);
                    fcalc.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void F_Requester_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Роль". При необходимости она может быть перемещена или удалена.
            this.рольTableAdapter.Fill(this.tinaDataSet.Роль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.FillBy(this.tinaDataSet.Пользователь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Пикет". При необходимости она может быть перемещена или удалена.
            this.пикетTableAdapter.Fill(this.tinaDataSet.Пикет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Профиль". При необходимости она может быть перемещена или удалена.
            this.профильTableAdapter.Fill(this.tinaDataSet.Профиль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet.Площадь". При необходимости она может быть перемещена или удалена.
            this.площадьTableAdapter.Fill(this.tinaDataSet.Площадь);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            F_Add_Data f_Add_Data = new F_Add_Data();
            f_Add_Data.Closed += (s, args) => this.Close();
            f_Add_Data.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.пользовательTableAdapter.FillBy(this.tinaDataSet.Пользователь);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cb_oper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
