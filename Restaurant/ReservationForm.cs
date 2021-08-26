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
    public partial class ReservationForm : Form
    {
        string TableId;
        string Date;
        string Time;
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            List<string> time = new List<string>();
            for (int i = 10; i < 22; i++)
            {
                time.Add(i.ToString() + ":00");
            }
            timeBox.Items.AddRange(time.ToArray());
        }

        private void chButton_Click(object sender, EventArgs e)
        {
            if (timeBox.Text == "")
            {
                MessageBox.Show("Выберите время!");
                return;
            }
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            int day = Convert.ToInt32(datePicker.Value.ToString("dd"));
            int month = Convert.ToInt32(datePicker.Value.ToString("MM"));
            int time = Convert.ToInt32(timeBox.Text.Substring(0, 2));

            string curDate = DateTime.Now.ToString("yyyy-MM-dd");
            int curMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int curDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            string curTime = DateTime.Now.ToString("t");

            if (time <= Convert.ToInt32(curTime.Substring(0, 2)) & 
                (curDate == date | month < curMonth ) |
                (month == curMonth & day < curDay))
            {
                MessageBox.Show("Бронирование недоступно! \r\nВыберите другое время или другую дату");
                return;
            }
            //////////////////////////////////////////////////////////////////////////
            List<string> free_tables = Program.client.Select_free_tables(date, time).ToList<string>();
            ////////////////////////////////////////////////////////////////////////
            int x = 40;
            int y = 10;
            TablesPanel.Controls.Clear();
            for (int i = 0; i < free_tables.Count; i += 3)
            {
                Button lbl = new Button();
                lbl.Text =
                    "Стол № " + free_tables[i + 1] + Environment.NewLine +
                    "Количество мест: " + free_tables[i + 2];
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(200, 80);
                lbl.Tag = free_tables[i];
                TablesPanel.Controls.Add(lbl);

                x += 250;
                if (x + 200 > Width)
                {
                    x = 40;
                    y += 100;
                }

                lbl.Click += new EventHandler(TableClick);
            }

        }
        private void TableClick(object sender, EventArgs e)
        {   
            Button table = (Button)sender;
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timeBox.Text;

            TableId = table.Tag.ToString();
            Date = date;
            Time = time;

            int x = 10;
            int y = 10;

            /*
            Label lbl = new Label();
            lbl.Text =
                    "Заказать стол № " + TableId + Environment.NewLine +
                    "Дата: " + date +
                    "Время: " + time;
            lbl.Location = new Point(x, y);
            lbl.Size = new Size(200, 100);
            panelOrder.Controls.Add(lbl);
            */


            Button btn = new Button();
            btn.Location = new Point(250, 8);
            btn.Size = new Size(290, 45);
            btn.Text = "Забронировать";
            btn.BackColor = Color.FromArgb(11, 21, 97);
            btn.ForeColor = Color.FromArgb(255, 255, 255);
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelOrder.Controls.Add(btn);
            btn.Click += new EventHandler(MakeOrder);

        }
        void MakeOrder(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            Program.client.Insert_reservation(TableId, Date, Time, Program.ID);
            /////////////////////////////////////////////////////////////
            panelOrder.Controls.Clear();
            MessageBox.Show("Забронировано!");
        }
    }
}
