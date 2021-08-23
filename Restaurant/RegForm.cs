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
    public partial class RegForm : Form
    {
        
        public RegForm()
        {
            InitializeComponent();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            new AuthoForm().ShowDialog();
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxFirstN.Text == "")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (textBoxMiddleN.Text == "")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Введите логин (email)!");
                return;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Придумайте пароль!");
                return;
            }
            if (textBoxPassword.Text != textBoxPassword2.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            if (textBoxPassAdmin.Text == "0000")
            {
                Program.Role = "администратор";
            } 
            else if (textBoxPassAdmin.Text != "")
            {
                MessageBox.Show("Пароль администратора неверный!");
                return;
            }
            else
            {
                Program.Role = "посетитель";
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SQLClass.Insert_visitor(textBoxLogin.Text, textBoxPassword.Text, textBoxFirstN.Text, 
                textBoxMiddleN.Text, textBoxLastN.Text, textBoxPhone.Text, Program.Role);
            Program.ID = SQLClass.Select_ID(textBoxLogin.Text);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Hide();
            new AdminForm().ShowDialog();
            Close();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
