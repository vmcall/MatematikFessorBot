namespace MatematikFessor
{
    partial class MatFessorForm
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
            this.txtQuestionOverwrites = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOverwriteAnswers = new System.Windows.Forms.CheckBox();
            this.txtAnswerOverwrites = new System.Windows.Forms.Label();
            this.chkOverwriteQuestions = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAdaptiveTrainingAnswers = new System.Windows.Forms.Label();
            this.chkSpamAdaptiveTrainingAnswers = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestionOverwrites
            // 
            this.txtQuestionOverwrites.AutoSize = true;
            this.txtQuestionOverwrites.Location = new System.Drawing.Point(168, 19);
            this.txtQuestionOverwrites.Name = "txtQuestionOverwrites";
            this.txtQuestionOverwrites.Size = new System.Drawing.Size(69, 13);
            this.txtQuestionOverwrites.TabIndex = 4;
            this.txtQuestionOverwrites.Text = "Overwrites: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOverwriteAnswers);
            this.groupBox1.Controls.Add(this.txtAnswerOverwrites);
            this.groupBox1.Controls.Add(this.chkOverwriteQuestions);
            this.groupBox1.Controls.Add(this.txtQuestionOverwrites);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overwrite";
            // 
            // chkOverwriteAnswers
            // 
            this.chkOverwriteAnswers.AutoSize = true;
            this.chkOverwriteAnswers.Location = new System.Drawing.Point(17, 42);
            this.chkOverwriteAnswers.Name = "chkOverwriteAnswers";
            this.chkOverwriteAnswers.Size = new System.Drawing.Size(66, 17);
            this.chkOverwriteAnswers.TabIndex = 7;
            this.chkOverwriteAnswers.Text = "Answers";
            this.chkOverwriteAnswers.UseVisualStyleBackColor = true;
            // 
            // txtAnswerOverwrites
            // 
            this.txtAnswerOverwrites.AutoSize = true;
            this.txtAnswerOverwrites.Location = new System.Drawing.Point(168, 42);
            this.txtAnswerOverwrites.Name = "txtAnswerOverwrites";
            this.txtAnswerOverwrites.Size = new System.Drawing.Size(69, 13);
            this.txtAnswerOverwrites.TabIndex = 6;
            this.txtAnswerOverwrites.Text = "Overwrites: 0";
            // 
            // chkOverwriteQuestions
            // 
            this.chkOverwriteQuestions.AutoSize = true;
            this.chkOverwriteQuestions.Location = new System.Drawing.Point(17, 19);
            this.chkOverwriteQuestions.Name = "chkOverwriteQuestions";
            this.chkOverwriteQuestions.Size = new System.Drawing.Size(73, 17);
            this.chkOverwriteQuestions.TabIndex = 5;
            this.chkOverwriteQuestions.Text = "Questions";
            this.chkOverwriteQuestions.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAdaptiveTrainingAnswers);
            this.groupBox3.Controls.Add(this.chkSpamAdaptiveTrainingAnswers);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spam";
            // 
            // txtAdaptiveTrainingAnswers
            // 
            this.txtAdaptiveTrainingAnswers.AutoSize = true;
            this.txtAdaptiveTrainingAnswers.Location = new System.Drawing.Point(167, 20);
            this.txtAdaptiveTrainingAnswers.Name = "txtAdaptiveTrainingAnswers";
            this.txtAdaptiveTrainingAnswers.Size = new System.Drawing.Size(59, 13);
            this.txtAdaptiveTrainingAnswers.TabIndex = 1;
            this.txtAdaptiveTrainingAnswers.Text = "Answers: 0";
            // 
            // chkSpamAdaptiveTrainingAnswers
            // 
            this.chkSpamAdaptiveTrainingAnswers.AutoSize = true;
            this.chkSpamAdaptiveTrainingAnswers.Location = new System.Drawing.Point(16, 20);
            this.chkSpamAdaptiveTrainingAnswers.Name = "chkSpamAdaptiveTrainingAnswers";
            this.chkSpamAdaptiveTrainingAnswers.Size = new System.Drawing.Size(128, 17);
            this.chkSpamAdaptiveTrainingAnswers.TabIndex = 0;
            this.chkSpamAdaptiveTrainingAnswers.Text = "Supertræner Answers";
            this.chkSpamAdaptiveTrainingAnswers.UseVisualStyleBackColor = true;
            // 
            // MatFessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MatFessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matematik Fessor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatFessorForm_FormClosing);
            this.Load += new System.EventHandler(this.MatFessorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtQuestionOverwrites;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkOverwriteQuestions;
        private System.Windows.Forms.CheckBox chkOverwriteAnswers;
        private System.Windows.Forms.Label txtAnswerOverwrites;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSpamAdaptiveTrainingAnswers;
        private System.Windows.Forms.Label txtAdaptiveTrainingAnswers;
    }
}

