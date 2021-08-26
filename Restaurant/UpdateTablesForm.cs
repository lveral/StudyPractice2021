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
    public partial class UpdateTablesForm : Form
    {
        static string Id;
        static string Number;
        public UpdateTablesForm(string id, string number, string persons)
        {
            Id = id;
            Number = number;
            InitializeComponent();
            numberBox.Text = number;
            personsBox.Text = persons;
            
        }

        private void UpdateTablesForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string check = Program.client.Exist_Table(numberBox.Text);
            if (check != "0" & Number != numberBox.Text)
            {
                MessageBox.Show("Стол с таким номером уже существует");
                return;
            }
            Program.client.Update_table(Id, personsBox.Text, numberBox.Text);
            Close();
        }
    }
}
