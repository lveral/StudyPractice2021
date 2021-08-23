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
        public ReservationAllForm()
        {
            InitializeComponent();
        }

        private void ReservationAllForm_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////
            dataGridTables.DataSource = SQLClass.Select_reservation();
            /////////////////////////////////////////////////////////////////////
            dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[4].ReadOnly = true;
            dataGridTables.Columns[5].ReadOnly = true;
            dataGridTables.Columns[6].ReadOnly = true;
            dataGridTables.Columns[7].ReadOnly = true;
            dataGridTables.Columns[8].ReadOnly = true;
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
            dataGridTables.DataSource = SQLClass.Select_reservation(dateFrom, dateTo);
            //////////////////////////////////////////////////////////////////////////////////
            dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[4].ReadOnly = true;
            dataGridTables.Columns[5].ReadOnly = true;
            dataGridTables.Columns[6].ReadOnly = true;
            dataGridTables.Columns[7].ReadOnly = true;
            dataGridTables.Columns[8].ReadOnly = true;

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
            string date = dataGridTables.Rows[index].Cells[2].Value.ToString();
            string time = dataGridTables.Rows[index].Cells[3].Value.ToString();
            ////////////////////////////////////////////////////////////////////////
            SQLClass.Update_reservation(id, id_t, date, time);
            /////////////////////////////////////////////////////////////////////////
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridTables.SelectedCells[0].RowIndex;
            string id = dataGridTables.Rows[index].Cells[0].Value.ToString();
            dataGridTables.Rows.RemoveAt(index);
            ////////////////////////////////////////////////////
            SQLClass.Delete_reservation(id);
            ////////////////////////////////////////////////////
        }
    }
    
}
