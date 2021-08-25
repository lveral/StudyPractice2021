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
    public partial class UpdateReservationForm : Form
    {
        static string Id;
        public UpdateReservationForm(string id, string id_t, string date, string time,string f_name,string m_name,string l_name,string phone,string login)
        {
            InitializeComponent();
            Id = id;
            idtBox.Text = id_t;
            dateBox.Text = date.Substring(0, 10);
            timeBox.Text = time;
            fnameBox.Text = f_name;
            mnameBox.Text = m_name;
            lnameBox.Text = l_name;
            phoneBox.Text = phone;
            loginBox.Text = login;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.client.Update_reservation(Id, idtBox.Text, dateBox.Text, timeBox.Text);
            Close();
        }

        private void UpdateReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
