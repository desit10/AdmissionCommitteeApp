using Npgsql;
using System;
using System.Windows.Forms;

namespace AdmissionCommitteeApp
{
    public partial class FormCreateApplication : Form
    {
        DataBase db = new DataBase();
        int idApplicant { get; set; }
        int idCriteria { get; set; }
        int typeScore { get; set; }

        public FormCreateApplication(int idApplicant)
        {
            InitializeComponent();

            this.idApplicant = idApplicant;                                  

            btnClose.DialogResult = DialogResult.Cancel;
            btnSave.DialogResult = DialogResult.OK;

            db.loadItemComboBox(comboBoxEducationLevels, "education_levels");
        }

        private void comboBoxEducationLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();

            comboBoxAreasTraining.Items.Clear();
            flowLayoutPanelEvaluationCriteria.Controls.Clear();

            int selectEducationLevel = comboBoxEducationLevels.SelectedIndex + 1;
            string cmd = null;
            typeScore = 0;

            NpgsqlCommand getAreasTrainings = new NpgsqlCommand(
                $"SELECT title FROM areas_training " +
                $"WHERE id_education_level = {selectEducationLevel} " +
                $"ORDER BY id ASC", db.getConnection());

            NpgsqlDataReader readerAreasTrainings = getAreasTrainings.ExecuteReader();

            while (readerAreasTrainings.Read())
            {
                comboBoxAreasTraining.Items.Add($"{readerAreasTrainings.GetString(0)}");
            }
            readerAreasTrainings.Close();

            switch (selectEducationLevel)
            {
                case 1:
                    cmd = $"SELECT title FROM evaluation_criteria WHERE id = 1";
                    idCriteria = 1;
                    typeScore = 1;
                    break;
                case 2:
                    cmd = $"SELECT title FROM evaluation_criteria ORDER BY id ASC OFFSET 2";
                    idCriteria = 3;
                    typeScore = 2;
                    break;
                case 3:
                    cmd = $"SELECT title FROM evaluation_criteria WHERE id = 2";
                    idCriteria = 2;
                    typeScore = 1;
                    break;
                case 4:
                    cmd = $"SELECT title FROM evaluation_criteria ORDER BY id ASC OFFSET 2";
                    idCriteria = 3;
                    typeScore = 2;
                    break;
                default:
                    break;
            }

            NpgsqlCommand getEvaluationCriteria = new NpgsqlCommand(cmd, db.getConnection());

            NpgsqlDataReader readerEvaluationCriteria = getEvaluationCriteria.ExecuteReader();

            while (readerEvaluationCriteria.Read())
            {
                EvaluationCriteriaCard evaluationCriteriaCard = new EvaluationCriteriaCard(readerEvaluationCriteria.GetString(0), null, true);
                evaluationCriteriaCard.setTypeScore(typeScore);
                flowLayoutPanelEvaluationCriteria.Controls.Add(evaluationCriteriaCard);
            }
            readerEvaluationCriteria.Close();

            db.closeConnection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxEducationLevels.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите уровень образования!");
                return;
            }

            if (comboBoxAreasTraining.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите направление!");
                return;
            }

            foreach (EvaluationCriteriaCard i in flowLayoutPanelEvaluationCriteria.Controls)
            {              
                switch (typeScore)
                {
                    case 1:                      
                        if (i.getScore() > 5)
                        {
                            MessageBox.Show("Значение балла не может быть больше 5!");
                            return;
                        }

                        if (i.getScore() == null)
                        {
                            MessageBox.Show("Введите баллы!");
                            return;
                        }

                        if (i.getScore() <= 0)
                        {
                            MessageBox.Show("Значение баллов не может быть меньше или равно 0!");
                            return;
                        }
                        break;
                    case 2:
                        if (i.getScore() > 100)
                        {
                            MessageBox.Show("Значение баллов не может быть больше 100!");
                            return;
                        }

                        if (i.getScore() <= 0)
                        {
                            MessageBox.Show("Значение баллов не может быть меньше или равно 0!");
                            return;
                        }
                        break;
                }             
            }

            db.openConnection();

            NpgsqlCommand getIdAreaTraining = new NpgsqlCommand(
                $"SELECT id FROM areas_training WHERE title = '{comboBoxAreasTraining.SelectedItem}'", db.getConnection());
            int idAreaTraining = (int)getIdAreaTraining.ExecuteScalar();

            NpgsqlCommand insertApplication = new NpgsqlCommand(
                "INSERT INTO applications (id_applicant, id_area_training, id_state, date) " +
                $"VALUES ({idApplicant}, {idAreaTraining}, 1, '{DateTime.Today.Date}')", db.getConnection());
            insertApplication.ExecuteNonQuery();

            int idAapplication = db.getMaxId("applications");

            foreach (EvaluationCriteriaCard i in flowLayoutPanelEvaluationCriteria.Controls)
            {
                string score = i.getScoreText();
                if (score.Length > 0 && score.Trim() != "0" && !String.IsNullOrEmpty(score.Trim()))
                {
                    NpgsqlCommand insertApplicantScores = new NpgsqlCommand(
                        "INSERT INTO applicants_scores (id_criteria, id_application, score) " +
                        $"VALUES ({idCriteria}, {idAapplication}, '{score.Replace(',', '.')}')", db.getConnection());
                    insertApplicantScores.ExecuteNonQuery();
                }

                idCriteria++;
            }

            db.closeConnection();

            MessageBox.Show("Заявление успешно создано.");

            Close();

        }
    }
}
