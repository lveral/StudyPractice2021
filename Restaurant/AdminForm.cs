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
    public partial class AdminForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(143, 89, 63);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(93, 53, 44);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            OpenChildForm(new TableForm(), sender);
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            OpenChildForm(new ReservationAllForm(), sender);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            OpenChildForm(new ReservationForm(), sender);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            OpenChildForm(new AccountForm(), sender);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
            new AuthoForm().ShowDialog();
            Close();
        }
        private void buttonVisitors_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            OpenChildForm(new InfoAdminsForm(), sender);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            if(Program.Role == "посетитель")
            {
                buttonRes.Visible = false;
                buttonTable.Visible = false;
                buttonVisitors.Visible = false;
            }
            if(Program.ID == "")
            {
                Hide();
                new AuthoForm().ShowDialog();
                Close();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new AdminForm().ShowDialog();
            Close();
        }

        
    }
}
