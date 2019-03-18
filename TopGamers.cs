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

namespace KingsAdventure
{
    public partial class TopGamers : Form
    {
        SqlConnection connection;
        public TopGamers()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = DATIX2\ALEKSANDERSQL; database=KingAdventure; Trusted_Connection=Yes");
        }

        private void buttonShowTopGamers_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Creature", connection);
            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridViewTopGamers.DataSource = table;
        }

        private void dataGridViewTopGamers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
