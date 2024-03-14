using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using LiveCharts;
using LiveCharts.WinForms;
using Geo.Classes;
using LiveCharts.Wpf;

namespace Geo.Forms
{
    public partial class F_Graph : Form
    {
        string ID_ZAK;
        string DB_name = ConnectDB.conn;

        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;
        private DataTable table = null;
        public F_Graph(string id_zak)
        {
            InitializeComponent();
            ID_ZAK = id_zak;
        }

        private void F_Graph_Load(object sender, EventArgs e)
        {
            label1.Text = ID_ZAK;
            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                conn.Open();

                dataAdapter = new SqlDataAdapter($"Select *  from Geo.Измерения where Id_Заказа = {ID_ZAK}", conn);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Измерения");
                table = dataSet.Tables["Измерения"];
                cartesianChart1.LegendLocation = LegendLocation.Bottom;
                conn.Close();
            }
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void bt_Graph_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DB_name))
            {
                SeriesCollection series = new SeriesCollection();
                ChartValues<int> speed = new ChartValues<int>();
                List<string> time = new List<string>();

                foreach(DataRow row in table.Rows)
                {
                        speed.Add(Convert.ToInt32(row["Значение_1"]));
                        time.Add(Convert.ToString(row["Id_Измерения"]));
                }

                cartesianChart1.AxisX.Clear();

            
                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = time
                });

                LineSeries line = new LineSeries();
                line.Title = "График";
                line.Values = speed;

                series.Add(line);
                cartesianChart1.Series = series;
                  
            }
        }
    }
}
