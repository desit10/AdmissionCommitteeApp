namespace AdmissionCommitteeApp
{
    partial class ApplicationCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAreaTraining = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanelEvaluationCriteria = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelComments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintApplication = new System.Windows.Forms.Button();
            this.labelAllScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Абитуриент";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(3, 16);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(38, 16);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "ФИО";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(905, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 16);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата заявки:";
            // 
            // labelAreaTraining
            // 
            this.labelAreaTraining.AutoSize = true;
            this.labelAreaTraining.Location = new System.Drawing.Point(3, 61);
            this.labelAreaTraining.Name = "labelAreaTraining";
            this.labelAreaTraining.Size = new System.Drawing.Size(97, 16);
            this.labelAreaTraining.TabIndex = 5;
            this.labelAreaTraining.Text = "Направление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Направление";
            // 
            // flowLayoutPanelEvaluationCriteria
            // 
            this.flowLayoutPanelEvaluationCriteria.AutoScroll = true;
            this.flowLayoutPanelEvaluationCriteria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelEvaluationCriteria.Location = new System.Drawing.Point(6, 104);
            this.flowLayoutPanelEvaluationCriteria.Name = "flowLayoutPanelEvaluationCriteria";
            this.flowLayoutPanelEvaluationCriteria.Size = new System.Drawing.Size(290, 145);
            this.flowLayoutPanelEvaluationCriteria.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Баллы";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "В ожидании",
            "В работе",
            "Готово",
            "В дороботку",
            "Отклонено"});
            this.comboBoxState.Location = new System.Drawing.Point(835, 104);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(158, 24);
            this.comboBoxState.TabIndex = 9;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Статус заявки";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(784, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Комментарии";
            // 
            // flowLayoutPanelComments
            // 
            this.flowLayoutPanelComments.AutoScroll = true;
            this.flowLayoutPanelComments.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelComments.Location = new System.Drawing.Point(338, 104);
            this.flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            this.flowLayoutPanelComments.Size = new System.Drawing.Size(440, 145);
            this.flowLayoutPanelComments.TabIndex = 12;
            // 
            // btnPrintApplication
            // 
            this.btnPrintApplication.Location = new System.Drawing.Point(784, 172);
            this.btnPrintApplication.Name = "btnPrintApplication";
            this.btnPrintApplication.Size = new System.Drawing.Size(208, 36);
            this.btnPrintApplication.TabIndex = 14;
            this.btnPrintApplication.Text = "Распечатать завление";
            this.btnPrintApplication.UseVisualStyleBackColor = true;
            this.btnPrintApplication.Click += new System.EventHandler(this.btnPrintApplication_Click);
            // 
            // labelAllScore
            // 
            this.labelAllScore.AutoSize = true;
            this.labelAllScore.Location = new System.Drawing.Point(131, 85);
            this.labelAllScore.Name = "labelAllScore";
            this.labelAllScore.Size = new System.Drawing.Size(99, 16);
            this.labelAllScore.TabIndex = 15;
            this.labelAllScore.Text = "Средний балл";
            // 
            // ApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelAllScore);
            this.Controls.Add(this.btnPrintApplication);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanelComments);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelEvaluationCriteria);
            this.Controls.Add(this.labelAreaTraining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1000, 260);
            this.Name = "ApplicationCard";
            this.Size = new System.Drawing.Size(996, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAreaTraining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvaluationCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComments;
        private System.Windows.Forms.Button btnPrintApplication;
        private System.Windows.Forms.Label labelAllScore;
    }
}
