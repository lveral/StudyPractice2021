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
using Npgsql;

namespace Restaurant
{
    public partial class TableForm : Form
    {
        DataTable dt;
        public TableForm()
        {
            InitializeComponent();

        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////
            dt = SQLClass.Select_tables();
            dataGridTables.DataSource = dt;
            /////////////////////////////////////////////////////////////



            /*
            List<string> select_tables = SQLClass.Select("select * from tables");
            DataTable tables = new DataTable();
            tables.Columns.Add("Номер стола", typeof(int));
            tables.Columns.Add("Количество персон", typeof(int));

            for (int i = 0; i < select_tables.Count; i += 2)
            {
                tables.Rows.Add(select_tables[i], select_tables[i + 1]);
            }

            dataGridTables.DataSource = tables;*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridTables.SelectedCells[0].RowIndex;
            string id_t = dataGridTables.Rows[index].Cells[0].Value.ToString();
            dataGridTables.Rows.RemoveAt(index);
            ///////////////////////////////////////////////////////////////
            SQLClass.Delete_table(id_t);
            ///////////////////////////////////////////////////////////////
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SQLClass.ncb = new NpgsqlCommandBuilder(SQLClass.nda);
            SQLClass.nda.Update(dt);
        }

    }
}
