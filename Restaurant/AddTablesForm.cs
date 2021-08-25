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
            if (idBox.Text == "" | personsBox.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            else
            {
                Program.client.Add_table(idBox.Text, personsBox.Text);
            }
        }
    }
}
