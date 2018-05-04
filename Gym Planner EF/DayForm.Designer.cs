namespace Gym_Planner_EF
{
    partial class DayForm
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
            this.PlanTreeView = new System.Windows.Forms.TreeView();
            this.DayCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DayTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редагуватиТренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DayTableLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanTreeView
            // 
            this.PlanTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanTreeView.Location = new System.Drawing.Point(3, 31);
            this.PlanTreeView.Name = "PlanTreeView";
            this.PlanTreeView.Size = new System.Drawing.Size(610, 332);
            this.PlanTreeView.TabIndex = 3;
            // 
            // DayCommentRichTextBox
            // 
            this.DayCommentRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayCommentRichTextBox.Location = new System.Drawing.Point(3, 369);
            this.DayCommentRichTextBox.Name = "DayCommentRichTextBox";
            this.DayCommentRichTextBox.Size = new System.Drawing.Size(610, 155);
            this.DayCommentRichTextBox.TabIndex = 4;
            this.DayCommentRichTextBox.Text = "";
            // 
            // DayTableLayout
            // 
            this.DayTableLayout.ColumnCount = 1;
            this.DayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DayTableLayout.Controls.Add(this.DayCommentRichTextBox, 0, 2);
            this.DayTableLayout.Controls.Add(this.PlanTreeView, 0, 1);
            this.DayTableLayout.Controls.Add(this.menuStrip1, 0, 0);
            this.DayTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayTableLayout.Location = new System.Drawing.Point(0, 0);
            this.DayTableLayout.Name = "DayTableLayout";
            this.DayTableLayout.RowCount = 3;
            this.DayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.DayTableLayout.Size = new System.Drawing.Size(616, 527);
            this.DayTableLayout.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редагуватиТренуванняToolStripMenuItem,
            this.SaveCommentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редагуватиТренуванняToolStripMenuItem
            // 
            this.редагуватиТренуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeTrainToolStripMenuItem,
            this.AddTrainToolStripMenuItem,
            this.RemoveTrainToolStripMenuItem});
            this.редагуватиТренуванняToolStripMenuItem.Name = "редагуватиТренуванняToolStripMenuItem";
            this.редагуватиТренуванняToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.редагуватиТренуванняToolStripMenuItem.Text = "Редагувати тренування";
            // 
            // ChangeTrainToolStripMenuItem
            // 
            this.ChangeTrainToolStripMenuItem.Name = "ChangeTrainToolStripMenuItem";
            this.ChangeTrainToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.ChangeTrainToolStripMenuItem.Text = "Змінити тренування";
            this.ChangeTrainToolStripMenuItem.Click += new System.EventHandler(this.ChangeTrainToolStripMenuItem_Click);
            // 
            // AddTrainToolStripMenuItem
            // 
            this.AddTrainToolStripMenuItem.Name = "AddTrainToolStripMenuItem";
            this.AddTrainToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.AddTrainToolStripMenuItem.Text = "Додати тренування";
            this.AddTrainToolStripMenuItem.Click += new System.EventHandler(this.AddTrainToolStripMenuItem_Click);
            // 
            // RemoveTrainToolStripMenuItem
            // 
            this.RemoveTrainToolStripMenuItem.Name = "RemoveTrainToolStripMenuItem";
            this.RemoveTrainToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.RemoveTrainToolStripMenuItem.Text = "Видалити тренування";
            this.RemoveTrainToolStripMenuItem.Click += new System.EventHandler(this.RemoveTrainToolStripMenuItem_Click);
            // 
            // SaveCommentToolStripMenuItem
            // 
            this.SaveCommentToolStripMenuItem.Name = "SaveCommentToolStripMenuItem";
            this.SaveCommentToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.SaveCommentToolStripMenuItem.Text = "Зберегти коментар";
            this.SaveCommentToolStripMenuItem.Click += new System.EventHandler(this.SaveCommentToolStripMenuItem_Click);
            // 
            // DayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 527);
            this.Controls.Add(this.DayTableLayout);
            this.Name = "DayForm";
            this.Text = "DayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DayForm_FormClosing);
            this.Load += new System.EventHandler(this.DayForm_Load);
            this.DayTableLayout.ResumeLayout(false);
            this.DayTableLayout.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView PlanTreeView;
        private System.Windows.Forms.RichTextBox DayCommentRichTextBox;
        private System.Windows.Forms.TableLayoutPanel DayTableLayout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редагуватиТренуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeTrainToolStripMenuItem;
    }
}