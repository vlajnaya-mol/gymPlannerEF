namespace Gym_Planner_EF
{
    partial class EditSetsForm
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
            this.AddSetButton = new System.Windows.Forms.Button();
            this.RemoveSetButton = new System.Windows.Forms.Button();
            this.RepsListView = new System.Windows.Forms.ListView();
            this.Reps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoneButton = new System.Windows.Forms.Button();
            this.RepsLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.RepsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddSetButton
            // 
            this.AddSetButton.Location = new System.Drawing.Point(232, 333);
            this.AddSetButton.Name = "AddSetButton";
            this.AddSetButton.Size = new System.Drawing.Size(119, 45);
            this.AddSetButton.TabIndex = 0;
            this.AddSetButton.Text = "Додати підхід";
            this.AddSetButton.UseVisualStyleBackColor = true;
            this.AddSetButton.Click += new System.EventHandler(this.AddSetButton_Click);
            // 
            // RemoveSetButton
            // 
            this.RemoveSetButton.Location = new System.Drawing.Point(232, 384);
            this.RemoveSetButton.Name = "RemoveSetButton";
            this.RemoveSetButton.Size = new System.Drawing.Size(119, 45);
            this.RemoveSetButton.TabIndex = 1;
            this.RemoveSetButton.Text = "Видалити підхід";
            this.RemoveSetButton.UseVisualStyleBackColor = true;
            this.RemoveSetButton.Click += new System.EventHandler(this.RemoveSetButton_Click);
            // 
            // RepsListView
            // 
            this.RepsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reps,
            this.Weight});
            this.RepsListView.HideSelection = false;
            this.RepsListView.Location = new System.Drawing.Point(12, 12);
            this.RepsListView.Name = "RepsListView";
            this.RepsListView.Size = new System.Drawing.Size(433, 315);
            this.RepsListView.TabIndex = 2;
            this.RepsListView.UseCompatibleStateImageBehavior = false;
            this.RepsListView.View = System.Windows.Forms.View.Details;
            // 
            // Reps
            // 
            this.Reps.Text = "Кількість повторів";
            this.Reps.Width = 130;
            // 
            // Weight
            // 
            this.Weight.Text = "Вага";
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Location = new System.Drawing.Point(357, 333);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(88, 96);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Готово!";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // RepsLabel
            // 
            this.RepsLabel.AutoSize = true;
            this.RepsLabel.Location = new System.Drawing.Point(12, 350);
            this.RepsLabel.Name = "RepsLabel";
            this.RepsLabel.Size = new System.Drawing.Size(105, 17);
            this.RepsLabel.TabIndex = 4;
            this.RepsLabel.Text = "Повтори, разів";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(12, 398);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(58, 17);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "Вага, кг";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(123, 395);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.WeightTextBox.TabIndex = 6;
            // 
            // RepsTextBox
            // 
            this.RepsTextBox.Location = new System.Drawing.Point(123, 347);
            this.RepsTextBox.Name = "RepsTextBox";
            this.RepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.RepsTextBox.TabIndex = 7;
            // 
            // EditSetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 436);
            this.Controls.Add(this.RepsTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.RepsLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.RepsListView);
            this.Controls.Add(this.RemoveSetButton);
            this.Controls.Add(this.AddSetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditSetsForm";
            this.Text = "Редагування підходів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSetsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSetButton;
        private System.Windows.Forms.Button RemoveSetButton;
        private System.Windows.Forms.ListView RepsListView;
        private System.Windows.Forms.ColumnHeader Reps;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label RepsLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox RepsTextBox;
    }
}