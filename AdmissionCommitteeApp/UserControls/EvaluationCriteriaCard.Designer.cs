namespace AdmissionCommitteeApp
{
    partial class EvaluationCriteriaCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEvaluationCriteria = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelEvaluationCriteria
            // 
            this.labelEvaluationCriteria.AutoSize = true;
            this.labelEvaluationCriteria.Location = new System.Drawing.Point(3, 7);
            this.labelEvaluationCriteria.Name = "labelEvaluationCriteria";
            this.labelEvaluationCriteria.Size = new System.Drawing.Size(73, 16);
            this.labelEvaluationCriteria.TabIndex = 0;
            this.labelEvaluationCriteria.Text = "Название";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(207, 4);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(40, 22);
            this.textBoxScore.TabIndex = 1;
            this.textBoxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EvaluationCriteriaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelEvaluationCriteria);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EvaluationCriteriaCard";
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEvaluationCriteria;
        private System.Windows.Forms.MaskedTextBox textBoxScore;
    }
}
