using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AddTablesForm : Form
    {
        public AddTablesForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (numberBox.Text == "" | personsBox.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            string check = Program.client.Exist_Table(numberBox.Text);
            if (check != "0")
            {
                MessageBox.Show("Стол с таким номером уже существует");
                return;
            }
            else
            {
                Program.client.Add_table(numberBox.Text, personsBox.Text);
                Close();
            }
        }

        private void AddTablesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
