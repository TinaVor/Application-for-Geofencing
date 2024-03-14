using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo.Forms
{
    public partial class F_Charts : Form
    {
        public F_Charts()
        {
            InitializeComponent();
        }

       
        

        private void F_Charts_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tinaDataSet1.prov". При необходимости она может быть перемещена или удалена.
            this.provTableAdapter2.Fill(this.tinaDataSet1.prov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "datachart.prov". При необходимости она может быть перемещена или удалена.
            //this.provTableAdapter1.Fill(this.datachart.prov);

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
