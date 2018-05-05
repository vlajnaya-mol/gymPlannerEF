namespace Gym_Planner_EF
{
    partial class ExerciseChooseForm
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
            this.ExerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.GetExerciseButton = new System.Windows.Forms.Button();
            this.ExerciseNameLabel = new System.Windows.Forms.Label();
            this.ExerciseFindLabel = new System.Windows.Forms.Label();
            this.ExercisesListBox = new System.Windows.Forms.ListBox();
            this.exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muscleGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChooseMuscleGroupComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muscleGroupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExerciseNameTextBox
            // 
            this.ExerciseNameTextBox.Location = new System.Drawing.Point(15, 37);
            this.ExerciseNameTextBox.Name = "ExerciseNameTextBox";
            this.ExerciseNameTextBox.Size = new System.Drawing.Size(262, 22);
            this.ExerciseNameTextBox.TabIndex = 0;
            this.ExerciseNameTextBox.TextChanged += new System.EventHandler(this.ExerciseNameTextBox_TextChanged);
            // 
            // GetExerciseButton
            // 
            this.GetExerciseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GetExerciseButton.Location = new System.Drawing.Point(301, 25);
            this.GetExerciseButton.Name = "GetExerciseButton";
            this.GetExerciseButton.Size = new System.Drawing.Size(103, 47);
            this.GetExerciseButton.TabIndex = 2;
            this.GetExerciseButton.Text = "Вибрати";
            this.GetExerciseButton.UseVisualStyleBackColor = true;
            this.GetExerciseButton.Click += new System.EventHandler(this.GetExerciseButton_Click);
            // 
            // ExerciseNameLabel
            // 
            this.ExerciseNameLabel.AutoSize = true;
            this.ExerciseNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ExerciseNameLabel.Name = "ExerciseNameLabel";
            this.ExerciseNameLabel.Size = new System.Drawing.Size(148, 17);
            this.ExerciseNameLabel.TabIndex = 3;
            this.ExerciseNameLabel.Text = "Введіть назву вправи";
            this.ExerciseNameLabel.UseMnemonic = false;
            // 
            // ExerciseFindLabel
            // 
            this.ExerciseFindLabel.AutoSize = true;
            this.ExerciseFindLabel.Location = new System.Drawing.Point(9, 124);
            this.ExerciseFindLabel.Name = "ExerciseFindLabel";
            this.ExerciseFindLabel.Size = new System.Drawing.Size(276, 17);
            this.ExerciseFindLabel.TabIndex = 4;
            this.ExerciseFindLabel.Text = "...або виберіть потрібну вправу зі списку";
            // 
            // ExercisesListBox
            // 
            this.ExercisesListBox.FormattingEnabled = true;
            this.ExercisesListBox.ItemHeight = 16;
            this.ExercisesListBox.Location = new System.Drawing.Point(12, 144);
            this.ExercisesListBox.Name = "ExercisesListBox";
            this.ExercisesListBox.Size = new System.Drawing.Size(402, 308);
            this.ExercisesListBox.TabIndex = 5;
            // 
            // exercisesBindingSource
            // 
            this.exercisesBindingSource.DataSource = typeof(Gym_Planner_EF.Exercises);
            // 
            // muscleGroupsBindingSource
            // 
            this.muscleGroupsBindingSource.DataSource = typeof(Gym_Planner_EF.MuscleGroups);
            // 
            // ChooseMuscleGroupComboBox
            // 
            this.ChooseMuscleGroupComboBox.FormattingEnabled = true;
            this.ChooseMuscleGroupComboBox.Location = new System.Drawing.Point(15, 85);
            this.ChooseMuscleGroupComboBox.Name = "ChooseMuscleGroupComboBox";
            this.ChooseMuscleGroupComboBox.Size = new System.Drawing.Size(213, 24);
            this.ChooseMuscleGroupComboBox.TabIndex = 6;
            this.ChooseMuscleGroupComboBox.SelectedValueChanged += new System.EventHandler(this.ChooseMuscleGroupComboBox_SelectedValueChanged);
            // 
            // ExerciseChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 472);
            this.Controls.Add(this.ChooseMuscleGroupComboBox);
            this.Controls.Add(this.ExercisesListBox);
            this.Controls.Add(this.ExerciseFindLabel);
            this.Controls.Add(this.ExerciseNameLabel);
            this.Controls.Add(this.GetExerciseButton);
            this.Controls.Add(this.ExerciseNameTextBox);
            this.Name = "ExerciseChooseForm";
            this.Text = "Вибір вправи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExerciseChooseForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muscleGroupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExerciseNameTextBox;
        private System.Windows.Forms.Button GetExerciseButton;
        private System.Windows.Forms.Label ExerciseNameLabel;
        private System.Windows.Forms.Label ExerciseFindLabel;
        private System.Windows.Forms.ListBox ExercisesListBox;
        private System.Windows.Forms.BindingSource exercisesBindingSource;
        private System.Windows.Forms.BindingSource muscleGroupsBindingSource;
        private System.Windows.Forms.ComboBox ChooseMuscleGroupComboBox;
    }
}