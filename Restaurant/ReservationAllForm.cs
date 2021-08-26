using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Restaurant
{
    public partial class ReservationAllForm : Form
    {
        NpgsqlCommandBuilder ncb;
        DataTable dt;
        public ReservationAllForm()
        {
            InitializeComponent();
        }

        private void ReservationAllForm_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////
            List<string> NameColumns = new List<string>();
            NameColumns.Add("id");
            NameColumns.Add("id_t");
            NameColumns.Add("Номер стола");
            NameColumns.Add("Дата");
            NameColumns.Add("Время");
            NameColumns.Add("Фамилия");
            NameColumns.Add("Имя");
            NameColumns.Add("Отчетсво");
            NameColumns.Add("Номер телефона");
            NameColumns.Add("Логин");

            List<string> list = Program.client.Select_reservation("", "").ToList<string>();
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < list.Count; i += 10)
            {
                list2.Add(new string[] { list[i], list[i + 1], list[i + 2], list[i + 3], list[i + 4], 
                    list[i + 5], list[i + 6], list[i + 7], list[i + 8], list[i + 9]  });
            }
            dt = Program.ToDataTable(list2, NameColumns);
            dataGridTables.DataSource = dt;
            /////////////////////////////////////////////////////////////////////
            dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[1].Visible = false;
            dataGridTables.Columns[2].ReadOnly = true;
            dataGridTables.Columns[3].ReadOnly = true;
            dataGridTables.Columns[4].ReadOnly = true;
            dataGridTables.Columns[5].ReadOnly = true;
            dataGridTables.Columns[6].ReadOnly = true;
            dataGridTables.Columns[7].ReadOnly = true;
            dataGridTables.Columns[8].ReadOnly = true;
            dataGridTables.Columns[9].ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string dateFrom = datePickerFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = datePickerTo.Value.ToString("yyyy-MM-dd");
            ////////////////////////////////////////////////////////////////////////////////////
            List<string> NameColumns = new List<string>();
            NameColumns.Add("id");
            NameColumns.Add("id_t");
            NameColumns.Add("Номер стола");
            NameColumns.Add("Дата");
            NameColumns.Add("Время");
            NameColumns.Add("Фамилия");
            NameColumns.Add("Имя");
            NameColumns.Add("Отчетсво");
            NameColumns.Add("Номер телефона");
            NameColumns.Add("Логин");

            List<string> list = Program.client.Select_reservation(dateFrom, dateTo).ToList<string>();
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < list.Count; i += 10)
            {
                list2.Add(new string[] { list[i], list[i + 1], list[i + 2], list[i + 3], list[i + 4],
                    list[i + 5], list[i + 6], list[i + 7], list[i + 8], list[i + 9] });
            }
            dt = Program.ToDataTable(list2, NameColumns);
            dataGridTables.DataSource = dt;
            //////////////////////////////////////////////////////////////////////////////////
            dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[1].Visible = false;
            dataGridTables.Columns[2].ReadOnly = true;
            dataGridTables.Columns[3].ReadOnly = true;
            dataGridTables.Columns[4].ReadOnly = true;
            dataGridTables.Columns[5].ReadOnly = true;
            dataGridTables.Columns[6].ReadOnly = true;
            dataGridTables.Columns[7].ReadOnly = true;
            dataGridTables.Columns[8].ReadOnly = true;
            dataGridTables.Columns[9].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationAllForm_Load(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = dataGridTables.SelectedCells[0].RowIndex;

            string id = dataGridTables.Rows[index].Cells[0].Value.ToString();
            string id_t = dataGridTables.Rows[index].Cells[1].Value.ToString();
            string number = dataGridTables.Rows[index].Cells[2].Value.ToString();
            string date = dataGridTables.Rows[index].Cells[3].Value.ToString();
            string time = dataGridTables.Rows[index].Cells[4].Value.ToString();
            string f_name = dataGridTables.Rows[index].Cells[5].Value.ToString();
            string m_name = dataGridTables.Rows[index].Cells[6].Value.ToString();
            string l_name = dataGridTables.Rows[index].Cells[7].Value.ToString();
            string phone = dataGridTables.Rows[index].Cells[8].Value.ToString();
            string login = dataGridTables.Rows[index].Cells[9].Value.ToString();

            new UpdateReservationForm(id, id_t, number, date, time, f_name, m_name, l_name, phone, login).ShowDialog();
            ReservationAllForm_Load(sender, e);
            ////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridTables.SelectedCells[0].RowIndex;
            string id = dataGridTables.Rows[index].Cells[0].Value.ToString();
            dataGridTables.Rows.RemoveAt(index);
            ////////////////////////////////////////////////////
            Program.client.Delete_reservation(id);
            ////////////////////////////////////////////////////
        }
    }
    
}
