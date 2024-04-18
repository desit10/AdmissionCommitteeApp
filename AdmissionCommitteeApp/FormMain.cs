using Npgsql;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AdmissionCommitteeApp
{
    public partial class FormMain : Form
    {
        DataBase db = new DataBase();
        private int idRole { get; set; }
        private int idApplicant { get; set; }
        string cmd = "";

        public FormMain(int idUser, int idRole)
        {
            InitializeComponent();

            this.idRole = idRole;

            db.openConnection();

            switch (idRole)
            {
                case 1:
                    cmd = $"SELECT * FROM applications";
                    btnCreateApplication.Text = "Статистика";                    
                    break;
                case 2:
                    NpgsqlCommand getIdApplicant = new NpgsqlCommand($"SELECT id FROM applicants WHERE id_user = {idUser};", db.getConnection());
                    idApplicant = (int) getIdApplicant.ExecuteScalar();
                    cmd = $"SELECT * FROM applications WHERE id_applicant = {idApplicant}";
                    break;
                default: 
                    break;
            }            

            loadApplications(cmd);



            db.closeConnection();
        }

        private void btnCreateApplication_Click(object sender, EventArgs e)
        {
            if(btnCreateApplication.Text == "Создать заявку")
            {
                if(flowLayoutPanel.Controls.Count < 5)
                {
                    Form formEditAndCreateStatement = new FormCreateApplication(idApplicant);

                    if (formEditAndCreateStatement.ShowDialog() == DialogResult.OK)
                    {
                        flowLayoutPanel.Controls.Clear();

                        db.openConnection();

                        loadApplications(cmd);

                        db.closeConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Вы можете подать только 5 заявлений!");
                }
                
            }
            else
            {
                db.openConnection();                             

                NpgsqlCommand getCountPending = new NpgsqlCommand("SELECT COUNT(id_state) FROM applications WHERE id_state = 1", db.getConnection());
                long countPending = (long) getCountPending.ExecuteScalar();

                NpgsqlCommand getCountInProgress = new NpgsqlCommand("SELECT COUNT(id_state) FROM applications WHERE id_state = 2", db.getConnection());
                long countInProgress = (long) getCountInProgress.ExecuteScalar();

                NpgsqlCommand getCountReady = new NpgsqlCommand("SELECT COUNT(id_state) FROM applications WHERE id_state = 3", db.getConnection());
                long countReady = (long) getCountReady.ExecuteScalar();

                NpgsqlCommand getCountOnTheWay = new NpgsqlCommand("SELECT COUNT(id_state) FROM applications WHERE id_state = 4", db.getConnection());
                long countOnTheWay = (long) getCountOnTheWay.ExecuteScalar();

                NpgsqlCommand getCountRejected = new NpgsqlCommand("SELECT COUNT(id_state) FROM applications WHERE id_state = 5", db.getConnection());
                long countRejected = (long) getCountRejected.ExecuteScalar();

                MessageBox.Show(
                    "Cтатистика заявлений\n" +
                    $"Заявлений в ожидании:\t {countPending};\n" +
                    $"Заявлений в работе:\t {countInProgress};\n" +
                    $"Заявлений готовых:\t {countReady};\n" +
                    $"Заявлений в дороботке:\t {countOnTheWay};\n" +
                    $"Заявлений отклонено:\t {countRejected}.\n"
                    );

                db.closeConnection();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form formAuth = new FormAuth();
            formAuth.Show();
        }

        private void loadApplications(string cmd)
        {
            NpgsqlCommand getApplications = new NpgsqlCommand(cmd, db.getConnection());
            NpgsqlDataReader readerApplications = getApplications.ExecuteReader();

            while (readerApplications.Read())
            {
                int id = readerApplications.GetInt32(0);
                int idApplicant = readerApplications.GetInt32(1);
                int idAreaTraining = readerApplications.GetInt32(2);
                int idState = readerApplications.GetInt32(3);
                string date = readerApplications.GetDateTime(4).ToString("dd-MM-yyyy");

                flowLayoutPanel.Controls.Add(new ApplicationCard(idRole, id, idApplicant, idAreaTraining, idState, date));
            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            db.openConnection();

            loadApplications(cmd);

            db.closeConnection();
        }
    }
}
