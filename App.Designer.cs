
namespace E7_20_v2._0
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AllMeterButton = new System.Windows.Forms.Button();
            this.CurieMeterButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.AutoName = new System.Windows.Forms.CheckBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.PortsList = new System.Windows.Forms.ComboBox();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Panel();
            this.CurieCoefficientsPanel = new System.Windows.Forms.Panel();
            this.CurieD = new System.Windows.Forms.TextBox();
            this.LabelD = new System.Windows.Forms.Label();
            this.CurieC = new System.Windows.Forms.TextBox();
            this.LabelC = new System.Windows.Forms.Label();
            this.CurieB = new System.Windows.Forms.TextBox();
            this.LabelB = new System.Windows.Forms.Label();
            this.CurieA = new System.Windows.Forms.TextBox();
            this.LabelA = new System.Windows.Forms.Label();
            this.CurieCoefficientsLabel = new System.Windows.Forms.Label();
            this.CurieSettings = new System.Windows.Forms.Panel();
            this.CurieLable = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.TextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.AllMeterSettings = new System.Windows.Forms.Panel();
            this.AllMeterStartFPanel = new System.Windows.Forms.Panel();
            this.AllMeterStartFLabel = new System.Windows.Forms.Label();
            this.AllMeterStartFDropBox = new System.Windows.Forms.ComboBox();
            this.AllMeterEndFPanel = new System.Windows.Forms.Panel();
            this.AllMeterEndFLabel = new System.Windows.Forms.Label();
            this.AllMeterEndFDropBox = new System.Windows.Forms.ComboBox();
            this.GeneralSettingsLabel = new System.Windows.Forms.Label();
            this.AllMeterStop = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AllMeterSlow = new System.Windows.Forms.Button();
            this.AllMeterFast = new System.Windows.Forms.Button();
            this.AllMeterModes = new System.Windows.Forms.Panel();
            this.AllMeterModesLabel = new System.Windows.Forms.Label();
            this.AllMeterFi = new System.Windows.Forms.CheckBox();
            this.AllMeterQr = new System.Windows.Forms.CheckBox();
            this.AllMeterQl = new System.Windows.Forms.CheckBox();
            this.AllMeterD = new System.Windows.Forms.CheckBox();
            this.AllMeterZ = new System.Windows.Forms.CheckBox();
            this.AllMeterR = new System.Windows.Forms.CheckBox();
            this.AllMeterL = new System.Windows.Forms.CheckBox();
            this.AllMeterC = new System.Windows.Forms.CheckBox();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.EstimatedTimeLabel = new System.Windows.Forms.Label();
            this.EstimatedTime = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MeasuresTimer = new System.Windows.Forms.Timer(this.components);
            this.ControlButtonPanel = new System.Windows.Forms.Panel();
            this.CurieStart = new System.Windows.Forms.Button();
            this.StartPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            this.CurieCoefficientsPanel.SuspendLayout();
            this.CurieSettings.SuspendLayout();
            this.AllMeterSettings.SuspendLayout();
            this.AllMeterStartFPanel.SuspendLayout();
            this.AllMeterEndFPanel.SuspendLayout();
            this.AllMeterModes.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.ControlButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllMeterButton
            // 
            this.AllMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterButton.Location = new System.Drawing.Point(150, 284);
            this.AllMeterButton.Name = "AllMeterButton";
            this.AllMeterButton.Size = new System.Drawing.Size(150, 32);
            this.AllMeterButton.TabIndex = 0;
            this.AllMeterButton.Text = "AllMeter";
            this.AllMeterButton.UseVisualStyleBackColor = true;
            this.AllMeterButton.Click += new System.EventHandler(this.AllMeterButton_Click);
            // 
            // CurieMeterButton
            // 
            this.CurieMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieMeterButton.Location = new System.Drawing.Point(412, 284);
            this.CurieMeterButton.Name = "CurieMeterButton";
            this.CurieMeterButton.Size = new System.Drawing.Size(150, 32);
            this.CurieMeterButton.TabIndex = 1;
            this.CurieMeterButton.Text = "TemperatureMeter";
            this.CurieMeterButton.UseVisualStyleBackColor = true;
            this.CurieMeterButton.Click += new System.EventHandler(this.TemperatureMeterButton_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartPanel.Controls.Add(this.AutoName);
            this.StartPanel.Controls.Add(this.FileName);
            this.StartPanel.Controls.Add(this.PortsList);
            this.StartPanel.Controls.Add(this.DirectoryPath);
            this.StartPanel.Controls.Add(this.DirectoryButton);
            this.StartPanel.Location = new System.Drawing.Point(38, 20);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(675, 81);
            this.StartPanel.TabIndex = 0;
            // 
            // AutoName
            // 
            this.AutoName.AutoSize = true;
            this.AutoName.BackColor = System.Drawing.SystemColors.Window;
            this.AutoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoName.Location = new System.Drawing.Point(19, 8);
            this.AutoName.Name = "AutoName";
            this.AutoName.Padding = new System.Windows.Forms.Padding(2, 3, 1, 2);
            this.AutoName.Size = new System.Drawing.Size(53, 24);
            this.AutoName.TabIndex = 0;
            this.AutoName.Text = "auto";
            this.AutoName.UseVisualStyleBackColor = false;
            this.AutoName.CheckedChanged += new System.EventHandler(this.AutoName_CheckedChanged);
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(82, 8);
            this.FileName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(376, 24);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "File name";
            this.FileName.UseWaitCursor = true;
            // 
            // PortsList
            // 
            this.PortsList.DropDownHeight = 100;
            this.PortsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortsList.FormattingEnabled = true;
            this.PortsList.IntegralHeight = false;
            this.PortsList.ItemHeight = 16;
            this.PortsList.Location = new System.Drawing.Point(506, 8);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(151, 24);
            this.PortsList.TabIndex = 2;
            this.PortsList.Text = "Choose the port";
            this.PortsList.DropDown += new System.EventHandler(this.FillThePorts);
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Enabled = false;
            this.DirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryPath.Location = new System.Drawing.Point(169, 50);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(488, 23);
            this.DirectoryPath.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(19, 48);
            this.DirectoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(142, 26);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Change directory";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.Window;
            this.Settings.Controls.Add(this.CurieCoefficientsPanel);
            this.Settings.Controls.Add(this.CurieSettings);
            this.Settings.Controls.Add(this.AllMeterSettings);
            this.Settings.Location = new System.Drawing.Point(38, 122);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(675, 162);
            this.Settings.TabIndex = 3;
            // 
            // CurieCoefficientsPanel
            // 
            this.CurieCoefficientsPanel.BackColor = System.Drawing.SystemColors.Info;
            this.CurieCoefficientsPanel.Controls.Add(this.CurieD);
            this.CurieCoefficientsPanel.Controls.Add(this.LabelD);
            this.CurieCoefficientsPanel.Controls.Add(this.CurieC);
            this.CurieCoefficientsPanel.Controls.Add(this.LabelC);
            this.CurieCoefficientsPanel.Controls.Add(this.CurieB);
            this.CurieCoefficientsPanel.Controls.Add(this.LabelB);
            this.CurieCoefficientsPanel.Controls.Add(this.CurieA);
            this.CurieCoefficientsPanel.Controls.Add(this.LabelA);
            this.CurieCoefficientsPanel.Controls.Add(this.CurieCoefficientsLabel);
            this.CurieCoefficientsPanel.Location = new System.Drawing.Point(356, 20);
            this.CurieCoefficientsPanel.Name = "CurieCoefficientsPanel";
            this.CurieCoefficientsPanel.Size = new System.Drawing.Size(300, 122);
            this.CurieCoefficientsPanel.TabIndex = 17;
            this.CurieCoefficientsPanel.Visible = false;
            // 
            // CurieD
            // 
            this.CurieD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieD.Location = new System.Drawing.Point(218, 81);
            this.CurieD.Margin = new System.Windows.Forms.Padding(2);
            this.CurieD.Name = "CurieD";
            this.CurieD.Size = new System.Drawing.Size(38, 24);
            this.CurieD.TabIndex = 24;
            this.CurieD.Text = "1";
            this.CurieD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelD.Location = new System.Drawing.Point(229, 41);
            this.LabelD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(19, 18);
            this.LabelD.TabIndex = 23;
            this.LabelD.Text = "D";
            // 
            // CurieC
            // 
            this.CurieC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieC.Location = new System.Drawing.Point(158, 81);
            this.CurieC.Margin = new System.Windows.Forms.Padding(2);
            this.CurieC.Name = "CurieC";
            this.CurieC.Size = new System.Drawing.Size(38, 24);
            this.CurieC.TabIndex = 22;
            this.CurieC.Text = "1";
            this.CurieC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelC.Location = new System.Drawing.Point(169, 41);
            this.LabelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(19, 18);
            this.LabelC.TabIndex = 21;
            this.LabelC.Text = "C";
            // 
            // CurieB
            // 
            this.CurieB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieB.Location = new System.Drawing.Point(98, 81);
            this.CurieB.Margin = new System.Windows.Forms.Padding(2);
            this.CurieB.Name = "CurieB";
            this.CurieB.Size = new System.Drawing.Size(38, 24);
            this.CurieB.TabIndex = 20;
            this.CurieB.Text = "1";
            this.CurieB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB.Location = new System.Drawing.Point(109, 41);
            this.LabelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(18, 18);
            this.LabelB.TabIndex = 19;
            this.LabelB.Text = "B";
            // 
            // CurieA
            // 
            this.CurieA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieA.Location = new System.Drawing.Point(38, 81);
            this.CurieA.Margin = new System.Windows.Forms.Padding(2);
            this.CurieA.Name = "CurieA";
            this.CurieA.Size = new System.Drawing.Size(38, 24);
            this.CurieA.TabIndex = 18;
            this.CurieA.Text = "1";
            this.CurieA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelA.Location = new System.Drawing.Point(49, 41);
            this.LabelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(17, 18);
            this.LabelA.TabIndex = 17;
            this.LabelA.Text = "A";
            // 
            // CurieCoefficientsLabel
            // 
            this.CurieCoefficientsLabel.AutoSize = true;
            this.CurieCoefficientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieCoefficientsLabel.Location = new System.Drawing.Point(98, 8);
            this.CurieCoefficientsLabel.Name = "CurieCoefficientsLabel";
            this.CurieCoefficientsLabel.Size = new System.Drawing.Size(108, 16);
            this.CurieCoefficientsLabel.TabIndex = 16;
            this.CurieCoefficientsLabel.Text = "Curie coefficients";
            this.CurieCoefficientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurieSettings
            // 
            this.CurieSettings.BackColor = System.Drawing.SystemColors.Info;
            this.CurieSettings.Controls.Add(this.CurieLable);
            this.CurieSettings.Controls.Add(this.Amount);
            this.CurieSettings.Controls.Add(this.AmountLabel);
            this.CurieSettings.Controls.Add(this.Interval);
            this.CurieSettings.Controls.Add(this.IntervalLabel);
            this.CurieSettings.Location = new System.Drawing.Point(19, 20);
            this.CurieSettings.Margin = new System.Windows.Forms.Padding(2);
            this.CurieSettings.Name = "CurieSettings";
            this.CurieSettings.Size = new System.Drawing.Size(300, 122);
            this.CurieSettings.TabIndex = 8;
            this.CurieSettings.Visible = false;
            // 
            // CurieLable
            // 
            this.CurieLable.AutoSize = true;
            this.CurieLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieLable.Location = new System.Drawing.Point(99, 8);
            this.CurieLable.Name = "CurieLable";
            this.CurieLable.Size = new System.Drawing.Size(104, 16);
            this.CurieLable.TabIndex = 17;
            this.CurieLable.Text = "Curie measuring";
            this.CurieLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(200, 75);
            this.Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(75, 24);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "10";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(25, 80);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(164, 18);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Measurements\' amount";
            // 
            // Interval
            // 
            this.Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Interval.Location = new System.Drawing.Point(200, 35);
            this.Interval.Margin = new System.Windows.Forms.Padding(2);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(75, 24);
            this.Interval.TabIndex = 1;
            this.Interval.Text = "10";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalLabel.Location = new System.Drawing.Point(25, 40);
            this.IntervalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(125, 18);
            this.IntervalLabel.TabIndex = 0;
            this.IntervalLabel.Text = "Interval (seconds)";
            // 
            // AllMeterSettings
            // 
            this.AllMeterSettings.BackColor = System.Drawing.SystemColors.Info;
            this.AllMeterSettings.Controls.Add(this.AllMeterStartFPanel);
            this.AllMeterSettings.Controls.Add(this.AllMeterEndFPanel);
            this.AllMeterSettings.Controls.Add(this.GeneralSettingsLabel);
            this.AllMeterSettings.Location = new System.Drawing.Point(19, 20);
            this.AllMeterSettings.Name = "AllMeterSettings";
            this.AllMeterSettings.Size = new System.Drawing.Size(300, 122);
            this.AllMeterSettings.TabIndex = 0;
            this.AllMeterSettings.Visible = false;
            // 
            // AllMeterStartFPanel
            // 
            this.AllMeterStartFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFLabel);
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFDropBox);
            this.AllMeterStartFPanel.Location = new System.Drawing.Point(19, 81);
            this.AllMeterStartFPanel.Name = "AllMeterStartFPanel";
            this.AllMeterStartFPanel.Size = new System.Drawing.Size(262, 30);
            this.AllMeterStartFPanel.TabIndex = 20;
            // 
            // AllMeterStartFLabel
            // 
            this.AllMeterStartFLabel.AutoSize = true;
            this.AllMeterStartFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStartFLabel.Location = new System.Drawing.Point(5, 7);
            this.AllMeterStartFLabel.Name = "AllMeterStartFLabel";
            this.AllMeterStartFLabel.Size = new System.Drawing.Size(96, 16);
            this.AllMeterStartFLabel.TabIndex = 19;
            this.AllMeterStartFLabel.Text = "Start frequency";
            // 
            // AllMeterStartFDropBox
            // 
            this.AllMeterStartFDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStartFDropBox.FormattingEnabled = true;
            this.AllMeterStartFDropBox.Location = new System.Drawing.Point(112, 4);
            this.AllMeterStartFDropBox.Name = "AllMeterStartFDropBox";
            this.AllMeterStartFDropBox.Size = new System.Drawing.Size(140, 24);
            this.AllMeterStartFDropBox.TabIndex = 18;
            // 
            // AllMeterEndFPanel
            // 
            this.AllMeterEndFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterEndFPanel.Controls.Add(this.AllMeterEndFLabel);
            this.AllMeterEndFPanel.Controls.Add(this.AllMeterEndFDropBox);
            this.AllMeterEndFPanel.Location = new System.Drawing.Point(19, 41);
            this.AllMeterEndFPanel.Name = "AllMeterEndFPanel";
            this.AllMeterEndFPanel.Size = new System.Drawing.Size(262, 32);
            this.AllMeterEndFPanel.TabIndex = 19;
            // 
            // AllMeterEndFLabel
            // 
            this.AllMeterEndFLabel.AutoSize = true;
            this.AllMeterEndFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterEndFLabel.Location = new System.Drawing.Point(5, 7);
            this.AllMeterEndFLabel.Name = "AllMeterEndFLabel";
            this.AllMeterEndFLabel.Size = new System.Drawing.Size(93, 16);
            this.AllMeterEndFLabel.TabIndex = 19;
            this.AllMeterEndFLabel.Text = "End frequency";
            // 
            // AllMeterEndFDropBox
            // 
            this.AllMeterEndFDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterEndFDropBox.FormattingEnabled = true;
            this.AllMeterEndFDropBox.Location = new System.Drawing.Point(112, 4);
            this.AllMeterEndFDropBox.Name = "AllMeterEndFDropBox";
            this.AllMeterEndFDropBox.Size = new System.Drawing.Size(140, 24);
            this.AllMeterEndFDropBox.TabIndex = 18;
            // 
            // GeneralSettingsLabel
            // 
            this.GeneralSettingsLabel.AutoSize = true;
            this.GeneralSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralSettingsLabel.Location = new System.Drawing.Point(84, 8);
            this.GeneralSettingsLabel.Name = "GeneralSettingsLabel";
            this.GeneralSettingsLabel.Size = new System.Drawing.Size(140, 16);
            this.GeneralSettingsLabel.TabIndex = 17;
            this.GeneralSettingsLabel.Text = "General measurement";
            this.GeneralSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllMeterStop
            // 
            this.AllMeterStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllMeterStop.BackColor = System.Drawing.Color.Salmon;
            this.AllMeterStop.Enabled = false;
            this.AllMeterStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStop.Location = new System.Drawing.Point(375, 8);
            this.AllMeterStop.Name = "AllMeterStop";
            this.AllMeterStop.Size = new System.Drawing.Size(112, 32);
            this.AllMeterStop.TabIndex = 5;
            this.AllMeterStop.Text = "Stop";
            this.AllMeterStop.UseVisualStyleBackColor = false;
            this.AllMeterStop.Click += new System.EventHandler(this.AllMeterStop_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Salmon;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(525, 8);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(112, 32);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AllMeterSlow
            // 
            this.AllMeterSlow.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSlow.Location = new System.Drawing.Point(188, 8);
            this.AllMeterSlow.Name = "AllMeterSlow";
            this.AllMeterSlow.Size = new System.Drawing.Size(112, 32);
            this.AllMeterSlow.TabIndex = 7;
            this.AllMeterSlow.Text = "Slow";
            this.AllMeterSlow.UseVisualStyleBackColor = false;
            this.AllMeterSlow.Click += new System.EventHandler(this.AllMeterSlow_Click);
            // 
            // AllMeterFast
            // 
            this.AllMeterFast.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFast.Location = new System.Drawing.Point(38, 8);
            this.AllMeterFast.Name = "AllMeterFast";
            this.AllMeterFast.Size = new System.Drawing.Size(112, 32);
            this.AllMeterFast.TabIndex = 6;
            this.AllMeterFast.Text = "Fast";
            this.AllMeterFast.UseVisualStyleBackColor = false;
            this.AllMeterFast.Click += new System.EventHandler(this.AllMeterFast_Click);
            // 
            // AllMeterModes
            // 
            this.AllMeterModes.BackColor = System.Drawing.SystemColors.Info;
            this.AllMeterModes.Controls.Add(this.AllMeterModesLabel);
            this.AllMeterModes.Controls.Add(this.AllMeterFi);
            this.AllMeterModes.Controls.Add(this.AllMeterQr);
            this.AllMeterModes.Controls.Add(this.AllMeterQl);
            this.AllMeterModes.Controls.Add(this.AllMeterD);
            this.AllMeterModes.Controls.Add(this.AllMeterZ);
            this.AllMeterModes.Controls.Add(this.AllMeterR);
            this.AllMeterModes.Controls.Add(this.AllMeterL);
            this.AllMeterModes.Controls.Add(this.AllMeterC);
            this.AllMeterModes.Location = new System.Drawing.Point(394, 142);
            this.AllMeterModes.Name = "AllMeterModes";
            this.AllMeterModes.Size = new System.Drawing.Size(300, 122);
            this.AllMeterModes.TabIndex = 0;
            this.AllMeterModes.Visible = false;
            // 
            // AllMeterModesLabel
            // 
            this.AllMeterModesLabel.AutoSize = true;
            this.AllMeterModesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterModesLabel.Location = new System.Drawing.Point(83, 8);
            this.AllMeterModesLabel.Name = "AllMeterModesLabel";
            this.AllMeterModesLabel.Size = new System.Drawing.Size(142, 16);
            this.AllMeterModesLabel.TabIndex = 16;
            this.AllMeterModesLabel.Text = "Measuring parameters";
            this.AllMeterModesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllMeterFi
            // 
            this.AllMeterFi.AutoSize = true;
            this.AllMeterFi.Enabled = false;
            this.AllMeterFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFi.Location = new System.Drawing.Point(200, 80);
            this.AllMeterFi.Name = "AllMeterFi";
            this.AllMeterFi.Size = new System.Drawing.Size(37, 20);
            this.AllMeterFi.TabIndex = 15;
            this.AllMeterFi.Text = "Fi";
            this.AllMeterFi.UseVisualStyleBackColor = true;
            // 
            // AllMeterQr
            // 
            this.AllMeterQr.AutoSize = true;
            this.AllMeterQr.Enabled = false;
            this.AllMeterQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQr.Location = new System.Drawing.Point(150, 80);
            this.AllMeterQr.Name = "AllMeterQr";
            this.AllMeterQr.Size = new System.Drawing.Size(40, 20);
            this.AllMeterQr.TabIndex = 14;
            this.AllMeterQr.Text = "Qr";
            this.AllMeterQr.UseVisualStyleBackColor = true;
            // 
            // AllMeterQl
            // 
            this.AllMeterQl.AutoSize = true;
            this.AllMeterQl.Enabled = false;
            this.AllMeterQl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQl.Location = new System.Drawing.Point(100, 80);
            this.AllMeterQl.Name = "AllMeterQl";
            this.AllMeterQl.Size = new System.Drawing.Size(39, 20);
            this.AllMeterQl.TabIndex = 13;
            this.AllMeterQl.Text = "Ql";
            this.AllMeterQl.UseVisualStyleBackColor = true;
            // 
            // AllMeterD
            // 
            this.AllMeterD.AutoSize = true;
            this.AllMeterD.Enabled = false;
            this.AllMeterD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterD.Location = new System.Drawing.Point(50, 80);
            this.AllMeterD.Name = "AllMeterD";
            this.AllMeterD.Size = new System.Drawing.Size(36, 20);
            this.AllMeterD.TabIndex = 12;
            this.AllMeterD.Text = "D";
            this.AllMeterD.UseVisualStyleBackColor = true;
            // 
            // AllMeterZ
            // 
            this.AllMeterZ.AutoSize = true;
            this.AllMeterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterZ.Location = new System.Drawing.Point(200, 40);
            this.AllMeterZ.Name = "AllMeterZ";
            this.AllMeterZ.Size = new System.Drawing.Size(34, 20);
            this.AllMeterZ.TabIndex = 11;
            this.AllMeterZ.Text = "Z";
            this.AllMeterZ.UseVisualStyleBackColor = true;
            this.AllMeterZ.CheckedChanged += new System.EventHandler(this.AllMeterZ_CheckedChanged);
            // 
            // AllMeterR
            // 
            this.AllMeterR.AutoSize = true;
            this.AllMeterR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterR.Location = new System.Drawing.Point(150, 40);
            this.AllMeterR.Name = "AllMeterR";
            this.AllMeterR.Size = new System.Drawing.Size(36, 20);
            this.AllMeterR.TabIndex = 10;
            this.AllMeterR.Text = "R";
            this.AllMeterR.UseVisualStyleBackColor = true;
            this.AllMeterR.CheckedChanged += new System.EventHandler(this.AllMeterR_CheckedChanged);
            // 
            // AllMeterL
            // 
            this.AllMeterL.AutoSize = true;
            this.AllMeterL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterL.Location = new System.Drawing.Point(100, 40);
            this.AllMeterL.Name = "AllMeterL";
            this.AllMeterL.Size = new System.Drawing.Size(33, 20);
            this.AllMeterL.TabIndex = 9;
            this.AllMeterL.Text = "L";
            this.AllMeterL.UseVisualStyleBackColor = true;
            this.AllMeterL.CheckedChanged += new System.EventHandler(this.AllMeterL_CheckedChanged);
            // 
            // AllMeterC
            // 
            this.AllMeterC.AutoSize = true;
            this.AllMeterC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterC.Location = new System.Drawing.Point(50, 40);
            this.AllMeterC.Name = "AllMeterC";
            this.AllMeterC.Size = new System.Drawing.Size(35, 20);
            this.AllMeterC.TabIndex = 8;
            this.AllMeterC.Text = "C";
            this.AllMeterC.UseVisualStyleBackColor = true;
            this.AllMeterC.CheckedChanged += new System.EventHandler(this.AllMeterC_CheckedChanged);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ProgressPanel.Controls.Add(this.EstimatedTimeLabel);
            this.ProgressPanel.Controls.Add(this.EstimatedTime);
            this.ProgressPanel.Controls.Add(this.ProgressBar);
            this.ProgressPanel.Enabled = false;
            this.ProgressPanel.Location = new System.Drawing.Point(38, 325);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(675, 102);
            this.ProgressPanel.TabIndex = 4;
            this.ProgressPanel.Visible = false;
            // 
            // EstimatedTimeLabel
            // 
            this.EstimatedTimeLabel.AutoSize = true;
            this.EstimatedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EstimatedTimeLabel.Location = new System.Drawing.Point(19, 20);
            this.EstimatedTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EstimatedTimeLabel.Name = "EstimatedTimeLabel";
            this.EstimatedTimeLabel.Size = new System.Drawing.Size(129, 22);
            this.EstimatedTimeLabel.TabIndex = 3;
            this.EstimatedTimeLabel.Text = "EstimatedTime";
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.Enabled = false;
            this.EstimatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EstimatedTime.Location = new System.Drawing.Point(169, 16);
            this.EstimatedTime.Margin = new System.Windows.Forms.Padding(2);
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.Size = new System.Drawing.Size(114, 27);
            this.EstimatedTime.TabIndex = 2;
            this.EstimatedTime.Text = "s";
            this.EstimatedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(19, 57);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(638, 32);
            this.ProgressBar.TabIndex = 0;
            // 
            // MeasuresTimer
            // 
            this.MeasuresTimer.Interval = 1000;
            this.MeasuresTimer.Tick += new System.EventHandler(this.MeasuresTimer_Tick);
            // 
            // ControlButtonPanel
            // 
            this.ControlButtonPanel.Controls.Add(this.CurieStart);
            this.ControlButtonPanel.Controls.Add(this.ReturnButton);
            this.ControlButtonPanel.Controls.Add(this.AllMeterStop);
            this.ControlButtonPanel.Controls.Add(this.AllMeterFast);
            this.ControlButtonPanel.Controls.Add(this.AllMeterSlow);
            this.ControlButtonPanel.Location = new System.Drawing.Point(38, 284);
            this.ControlButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ControlButtonPanel.Name = "ControlButtonPanel";
            this.ControlButtonPanel.Size = new System.Drawing.Size(675, 49);
            this.ControlButtonPanel.TabIndex = 9;
            this.ControlButtonPanel.Visible = false;
            // 
            // CurieStart
            // 
            this.CurieStart.BackColor = System.Drawing.Color.PaleGreen;
            this.CurieStart.Enabled = false;
            this.CurieStart.Location = new System.Drawing.Point(40, 10);
            this.CurieStart.Name = "CurieStart";
            this.CurieStart.Size = new System.Drawing.Size(260, 30);
            this.CurieStart.TabIndex = 8;
            this.CurieStart.Text = "Start";
            this.CurieStart.UseVisualStyleBackColor = false;
            this.CurieStart.Click += new System.EventHandler(this.CurieStart_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.CurieMeterButton);
            this.Controls.Add(this.AllMeterButton);
            this.Controls.Add(this.ControlButtonPanel);
            this.Controls.Add(this.AllMeterModes);
            this.Controls.Add(this.Settings);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "App";
            this.Text = "E7-20";
            this.Load += new System.EventHandler(this.App_Load);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.CurieCoefficientsPanel.ResumeLayout(false);
            this.CurieCoefficientsPanel.PerformLayout();
            this.CurieSettings.ResumeLayout(false);
            this.CurieSettings.PerformLayout();
            this.AllMeterSettings.ResumeLayout(false);
            this.AllMeterSettings.PerformLayout();
            this.AllMeterStartFPanel.ResumeLayout(false);
            this.AllMeterStartFPanel.PerformLayout();
            this.AllMeterEndFPanel.ResumeLayout(false);
            this.AllMeterEndFPanel.PerformLayout();
            this.AllMeterModes.ResumeLayout(false);
            this.AllMeterModes.PerformLayout();
            this.ProgressPanel.ResumeLayout(false);
            this.ProgressPanel.PerformLayout();
            this.ControlButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AllMeterButton;
        private System.Windows.Forms.Button CurieMeterButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Panel ProgressPanel;
        private System.Windows.Forms.ComboBox PortsList;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Panel AllMeterModes;
        private System.Windows.Forms.CheckBox AllMeterZ;
        private System.Windows.Forms.CheckBox AllMeterR;
        private System.Windows.Forms.CheckBox AllMeterL;
        private System.Windows.Forms.CheckBox AllMeterC;
        private System.Windows.Forms.Panel AllMeterSettings;
        private System.Windows.Forms.Panel AllMeterStartFPanel;
        private System.Windows.Forms.Label AllMeterStartFLabel;
        private System.Windows.Forms.ComboBox AllMeterStartFDropBox;
        private System.Windows.Forms.Panel AllMeterEndFPanel;
        private System.Windows.Forms.Label AllMeterEndFLabel;
        private System.Windows.Forms.ComboBox AllMeterEndFDropBox;
        private System.Windows.Forms.Label GeneralSettingsLabel;
        private System.Windows.Forms.Label AllMeterModesLabel;
        private System.Windows.Forms.CheckBox AllMeterFi;
        private System.Windows.Forms.CheckBox AllMeterQr;
        private System.Windows.Forms.CheckBox AllMeterQl;
        private System.Windows.Forms.CheckBox AllMeterD;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button AllMeterFast;
        private System.Windows.Forms.Button AllMeterSlow;
        private System.Windows.Forms.Timer MeasuresTimer;
        private System.Windows.Forms.CheckBox AutoName;
        private System.Windows.Forms.Button AllMeterStop;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label EstimatedTimeLabel;
        private System.Windows.Forms.TextBox EstimatedTime;
        private System.Windows.Forms.Panel CurieSettings;
        private System.Windows.Forms.Panel ControlButtonPanel;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox Interval;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Label CurieLable;
        private System.Windows.Forms.Panel CurieCoefficientsPanel;
        private System.Windows.Forms.Label CurieCoefficientsLabel;
        private System.Windows.Forms.TextBox CurieD;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.TextBox CurieC;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.TextBox CurieB;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.TextBox CurieA;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.Button CurieStart;
    }
}

