namespace Gym_Planner_EF
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NewAccount = new System.Windows.Forms.LinkLabel();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(129, 104);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(246, 22);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(129, 151);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(246, 22);
            this.PassTextBox.TabIndex = 1;
            // 
            // SignInButton
            // 
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.No;
            this.SignInButton.Location = new System.Drawing.Point(129, 193);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(246, 40);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Увійти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(35, 151);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(65, 17);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Пароль :";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(38, 104);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(50, 17);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логін :";
            // 
            // NewAccount
            // 
            this.NewAccount.AutoSize = true;
            this.NewAccount.Location = new System.Drawing.Point(198, 9);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(177, 17);
            this.NewAccount.TabIndex = 5;
            this.NewAccount.TabStop = true;
            this.NewAccount.Text = "Створити новий аккаунт?";
            this.NewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewAccount_LinkClicked);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizationLabel.Location = new System.Drawing.Point(155, 50);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(220, 32);
            this.AuthorizationLabel.TabIndex = 6;
            this.AuthorizationLabel.Text = "Вхід у систему";
            this.AuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(461, 277);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.NewAccount);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизація";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.LinkLabel NewAccount;
        private System.Windows.Forms.Label AuthorizationLabel;
    }
}

