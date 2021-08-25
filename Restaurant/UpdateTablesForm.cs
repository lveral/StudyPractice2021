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
        public UpdateTablesForm(string id, string persons)
        {
            Id = id;
            InitializeComponent();
            idBox.Text = id;
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
            Program.client.Update_table(Id, personsBox.Text);
        }
    }
}
