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
        static string Id_t;
        public UpdateReservationForm(string id, string id_t, string number, string date, string time,string f_name,string m_name,string l_name,string phone,string login)
        {
            InitializeComponent();
            Id = id;
            Id_t = id_t;
            numberBox.Text = number;
            dateTimePicker.Text= date.Substring(0, 10);
            timeBox.Text = time.Substring(0,5);
            fnameBox.Text = f_name;
            mnameBox.Text = m_name;
            lnameBox.Text = l_name;
            phoneBox.Text = phone;
            loginBox.Text = login;

            List<string> numbers = Program.client.Select_number_tables().ToList<string>();
            numberBox.Items.AddRange(numbers.ToArray());


            List<string> timeB = new List<string>();
            for (int i = 10; i < 22; i++)
            {
                timeB.Add(i.ToString() + ":00");
            }
            timeBox.Items.AddRange(timeB.ToArray());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Id_t = Program.client.Select_ID_table(numberBox.Text);
            string check = Program.client.Select_reserved_tables(Id_t, dateTimePicker.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(timeBox.Text.Substring(0,2)));
            if (check != "0")
            {
                MessageBox.Show("Сохранение изменений невозможно! Стол на это время занят");
                return;
            }
            Program.client.Update_reservation(Id, Id_t, dateTimePicker.Value.ToString("yyyy-MM-dd"), timeBox.Text);
            Close();
        }

        private void UpdateReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
