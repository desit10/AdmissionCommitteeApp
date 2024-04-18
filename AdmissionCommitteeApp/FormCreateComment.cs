using System;
using System.Windows.Forms;

namespace AdmissionCommitteeApp
{
    public partial class FormCreateComment : Form
    {
        public string comment {  get; set; }

        public FormCreateComment()
        {
            InitializeComponent();

            btnClose.DialogResult = DialogResult.Cancel;
            btnSave.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxComment.Text.Trim()))
            {
                comment = textBoxComment.Text;
            }
            else
            {
                MessageBox.Show("Комментарий не может быть пустым!");
            }
        }        
    }
}
