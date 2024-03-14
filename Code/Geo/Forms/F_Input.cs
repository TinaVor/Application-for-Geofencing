using Geo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geo.Forms;
using System.Data.SqlClient;

namespace Geo
{
    public partial class Input : Form
    {
        string DB_name = ConnectDB.conn;
        string StrConn = Classes.ConnectDB.conn;

        public Input()
        {
            InitializeComponent();
        }

        private void bt_Input_Click(object sender, EventArgs e)
        {
            if (Login.Text != "" && Password.Text != "")
            {
                
                
                string sql = $"select ID_ПОЛЬЗОВАТЕЛЯ from Geo.Пользователь where ЛОГИН = '{Login.Text}' and ПАРОЛЬ = '{Password.Text}'";
                string sql2 = $"select ID_ПОЛЬЗОВАТЕЛЯ from Geo.Пользователь where ЛОГИН = '{Login.Text}'";
                string sql3 = $"select ЛОГИН from Geo.Пользователь where Логин = '{Login.Text}' and Пароль = '{Password.Text}'";
                string sql4 = $"select ID_РОЛИ from Geo.Пользователь where ЛОГИН = '{Login.Text}' and ПАРОЛЬ = '{Password.Text}'";

                using (SqlConnection conn = new SqlConnection(StrConn))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlCommand command2 = new SqlCommand(sql2, conn);
                    SqlCommand command3 = new SqlCommand(sql3, conn);
                    SqlCommand command4 = new SqlCommand(sql4, conn);
                    var id = command.ExecuteScalar();
                    if (id == null)
                    {
                        MessageBox.Show("Введен неправльный логин/пароль");
                        return;
                    }
                    else
                    {
                        var id_user = (Int32)command2.ExecuteScalar();
                        string name = (string)command3.ExecuteScalar();
                        var post = (Int32)command4.ExecuteScalar();
                        switch (post)
                        {
                            case 1:
                                Hide();
                                F_Requester requester = new F_Requester(id_user);
                                requester.Closed += (s, args) => this.Close();
                                requester.ShowDialog();
                                break;
                            case 2:
                                Hide();
                                F_Operator foperator = new F_Operator();
                                
                                foperator.ShowDialog();
                                break;
                            case 3:
                                Hide();
                                F_Director director = new F_Director();
                                director.Closed += (s, args) => this.Close();
                                director.ShowDialog();
                                break;
                            case 4:
                                Hide();
                                F_Quality quality = new F_Quality();
                                quality.Closed += (s, args) => this.Close();
                                quality.ShowDialog();
                                break;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            F_Registration fcalc = new F_Registration();
            fcalc.ShowDialog();
        }
    }
}
