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
    public partial class AuthoForm : Form
    {
        public AuthoForm()
        {
            InitializeComponent();
        }

        private void AuthoFor2_Load(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string existUser = SQLClass.Exist_User(login);
            string existUserWithPass = SQLClass.Exist_UserWithPass(login, password);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            if (existUser == "0")
            {
                MessageBox.Show("Вы не зарегистрированы!");
                return;
            }
            else if (existUserWithPass == "0")
            {
                MessageBox.Show("Неверный пароль!");
                return;
            }
            else
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Program.ID = SQLClass.Select_ID(login);
                Program.Role = SQLClass.Select_Role(login);
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Hide();
                new AdminForm().ShowDialog();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Hide();
            new RegForm().ShowDialog();
            Close();
        }
    }
}
