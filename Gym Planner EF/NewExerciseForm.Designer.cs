namespace Gym_Planner_EF
{
    partial class NewExerciseForm
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
            this.components = new System.ComponentModel.Container();
            this.ExerciseInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ExerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.ExerciseInformatinLabel = new System.Windows.Forms.Label();
            this.ExerciseNameLabel = new System.Windows.Forms.Label();
            this.CreateExerciseButton = new System.Windows.Forms.Button();
            this.ChooseMuscleGroupComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseMuscleGroupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExerciseInfoRichTextBox
            // 
            this.ExerciseInfoRichTextBox.Location = new System.Drawing.Point(24, 209);
            this.ExerciseInfoRichTextBox.Name = "ExerciseInfoRichTextBox";
            this.ExerciseInfoRichTextBox.Size = new System.Drawing.Size(391, 219);
            this.ExerciseInfoRichTextBox.TabIndex = 0;
            this.ExerciseInfoRichTextBox.Text = "";
            // 
            // ExerciseNameTextBox
            // 
            this.ExerciseNameTextBox.Location = new System.Drawing.Point(24, 44);
            this.ExerciseNameTextBox.Name = "ExerciseNameTextBox";
            this.ExerciseNameTextBox.Size = new System.Drawing.Size(391, 22);
            this.ExerciseNameTextBox.TabIndex = 1;
            // 
            // ExerciseInformatinLabel
            // 
            this.ExerciseInformatinLabel.AutoSize = true;
            this.ExerciseInformatinLabel.Location = new System.Drawing.Point(21, 173);
            this.ExerciseInformatinLabel.Name = "ExerciseInformatinLabel";
            this.ExerciseInformatinLabel.Size = new System.Drawing.Size(159, 17);
            this.ExerciseInformatinLabel.TabIndex = 2;
            this.ExerciseInformatinLabel.Text = "Інформація про вправу";
            // 
            // ExerciseNameLabel
            // 
            this.ExerciseNameLabel.AutoSize = true;
            this.ExerciseNameLabel.Location = new System.Drawing.Point(24, 13);
            this.ExerciseNameLabel.Name = "ExerciseNameLabel";
            this.ExerciseNameLabel.Size = new System.Drawing.Size(98, 17);
            this.ExerciseNameLabel.TabIndex = 3;
            this.ExerciseNameLabel.Text = "Назва вправи";
            // 
            // CreateExerciseButton
            // 
            this.CreateExerciseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateExerciseButton.Location = new System.Drawing.Point(295, 93);
            this.CreateExerciseButton.Name = "CreateExerciseButton";
            this.CreateExerciseButton.Size = new System.Drawing.Size(120, 62);
            this.CreateExerciseButton.TabIndex = 4;
            this.CreateExerciseButton.Text = "Створити";
            this.CreateExerciseButton.UseVisualStyleBackColor = true;
            this.CreateExerciseButton.Click += new System.EventHandler(this.CreateExerciseButton_Click);
            // 
            // ChooseMuscleGroupComboBox
            // 
            this.ChooseMuscleGroupComboBox.DisplayMember = "Name";
            this.ChooseMuscleGroupComboBox.FormattingEnabled = true;
            this.ChooseMuscleGroupComboBox.Location = new System.Drawing.Point(24, 131);
            this.ChooseMuscleGroupComboBox.Name = "ChooseMuscleGroupComboBox";
            this.ChooseMuscleGroupComboBox.Size = new System.Drawing.Size(213, 24);
            this.ChooseMuscleGroupComboBox.TabIndex = 5;
            // 
            // ChooseMuscleGroupLabel
            // 
            this.ChooseMuscleGroupLabel.AutoSize = true;
            this.ChooseMuscleGroupLabel.Location = new System.Drawing.Point(24, 93);
            this.ChooseMuscleGroupLabel.Name = "ChooseMuscleGroupLabel";
            this.ChooseMuscleGroupLabel.Size = new System.Drawing.Size(88, 17);
            this.ChooseMuscleGroupLabel.TabIndex = 6;
            this.ChooseMuscleGroupLabel.Text = "Група м\'язів";
            // 
            // NewExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 454);
            this.Controls.Add(this.ChooseMuscleGroupLabel);
            this.Controls.Add(this.ChooseMuscleGroupComboBox);
            this.Controls.Add(this.CreateExerciseButton);
            this.Controls.Add(this.ExerciseNameLabel);
            this.Controls.Add(this.ExerciseInformatinLabel);
            this.Controls.Add(this.ExerciseNameTextBox);
            this.Controls.Add(this.ExerciseInfoRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewExerciseForm";
            this.Text = "Нова вправа";
            this.Load += new System.EventHandler(this.NewExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ExerciseInfoRichTextBox;
        private System.Windows.Forms.TextBox ExerciseNameTextBox;
        private System.Windows.Forms.Label ExerciseInformatinLabel;
        private System.Windows.Forms.Label ExerciseNameLabel;
        private System.Windows.Forms.Button CreateExerciseButton;
        private System.Windows.Forms.ComboBox ChooseMuscleGroupComboBox;
        private System.Windows.Forms.Label ChooseMuscleGroupLabel;
    }
}