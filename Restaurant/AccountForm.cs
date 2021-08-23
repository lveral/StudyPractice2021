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
    public partial class AccountForm : Form
    {
        string Password;
        public AccountForm()
        {
            InitializeComponent();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool ch = false;
            if (textBoxOldPass.Text != "" & textBoxOldPass.Text != Password)
            {
                MessageBox.Show("Пароль неверный!");
                return;
            }
            if (textBoxNewPass.Text != textBoxNewPass2.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            if (textBoxNewPass.Text != "")
            {
                Password = textBoxNewPass.Text;
            }

            if (textBoxPassAdmin.Text == "0000")
            {
                Program.Role = "администратор";
                ch = true;
            }
            else if (textBoxPassAdmin.Text != "")
            {
                MessageBox.Show("Пароль администратора неверный!");
                return;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SQLClass.Update_visitor(textBoxLogin.Text, Password, textBoxFirstN.Text, textBoxMiddleN.Text, textBoxLastN.Text, textBoxPhone.Text);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ch)
            {
                MessageBox.Show("Изменения сохранены. Обновите окно");
            }
            else
            {
                MessageBox.Show("Изменения сохранены.");
            }
            
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////
            List<string> visitor = SQLClass.Select_visitor();
            ////////////////////////////////////////////////////////////////////////////////////////////
            textBoxLogin.Text = visitor[0];
            Password = visitor[1];
            textBoxFirstN.Text = visitor[2];
            textBoxMiddleN.Text = visitor[3];
            textBoxLastN.Text = visitor[4];
            textBoxPhone.Text = visitor[5];
            Program.Role = visitor[6];
            if (Program.Role == "администратор")
            {
                label10.Visible = false;
                label8.Visible = false;
                textBoxPassAdmin.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить аккаунт?", "Удаление аккаунта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ////////////////////////////////////////////////////////////////////////////////////////////
                SQLClass.Delete_visitor();
                ////////////////////////////////////////////////////////////////////////////////////////////
                Program.ID = "";
                MessageBox.Show("Аккаунт удален. Обновите окно");
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
        }
    }
}
