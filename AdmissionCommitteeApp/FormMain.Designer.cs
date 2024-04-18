namespace AdmissionCommitteeApp
{
    partial class FormMain
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateApplication = new System.Windows.Forms.Button();
            this.textBoxFindFIO = new System.Windows.Forms.TextBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxScore = new System.Windows.Forms.ComboBox();
            this.comboBoxEducationLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFindAreaTraining = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel.Location = new System.Drawing.Point(162, 48);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1030, 400);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnUpdateData);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCreateApplication);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 444);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(4, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateApplication
            // 
            this.btnCreateApplication.Location = new System.Drawing.Point(3, 3);
            this.btnCreateApplication.Name = "btnCreateApplication";
            this.btnCreateApplication.Size = new System.Drawing.Size(137, 41);
            this.btnCreateApplication.TabIndex = 0;
            this.btnCreateApplication.Text = "Создать заявку";
            this.btnCreateApplication.UseVisualStyleBackColor = true;
            this.btnCreateApplication.Click += new System.EventHandler(this.btnCreateApplication_Click);
            // 
            // textBoxFindFIO
            // 
            this.textBoxFindFIO.Location = new System.Drawing.Point(162, 25);
            this.textBoxFindFIO.Name = "textBoxFindFIO";
            this.textBoxFindFIO.Size = new System.Drawing.Size(181, 22);
            this.textBoxFindFIO.TabIndex = 3;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            "Без фильтрации",
            "По возрастанию",
            "По убыванию"});
            this.comboBoxDate.Location = new System.Drawing.Point(900, 23);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(144, 24);
            this.comboBoxDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Направление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(897, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Баллы";
            // 
            // comboBoxScore
            // 
            this.comboBoxScore.FormattingEnabled = true;
            this.comboBoxScore.Items.AddRange(new object[] {
            "Без фильтрации",
            "По возрастанию",
            "По убыванию"});
            this.comboBoxScore.Location = new System.Drawing.Point(750, 23);
            this.comboBoxScore.Name = "comboBoxScore";
            this.comboBoxScore.Size = new System.Drawing.Size(144, 24);
            this.comboBoxScore.TabIndex = 11;
            // 
            // comboBoxEducationLevel
            // 
            this.comboBoxEducationLevel.FormattingEnabled = true;
            this.comboBoxEducationLevel.Items.AddRange(new object[] {
            "Без фильтрации"});
            this.comboBoxEducationLevel.Location = new System.Drawing.Point(536, 23);
            this.comboBoxEducationLevel.Name = "comboBoxEducationLevel";
            this.comboBoxEducationLevel.Size = new System.Drawing.Size(208, 24);
            this.comboBoxEducationLevel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Уровень образования";
            // 
            // textBoxFindAreaTraining
            // 
            this.textBoxFindAreaTraining.Location = new System.Drawing.Point(349, 25);
            this.textBoxFindAreaTraining.Name = "textBoxFindAreaTraining";
            this.textBoxFindAreaTraining.Size = new System.Drawing.Size(181, 22);
            this.textBoxFindAreaTraining.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1045, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Статус";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Без фильтрации",
            "По возрастанию",
            "По убыванию"});
            this.comboBoxState.Location = new System.Drawing.Point(1048, 23);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(144, 24);
            this.comboBoxState.TabIndex = 15;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(4, 345);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(137, 41);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Text = "Обновить";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textBoxFindAreaTraining);
            this.Controls.Add(this.comboBoxEducationLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.textBoxFindFIO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приёмная комиссия ВГТУ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFindFIO;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Button btnCreateApplication;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxScore;
        private System.Windows.Forms.ComboBox comboBoxEducationLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFindAreaTraining;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button btnUpdateData;
    }
}