﻿namespace Gym_Planner_EF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.CalendarTabPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.FindDayTab = new System.Windows.Forms.TabPage();
            this.FindDayTable = new System.Windows.Forms.TableLayoutPanel();
            this.FindPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.ExerciseNameLabel = new System.Windows.Forms.Label();
            this.GetExerciseButton = new System.Windows.Forms.Button();
            this.ExerciseLabel = new System.Windows.Forms.Label();
            this.maxWeightLabel = new System.Windows.Forms.Label();
            this.minWeightLabel = new System.Windows.Forms.Label();
            this.rapsLabel = new System.Windows.Forms.Label();
            this.maxDateLabel = new System.Windows.Forms.Label();
            this.minDateLabel = new System.Windows.Forms.Label();
            this.wereFoundLabel = new System.Windows.Forms.Label();
            this.BeforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FindButton = new System.Windows.Forms.Button();
            this.minWeightTextBox = new System.Windows.Forms.TextBox();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.RepsTextBox = new System.Windows.Forms.TextBox();
            this.workoutsListView = new System.Windows.Forms.ListView();
            this.ExercisesTab = new System.Windows.Forms.TabPage();
            this.ExercisesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExerciseInfoLabel = new System.Windows.Forms.Label();
            this.ExercisesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExercisesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AddNewExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatTab = new System.Windows.Forms.TabPage();
            this.ExerciseStatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ChooseExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuscleGroupToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.CalendarTab.SuspendLayout();
            this.CalendarTabPanel.SuspendLayout();
            this.FindDayTab.SuspendLayout();
            this.FindDayTable.SuspendLayout();
            this.FindPanel.SuspendLayout();
            this.ExercisesTab.SuspendLayout();
            this.ExercisesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).BeginInit();
            this.ExercisesMenuStrip.SuspendLayout();
            this.StatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseStatisticChart)).BeginInit();
            this.StatMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainTableLayout.BackgroundImage")));
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.MainTabControl, 0, 1);
            this.MainTableLayout.Controls.Add(this.linkLabelLogout, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.71018F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.28982F));
            this.MainTableLayout.Size = new System.Drawing.Size(954, 538);
            this.MainTableLayout.TabIndex = 2;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.CalendarTab);
            this.MainTabControl.Controls.Add(this.FindDayTab);
            this.MainTabControl.Controls.Add(this.ExercisesTab);
            this.MainTabControl.Controls.Add(this.StatTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(3, 92);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(948, 443);
            this.MainTabControl.TabIndex = 0;
            // 
            // CalendarTab
            // 
            this.CalendarTab.Controls.Add(this.CalendarTabPanel);
            this.CalendarTab.Location = new System.Drawing.Point(4, 25);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(940, 414);
            this.CalendarTab.TabIndex = 1;
            this.CalendarTab.Text = "Календар";
            this.CalendarTab.UseVisualStyleBackColor = true;
            // 
            // CalendarTabPanel
            // 
            this.CalendarTabPanel.ColumnCount = 1;
            this.CalendarTabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalendarTabPanel.Controls.Add(this.Calendar, 0, 0);
            this.CalendarTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarTabPanel.Location = new System.Drawing.Point(3, 3);
            this.CalendarTabPanel.Name = "CalendarTabPanel";
            this.CalendarTabPanel.RowCount = 2;
            this.CalendarTabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.20588F));
            this.CalendarTabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.79412F));
            this.CalendarTabPanel.Size = new System.Drawing.Size(934, 408);
            this.CalendarTabPanel.TabIndex = 1;
            // 
            // Calendar
            // 
            this.Calendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar.Location = new System.Drawing.Point(9, 9);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDayClicked);
            // 
            // FindDayTab
            // 
            this.FindDayTab.Controls.Add(this.FindDayTable);
            this.FindDayTab.Location = new System.Drawing.Point(4, 25);
            this.FindDayTab.Name = "FindDayTab";
            this.FindDayTab.Padding = new System.Windows.Forms.Padding(3);
            this.FindDayTab.Size = new System.Drawing.Size(940, 414);
            this.FindDayTab.TabIndex = 4;
            this.FindDayTab.Text = "Пошук днів";
            this.FindDayTab.UseVisualStyleBackColor = true;
            // 
            // FindDayTable
            // 
            this.FindDayTable.ColumnCount = 2;
            this.FindDayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindDayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindDayTable.Controls.Add(this.FindPanel, 1, 0);
            this.FindDayTable.Controls.Add(this.workoutsListView, 0, 0);
            this.FindDayTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindDayTable.Location = new System.Drawing.Point(3, 3);
            this.FindDayTable.Name = "FindDayTable";
            this.FindDayTable.RowCount = 1;
            this.FindDayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindDayTable.Size = new System.Drawing.Size(934, 408);
            this.FindDayTable.TabIndex = 0;
            // 
            // FindPanel
            // 
            this.FindPanel.Controls.Add(this.resetButton);
            this.FindPanel.Controls.Add(this.ExerciseNameLabel);
            this.FindPanel.Controls.Add(this.GetExerciseButton);
            this.FindPanel.Controls.Add(this.ExerciseLabel);
            this.FindPanel.Controls.Add(this.maxWeightLabel);
            this.FindPanel.Controls.Add(this.minWeightLabel);
            this.FindPanel.Controls.Add(this.rapsLabel);
            this.FindPanel.Controls.Add(this.maxDateLabel);
            this.FindPanel.Controls.Add(this.minDateLabel);
            this.FindPanel.Controls.Add(this.wereFoundLabel);
            this.FindPanel.Controls.Add(this.BeforeDateTimePicker);
            this.FindPanel.Controls.Add(this.AfterDateTimePicker);
            this.FindPanel.Controls.Add(this.FindButton);
            this.FindPanel.Controls.Add(this.minWeightTextBox);
            this.FindPanel.Controls.Add(this.maxWeightTextBox);
            this.FindPanel.Controls.Add(this.RepsTextBox);
            this.FindPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindPanel.Location = new System.Drawing.Point(470, 3);
            this.FindPanel.Name = "FindPanel";
            this.FindPanel.Size = new System.Drawing.Size(461, 402);
            this.FindPanel.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(27, 356);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 29);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Ресет";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ExerciseNameLabel
            // 
            this.ExerciseNameLabel.AutoSize = true;
            this.ExerciseNameLabel.Location = new System.Drawing.Point(98, 23);
            this.ExerciseNameLabel.Name = "ExerciseNameLabel";
            this.ExerciseNameLabel.Size = new System.Drawing.Size(0, 17);
            this.ExerciseNameLabel.TabIndex = 14;
            // 
            // GetExerciseButton
            // 
            this.GetExerciseButton.Location = new System.Drawing.Point(303, 17);
            this.GetExerciseButton.Name = "GetExerciseButton";
            this.GetExerciseButton.Size = new System.Drawing.Size(130, 23);
            this.GetExerciseButton.TabIndex = 13;
            this.GetExerciseButton.Text = "Вибрати вправу";
            this.GetExerciseButton.UseVisualStyleBackColor = true;
            this.GetExerciseButton.Click += new System.EventHandler(this.GetExerciseButton_Click);
            // 
            // ExerciseLabel
            // 
            this.ExerciseLabel.AutoSize = true;
            this.ExerciseLabel.Location = new System.Drawing.Point(24, 23);
            this.ExerciseLabel.Name = "ExerciseLabel";
            this.ExerciseLabel.Size = new System.Drawing.Size(64, 17);
            this.ExerciseLabel.TabIndex = 12;
            this.ExerciseLabel.Text = "Вправа :";
            // 
            // maxWeightLabel
            // 
            this.maxWeightLabel.AutoSize = true;
            this.maxWeightLabel.Location = new System.Drawing.Point(24, 277);
            this.maxWeightLabel.Name = "maxWeightLabel";
            this.maxWeightLabel.Size = new System.Drawing.Size(157, 17);
            this.maxWeightLabel.TabIndex = 11;
            this.maxWeightLabel.Text = "Максимальна вага, кг :";
            // 
            // minWeightLabel
            // 
            this.minWeightLabel.AutoSize = true;
            this.minWeightLabel.Location = new System.Drawing.Point(24, 225);
            this.minWeightLabel.Name = "minWeightLabel";
            this.minWeightLabel.Size = new System.Drawing.Size(141, 17);
            this.minWeightLabel.TabIndex = 10;
            this.minWeightLabel.Text = "Мінімальна вага, кг :";
            // 
            // rapsLabel
            // 
            this.rapsLabel.AutoSize = true;
            this.rapsLabel.Location = new System.Drawing.Point(24, 170);
            this.rapsLabel.Name = "rapsLabel";
            this.rapsLabel.Size = new System.Drawing.Size(164, 17);
            this.rapsLabel.TabIndex = 9;
            this.rapsLabel.Text = "Кількість повторювань :";
            // 
            // maxDateLabel
            // 
            this.maxDateLabel.AutoSize = true;
            this.maxDateLabel.Location = new System.Drawing.Point(24, 122);
            this.maxDateLabel.Name = "maxDateLabel";
            this.maxDateLabel.Size = new System.Drawing.Size(140, 17);
            this.maxDateLabel.TabIndex = 8;
            this.maxDateLabel.Text = "Максимальна дата :";
            // 
            // minDateLabel
            // 
            this.minDateLabel.AutoSize = true;
            this.minDateLabel.Location = new System.Drawing.Point(24, 70);
            this.minDateLabel.Name = "minDateLabel";
            this.minDateLabel.Size = new System.Drawing.Size(124, 17);
            this.minDateLabel.TabIndex = 7;
            this.minDateLabel.Text = "Мінімальна дата :";
            // 
            // wereFoundLabel
            // 
            this.wereFoundLabel.AutoSize = true;
            this.wereFoundLabel.Location = new System.Drawing.Point(203, 327);
            this.wereFoundLabel.Name = "wereFoundLabel";
            this.wereFoundLabel.Size = new System.Drawing.Size(85, 17);
            this.wereFoundLabel.TabIndex = 6;
            this.wereFoundLabel.Text = "Знайдено : ";
            // 
            // BeforeDateTimePicker
            // 
            this.BeforeDateTimePicker.Location = new System.Drawing.Point(206, 117);
            this.BeforeDateTimePicker.Name = "BeforeDateTimePicker";
            this.BeforeDateTimePicker.Size = new System.Drawing.Size(227, 22);
            this.BeforeDateTimePicker.TabIndex = 5;
            // 
            // AfterDateTimePicker
            // 
            this.AfterDateTimePicker.Location = new System.Drawing.Point(206, 65);
            this.AfterDateTimePicker.Name = "AfterDateTimePicker";
            this.AfterDateTimePicker.Size = new System.Drawing.Size(227, 22);
            this.AfterDateTimePicker.TabIndex = 4;
            this.AfterDateTimePicker.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(27, 321);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(121, 29);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Знайти!";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // minWeightTextBox
            // 
            this.minWeightTextBox.Location = new System.Drawing.Point(206, 220);
            this.minWeightTextBox.Name = "minWeightTextBox";
            this.minWeightTextBox.Size = new System.Drawing.Size(227, 22);
            this.minWeightTextBox.TabIndex = 2;
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(206, 274);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(227, 22);
            this.maxWeightTextBox.TabIndex = 1;
            // 
            // RepsTextBox
            // 
            this.RepsTextBox.Location = new System.Drawing.Point(206, 165);
            this.RepsTextBox.Name = "RepsTextBox";
            this.RepsTextBox.Size = new System.Drawing.Size(227, 22);
            this.RepsTextBox.TabIndex = 0;
            // 
            // workoutsListView
            // 
            this.workoutsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workoutsListView.FullRowSelect = true;
            this.workoutsListView.Location = new System.Drawing.Point(3, 3);
            this.workoutsListView.Name = "workoutsListView";
            this.workoutsListView.Size = new System.Drawing.Size(461, 402);
            this.workoutsListView.TabIndex = 2;
            this.workoutsListView.UseCompatibleStateImageBehavior = false;
            this.workoutsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DayListBox_DoubleClick);
            // 
            // ExercisesTab
            // 
            this.ExercisesTab.Controls.Add(this.ExercisesTableLayoutPanel);
            this.ExercisesTab.Controls.Add(this.ExercisesMenuStrip);
            this.ExercisesTab.Location = new System.Drawing.Point(4, 25);
            this.ExercisesTab.Name = "ExercisesTab";
            this.ExercisesTab.Size = new System.Drawing.Size(940, 414);
            this.ExercisesTab.TabIndex = 2;
            this.ExercisesTab.Text = "Вправи";
            this.ExercisesTab.UseVisualStyleBackColor = true;
            // 
            // ExercisesTableLayoutPanel
            // 
            this.ExercisesTableLayoutPanel.ColumnCount = 2;
            this.ExercisesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34568F));
            this.ExercisesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65432F));
            this.ExercisesTableLayoutPanel.Controls.Add(this.ExerciseInfoLabel, 1, 0);
            this.ExercisesTableLayoutPanel.Controls.Add(this.ExercisesDataGridView, 0, 0);
            this.ExercisesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExercisesTableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.ExercisesTableLayoutPanel.Name = "ExercisesTableLayoutPanel";
            this.ExercisesTableLayoutPanel.RowCount = 1;
            this.ExercisesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExercisesTableLayoutPanel.Size = new System.Drawing.Size(940, 386);
            this.ExercisesTableLayoutPanel.TabIndex = 2;
            // 
            // ExerciseInfoLabel
            // 
            this.ExerciseInfoLabel.AutoSize = true;
            this.ExerciseInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExerciseInfoLabel.Location = new System.Drawing.Point(495, 0);
            this.ExerciseInfoLabel.Name = "ExerciseInfoLabel";
            this.ExerciseInfoLabel.Size = new System.Drawing.Size(442, 386);
            this.ExerciseInfoLabel.TabIndex = 1;
            this.ExerciseInfoLabel.Text = "Для інформації про вправу - натисніть на ній у списку зліва";
            // 
            // ExercisesDataGridView
            // 
            this.ExercisesDataGridView.AllowUserToAddRows = false;
            this.ExercisesDataGridView.AllowUserToDeleteRows = false;
            this.ExercisesDataGridView.AllowUserToResizeColumns = false;
            this.ExercisesDataGridView.AllowUserToResizeRows = false;
            this.ExercisesDataGridView.AutoGenerateColumns = false;
            this.ExercisesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExercisesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExercisesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ExercisesDataGridView.DataSource = this.exercisesBindingSource;
            this.ExercisesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExercisesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ExercisesDataGridView.Name = "ExercisesDataGridView";
            this.ExercisesDataGridView.ReadOnly = true;
            this.ExercisesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExercisesDataGridView.RowHeadersVisible = false;
            this.ExercisesDataGridView.RowTemplate.Height = 24;
            this.ExercisesDataGridView.Size = new System.Drawing.Size(486, 380);
            this.ExercisesDataGridView.TabIndex = 2;
            this.ExercisesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExercisesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва вправи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Information";
            this.dataGridViewTextBoxColumn2.HeaderText = "Information";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MuscleGroups";
            this.dataGridViewTextBoxColumn3.HeaderText = "Група м\'язів";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Workouts";
            this.dataGridViewTextBoxColumn4.HeaderText = "Workouts";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // exercisesBindingSource
            // 
            this.exercisesBindingSource.DataSource = typeof(Gym_Planner_EF.Exercises);
            // 
            // ExercisesMenuStrip
            // 
            this.ExercisesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExercisesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewExerciseToolStripMenuItem,
            this.RemoveExerciseToolStripMenuItem});
            this.ExercisesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ExercisesMenuStrip.Name = "ExercisesMenuStrip";
            this.ExercisesMenuStrip.Size = new System.Drawing.Size(940, 28);
            this.ExercisesMenuStrip.TabIndex = 1;
            this.ExercisesMenuStrip.Text = "menuStrip1";
            // 
            // AddNewExerciseToolStripMenuItem
            // 
            this.AddNewExerciseToolStripMenuItem.Name = "AddNewExerciseToolStripMenuItem";
            this.AddNewExerciseToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.AddNewExerciseToolStripMenuItem.Text = "Додати нову вправу";
            this.AddNewExerciseToolStripMenuItem.Click += new System.EventHandler(this.AddNewExerciseToolStripMenuItem_Click);
            // 
            // RemoveExerciseToolStripMenuItem
            // 
            this.RemoveExerciseToolStripMenuItem.Name = "RemoveExerciseToolStripMenuItem";
            this.RemoveExerciseToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.RemoveExerciseToolStripMenuItem.Text = "Видалити вправу";
            this.RemoveExerciseToolStripMenuItem.Click += new System.EventHandler(this.RemoveExerciseToolStripMenuItem_Click);
            // 
            // StatTab
            // 
            this.StatTab.Controls.Add(this.ExerciseStatisticChart);
            this.StatTab.Controls.Add(this.StatMenuStrip);
            this.StatTab.Location = new System.Drawing.Point(4, 25);
            this.StatTab.Name = "StatTab";
            this.StatTab.Size = new System.Drawing.Size(940, 414);
            this.StatTab.TabIndex = 3;
            this.StatTab.Text = "Статистика";
            this.StatTab.UseVisualStyleBackColor = true;
            // 
            // ExerciseStatisticChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ExerciseStatisticChart.ChartAreas.Add(chartArea1);
            this.ExerciseStatisticChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ExerciseStatisticChart.Legends.Add(legend1);
            this.ExerciseStatisticChart.Location = new System.Drawing.Point(0, 32);
            this.ExerciseStatisticChart.Name = "ExerciseStatisticChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ExerciseStatisticChart.Series.Add(series1);
            this.ExerciseStatisticChart.Size = new System.Drawing.Size(940, 382);
            this.ExerciseStatisticChart.TabIndex = 1;
            this.ExerciseStatisticChart.Text = "chart1";
            // 
            // StatMenuStrip
            // 
            this.StatMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseExToolStripMenuItem,
            this.MuscleGroupToolStripComboBox});
            this.StatMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StatMenuStrip.Name = "StatMenuStrip";
            this.StatMenuStrip.Size = new System.Drawing.Size(940, 32);
            this.StatMenuStrip.TabIndex = 0;
            this.StatMenuStrip.Text = "menuStrip1";
            // 
            // ChooseExToolStripMenuItem
            // 
            this.ChooseExToolStripMenuItem.Name = "ChooseExToolStripMenuItem";
            this.ChooseExToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.ChooseExToolStripMenuItem.Text = "Вибрати вправу";
            this.ChooseExToolStripMenuItem.Click += new System.EventHandler(this.ChooseExToolStripMenuItem_Click);
            // 
            // MuscleGroupToolStripComboBox
            // 
            this.MuscleGroupToolStripComboBox.DropDownWidth = 121;
            this.MuscleGroupToolStripComboBox.Name = "MuscleGroupToolStripComboBox";
            this.MuscleGroupToolStripComboBox.Size = new System.Drawing.Size(180, 28);
            this.MuscleGroupToolStripComboBox.Text = "Виберіть групу м\'язів";
            this.MuscleGroupToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.MuscleGroupToolStripComboBox_Click);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(804, 0);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(147, 17);
            this.linkLabelLogout.TabIndex = 1;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Змінити користувача";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 538);
            this.Controls.Add(this.MainTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.ExercisesMenuStrip;
            this.Name = "MainForm";
            this.Text = "Gym Planner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.CalendarTab.ResumeLayout(false);
            this.CalendarTabPanel.ResumeLayout(false);
            this.FindDayTab.ResumeLayout(false);
            this.FindDayTable.ResumeLayout(false);
            this.FindPanel.ResumeLayout(false);
            this.FindPanel.PerformLayout();
            this.ExercisesTab.ResumeLayout(false);
            this.ExercisesTab.PerformLayout();
            this.ExercisesTableLayoutPanel.ResumeLayout(false);
            this.ExercisesTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).EndInit();
            this.ExercisesMenuStrip.ResumeLayout(false);
            this.ExercisesMenuStrip.PerformLayout();
            this.StatTab.ResumeLayout(false);
            this.StatTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseStatisticChart)).EndInit();
            this.StatMenuStrip.ResumeLayout(false);
            this.StatMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn інформаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn групимязівDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тренуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscleGroupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnInfo;
        private System.Windows.Forms.BindingSource exercisesBindingSource;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage CalendarTab;
        private System.Windows.Forms.TableLayoutPanel CalendarTabPanel;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TabPage FindDayTab;
        private System.Windows.Forms.TableLayoutPanel FindDayTable;
        private System.Windows.Forms.Panel FindPanel;
        private System.Windows.Forms.Label ExerciseNameLabel;
        private System.Windows.Forms.Button GetExerciseButton;
        private System.Windows.Forms.Label ExerciseLabel;
        private System.Windows.Forms.Label maxWeightLabel;
        private System.Windows.Forms.Label minWeightLabel;
        private System.Windows.Forms.Label rapsLabel;
        private System.Windows.Forms.Label maxDateLabel;
        private System.Windows.Forms.Label minDateLabel;
        private System.Windows.Forms.Label wereFoundLabel;
        private System.Windows.Forms.DateTimePicker BeforeDateTimePicker;
        private System.Windows.Forms.DateTimePicker AfterDateTimePicker;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox minWeightTextBox;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.TextBox RepsTextBox;
        private System.Windows.Forms.TabPage ExercisesTab;
        private System.Windows.Forms.TableLayoutPanel ExercisesTableLayoutPanel;
        private System.Windows.Forms.Label ExerciseInfoLabel;
        private System.Windows.Forms.DataGridView ExercisesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MenuStrip ExercisesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddNewExerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveExerciseToolStripMenuItem;
        private System.Windows.Forms.TabPage StatTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExerciseStatisticChart;
        private System.Windows.Forms.MenuStrip StatMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChooseExToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox MuscleGroupToolStripComboBox;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.ListView workoutsListView;
        private System.Windows.Forms.Button resetButton;
    }
}