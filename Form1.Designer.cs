
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
            this.TemperatureMeterButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.AutoName = new System.Windows.Forms.CheckBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.PortsList = new System.Windows.Forms.ComboBox();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.MeasurementSettings = new System.Windows.Forms.Panel();
            this.AllMeterStop = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AllMeterSlow = new System.Windows.Forms.Button();
            this.AllMeterFast = new System.Windows.Forms.Button();
            this.GeneralSettings = new System.Windows.Forms.Panel();
            this.AllMeterStartFPanel = new System.Windows.Forms.Panel();
            this.AllMeterStartFLabel = new System.Windows.Forms.Label();
            this.AllMeterStartFDropBox = new System.Windows.Forms.ComboBox();
            this.AllMeterEndFPanel = new System.Windows.Forms.Panel();
            this.AllMeterEndFLabel = new System.Windows.Forms.Label();
            this.AllMeterEndFDropBox = new System.Windows.Forms.ComboBox();
            this.GeneralSettingsLabel = new System.Windows.Forms.Label();
            this.MeasurementModes = new System.Windows.Forms.Panel();
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
            this.CuriePanel = new System.Windows.Forms.Panel();
            this.ControlButtonPanel = new System.Windows.Forms.Panel();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CurieLable = new System.Windows.Forms.Label();
            this.CurieCoefficientsPanel = new System.Windows.Forms.Panel();
            this.CurieCoefficientsLabel = new System.Windows.Forms.Label();
            this.LabelA = new System.Windows.Forms.Label();
            this.CurieA = new System.Windows.Forms.TextBox();
            this.CurieB = new System.Windows.Forms.TextBox();
            this.LabelB = new System.Windows.Forms.Label();
            this.CurieC = new System.Windows.Forms.TextBox();
            this.LabelC = new System.Windows.Forms.Label();
            this.CurieD = new System.Windows.Forms.TextBox();
            this.LabelD = new System.Windows.Forms.Label();
            this.StartPanel.SuspendLayout();
            this.MeasurementSettings.SuspendLayout();
            this.GeneralSettings.SuspendLayout();
            this.AllMeterStartFPanel.SuspendLayout();
            this.AllMeterEndFPanel.SuspendLayout();
            this.MeasurementModes.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.CuriePanel.SuspendLayout();
            this.ControlButtonPanel.SuspendLayout();
            this.CurieCoefficientsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllMeterButton
            // 
            this.AllMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterButton.Location = new System.Drawing.Point(200, 350);
            this.AllMeterButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterButton.Name = "AllMeterButton";
            this.AllMeterButton.Size = new System.Drawing.Size(200, 40);
            this.AllMeterButton.TabIndex = 0;
            this.AllMeterButton.Text = "AllMeter";
            this.AllMeterButton.UseVisualStyleBackColor = true;
            this.AllMeterButton.Click += new System.EventHandler(this.AllMeterButton_Click);
            // 
            // TemperatureMeterButton
            // 
            this.TemperatureMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureMeterButton.Location = new System.Drawing.Point(550, 350);
            this.TemperatureMeterButton.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureMeterButton.Name = "TemperatureMeterButton";
            this.TemperatureMeterButton.Size = new System.Drawing.Size(200, 40);
            this.TemperatureMeterButton.TabIndex = 1;
            this.TemperatureMeterButton.Text = "TemperatureMeter";
            this.TemperatureMeterButton.UseVisualStyleBackColor = true;
            this.TemperatureMeterButton.Click += new System.EventHandler(this.TemperatureMeterButton_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartPanel.Controls.Add(this.AutoName);
            this.StartPanel.Controls.Add(this.FileName);
            this.StartPanel.Controls.Add(this.PortsList);
            this.StartPanel.Controls.Add(this.DirectoryPath);
            this.StartPanel.Controls.Add(this.DirectoryButton);
            this.StartPanel.Location = new System.Drawing.Point(50, 25);
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
            this.FileName.Location = new System.Drawing.Point(110, 10);
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
            this.DirectoryPath.Size = new System.Drawing.Size(650, 26);
            this.DirectoryPath.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(25, 59);
            this.DirectoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(190, 32);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Change directory";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // MeasurementSettings
            // 
            this.MeasurementSettings.BackColor = System.Drawing.SystemColors.Window;
            this.MeasurementSettings.Controls.Add(this.CurieCoefficientsPanel);
            this.MeasurementSettings.Controls.Add(this.CuriePanel);
            this.MeasurementSettings.Controls.Add(this.GeneralSettings);
            this.MeasurementSettings.Location = new System.Drawing.Point(50, 150);
            this.MeasurementSettings.Margin = new System.Windows.Forms.Padding(4);
            this.MeasurementSettings.Name = "MeasurementSettings";
            this.MeasurementSettings.Size = new System.Drawing.Size(900, 200);
            this.MeasurementSettings.TabIndex = 3;
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
            this.AllMeterStop.Size = new System.Drawing.Size(150, 40);
            this.AllMeterStop.TabIndex = 5;
            this.AllMeterStop.Text = "Stop";
            this.AllMeterStop.UseVisualStyleBackColor = false;
            this.AllMeterStop.Click += new System.EventHandler(this.AllMeterStop_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Salmon;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(700, 10);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(150, 40);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AllMeterSlow
            // 
            this.AllMeterSlow.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSlow.Location = new System.Drawing.Point(250, 10);
            this.AllMeterSlow.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterSlow.Name = "AllMeterSlow";
            this.AllMeterSlow.Size = new System.Drawing.Size(150, 40);
            this.AllMeterSlow.TabIndex = 7;
            this.AllMeterSlow.Text = "Slow";
            this.AllMeterSlow.UseVisualStyleBackColor = false;
            this.AllMeterSlow.Click += new System.EventHandler(this.AllMeterSlow_Click);
            // 
            // AllMeterFast
            // 
            this.AllMeterFast.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFast.Location = new System.Drawing.Point(50, 10);
            this.AllMeterFast.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterFast.Name = "AllMeterFast";
            this.AllMeterFast.Size = new System.Drawing.Size(150, 40);
            this.AllMeterFast.TabIndex = 6;
            this.AllMeterFast.Text = "Fast";
            this.AllMeterFast.UseVisualStyleBackColor = false;
            this.AllMeterFast.Click += new System.EventHandler(this.AllMeterFast_Click);
            // 
            // GeneralSettings
            // 
            this.GeneralSettings.BackColor = System.Drawing.SystemColors.Info;
            this.GeneralSettings.Controls.Add(this.AllMeterStartFPanel);
            this.GeneralSettings.Controls.Add(this.AllMeterEndFPanel);
            this.GeneralSettings.Controls.Add(this.GeneralSettingsLabel);
            this.GeneralSettings.Location = new System.Drawing.Point(25, 25);
            this.GeneralSettings.Margin = new System.Windows.Forms.Padding(4);
            this.GeneralSettings.Name = "GeneralSettings";
            this.GeneralSettings.Size = new System.Drawing.Size(400, 150);
            this.GeneralSettings.TabIndex = 0;
            this.GeneralSettings.Visible = false;
            // 
            // AllMeterStartFPanel
            // 
            this.AllMeterStartFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFLabel);
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFDropBox);
            this.AllMeterStartFPanel.Location = new System.Drawing.Point(25, 100);
            this.AllMeterStartFPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStartFPanel.Name = "AllMeterStartFPanel";
            this.AllMeterStartFPanel.Size = new System.Drawing.Size(350, 37);
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
            this.AllMeterStartFDropBox.Location = new System.Drawing.Point(150, 5);
            this.AllMeterStartFDropBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStartFDropBox.Name = "AllMeterStartFDropBox";
            this.AllMeterStartFDropBox.Size = new System.Drawing.Size(185, 28);
            this.AllMeterStartFDropBox.TabIndex = 18;
            this.AllMeterStartFDropBox.SelectionChangeCommitted += new System.EventHandler(this.AllMeterStartFDropBox_SelectedIndexChanged);
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
            this.AllMeterEndFDropBox.Location = new System.Drawing.Point(150, 5);
            this.AllMeterEndFDropBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterEndFDropBox.Name = "AllMeterEndFDropBox";
            this.AllMeterEndFDropBox.Size = new System.Drawing.Size(185, 28);
            this.AllMeterEndFDropBox.TabIndex = 18;
            this.AllMeterEndFDropBox.SelectionChangeCommitted += new System.EventHandler(this.AllMeterEndFDropBox_SelectedIndexChanged);
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
            // MeasurementModes
            // 
            this.MeasurementModes.BackColor = System.Drawing.SystemColors.Info;
            this.MeasurementModes.Controls.Add(this.AllMeterModesLabel);
            this.MeasurementModes.Controls.Add(this.AllMeterFi);
            this.MeasurementModes.Controls.Add(this.AllMeterQr);
            this.MeasurementModes.Controls.Add(this.AllMeterQl);
            this.MeasurementModes.Controls.Add(this.AllMeterD);
            this.MeasurementModes.Controls.Add(this.AllMeterZ);
            this.MeasurementModes.Controls.Add(this.AllMeterR);
            this.MeasurementModes.Controls.Add(this.AllMeterL);
            this.MeasurementModes.Controls.Add(this.AllMeterC);
            this.MeasurementModes.Location = new System.Drawing.Point(525, 175);
            this.MeasurementModes.Margin = new System.Windows.Forms.Padding(4);
            this.MeasurementModes.Name = "MeasurementModes";
            this.MeasurementModes.Size = new System.Drawing.Size(400, 150);
            this.MeasurementModes.TabIndex = 0;
            this.MeasurementModes.Visible = false;
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
            // AllMeterFi
            // 
            this.AllMeterFi.AutoSize = true;
            this.AllMeterFi.Enabled = false;
            this.AllMeterFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFi.Location = new System.Drawing.Point(275, 100);
            this.AllMeterFi.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterFi.Name = "AllMeterFi";
            this.AllMeterFi.Size = new System.Drawing.Size(45, 24);
            this.AllMeterFi.TabIndex = 15;
            this.AllMeterFi.Text = "Fi";
            this.AllMeterFi.UseVisualStyleBackColor = true;
            // 
            // AllMeterQr
            // 
            this.AllMeterQr.AutoSize = true;
            this.AllMeterQr.Enabled = false;
            this.AllMeterQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQr.Location = new System.Drawing.Point(200, 100);
            this.AllMeterQr.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterQr.Name = "AllMeterQr";
            this.AllMeterQr.Size = new System.Drawing.Size(50, 24);
            this.AllMeterQr.TabIndex = 14;
            this.AllMeterQr.Text = "Qr";
            this.AllMeterQr.UseVisualStyleBackColor = true;
            // 
            // AllMeterQl
            // 
            this.AllMeterQl.AutoSize = true;
            this.AllMeterQl.Enabled = false;
            this.AllMeterQl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQl.Location = new System.Drawing.Point(125, 100);
            this.AllMeterQl.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterQl.Name = "AllMeterQl";
            this.AllMeterQl.Size = new System.Drawing.Size(48, 24);
            this.AllMeterQl.TabIndex = 13;
            this.AllMeterQl.Text = "Ql";
            this.AllMeterQl.UseVisualStyleBackColor = true;
            // 
            // AllMeterD
            // 
            this.AllMeterD.AutoSize = true;
            this.AllMeterD.Enabled = false;
            this.AllMeterD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterD.Location = new System.Drawing.Point(50, 100);
            this.AllMeterD.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterD.Name = "AllMeterD";
            this.AllMeterD.Size = new System.Drawing.Size(44, 24);
            this.AllMeterD.TabIndex = 12;
            this.AllMeterD.Text = "D";
            this.AllMeterD.UseVisualStyleBackColor = true;
            // 
            // AllMeterZ
            // 
            this.AllMeterZ.AutoSize = true;
            this.AllMeterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterZ.Location = new System.Drawing.Point(275, 50);
            this.AllMeterZ.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterZ.Name = "AllMeterZ";
            this.AllMeterZ.Size = new System.Drawing.Size(40, 24);
            this.AllMeterZ.TabIndex = 11;
            this.AllMeterZ.Text = "Z";
            this.AllMeterZ.UseVisualStyleBackColor = true;
            this.AllMeterZ.CheckedChanged += new System.EventHandler(this.AllMeterZ_CheckedChanged);
            // 
            // AllMeterR
            // 
            this.AllMeterR.AutoSize = true;
            this.AllMeterR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterR.Location = new System.Drawing.Point(200, 50);
            this.AllMeterR.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterR.Name = "AllMeterR";
            this.AllMeterR.Size = new System.Drawing.Size(43, 24);
            this.AllMeterR.TabIndex = 10;
            this.AllMeterR.Text = "R";
            this.AllMeterR.UseVisualStyleBackColor = true;
            this.AllMeterR.CheckedChanged += new System.EventHandler(this.AllMeterR_CheckedChanged);
            // 
            // AllMeterL
            // 
            this.AllMeterL.AutoSize = true;
            this.AllMeterL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterL.Location = new System.Drawing.Point(125, 50);
            this.AllMeterL.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterL.Name = "AllMeterL";
            this.AllMeterL.Size = new System.Drawing.Size(41, 24);
            this.AllMeterL.TabIndex = 9;
            this.AllMeterL.Text = "L";
            this.AllMeterL.UseVisualStyleBackColor = true;
            this.AllMeterL.CheckedChanged += new System.EventHandler(this.AllMeterL_CheckedChanged);
            // 
            // AllMeterC
            // 
            this.AllMeterC.AutoSize = true;
            this.AllMeterC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterC.Location = new System.Drawing.Point(50, 50);
            this.AllMeterC.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterC.Name = "AllMeterC";
            this.AllMeterC.Size = new System.Drawing.Size(43, 24);
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
            this.ProgressPanel.Location = new System.Drawing.Point(50, 400);
            this.ProgressPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(900, 125);
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
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.Size = new System.Drawing.Size(150, 32);
            this.EstimatedTime.TabIndex = 2;
            this.EstimatedTime.Text = "s";
            this.EstimatedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(25, 70);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(850, 40);
            this.ProgressBar.TabIndex = 0;
            // 
            // MeasuresTimer
            // 
            this.MeasuresTimer.Interval = 1000;
            this.MeasuresTimer.Tick += new System.EventHandler(this.MeasuresTimer_Tick);
            // 
            // CuriePanel
            // 
            this.CuriePanel.BackColor = System.Drawing.SystemColors.Info;
            this.CuriePanel.Controls.Add(this.CurieLable);
            this.CuriePanel.Controls.Add(this.Amount);
            this.CuriePanel.Controls.Add(this.AmountLabel);
            this.CuriePanel.Controls.Add(this.Interval);
            this.CuriePanel.Controls.Add(this.IntervalLabel);
            this.CuriePanel.Location = new System.Drawing.Point(25, 25);
            this.CuriePanel.Name = "CuriePanel";
            this.CuriePanel.Size = new System.Drawing.Size(400, 150);
            this.CuriePanel.TabIndex = 8;
            this.CuriePanel.Visible = false;
            // 
            // ControlButtonPanel
            // 
            this.ControlButtonPanel.Controls.Add(this.ReturnButton);
            this.ControlButtonPanel.Controls.Add(this.AllMeterStop);
            this.ControlButtonPanel.Controls.Add(this.AllMeterFast);
            this.ControlButtonPanel.Controls.Add(this.AllMeterSlow);
            this.ControlButtonPanel.Location = new System.Drawing.Point(50, 350);
            this.ControlButtonPanel.Name = "ControlButtonPanel";
            this.ControlButtonPanel.Size = new System.Drawing.Size(900, 60);
            this.ControlButtonPanel.TabIndex = 9;
            this.ControlButtonPanel.Visible = false;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalLabel.Location = new System.Drawing.Point(25, 50);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(195, 22);
            this.IntervalLabel.TabIndex = 0;
            this.IntervalLabel.Text = "Interval label (seconds)";
            // 
            // Interval
            // 
            this.Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Interval.Location = new System.Drawing.Point(250, 50);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(125, 28);
            this.Interval.TabIndex = 1;
            this.Interval.Text = "10";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(250, 100);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(125, 28);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "10";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(25, 100);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(213, 22);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount of measurements";
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
            this.CurieCoefficientsPanel.Location = new System.Drawing.Point(475, 25);
            this.CurieCoefficientsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CurieCoefficientsPanel.Name = "CurieCoefficientsPanel";
            this.CurieCoefficientsPanel.Size = new System.Drawing.Size(400, 150);
            this.CurieCoefficientsPanel.TabIndex = 17;
            this.CurieCoefficientsPanel.Visible = false;
            // 
            // CurieCoefficientsLabel
            // 
            this.CurieCoefficientsLabel.AutoSize = true;
            this.CurieCoefficientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieCoefficientsLabel.Location = new System.Drawing.Point(130, 10);
            this.CurieCoefficientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurieCoefficientsLabel.Name = "CurieCoefficientsLabel";
            this.CurieCoefficientsLabel.Size = new System.Drawing.Size(140, 20);
            this.CurieCoefficientsLabel.TabIndex = 16;
            this.CurieCoefficientsLabel.Text = "Curie coefficients";
            this.CurieCoefficientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelA.Location = new System.Drawing.Point(65, 50);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(22, 22);
            this.LabelA.TabIndex = 17;
            this.LabelA.Text = "A";
            // 
            // CurieA
            // 
            this.CurieA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieA.Location = new System.Drawing.Point(50, 100);
            this.CurieA.Name = "CurieA";
            this.CurieA.Size = new System.Drawing.Size(50, 28);
            this.CurieA.TabIndex = 18;
            this.CurieA.Text = "1";
            this.CurieA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurieB
            // 
            this.CurieB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieB.Location = new System.Drawing.Point(130, 100);
            this.CurieB.Name = "CurieB";
            this.CurieB.Size = new System.Drawing.Size(50, 28);
            this.CurieB.TabIndex = 20;
            this.CurieB.Text = "1";
            this.CurieB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB.Location = new System.Drawing.Point(145, 50);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(22, 22);
            this.LabelB.TabIndex = 19;
            this.LabelB.Text = "B";
            // 
            // CurieC
            // 
            this.CurieC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieC.Location = new System.Drawing.Point(210, 100);
            this.CurieC.Name = "CurieC";
            this.CurieC.Size = new System.Drawing.Size(50, 28);
            this.CurieC.TabIndex = 22;
            this.CurieC.Text = "1";
            this.CurieC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelC.Location = new System.Drawing.Point(225, 50);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(23, 22);
            this.LabelC.TabIndex = 21;
            this.LabelC.Text = "C";
            // 
            // CurieD
            // 
            this.CurieD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurieD.Location = new System.Drawing.Point(290, 100);
            this.CurieD.Name = "CurieD";
            this.CurieD.Size = new System.Drawing.Size(50, 28);
            this.CurieD.TabIndex = 24;
            this.CurieD.Text = "1";
            this.CurieD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelD.Location = new System.Drawing.Point(305, 50);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(23, 22);
            this.LabelD.TabIndex = 23;
            this.LabelD.Text = "D";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.TemperatureMeterButton);
            this.Controls.Add(this.AllMeterButton);
            this.Controls.Add(this.ControlButtonPanel);
            this.Controls.Add(this.MeasurementSettings);
            this.Controls.Add(this.MeasurementModes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Text = "E7-20";
            this.Load += new System.EventHandler(this.App_Load);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.MeasurementSettings.ResumeLayout(false);
            this.GeneralSettings.ResumeLayout(false);
            this.GeneralSettings.PerformLayout();
            this.AllMeterStartFPanel.ResumeLayout(false);
            this.AllMeterStartFPanel.PerformLayout();
            this.AllMeterEndFPanel.ResumeLayout(false);
            this.AllMeterEndFPanel.PerformLayout();
            this.MeasurementModes.ResumeLayout(false);
            this.MeasurementModes.PerformLayout();
            this.ProgressPanel.ResumeLayout(false);
            this.ProgressPanel.PerformLayout();
            this.CuriePanel.ResumeLayout(false);
            this.CuriePanel.PerformLayout();
            this.ControlButtonPanel.ResumeLayout(false);
            this.CurieCoefficientsPanel.ResumeLayout(false);
            this.CurieCoefficientsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AllMeterButton;
        private System.Windows.Forms.Button TemperatureMeterButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Panel MeasurementSettings;
        private System.Windows.Forms.Panel ProgressPanel;
        private System.Windows.Forms.ComboBox PortsList;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Panel MeasurementModes;
        private System.Windows.Forms.CheckBox AllMeterZ;
        private System.Windows.Forms.CheckBox AllMeterR;
        private System.Windows.Forms.CheckBox AllMeterL;
        private System.Windows.Forms.CheckBox AllMeterC;
        private System.Windows.Forms.Panel GeneralSettings;
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
        private System.Windows.Forms.Panel CuriePanel;
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
    }
}

