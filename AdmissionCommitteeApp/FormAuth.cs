using System;
using System.Windows.Forms;
using Npgsql;

namespace AdmissionCommitteeApp
{
    public partial class FormAuth : Form
    {
        DataBase db = new DataBase();

        public FormAuth()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
          
            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин.");
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль.");
            }
            else
            {
                int userId = 0;
                int roleId = 0;
                string passwordUser = null;

                db.openConnection();

                NpgsqlCommand checkUser = new NpgsqlCommand(
                    $"SELECT * FROM users WHERE login = '{login}'", db.getConnection());

                NpgsqlDataReader reader = checkUser.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        userId = reader.GetInt32(0);
                        passwordUser = reader.GetString(2);
                        roleId = reader.GetInt32(3);
                    }
                }
                db.closeConnection();

                if (passwordUser != null)
                {
                    if (passwordUser != password)
                    {
                        MessageBox.Show("Не верный пароль.");
                    }

                    if (passwordUser == password)
                    {
                        Form formMain = new FormMain(userId, roleId);
                        this.Hide();
                        formMain.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином не существует.");
                }

            }
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            Form formReg = new FormReg();
            this.Hide();
            formReg.Show();
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
