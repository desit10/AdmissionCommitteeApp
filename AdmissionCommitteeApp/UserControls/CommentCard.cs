using System.Windows.Forms;

namespace AdmissionCommitteeApp.UserControls
{
    public partial class CommentCard : UserControl
    {
        public CommentCard(string text, string date)
        {
            InitializeComponent();

            labelDate.Text = date;
            labelText.Text = text;
        }
    }
}
