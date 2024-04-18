using System;
using System.Windows.Forms;
using Npgsql;

namespace AdmissionCommitteeApp
{
    public partial class FormReg : Form
    {
        DataBase db = new DataBase();
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string patronymic = textBoxPatronymic.Text;
            string passport = textBoxPassport.Text;
            string snils = textBoxSnils.Text;
            string telephone = textBoxTelephone.Text;
            string educationalInstitution = textBoxEducationalInstitution.Text;
            string nameRepresentative = textBoxNameRepresentative.Text;
            string surnameRepresentative = textBoxSurnameRepresentative.Text;
            string patronymicRepresentative = textBoxPatronymicRepresentative.Text;
            string mail = textBoxMail.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Заполните поле Имя.");

                return;
            }
            if (String.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Заполните поле Фамилия.");

                return;
            }
            if (String.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Заполните поле Отчество.");

                return;
            }
            if (passport.Length != 11)
            {
                MessageBox.Show("Заполните поле Паспорт.");

                return;
            }
            if (snils.Length != 14)
            {
                MessageBox.Show("Заполните поле СНИЛС.");

                return;
            }
            if (telephone.Length != 18)
            {
                MessageBox.Show("Заполните поле Телефон.");

                return;
            }
            if (String.IsNullOrEmpty(educationalInstitution))
            {
                MessageBox.Show("Заполните поле Оконченое образовательное заведение.");

                return;
            }
            if (String.IsNullOrEmpty(nameRepresentative))
            {
                MessageBox.Show("Заполните поле Имя представителя.");

                return;
            }
            if (String.IsNullOrEmpty(surnameRepresentative))
            {
                MessageBox.Show("Заполните поле Фамилия представителя.");

                return;
            }
            if (String.IsNullOrEmpty(patronymicRepresentative))
            {
                MessageBox.Show("Заполните поле Отчество представителя.");

                return;
            }
            if (String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Заполните поле Эл. почта.");

                return;
            }
            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Заполните поле Логин.");

                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните поле Пароль.");

                return;
            }

            db.openConnection();


            NpgsqlCommand checkUser = new NpgsqlCommand($"SELECT id FROM users WHERE login = '{login}'", db.getConnection());
            int? checkLogin = (int?)checkUser.ExecuteScalar();

            if (checkLogin != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
                return;
            }            

            NpgsqlCommand inserUser = new NpgsqlCommand(
                $"INSERT INTO users (login, password, id_role) " +
                $"VALUES ('{login}', '{password}', {2})",
                db.getConnection());
            inserUser.ExecuteNonQuery();

            NpgsqlCommand insertRepresentative = new NpgsqlCommand(
                $"INSERT INTO representatives (surname, name, patronymic) " +
                $"VALUES ('{surnameRepresentative}', '{nameRepresentative}', '{patronymicRepresentative}');",
                db.getConnection());
            insertRepresentative.ExecuteNonQuery();

            NpgsqlCommand insertApplicant = new NpgsqlCommand(
                "INSERT INTO " +
                "applicants (surname, name, patronymic, passport, snils, mail, telephone, educational_institution, id_representative, id_user) " +
                "VALUES (" +
                $"'{surname}'," +
                $"'{name}'," +
                $"'{patronymic}'," +
                $"'{passport}'," +
                $"'{snils}'," +
                $"'{mail}'," +
                $"'{telephone}'," +
                $"'{educationalInstitution}'," +
                $"{db.getMaxId("representatives")}," +
                $"{db.getMaxId("users")})", 
                db.getConnection());
            insertApplicant.ExecuteNonQuery();

            db.closeConnection();

            MessageBox.Show("Абитуриент успешно зарегистрирован.");

            Close();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form formAuth = new FormAuth();
            formAuth.Show();
        }
    }
}
