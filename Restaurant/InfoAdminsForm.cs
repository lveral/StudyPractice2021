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
    public partial class InfoAdminsForm : Form
    {
        DataTable dt;
        public InfoAdminsForm()
        {
            InitializeComponent();
        }

        private void dataGridTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InfoAdminsForm_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////////////////
            List<string> NameColumns = new List<string>();
            NameColumns.Add("id");
            NameColumns.Add("Фамилия");
            NameColumns.Add("Имя");
            NameColumns.Add("Отчетсво");
            NameColumns.Add("Номер телефона");
            NameColumns.Add("Логин");

            List<string> list = Program.client.Select_admins().ToList<string>();
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < list.Count; i += 6)
            {
                list2.Add(new string[] {list[i], list[i + 1], list[i + 2], list[i + 3], list[i + 4], list[i + 5] });
            }
            dt = Program.ToDataTable(list2, NameColumns);
            dataGridTables.DataSource = dt;
            /////////////////////////////////////////////////////////////////////////////////
            dataGridTables.Columns[0].Visible = false;
            dataGridTables.Columns[1].ReadOnly = true;
            dataGridTables.Columns[2].ReadOnly = true;
            dataGridTables.Columns[3].ReadOnly = true;
            dataGridTables.Columns[4].ReadOnly = true;
            dataGridTables.Columns[5].ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Пользователь больше не будет иметь доступ к возможностям администратора.", "Исключение из администраторов", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridTables.SelectedCells[0].RowIndex;
                string id = dataGridTables.Rows[index].Cells[0].Value.ToString();
                dataGridTables.Rows.RemoveAt(index);
                ////////////////////////////////////////////////////
                Program.client.Update_admin(id);
                ////////////////////////////////////////////////////
                if (id == Program.ID)
                {
                    Program.Role = "посетитель";
                    MessageBox.Show("Изменения сохранены. Обновите окно");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
            
            
        }
    }
}
