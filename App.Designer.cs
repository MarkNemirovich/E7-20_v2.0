
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
            this.CurieSettings = new System.Windows.Forms.Panel();
            this.CurieD = new System.Windows.Forms.TextBox();
            this.CurieLable = new System.Windows.Forms.Label();
            this.LabelD = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.CurieC = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.LabelC = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.TextBox();
            this.CurieB = new System.Windows.Forms.TextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.LabelB = new System.Windows.Forms.Label();
            this.LabelA = new System.Windows.Forms.Label();
            this.CurieA = new System.Windows.Forms.TextBox();
            this.AllMeterSettings = new System.Windows.Forms.Panel();
            this.AllMeterStartFPanel = new System.Windows.Forms.Panel();
            this.AllMeterStartFLabel = new System.Windows.Forms.Label();
            this.AllMeterStartFDropBox = new System.Windows.Forms.ComboBox();
            this.AllMeterEndFPanel = new System.Windows.Forms.Panel();
            this.AllMeterEndFLabel = new System.Windows.Forms.Label();
            this.AllMeterEndFDropBox = new System.Windows.Forms.ComboBox();
            this.GeneralSettingsLabel = new System.Windows.Forms.Label();
            this.SettingsModes = new System.Windows.Forms.Panel();
            this.SubParameters = new System.Windows.Forms.Panel();
            this.ParameterD = new System.Windows.Forms.CheckBox();
            this.ParameterQl = new System.Windows.Forms.CheckBox();
            this.ParameterQr = new System.Windows.Forms.CheckBox();
            this.MainParameters = new System.Windows.Forms.Panel();
            this.ParameterC = new System.Windows.Forms.CheckBox();
            this.ParameterL = new System.Windows.Forms.CheckBox();
            this.ParameterR = new System.Windows.Forms.CheckBox();
            this.ParameterZ = new System.Windows.Forms.CheckBox();
            this.AllMeterModesLabel = new System.Windows.Forms.Label();
            this.ParameterFi = new System.Windows.Forms.CheckBox();
            this.AllMeterStop = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AllMeterSlow = new System.Windows.Forms.Button();
            this.AllMeterFast = new System.Windows.Forms.Button();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.EstimatedTimeLabel = new System.Windows.Forms.Label();
            this.EstimatedTime = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MeasuresTimer = new System.Windows.Forms.Timer(this.components);
            this.ControlButtonPanel = new System.Windows.Forms.Panel();
            this.CurieStart = new System.Windows.Forms.Button();
            this.StartPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            this.CurieSettings.SuspendLayout();
            this.AllMeterSettings.SuspendLayout();
            this.AllMeterStartFPanel.SuspendLayout();
            this.AllMeterEndFPanel.SuspendLayout();
            this.SettingsModes.SuspendLayout();
            this.SubParameters.SuspendLayout();
            this.MainParameters.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.ControlButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllMeterButton
            // 
            this.AllMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterButton.Location = new System.Drawing.Point(200, 350);
            this.AllMeterButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterButton.Name = "AllMeterButton";
            this.AllMeterButton.Size = new System.Drawing.Size(200, 39);
            this.AllMeterButton.TabIndex = 0;
            this.AllMeterButton.Text = "AllMeter";
            this.AllMeterButton.UseVisualStyleBackColor = true;
            this.AllMeterButton.Click += new System.EventHandler(this.AllMeterButton_Click);
            // 
            // CurieMeterButton
            // 
            this.CurieMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieMeterButton.Location = new System.Drawing.Point(549, 350);
            this.CurieMeterButton.Margin = new System.Windows.Forms.Padding(4);
            this.CurieMeterButton.Name = "CurieMeterButton";
            this.CurieMeterButton.Size = new System.Drawing.Size(200, 39);
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
            this.StartPanel.Location = new System.Drawing.Point(51, 25);
            this.StartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(900, 100);
            this.StartPanel.TabIndex = 0;
            // 
            // AutoName
            // 
            this.AutoName.AutoSize = true;
            this.AutoName.BackColor = System.Drawing.SystemColors.Window;
            this.AutoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoName.Location = new System.Drawing.Point(25, 10);
            this.AutoName.Margin = new System.Windows.Forms.Padding(4);
            this.AutoName.Name = "AutoName";
            this.AutoName.Padding = new System.Windows.Forms.Padding(3, 4, 1, 2);
            this.AutoName.Size = new System.Drawing.Size(63, 28);
            this.AutoName.TabIndex = 0;
            this.AutoName.Text = "auto";
            this.AutoName.UseVisualStyleBackColor = false;
            this.AutoName.CheckedChanged += new System.EventHandler(this.AutoName_CheckedChanged);
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(109, 10);
            this.FileName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(500, 28);
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
            this.PortsList.ItemHeight = 20;
            this.PortsList.Location = new System.Drawing.Point(675, 10);
            this.PortsList.Margin = new System.Windows.Forms.Padding(4);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(200, 28);
            this.PortsList.TabIndex = 2;
            this.PortsList.Text = "Choose the port";
            this.PortsList.DropDown += new System.EventHandler(this.FillThePorts);
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Enabled = false;
            this.DirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryPath.Location = new System.Drawing.Point(225, 62);
            this.DirectoryPath.Margin = new System.Windows.Forms.Padding(4);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(649, 26);
            this.DirectoryPath.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(25, 59);
            this.DirectoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(189, 32);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Change directory";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.Window;
            this.Settings.Controls.Add(this.CurieSettings);
            this.Settings.Controls.Add(this.AllMeterSettings);
            this.Settings.Controls.Add(this.SettingsModes);
            this.Settings.Location = new System.Drawing.Point(51, 122);
            this.Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(900, 230);
            this.Settings.TabIndex = 3;
            // 
            // CurieSettings
            // 
            this.CurieSettings.BackColor = System.Drawing.SystemColors.Info;
            this.CurieSettings.Controls.Add(this.CurieD);
            this.CurieSettings.Controls.Add(this.CurieLable);
            this.CurieSettings.Controls.Add(this.LabelD);
            this.CurieSettings.Controls.Add(this.Amount);
            this.CurieSettings.Controls.Add(this.CurieC);
            this.CurieSettings.Controls.Add(this.AmountLabel);
            this.CurieSettings.Controls.Add(this.LabelC);
            this.CurieSettings.Controls.Add(this.Interval);
            this.CurieSettings.Controls.Add(this.CurieB);
            this.CurieSettings.Controls.Add(this.IntervalLabel);
            this.CurieSettings.Controls.Add(this.LabelB);
            this.CurieSettings.Controls.Add(this.LabelA);
            this.CurieSettings.Controls.Add(this.CurieA);
            this.CurieSettings.Location = new System.Drawing.Point(25, 25);
            this.CurieSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurieSettings.Name = "CurieSettings";
            this.CurieSettings.Size = new System.Drawing.Size(400, 200);
            this.CurieSettings.TabIndex = 8;
            this.CurieSettings.Visible = false;
            // 
            // CurieD
            // 
            this.CurieD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieD.Location = new System.Drawing.Point(288, 145);
            this.CurieD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurieD.Name = "CurieD";
            this.CurieD.Size = new System.Drawing.Size(49, 28);
            this.CurieD.TabIndex = 24;
            this.CurieD.Text = "1";
            this.CurieD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurieLable
            // 
            this.CurieLable.AutoSize = true;
            this.CurieLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieLable.Location = new System.Drawing.Point(132, 10);
            this.CurieLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurieLable.Name = "CurieLable";
            this.CurieLable.Size = new System.Drawing.Size(132, 20);
            this.CurieLable.TabIndex = 17;
            this.CurieLable.Text = "Curie measuring";
            this.CurieLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelD.Location = new System.Drawing.Point(303, 114);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(23, 22);
            this.LabelD.TabIndex = 23;
            this.LabelD.Text = "D";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(267, 74);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(99, 28);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "10";
            // 
            // CurieC
            // 
            this.CurieC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieC.Location = new System.Drawing.Point(208, 145);
            this.CurieC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurieC.Name = "CurieC";
            this.CurieC.Size = new System.Drawing.Size(49, 28);
            this.CurieC.TabIndex = 22;
            this.CurieC.Text = "1";
            this.CurieC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(33, 80);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(195, 22);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Measurements\' amount";
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelC.Location = new System.Drawing.Point(223, 114);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(23, 22);
            this.LabelC.TabIndex = 21;
            this.LabelC.Text = "C";
            // 
            // Interval
            // 
            this.Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Interval.Location = new System.Drawing.Point(267, 37);
            this.Interval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(99, 28);
            this.Interval.TabIndex = 1;
            this.Interval.Text = "10";
            // 
            // CurieB
            // 
            this.CurieB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieB.Location = new System.Drawing.Point(128, 145);
            this.CurieB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurieB.Name = "CurieB";
            this.CurieB.Size = new System.Drawing.Size(49, 28);
            this.CurieB.TabIndex = 20;
            this.CurieB.Text = "1";
            this.CurieB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalLabel.Location = new System.Drawing.Point(33, 43);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(152, 22);
            this.IntervalLabel.TabIndex = 0;
            this.IntervalLabel.Text = "Interval (seconds)";
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB.Location = new System.Drawing.Point(143, 114);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(22, 22);
            this.LabelB.TabIndex = 19;
            this.LabelB.Text = "B";
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelA.Location = new System.Drawing.Point(63, 114);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(22, 22);
            this.LabelA.TabIndex = 17;
            this.LabelA.Text = "A";
            // 
            // CurieA
            // 
            this.CurieA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieA.Location = new System.Drawing.Point(48, 145);
            this.CurieA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurieA.Name = "CurieA";
            this.CurieA.Size = new System.Drawing.Size(49, 28);
            this.CurieA.TabIndex = 18;
            this.CurieA.Text = "1";
            this.CurieA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AllMeterSettings
            // 
            this.AllMeterSettings.BackColor = System.Drawing.SystemColors.Info;
            this.AllMeterSettings.Controls.Add(this.AllMeterStartFPanel);
            this.AllMeterSettings.Controls.Add(this.AllMeterEndFPanel);
            this.AllMeterSettings.Controls.Add(this.GeneralSettingsLabel);
            this.AllMeterSettings.Location = new System.Drawing.Point(25, 25);
            this.AllMeterSettings.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterSettings.Name = "AllMeterSettings";
            this.AllMeterSettings.Size = new System.Drawing.Size(400, 200);
            this.AllMeterSettings.TabIndex = 0;
            this.AllMeterSettings.Visible = false;
            // 
            // AllMeterStartFPanel
            // 
            this.AllMeterStartFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFLabel);
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFDropBox);
            this.AllMeterStartFPanel.Location = new System.Drawing.Point(25, 125);
            this.AllMeterStartFPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStartFPanel.Name = "AllMeterStartFPanel";
            this.AllMeterStartFPanel.Size = new System.Drawing.Size(350, 40);
            this.AllMeterStartFPanel.TabIndex = 20;
            // 
            // AllMeterStartFLabel
            // 
            this.AllMeterStartFLabel.AutoSize = true;
            this.AllMeterStartFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStartFLabel.Location = new System.Drawing.Point(7, 9);
            this.AllMeterStartFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllMeterStartFLabel.Name = "AllMeterStartFLabel";
            this.AllMeterStartFLabel.Size = new System.Drawing.Size(123, 20);
            this.AllMeterStartFLabel.TabIndex = 19;
            this.AllMeterStartFLabel.Text = "Start frequency";
            // 
            // AllMeterStartFDropBox
            // 
            this.AllMeterStartFDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStartFDropBox.FormattingEnabled = true;
            this.AllMeterStartFDropBox.Location = new System.Drawing.Point(149, 5);
            this.AllMeterStartFDropBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStartFDropBox.Name = "AllMeterStartFDropBox";
            this.AllMeterStartFDropBox.Size = new System.Drawing.Size(185, 28);
            this.AllMeterStartFDropBox.TabIndex = 18;
            // 
            // AllMeterEndFPanel
            // 
            this.AllMeterEndFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterEndFPanel.Controls.Add(this.AllMeterEndFLabel);
            this.AllMeterEndFPanel.Controls.Add(this.AllMeterEndFDropBox);
            this.AllMeterEndFPanel.Location = new System.Drawing.Point(25, 50);
            this.AllMeterEndFPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterEndFPanel.Name = "AllMeterEndFPanel";
            this.AllMeterEndFPanel.Size = new System.Drawing.Size(350, 40);
            this.AllMeterEndFPanel.TabIndex = 19;
            // 
            // AllMeterEndFLabel
            // 
            this.AllMeterEndFLabel.AutoSize = true;
            this.AllMeterEndFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterEndFLabel.Location = new System.Drawing.Point(7, 9);
            this.AllMeterEndFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllMeterEndFLabel.Name = "AllMeterEndFLabel";
            this.AllMeterEndFLabel.Size = new System.Drawing.Size(116, 20);
            this.AllMeterEndFLabel.TabIndex = 19;
            this.AllMeterEndFLabel.Text = "End frequency";
            // 
            // AllMeterEndFDropBox
            // 
            this.AllMeterEndFDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterEndFDropBox.FormattingEnabled = true;
            this.AllMeterEndFDropBox.Location = new System.Drawing.Point(149, 5);
            this.AllMeterEndFDropBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterEndFDropBox.Name = "AllMeterEndFDropBox";
            this.AllMeterEndFDropBox.Size = new System.Drawing.Size(185, 28);
            this.AllMeterEndFDropBox.TabIndex = 18;
            // 
            // GeneralSettingsLabel
            // 
            this.GeneralSettingsLabel.AutoSize = true;
            this.GeneralSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralSettingsLabel.Location = new System.Drawing.Point(112, 10);
            this.GeneralSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeneralSettingsLabel.Name = "GeneralSettingsLabel";
            this.GeneralSettingsLabel.Size = new System.Drawing.Size(175, 20);
            this.GeneralSettingsLabel.TabIndex = 17;
            this.GeneralSettingsLabel.Text = "General measurement";
            this.GeneralSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsModes
            // 
            this.SettingsModes.BackColor = System.Drawing.SystemColors.Info;
            this.SettingsModes.Controls.Add(this.SubParameters);
            this.SettingsModes.Controls.Add(this.MainParameters);
            this.SettingsModes.Controls.Add(this.AllMeterModesLabel);
            this.SettingsModes.Location = new System.Drawing.Point(476, 25);
            this.SettingsModes.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsModes.Name = "SettingsModes";
            this.SettingsModes.Size = new System.Drawing.Size(400, 200);
            this.SettingsModes.TabIndex = 0;
            this.SettingsModes.Visible = false;
            // 
            // SubParameters
            // 
            this.SubParameters.Controls.Add(this.ParameterD);
            this.SubParameters.Controls.Add(this.ParameterQl);
            this.SubParameters.Controls.Add(this.ParameterQr);
            this.SubParameters.Controls.Add(this.ParameterFi);
            this.SubParameters.Location = new System.Drawing.Point(25, 125);
            this.SubParameters.Name = "SubParameters";
            this.SubParameters.Size = new System.Drawing.Size(350, 40);
            this.SubParameters.TabIndex = 18;
            // 
            // ParameterD
            // 
            this.ParameterD.AutoSize = true;
            this.ParameterD.Enabled = false;
            this.ParameterD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterD.Location = new System.Drawing.Point(0, 10);
            this.ParameterD.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterD.Name = "AllMeterD";
            this.ParameterD.Size = new System.Drawing.Size(44, 24);
            this.ParameterD.TabIndex = 12;
            this.ParameterD.Text = "D";
            this.ParameterD.UseVisualStyleBackColor = true;
            // 
            // ParameterQl
            // 
            this.ParameterQl.AutoSize = true;
            this.ParameterQl.Enabled = false;
            this.ParameterQl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterQl.Location = new System.Drawing.Point(100, 10);
            this.ParameterQl.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterQl.Name = "AllMeterQl";
            this.ParameterQl.Size = new System.Drawing.Size(48, 24);
            this.ParameterQl.TabIndex = 13;
            this.ParameterQl.Text = "Ql";
            this.ParameterQl.UseVisualStyleBackColor = true;
            // 
            // ParameterQr
            // 
            this.ParameterQr.AutoSize = true;
            this.ParameterQr.Enabled = false;
            this.ParameterQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterQr.Location = new System.Drawing.Point(200, 10);
            this.ParameterQr.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterQr.Name = "AllMeterQr";
            this.ParameterQr.Size = new System.Drawing.Size(50, 24);
            this.ParameterQr.TabIndex = 14;
            this.ParameterQr.Text = "Qr";
            this.ParameterQr.UseVisualStyleBackColor = true;
            // 
            // MainParameters
            // 
            this.MainParameters.Controls.Add(this.ParameterC);
            this.MainParameters.Controls.Add(this.ParameterL);
            this.MainParameters.Controls.Add(this.ParameterR);
            this.MainParameters.Controls.Add(this.ParameterZ);
            this.MainParameters.Location = new System.Drawing.Point(25, 50);
            this.MainParameters.Name = "MainParameters";
            this.MainParameters.Size = new System.Drawing.Size(350, 40);
            this.MainParameters.TabIndex = 17;
            // 
            // ParameterC
            // 
            this.ParameterC.AutoSize = true;
            this.ParameterC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterC.Location = new System.Drawing.Point(0, 10);
            this.ParameterC.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterC.Name = "AllMeterC";
            this.ParameterC.Size = new System.Drawing.Size(43, 24);
            this.ParameterC.TabIndex = 8;
            this.ParameterC.Text = "C";
            this.ParameterC.UseVisualStyleBackColor = true;
            this.ParameterC.CheckedChanged += new System.EventHandler(this.AllMeterC_CheckedChanged);
            // 
            // ParameterL
            // 
            this.ParameterL.AutoSize = true;
            this.ParameterL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterL.Location = new System.Drawing.Point(100, 10);
            this.ParameterL.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterL.Name = "AllMeterL";
            this.ParameterL.Size = new System.Drawing.Size(41, 24);
            this.ParameterL.TabIndex = 9;
            this.ParameterL.Text = "L";
            this.ParameterL.UseVisualStyleBackColor = true;
            this.ParameterL.CheckedChanged += new System.EventHandler(this.AllMeterL_CheckedChanged);
            // 
            // ParameterR
            // 
            this.ParameterR.AutoSize = true;
            this.ParameterR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterR.Location = new System.Drawing.Point(200, 10);
            this.ParameterR.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterR.Name = "AllMeterR";
            this.ParameterR.Size = new System.Drawing.Size(43, 24);
            this.ParameterR.TabIndex = 10;
            this.ParameterR.Text = "R";
            this.ParameterR.UseVisualStyleBackColor = true;
            this.ParameterR.CheckedChanged += new System.EventHandler(this.AllMeterR_CheckedChanged);
            // 
            // ParameterZ
            // 
            this.ParameterZ.AutoSize = true;
            this.ParameterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterZ.Location = new System.Drawing.Point(300, 10);
            this.ParameterZ.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterZ.Name = "AllMeterZ";
            this.ParameterZ.Size = new System.Drawing.Size(40, 24);
            this.ParameterZ.TabIndex = 11;
            this.ParameterZ.Text = "Z";
            this.ParameterZ.UseVisualStyleBackColor = true;
            this.ParameterZ.CheckedChanged += new System.EventHandler(this.AllMeterZ_CheckedChanged);
            // 
            // AllMeterModesLabel
            // 
            this.AllMeterModesLabel.AutoSize = true;
            this.AllMeterModesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterModesLabel.Location = new System.Drawing.Point(111, 10);
            this.AllMeterModesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllMeterModesLabel.Name = "AllMeterModesLabel";
            this.AllMeterModesLabel.Size = new System.Drawing.Size(177, 20);
            this.AllMeterModesLabel.TabIndex = 16;
            this.AllMeterModesLabel.Text = "Measuring parameters";
            this.AllMeterModesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParameterFi
            // 
            this.ParameterFi.AutoSize = true;
            this.ParameterFi.Enabled = false;
            this.ParameterFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterFi.Location = new System.Drawing.Point(300, 10);
            this.ParameterFi.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterFi.Name = "AllMeterFi";
            this.ParameterFi.Size = new System.Drawing.Size(45, 24);
            this.ParameterFi.TabIndex = 15;
            this.ParameterFi.Text = "Fi";
            this.ParameterFi.UseVisualStyleBackColor = true;
            // 
            // AllMeterStop
            // 
            this.AllMeterStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllMeterStop.BackColor = System.Drawing.Color.Salmon;
            this.AllMeterStop.Enabled = false;
            this.AllMeterStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStop.Location = new System.Drawing.Point(500, 10);
            this.AllMeterStop.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStop.Name = "AllMeterStop";
            this.AllMeterStop.Size = new System.Drawing.Size(149, 39);
            this.AllMeterStop.TabIndex = 5;
            this.AllMeterStop.Text = "Stop";
            this.AllMeterStop.UseVisualStyleBackColor = false;
            this.AllMeterStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Salmon;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(700, 10);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(149, 39);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AllMeterSlow
            // 
            this.AllMeterSlow.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSlow.Location = new System.Drawing.Point(251, 10);
            this.AllMeterSlow.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterSlow.Name = "AllMeterSlow";
            this.AllMeterSlow.Size = new System.Drawing.Size(149, 39);
            this.AllMeterSlow.TabIndex = 7;
            this.AllMeterSlow.Text = "Slow";
            this.AllMeterSlow.UseVisualStyleBackColor = false;
            this.AllMeterSlow.Click += new System.EventHandler(this.AllMeterSlow_Click);
            // 
            // AllMeterFast
            // 
            this.AllMeterFast.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFast.Location = new System.Drawing.Point(51, 10);
            this.AllMeterFast.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterFast.Name = "AllMeterFast";
            this.AllMeterFast.Size = new System.Drawing.Size(149, 39);
            this.AllMeterFast.TabIndex = 6;
            this.AllMeterFast.Text = "Fast";
            this.AllMeterFast.UseVisualStyleBackColor = false;
            this.AllMeterFast.Click += new System.EventHandler(this.AllMeterFast_Click);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ProgressPanel.Controls.Add(this.EstimatedTimeLabel);
            this.ProgressPanel.Controls.Add(this.EstimatedTime);
            this.ProgressPanel.Controls.Add(this.ProgressBar);
            this.ProgressPanel.Enabled = false;
            this.ProgressPanel.Location = new System.Drawing.Point(51, 400);
            this.ProgressPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(900, 126);
            this.ProgressPanel.TabIndex = 4;
            this.ProgressPanel.Visible = false;
            // 
            // EstimatedTimeLabel
            // 
            this.EstimatedTimeLabel.AutoSize = true;
            this.EstimatedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EstimatedTimeLabel.Location = new System.Drawing.Point(25, 25);
            this.EstimatedTimeLabel.Name = "EstimatedTimeLabel";
            this.EstimatedTimeLabel.Size = new System.Drawing.Size(158, 26);
            this.EstimatedTimeLabel.TabIndex = 3;
            this.EstimatedTimeLabel.Text = "EstimatedTime";
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.Enabled = false;
            this.EstimatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EstimatedTime.Location = new System.Drawing.Point(225, 20);
            this.EstimatedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.Size = new System.Drawing.Size(199, 32);
            this.EstimatedTime.TabIndex = 2;
            this.EstimatedTime.Text = "s";
            this.EstimatedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(25, 70);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(851, 39);
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
            this.ControlButtonPanel.Location = new System.Drawing.Point(51, 350);
            this.ControlButtonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ControlButtonPanel.Name = "ControlButtonPanel";
            this.ControlButtonPanel.Size = new System.Drawing.Size(900, 60);
            this.ControlButtonPanel.TabIndex = 9;
            this.ControlButtonPanel.Visible = false;
            // 
            // CurieStart
            // 
            this.CurieStart.BackColor = System.Drawing.Color.PaleGreen;
            this.CurieStart.Enabled = false;
            this.CurieStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieStart.Location = new System.Drawing.Point(53, 12);
            this.CurieStart.Margin = new System.Windows.Forms.Padding(4);
            this.CurieStart.Name = "CurieStart";
            this.CurieStart.Size = new System.Drawing.Size(347, 37);
            this.CurieStart.TabIndex = 8;
            this.CurieStart.Text = "Start";
            this.CurieStart.UseVisualStyleBackColor = false;
            this.CurieStart.Click += new System.EventHandler(this.CurieStart_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.CurieMeterButton);
            this.Controls.Add(this.AllMeterButton);
            this.Controls.Add(this.ControlButtonPanel);
            this.Controls.Add(this.Settings);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Text = "E7-20";
            this.Load += new System.EventHandler(this.App_Load);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.CurieSettings.ResumeLayout(false);
            this.CurieSettings.PerformLayout();
            this.AllMeterSettings.ResumeLayout(false);
            this.AllMeterSettings.PerformLayout();
            this.AllMeterStartFPanel.ResumeLayout(false);
            this.AllMeterStartFPanel.PerformLayout();
            this.AllMeterEndFPanel.ResumeLayout(false);
            this.AllMeterEndFPanel.PerformLayout();
            this.SettingsModes.ResumeLayout(false);
            this.SettingsModes.PerformLayout();
            this.SubParameters.ResumeLayout(false);
            this.SubParameters.PerformLayout();
            this.MainParameters.ResumeLayout(false);
            this.MainParameters.PerformLayout();
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
        private System.Windows.Forms.Panel SettingsModes;
        private System.Windows.Forms.CheckBox ParameterZ;
        private System.Windows.Forms.CheckBox ParameterR;
        private System.Windows.Forms.CheckBox ParameterL;
        private System.Windows.Forms.CheckBox ParameterC;
        private System.Windows.Forms.Panel AllMeterSettings;
        private System.Windows.Forms.Panel AllMeterStartFPanel;
        private System.Windows.Forms.Label AllMeterStartFLabel;
        private System.Windows.Forms.ComboBox AllMeterStartFDropBox;
        private System.Windows.Forms.Panel AllMeterEndFPanel;
        private System.Windows.Forms.Label AllMeterEndFLabel;
        private System.Windows.Forms.ComboBox AllMeterEndFDropBox;
        private System.Windows.Forms.Label GeneralSettingsLabel;
        private System.Windows.Forms.Label AllMeterModesLabel;
        private System.Windows.Forms.CheckBox ParameterFi;
        private System.Windows.Forms.CheckBox ParameterQr;
        private System.Windows.Forms.CheckBox ParameterQl;
        private System.Windows.Forms.CheckBox ParameterD;
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
        private System.Windows.Forms.TextBox CurieD;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.TextBox CurieC;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.TextBox CurieB;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.TextBox CurieA;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.Button CurieStart;
        private System.Windows.Forms.Panel SubParameters;
        private System.Windows.Forms.Panel MainParameters;
    }
}

