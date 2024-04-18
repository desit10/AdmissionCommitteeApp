using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Npgsql;
using AdmissionCommitteeApp.UserControls;
using System.Drawing.Printing;

namespace AdmissionCommitteeApp
{
    public partial class ApplicationCard : UserControl
    {
        DataBase db = new DataBase();
        int id { get; set; }
        int idRole { get; set; }
        string email { get; set; }
        bool isSendMessage = false;

        public ApplicationCard(int idRole, int id, int idApplicant, int idAreaTraining, int idState, string date)
        {
            InitializeComponent();

            this.id = id;
            this.idRole = idRole;

            comboBoxState.SelectedIndex = idState - 1;
            labelDate.Text = date;

            btnPrintApplication.Enabled = false;
            btnPrintApplication.Visible = false;

            db.openConnection();

            NpgsqlCommand getFIO = new NpgsqlCommand($"SELECT surname, name, patronymic FROM applicants WHERE id = {idApplicant}", db.getConnection());
            NpgsqlDataReader readerApplicant = getFIO.ExecuteReader();

            while (readerApplicant.Read())
            {
                labelFIO.Text = $"{readerApplicant.GetString(0)} {readerApplicant.GetString(1)} {readerApplicant.GetString(2)}";
            }
            readerApplicant.Close();

            NpgsqlCommand getAreaTraining = new NpgsqlCommand($"SELECT title FROM areas_training WHERE id = {idAreaTraining}", db.getConnection());
            labelAreaTraining.Text = (string)getAreaTraining.ExecuteScalar();

            NpgsqlCommand getEvaluationCriteria = new NpgsqlCommand(
                "SELECT evaluation_criteria.title, applicants_scores.score " +
                "FROM applicants_scores JOIN evaluation_criteria " +
                "ON applicants_scores.id_criteria = evaluation_criteria.id " +
                $"WHERE applicants_scores.id_application = {id}", db.getConnection());
            NpgsqlDataReader readerEvaluationCriteria = getEvaluationCriteria.ExecuteReader();

            double? sumScore = 0;
            int count = 0;
            while (readerEvaluationCriteria.Read())
            {
                EvaluationCriteriaCard evaluationCriteriaCard = new EvaluationCriteriaCard(
                    readerEvaluationCriteria.GetString(0),
                    readerEvaluationCriteria.GetDouble(1),
                    false
                    );
                flowLayoutPanelEvaluationCriteria.Controls.Add(evaluationCriteriaCard);

                sumScore += evaluationCriteriaCard.getScore();
                count++;
            }
            readerEvaluationCriteria.Close();

            double? avgScore = sumScore / count;
            labelAllScore.Text = $"Средний балл: {Math.Round((double) avgScore, 2)}";

            NpgsqlCommand getComments = new NpgsqlCommand(
                "SELECT comments.text, comments.date FROM comments " +
                "JOIN applications_comments ON comments.id = applications_comments.id_comment " +
                $"WHERE applications_comments.id_application = {id}", db.getConnection());
            NpgsqlDataReader readerComments = getComments.ExecuteReader();

            while (readerComments.Read())
            {
                flowLayoutPanelComments.Controls.Add(
                    new CommentCard(
                        readerComments.GetString(0),
                        readerComments.GetDateTime(1).Date.ToString("dd-MM-yyyy")
                        )
                    );
            }
            readerComments.Close();

            NpgsqlCommand getEmail = new NpgsqlCommand(
                    $"SELECT mail FROM applicants JOIN applications ON applicants.id = applications.id_applicant WHERE applications.id = {id}", db.getConnection());
            email = (string)getEmail.ExecuteScalar();

            db.closeConnection();

            if (idRole == 2)
            {
                comboBoxState.Enabled = false;
            }

            if (idRole == 1)
            {
                btnDelete.Text = "Добавить комментарий";
            }

            if (idState == 3)
            {
                btnPrintApplication.Enabled = true;
                btnPrintApplication.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Удалить")
            {
                db.openConnection();

                NpgsqlCommand deleteApplication = new NpgsqlCommand($"DELETE FROM applications WHERE id = {id}", db.getConnection());
                deleteApplication.ExecuteNonQuery();

                this.Parent.Controls.Remove(this);

                db.closeConnection();
            }
            else
            {
                FormCreateComment formCreateComment = new FormCreateComment();

                if (formCreateComment.ShowDialog() == DialogResult.OK)
                {
                    string comment = formCreateComment.comment;
                    string date = DateTime.Today.Date.ToString("dd-MM-yyyy");

                    flowLayoutPanelComments.Controls.Add(new CommentCard(comment, date));

                    db.openConnection();

                    NpgsqlCommand insertComment = new NpgsqlCommand(
                        $"INSERT INTO comments (text, date) VALUES ('{comment}', '{date}')", db.getConnection());
                    insertComment.ExecuteNonQuery();

                    NpgsqlCommand insertCommentApplication = new NpgsqlCommand(
                        $"INSERT INTO applications_comments (id_application, id_comment) VALUES ({id}, {db.getMaxId("comments")});", db.getConnection());
                    insertCommentApplication.ExecuteNonQuery();

                    db.closeConnection();

                    sendMessageToMail(
                    email,
                    $"Комментарий к заявлению на направление '{labelAreaTraining.Text}'",
                    $"</h2>{comment}</h2>",
                    0);
                }
                else
                {
                    isSendMessage = false;
                }
            }

        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idRole == 1 && isSendMessage)
            {
                int selectedState = comboBoxState.SelectedIndex + 1;

                db.openConnection();

                NpgsqlCommand updateState = new NpgsqlCommand(
                    $"UPDATE applications SET id_state = {selectedState} WHERE id = {id}", db.getConnection());
                updateState.ExecuteNonQuery();

                db.closeConnection();

                sendMessageToMail(
                    email,
                    "Статус заявки обнавлён",
                    $"<h2>Ваша заявка на поступление на направление '{labelAreaTraining.Text}' обновила статус на '{comboBoxState.SelectedItem}'</h2>",
                    selectedState);

            }

            isSendMessage = true;
        }

        private void btnPrintApplication_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;

            printDocument.PrintController = new StandardPrintController();

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string application =
                "ЗАЯВЛЕНИЕ\r\n" +
                $"Я, {labelFIO.Text} подал документы в ВУЗ" +
                "\r\nНа направления подготовки:" +
                $"\r\n{labelAreaTraining.Text}" +
                $"\r\n\r\n\r\n\r\n{DateTime.Today.Date.ToString("dd-MM-yyyy")}\r\n";

            e.Graphics.DrawString(application, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
        }

        private void sendMessageToMail(string email, string subject, string body, int selectedState)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("ser_0.9.0@mail.ru", "Приёмная комиссия ВГТУ");
                // кому отправляем
                MailAddress to = new MailAddress(email);
                // создаем объект сообщения
                MailMessage message = new MailMessage(from, to);
                // тема письма
                message.Subject = subject;
                // текст письма
                message.Body = body;
                if (selectedState > 3)
                {
                    FormCreateComment formCreateComment = new FormCreateComment();

                    if (formCreateComment.ShowDialog() == DialogResult.OK)
                    {
                        message.Body += $"\n<h2>Причина:\n{formCreateComment.comment}</h2>";
                    }
                }
                // письмо представляет код html
                message.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 587);
                // логин и пароль
                smtpClient.Credentials = new NetworkCredential("ser_0.9.0@mail.ru", "BikRxjpkauW1pjxFZXTs");
                smtpClient.EnableSsl = true;

                smtpClient.Send(message);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка при отправки электронного письма:\n{exception.Message}");
            }
        }
    }
}
