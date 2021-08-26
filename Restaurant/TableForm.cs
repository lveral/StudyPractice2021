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
            List<string> NameColumns = new List<string>();
            NameColumns.Add("id");
            NameColumns.Add("Номер стола");
            NameColumns.Add("Количество персон");

            List<string> list = Program.client.Select_tables().ToList<string>();
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < list.Count; i += 3)
            {
                list2.Add(new string[] { list[i], list[i + 1], list[i + 2] });
            }
            dt = Program.ToDataTable(list2, NameColumns);
            dataGridTables.DataSource = dt;

            //////dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[1].ReadOnly = true;
            dataGridTables.Columns[2].ReadOnly = true;
            /////////////////////////////////////////////////////////////
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
            Program.client.Delete_table(id_t);
            ///////////////////////////////////////////////////////////////
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = dataGridTables.SelectedCells[0].RowIndex;
            string id = dataGridTables.Rows[index].Cells[0].Value.ToString();
            string number = dataGridTables.Rows[index].Cells[1].Value.ToString();
            string persons = dataGridTables.Rows[index].Cells[2].Value.ToString();
            new UpdateTablesForm(id, number, persons).ShowDialog();

            TableForm_Load(sender, e);
            /*
            string[] list = new string[dt.Rows.Count * 2];
            for (int i = 0; i < dt.Rows.Count*2; i+=2)
            {
                list[i] = (dt.Rows[i / 2][0].ToString());
                list[i + 1] = (dt.Rows[i / 2][1].ToString());
            }
            Program.client.Update_table(list);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddTablesForm().ShowDialog();
            TableForm_Load(sender, e);
        }
    }
}
