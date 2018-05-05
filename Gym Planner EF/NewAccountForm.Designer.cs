namespace Gym_Planner_EF
{
    partial class NewAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccountForm));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.NewAccountLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NewAcLoganLabel = new System.Windows.Forms.Label();
            this.NewAcPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(147, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(284, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(147, 128);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(284, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(147, 177);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(284, 22);
            this.PassTextBox.TabIndex = 2;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(147, 219);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(159, 44);
            this.CreateAccountButton.TabIndex = 3;
            this.CreateAccountButton.Text = "Створити";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // NewAccountLabel
            // 
            this.NewAccountLabel.AutoSize = true;
            this.NewAccountLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.NewAccountLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewAccountLabel.Location = new System.Drawing.Point(45, 20);
            this.NewAccountLabel.Name = "NewAccountLabel";
            this.NewAccountLabel.Size = new System.Drawing.Size(368, 32);
            this.NewAccountLabel.TabIndex = 4;
            this.NewAccountLabel.Text = "Створення нового аккаунту";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(30, 80);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 17);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Ім\'я :";
            // 
            // NewAcLoganLabel
            // 
            this.NewAcLoganLabel.AutoSize = true;
            this.NewAcLoganLabel.Location = new System.Drawing.Point(30, 131);
            this.NewAcLoganLabel.Name = "NewAcLoganLabel";
            this.NewAcLoganLabel.Size = new System.Drawing.Size(50, 17);
            this.NewAcLoganLabel.TabIndex = 6;
            this.NewAcLoganLabel.Text = "Логін :";
            // 
            // NewAcPassLabel
            // 
            this.NewAcPassLabel.AutoSize = true;
            this.NewAcPassLabel.Location = new System.Drawing.Point(30, 177);
            this.NewAcPassLabel.Name = "NewAcPassLabel";
            this.NewAcPassLabel.Size = new System.Drawing.Size(65, 17);
            this.NewAcPassLabel.TabIndex = 7;
            this.NewAcPassLabel.Text = "Пароль :";
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 279);
            this.Controls.Add(this.NewAcPassLabel);
            this.Controls.Add(this.NewAcLoganLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NewAccountLabel);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "NewAccountForm";
            this.Text = "Створення нового аккаунту";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewAccountForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label NewAccountLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NewAcLoganLabel;
        private System.Windows.Forms.Label NewAcPassLabel;
    }
}