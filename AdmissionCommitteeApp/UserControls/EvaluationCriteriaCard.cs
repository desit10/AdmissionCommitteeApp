using System;
using System.Windows.Forms;

namespace AdmissionCommitteeApp
{
    public partial class EvaluationCriteriaCard : UserControl
    {
        double? score {  get; set; }
        public EvaluationCriteriaCard(string title, double? score, bool isEnabled)
        {
            InitializeComponent();

            this.score = score;

            labelEvaluationCriteria.Text = title;
            textBoxScore.Text = score.ToString();
                        
            textBoxScore.Enabled = isEnabled;
        }
     
        public string getScoreText()
        {
            return textBoxScore.Text;
        }

        public double? getScore()
        {
            try
            {
                return double.Parse(textBoxScore.Text);
            }
            catch
            {                
                return null;
            }
        }

        public void setTypeScore(int typeScore)
        {
            switch (typeScore)
            {
                case 1:
                    textBoxScore.Mask = "0.00";
                    break;
                case 2:
                    textBoxScore.Mask = "000";
                    break;                
                default:
                    break;
            }
        }
    }
}
