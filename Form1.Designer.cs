
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
            this.AllMeterPanel = new System.Windows.Forms.Panel();
            this.AllMeterStop = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AllMeterSlow = new System.Windows.Forms.Button();
            this.AllMeterFast = new System.Windows.Forms.Button();
            this.AllMeterSettings = new System.Windows.Forms.Panel();
            this.AllMeterStartFPanel = new System.Windows.Forms.Panel();
            this.AllMeterStartFLabel = new System.Windows.Forms.Label();
            this.AllMeterStartFDropBox = new System.Windows.Forms.ComboBox();
            this.AllMeterEndFPanel = new System.Windows.Forms.Panel();
            this.AllMeterEndFLabel = new System.Windows.Forms.Label();
            this.AllMeterEndFDropBox = new System.Windows.Forms.ComboBox();
            this.AllMeterSettingsLabel = new System.Windows.Forms.Label();
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
            this.TemperatureMeterPanel = new System.Windows.Forms.Panel();
            this.MeasuresTimer = new System.Windows.Forms.Timer(this.components);
            this.StartPanel.SuspendLayout();
            this.AllMeterPanel.SuspendLayout();
            this.AllMeterSettings.SuspendLayout();
            this.AllMeterStartFPanel.SuspendLayout();
            this.AllMeterEndFPanel.SuspendLayout();
            this.AllMeterModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllMeterButton
            // 
            this.AllMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterButton.Location = new System.Drawing.Point(267, 369);
            this.AllMeterButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterButton.Name = "AllMeterButton";
            this.AllMeterButton.Size = new System.Drawing.Size(200, 31);
            this.AllMeterButton.TabIndex = 0;
            this.AllMeterButton.Text = "AllMeter";
            this.AllMeterButton.UseVisualStyleBackColor = true;
            this.AllMeterButton.Click += new System.EventHandler(this.AllMeterButton_Click);
            // 
            // TemperatureMeterButton
            // 
            this.TemperatureMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureMeterButton.Location = new System.Drawing.Point(600, 369);
            this.TemperatureMeterButton.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureMeterButton.Name = "TemperatureMeterButton";
            this.TemperatureMeterButton.Size = new System.Drawing.Size(200, 31);
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
            this.StartPanel.Location = new System.Drawing.Point(56, 28);
            this.StartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(967, 41);
            this.StartPanel.TabIndex = 2;
            // 
            // AutoName
            // 
            this.AutoName.AutoSize = true;
            this.AutoName.BackColor = System.Drawing.SystemColors.Window;
            this.AutoName.Location = new System.Drawing.Point(727, 7);
            this.AutoName.Margin = new System.Windows.Forms.Padding(4);
            this.AutoName.Name = "AutoName";
            this.AutoName.Padding = new System.Windows.Forms.Padding(3, 4, 1, 2);
            this.AutoName.Size = new System.Drawing.Size(59, 26);
            this.AutoName.TabIndex = 4;
            this.AutoName.Text = "auto";
            this.AutoName.UseVisualStyleBackColor = false;
            this.AutoName.CheckedChanged += new System.EventHandler(this.AutoName_CheckedChanged);
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(587, 6);
            this.FileName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(132, 28);
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
            this.PortsList.Location = new System.Drawing.Point(800, 6);
            this.PortsList.Margin = new System.Windows.Forms.Padding(4);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(159, 28);
            this.PortsList.TabIndex = 2;
            this.PortsList.Text = "Choose the port";
            this.PortsList.DropDown += new System.EventHandler(this.FillThePorts);
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Enabled = false;
            this.DirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryPath.Location = new System.Drawing.Point(180, 7);
            this.DirectoryPath.Margin = new System.Windows.Forms.Padding(4);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(399, 26);
            this.DirectoryPath.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(7, 6);
            this.DirectoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(167, 31);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Change directory";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // AllMeterPanel
            // 
            this.AllMeterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.AllMeterPanel.Controls.Add(this.AllMeterStop);
            this.AllMeterPanel.Controls.Add(this.ReturnButton);
            this.AllMeterPanel.Controls.Add(this.AllMeterSlow);
            this.AllMeterPanel.Controls.Add(this.AllMeterFast);
            this.AllMeterPanel.Controls.Add(this.AllMeterSettings);
            this.AllMeterPanel.Controls.Add(this.AllMeterModes);
            this.AllMeterPanel.Location = new System.Drawing.Point(67, 92);
            this.AllMeterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterPanel.Name = "AllMeterPanel";
            this.AllMeterPanel.Size = new System.Drawing.Size(933, 233);
            this.AllMeterPanel.TabIndex = 3;
            // 
            // AllMeterStop
            // 
            this.AllMeterStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllMeterStop.BackColor = System.Drawing.Color.Salmon;
            this.AllMeterStop.Enabled = false;
            this.AllMeterStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStop.Location = new System.Drawing.Point(516, 178);
            this.AllMeterStop.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStop.Name = "AllMeterStop";
            this.AllMeterStop.Size = new System.Drawing.Size(133, 31);
            this.AllMeterStop.TabIndex = 5;
            this.AllMeterStop.Text = "Stop";
            this.AllMeterStop.UseVisualStyleBackColor = false;
            this.AllMeterStop.Click += new System.EventHandler(this.AllMeterStop_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Salmon;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(716, 178);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(133, 31);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AllMeterSlow
            // 
            this.AllMeterSlow.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSlow.Location = new System.Drawing.Point(316, 178);
            this.AllMeterSlow.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterSlow.Name = "AllMeterSlow";
            this.AllMeterSlow.Size = new System.Drawing.Size(133, 31);
            this.AllMeterSlow.TabIndex = 7;
            this.AllMeterSlow.Text = "Slow";
            this.AllMeterSlow.UseVisualStyleBackColor = false;
            this.AllMeterSlow.Click += new System.EventHandler(this.AllMeterSlow_Click);
            // 
            // AllMeterFast
            // 
            this.AllMeterFast.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFast.Location = new System.Drawing.Point(116, 178);
            this.AllMeterFast.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterFast.Name = "AllMeterFast";
            this.AllMeterFast.Size = new System.Drawing.Size(133, 31);
            this.AllMeterFast.TabIndex = 6;
            this.AllMeterFast.Text = "Fast";
            this.AllMeterFast.UseVisualStyleBackColor = false;
            this.AllMeterFast.Click += new System.EventHandler(this.AllMeterFast_Click);
            // 
            // AllMeterSettings
            // 
            this.AllMeterSettings.BackColor = System.Drawing.SystemColors.Info;
            this.AllMeterSettings.Controls.Add(this.AllMeterStartFPanel);
            this.AllMeterSettings.Controls.Add(this.AllMeterEndFPanel);
            this.AllMeterSettings.Controls.Add(this.AllMeterSettingsLabel);
            this.AllMeterSettings.Location = new System.Drawing.Point(33, 18);
            this.AllMeterSettings.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterSettings.Name = "AllMeterSettings";
            this.AllMeterSettings.Size = new System.Drawing.Size(434, 130);
            this.AllMeterSettings.TabIndex = 1;
            // 
            // AllMeterStartFPanel
            // 
            this.AllMeterStartFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFLabel);
            this.AllMeterStartFPanel.Controls.Add(this.AllMeterStartFDropBox);
            this.AllMeterStartFPanel.Location = new System.Drawing.Point(20, 80);
            this.AllMeterStartFPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStartFPanel.Name = "AllMeterStartFPanel";
            this.AllMeterStartFPanel.Size = new System.Drawing.Size(398, 37);
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
            this.AllMeterStartFDropBox.Location = new System.Drawing.Point(147, 5);
            this.AllMeterStartFDropBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterStartFDropBox.Name = "AllMeterStartFDropBox";
            this.AllMeterStartFDropBox.Size = new System.Drawing.Size(239, 28);
            this.AllMeterStartFDropBox.TabIndex = 18;
            this.AllMeterStartFDropBox.SelectionChangeCommitted += new System.EventHandler(this.AllMeterStartFDropBox_SelectedIndexChanged);
            // 
            // AllMeterEndFPanel
            // 
            this.AllMeterEndFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterEndFPanel.Controls.Add(this.AllMeterEndFLabel);
            this.AllMeterEndFPanel.Controls.Add(this.AllMeterEndFDropBox);
            this.AllMeterEndFPanel.Location = new System.Drawing.Point(20, 37);
            this.AllMeterEndFPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterEndFPanel.Name = "AllMeterEndFPanel";
            this.AllMeterEndFPanel.Size = new System.Drawing.Size(398, 37);
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
            this.AllMeterEndFDropBox.Location = new System.Drawing.Point(147, 4);
            this.AllMeterEndFDropBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterEndFDropBox.Name = "AllMeterEndFDropBox";
            this.AllMeterEndFDropBox.Size = new System.Drawing.Size(239, 28);
            this.AllMeterEndFDropBox.TabIndex = 18;
            this.AllMeterEndFDropBox.SelectionChangeCommitted += new System.EventHandler(this.AllMeterEndFDropBox_SelectedIndexChanged);
            // 
            // AllMeterSettingsLabel
            // 
            this.AllMeterSettingsLabel.AutoSize = true;
            this.AllMeterSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSettingsLabel.Location = new System.Drawing.Point(163, 6);
            this.AllMeterSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllMeterSettingsLabel.Name = "AllMeterSettingsLabel";
            this.AllMeterSettingsLabel.Size = new System.Drawing.Size(112, 20);
            this.AllMeterSettingsLabel.TabIndex = 17;
            this.AllMeterSettingsLabel.Text = "Initial settings";
            this.AllMeterSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AllMeterModes.Location = new System.Drawing.Point(499, 18);
            this.AllMeterModes.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterModes.Name = "AllMeterModes";
            this.AllMeterModes.Size = new System.Drawing.Size(400, 130);
            this.AllMeterModes.TabIndex = 0;
            // 
            // AllMeterModesLabel
            // 
            this.AllMeterModesLabel.AutoSize = true;
            this.AllMeterModesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterModesLabel.Location = new System.Drawing.Point(124, 6);
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
            this.AllMeterFi.Location = new System.Drawing.Point(220, 80);
            this.AllMeterFi.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterFi.Name = "AllMeterFi";
            this.AllMeterFi.Size = new System.Drawing.Size(40, 24);
            this.AllMeterFi.TabIndex = 15;
            this.AllMeterFi.Text = "fi";
            this.AllMeterFi.UseVisualStyleBackColor = true;
            // 
            // AllMeterQr
            // 
            this.AllMeterQr.AutoSize = true;
            this.AllMeterQr.Enabled = false;
            this.AllMeterQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQr.Location = new System.Drawing.Point(157, 75);
            this.AllMeterQr.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterQr.Name = "AllMeterQr";
            this.AllMeterQr.Size = new System.Drawing.Size(44, 24);
            this.AllMeterQr.TabIndex = 14;
            this.AllMeterQr.Text = "Q";
            this.AllMeterQr.UseVisualStyleBackColor = true;
            // 
            // AllMeterQl
            // 
            this.AllMeterQl.AutoSize = true;
            this.AllMeterQl.Enabled = false;
            this.AllMeterQl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQl.Location = new System.Drawing.Point(100, 74);
            this.AllMeterQl.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterQl.Name = "AllMeterQl";
            this.AllMeterQl.Size = new System.Drawing.Size(44, 24);
            this.AllMeterQl.TabIndex = 13;
            this.AllMeterQl.Text = "Q";
            this.AllMeterQl.UseVisualStyleBackColor = true;
            // 
            // AllMeterD
            // 
            this.AllMeterD.AutoSize = true;
            this.AllMeterD.Enabled = false;
            this.AllMeterD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterD.Location = new System.Drawing.Point(32, 76);
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
            this.AllMeterZ.Location = new System.Drawing.Point(220, 37);
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
            this.AllMeterR.Location = new System.Drawing.Point(157, 37);
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
            this.AllMeterL.Location = new System.Drawing.Point(99, 37);
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
            this.AllMeterC.Location = new System.Drawing.Point(33, 37);
            this.AllMeterC.Margin = new System.Windows.Forms.Padding(4);
            this.AllMeterC.Name = "AllMeterC";
            this.AllMeterC.Size = new System.Drawing.Size(43, 24);
            this.AllMeterC.TabIndex = 8;
            this.AllMeterC.Text = "C";
            this.AllMeterC.UseVisualStyleBackColor = true;
            this.AllMeterC.CheckedChanged += new System.EventHandler(this.AllMeterC_CheckedChanged);
            // 
            // TemperatureMeterPanel
            // 
            this.TemperatureMeterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TemperatureMeterPanel.Location = new System.Drawing.Point(67, 407);
            this.TemperatureMeterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureMeterPanel.Name = "TemperatureMeterPanel";
            this.TemperatureMeterPanel.Size = new System.Drawing.Size(933, 123);
            this.TemperatureMeterPanel.TabIndex = 4;
            // 
            // MeasuresTimer
            // 
            this.MeasuresTimer.Interval = 1000;
            this.MeasuresTimer.Tick += new System.EventHandler(this.MeasuresTimer_Tick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.TemperatureMeterPanel);
            this.Controls.Add(this.AllMeterPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.TemperatureMeterButton);
            this.Controls.Add(this.AllMeterButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Text = "E7-20";
            this.Load += new System.EventHandler(this.App_Load);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.AllMeterPanel.ResumeLayout(false);
            this.AllMeterSettings.ResumeLayout(false);
            this.AllMeterSettings.PerformLayout();
            this.AllMeterStartFPanel.ResumeLayout(false);
            this.AllMeterStartFPanel.PerformLayout();
            this.AllMeterEndFPanel.ResumeLayout(false);
            this.AllMeterEndFPanel.PerformLayout();
            this.AllMeterModes.ResumeLayout(false);
            this.AllMeterModes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AllMeterButton;
        private System.Windows.Forms.Button TemperatureMeterButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Panel AllMeterPanel;
        private System.Windows.Forms.Panel TemperatureMeterPanel;
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
        private System.Windows.Forms.Label AllMeterSettingsLabel;
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
    }
}

