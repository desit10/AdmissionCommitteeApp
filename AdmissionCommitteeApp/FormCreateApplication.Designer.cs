namespace AdmissionCommitteeApp
{
    partial class FormCreateApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEducationLevels = new System.Windows.Forms.ComboBox();
            this.comboBoxAreasTraining = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelEvaluationCriteria = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровень образования";
            // 
            // comboBoxEducationLevels
            // 
            this.comboBoxEducationLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducationLevels.FormattingEnabled = true;
            this.comboBoxEducationLevels.Location = new System.Drawing.Point(12, 28);
            this.comboBoxEducationLevels.Name = "comboBoxEducationLevels";
            this.comboBoxEducationLevels.Size = new System.Drawing.Size(232, 24);
            this.comboBoxEducationLevels.TabIndex = 1;
            this.comboBoxEducationLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxEducationLevels_SelectedIndexChanged);
            // 
            // comboBoxAreasTraining
            // 
            this.comboBoxAreasTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAreasTraining.FormattingEnabled = true;
            this.comboBoxAreasTraining.Location = new System.Drawing.Point(12, 74);
            this.comboBoxAreasTraining.Name = "comboBoxAreasTraining";
            this.comboBoxAreasTraining.Size = new System.Drawing.Size(232, 24);
            this.comboBoxAreasTraining.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Направление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Критерии оценивания";
            // 
            // flowLayoutPanelEvaluationCriteria
            // 
            this.flowLayoutPanelEvaluationCriteria.AutoScroll = true;
            this.flowLayoutPanelEvaluationCriteria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelEvaluationCriteria.Location = new System.Drawing.Point(266, 28);
            this.flowLayoutPanelEvaluationCriteria.Name = "flowLayoutPanelEvaluationCriteria";
            this.flowLayoutPanelEvaluationCriteria.Size = new System.Drawing.Size(289, 150);
            this.flowLayoutPanelEvaluationCriteria.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(354, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormCreateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 240);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutPanelEvaluationCriteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAreasTraining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEducationLevels);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание заявления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEducationLevels;
        private System.Windows.Forms.ComboBox comboBoxAreasTraining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvaluationCriteria;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}