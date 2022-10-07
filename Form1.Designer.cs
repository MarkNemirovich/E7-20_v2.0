
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
            this.AllMeterButton = new System.Windows.Forms.Button();
            this.TemperatureMeterButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.FileName = new System.Windows.Forms.TextBox();
            this.PortsList = new System.Windows.Forms.ComboBox();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.AllMeterPanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AllMeterSlow = new System.Windows.Forms.Button();
            this.AllMeterSavingPanel = new System.Windows.Forms.Panel();
            this.AllMeterSavingLabel = new System.Windows.Forms.Label();
            this.AllMeterStandardDeviation = new System.Windows.Forms.CheckBox();
            this.AllMeterMaxValue = new System.Windows.Forms.CheckBox();
            this.AllMeterMinValue = new System.Windows.Forms.CheckBox();
            this.AllMeterAverageValue = new System.Windows.Forms.CheckBox();
            this.AllMeterFast = new System.Windows.Forms.Button();
            this.AllMeterSettings = new System.Windows.Forms.Panel();
            this.AllMeterMeasurementsPanel = new System.Windows.Forms.Panel();
            this.AllMeterMeasurements = new System.Windows.Forms.TextBox();
            this.AllMeterMeasurementsBar = new System.Windows.Forms.TrackBar();
            this.AllMeterMeasurementsLabel = new System.Windows.Forms.Label();
            this.MinFPanel = new System.Windows.Forms.Panel();
            this.AllMeterMinFLabel = new System.Windows.Forms.Label();
            this.AllMeterMinFDropBox = new System.Windows.Forms.ComboBox();
            this.MaxFPanel = new System.Windows.Forms.Panel();
            this.AllMeterMaxFLabel = new System.Windows.Forms.Label();
            this.AllMeterMaxFDropBox = new System.Windows.Forms.ComboBox();
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
            this.StartPanel.SuspendLayout();
            this.AllMeterPanel.SuspendLayout();
            this.AllMeterSavingPanel.SuspendLayout();
            this.AllMeterSettings.SuspendLayout();
            this.AllMeterMeasurementsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllMeterMeasurementsBar)).BeginInit();
            this.MinFPanel.SuspendLayout();
            this.MaxFPanel.SuspendLayout();
            this.AllMeterModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllMeterButton
            // 
            this.AllMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterButton.Location = new System.Drawing.Point(200, 300);
            this.AllMeterButton.Name = "AllMeterButton";
            this.AllMeterButton.Size = new System.Drawing.Size(150, 25);
            this.AllMeterButton.TabIndex = 0;
            this.AllMeterButton.Text = "AllMeter";
            this.AllMeterButton.UseVisualStyleBackColor = true;
            this.AllMeterButton.Click += new System.EventHandler(this.AllMeterButton_Click);
            // 
            // TemperatureMeterButton
            // 
            this.TemperatureMeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureMeterButton.Location = new System.Drawing.Point(450, 300);
            this.TemperatureMeterButton.Name = "TemperatureMeterButton";
            this.TemperatureMeterButton.Size = new System.Drawing.Size(150, 25);
            this.TemperatureMeterButton.TabIndex = 1;
            this.TemperatureMeterButton.Text = "TemperatureMeter";
            this.TemperatureMeterButton.UseVisualStyleBackColor = true;
            this.TemperatureMeterButton.Click += new System.EventHandler(this.TemperatureMeterButton_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartPanel.Controls.Add(this.FileName);
            this.StartPanel.Controls.Add(this.PortsList);
            this.StartPanel.Controls.Add(this.DirectoryPath);
            this.StartPanel.Controls.Add(this.DirectoryButton);
            this.StartPanel.Location = new System.Drawing.Point(42, 23);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(725, 33);
            this.StartPanel.TabIndex = 2;
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(400, 5);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(150, 22);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "Write the file name";
            // 
            // PortsList
            // 
            this.PortsList.DropDownHeight = 100;
            this.PortsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortsList.FormattingEnabled = true;
            this.PortsList.IntegralHeight = false;
            this.PortsList.ItemHeight = 16;
            this.PortsList.Location = new System.Drawing.Point(600, 5);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(120, 24);
            this.PortsList.TabIndex = 2;
            this.PortsList.Text = "Choose the port";
            this.PortsList.SelectedIndexChanged += new System.EventHandler(this.PortsList_SelectedIndexChanged);
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Enabled = false;
            this.DirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryPath.Location = new System.Drawing.Point(160, 6);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(200, 22);
            this.DirectoryPath.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(5, 5);
            this.DirectoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(150, 25);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Change directory";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // AllMeterPanel
            // 
            this.AllMeterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.AllMeterPanel.Controls.Add(this.ReturnButton);
            this.AllMeterPanel.Controls.Add(this.AllMeterSlow);
            this.AllMeterPanel.Controls.Add(this.AllMeterSavingPanel);
            this.AllMeterPanel.Controls.Add(this.AllMeterFast);
            this.AllMeterPanel.Controls.Add(this.AllMeterSettings);
            this.AllMeterPanel.Controls.Add(this.AllMeterModes);
            this.AllMeterPanel.Location = new System.Drawing.Point(50, 75);
            this.AllMeterPanel.Name = "AllMeterPanel";
            this.AllMeterPanel.Size = new System.Drawing.Size(700, 230);
            this.AllMeterPanel.TabIndex = 3;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Salmon;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(500, 200);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(100, 25);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AllMeterSlow
            // 
            this.AllMeterSlow.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSlow.Location = new System.Drawing.Point(300, 200);
            this.AllMeterSlow.Name = "AllMeterSlow";
            this.AllMeterSlow.Size = new System.Drawing.Size(100, 25);
            this.AllMeterSlow.TabIndex = 7;
            this.AllMeterSlow.Text = "Slow";
            this.AllMeterSlow.UseVisualStyleBackColor = false;
            this.AllMeterSlow.Click += new System.EventHandler(this.AllMeterSlow_Click);
            // 
            // AllMeterSavingPanel
            // 
            this.AllMeterSavingPanel.BackColor = System.Drawing.SystemColors.Info;
            this.AllMeterSavingPanel.Controls.Add(this.AllMeterSavingLabel);
            this.AllMeterSavingPanel.Controls.Add(this.AllMeterStandardDeviation);
            this.AllMeterSavingPanel.Controls.Add(this.AllMeterMaxValue);
            this.AllMeterSavingPanel.Controls.Add(this.AllMeterMinValue);
            this.AllMeterSavingPanel.Controls.Add(this.AllMeterAverageValue);
            this.AllMeterSavingPanel.Location = new System.Drawing.Point(475, 25);
            this.AllMeterSavingPanel.Name = "AllMeterSavingPanel";
            this.AllMeterSavingPanel.Size = new System.Drawing.Size(200, 150);
            this.AllMeterSavingPanel.TabIndex = 17;
            // 
            // AllMeterSavingLabel
            // 
            this.AllMeterSavingLabel.AutoSize = true;
            this.AllMeterSavingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSavingLabel.Location = new System.Drawing.Point(50, 5);
            this.AllMeterSavingLabel.Name = "AllMeterSavingLabel";
            this.AllMeterSavingLabel.Size = new System.Drawing.Size(122, 16);
            this.AllMeterSavingLabel.TabIndex = 16;
            this.AllMeterSavingLabel.Text = "Saving parameters";
            this.AllMeterSavingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllMeterStandardDeviation
            // 
            this.AllMeterStandardDeviation.AutoSize = true;
            this.AllMeterStandardDeviation.Enabled = false;
            this.AllMeterStandardDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterStandardDeviation.Location = new System.Drawing.Point(25, 120);
            this.AllMeterStandardDeviation.Name = "AllMeterStandardDeviation";
            this.AllMeterStandardDeviation.Size = new System.Drawing.Size(139, 20);
            this.AllMeterStandardDeviation.TabIndex = 11;
            this.AllMeterStandardDeviation.Text = "StandardDeviation";
            this.AllMeterStandardDeviation.UseVisualStyleBackColor = true;
            this.AllMeterStandardDeviation.CheckedChanged += new System.EventHandler(this.AllMeterStandardDeviation_CheckedChanged);
            // 
            // AllMeterMaxValue
            // 
            this.AllMeterMaxValue.AutoSize = true;
            this.AllMeterMaxValue.Enabled = false;
            this.AllMeterMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMaxValue.Location = new System.Drawing.Point(25, 60);
            this.AllMeterMaxValue.Name = "AllMeterMaxValue";
            this.AllMeterMaxValue.Size = new System.Drawing.Size(87, 20);
            this.AllMeterMaxValue.TabIndex = 10;
            this.AllMeterMaxValue.Text = "MaxValue";
            this.AllMeterMaxValue.UseVisualStyleBackColor = true;
            this.AllMeterMaxValue.CheckedChanged += new System.EventHandler(this.AllMeterMaxValue_CheckedChanged);
            // 
            // AllMeterMinValue
            // 
            this.AllMeterMinValue.AutoSize = true;
            this.AllMeterMinValue.Enabled = false;
            this.AllMeterMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMinValue.Location = new System.Drawing.Point(25, 90);
            this.AllMeterMinValue.Name = "AllMeterMinValue";
            this.AllMeterMinValue.Size = new System.Drawing.Size(83, 20);
            this.AllMeterMinValue.TabIndex = 9;
            this.AllMeterMinValue.Text = "MinValue";
            this.AllMeterMinValue.UseVisualStyleBackColor = true;
            this.AllMeterMinValue.CheckedChanged += new System.EventHandler(this.AllMeterMinValue_CheckedChanged);
            // 
            // AllMeterAverageValue
            // 
            this.AllMeterAverageValue.AutoSize = true;
            this.AllMeterAverageValue.Checked = true;
            this.AllMeterAverageValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllMeterAverageValue.Enabled = false;
            this.AllMeterAverageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterAverageValue.Location = new System.Drawing.Point(25, 30);
            this.AllMeterAverageValue.Name = "AllMeterAverageValue";
            this.AllMeterAverageValue.Size = new System.Drawing.Size(114, 20);
            this.AllMeterAverageValue.TabIndex = 8;
            this.AllMeterAverageValue.Text = "AverageValue";
            this.AllMeterAverageValue.UseVisualStyleBackColor = true;
            // 
            // AllMeterFast
            // 
            this.AllMeterFast.BackColor = System.Drawing.Color.PaleGreen;
            this.AllMeterFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFast.Location = new System.Drawing.Point(100, 200);
            this.AllMeterFast.Name = "AllMeterFast";
            this.AllMeterFast.Size = new System.Drawing.Size(100, 25);
            this.AllMeterFast.TabIndex = 6;
            this.AllMeterFast.Text = "Fast";
            this.AllMeterFast.UseVisualStyleBackColor = false;
            this.AllMeterFast.Click += new System.EventHandler(this.AllMeterFast_Click);
            // 
            // AllMeterSettings
            // 
            this.AllMeterSettings.BackColor = System.Drawing.SystemColors.Info;
            this.AllMeterSettings.Controls.Add(this.AllMeterMeasurementsPanel);
            this.AllMeterSettings.Controls.Add(this.MinFPanel);
            this.AllMeterSettings.Controls.Add(this.MaxFPanel);
            this.AllMeterSettings.Controls.Add(this.AllMeterSettingsLabel);
            this.AllMeterSettings.Location = new System.Drawing.Point(25, 15);
            this.AllMeterSettings.Name = "AllMeterSettings";
            this.AllMeterSettings.Size = new System.Drawing.Size(250, 170);
            this.AllMeterSettings.TabIndex = 1;
            // 
            // AllMeterMeasurementsPanel
            // 
            this.AllMeterMeasurementsPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.AllMeterMeasurementsPanel.Controls.Add(this.AllMeterMeasurements);
            this.AllMeterMeasurementsPanel.Controls.Add(this.AllMeterMeasurementsBar);
            this.AllMeterMeasurementsPanel.Controls.Add(this.AllMeterMeasurementsLabel);
            this.AllMeterMeasurementsPanel.Location = new System.Drawing.Point(15, 100);
            this.AllMeterMeasurementsPanel.Name = "AllMeterMeasurementsPanel";
            this.AllMeterMeasurementsPanel.Size = new System.Drawing.Size(220, 55);
            this.AllMeterMeasurementsPanel.TabIndex = 20;
            // 
            // AllMeterMeasurements
            // 
            this.AllMeterMeasurements.Enabled = false;
            this.AllMeterMeasurements.Location = new System.Drawing.Point(60, 30);
            this.AllMeterMeasurements.Name = "AllMeterMeasurements";
            this.AllMeterMeasurements.Size = new System.Drawing.Size(40, 20);
            this.AllMeterMeasurements.TabIndex = 21;
            // 
            // AllMeterMeasurementsBar
            // 
            this.AllMeterMeasurementsBar.BackColor = System.Drawing.Color.GreenYellow;
            this.AllMeterMeasurementsBar.Location = new System.Drawing.Point(115, 5);
            this.AllMeterMeasurementsBar.Minimum = 1;
            this.AllMeterMeasurementsBar.Name = "AllMeterMeasurementsBar";
            this.AllMeterMeasurementsBar.Size = new System.Drawing.Size(100, 45);
            this.AllMeterMeasurementsBar.TabIndex = 20;
            this.AllMeterMeasurementsBar.Value = 1;
            this.AllMeterMeasurementsBar.Scroll += new System.EventHandler(this.AllMeterMeasurementsBar_Scroll);
            // 
            // AllMeterMeasurementsLabel
            // 
            this.AllMeterMeasurementsLabel.AutoSize = true;
            this.AllMeterMeasurementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMeasurementsLabel.Location = new System.Drawing.Point(5, 5);
            this.AllMeterMeasurementsLabel.Name = "AllMeterMeasurementsLabel";
            this.AllMeterMeasurementsLabel.Size = new System.Drawing.Size(97, 16);
            this.AllMeterMeasurementsLabel.TabIndex = 19;
            this.AllMeterMeasurementsLabel.Text = "Measurements";
            // 
            // MinFPanel
            // 
            this.MinFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.MinFPanel.Controls.Add(this.AllMeterMinFLabel);
            this.MinFPanel.Controls.Add(this.AllMeterMinFDropBox);
            this.MinFPanel.Location = new System.Drawing.Point(15, 65);
            this.MinFPanel.Name = "MinFPanel";
            this.MinFPanel.Size = new System.Drawing.Size(220, 30);
            this.MinFPanel.TabIndex = 20;
            // 
            // AllMeterMinFLabel
            // 
            this.AllMeterMinFLabel.AutoSize = true;
            this.AllMeterMinFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMinFLabel.Location = new System.Drawing.Point(5, 7);
            this.AllMeterMinFLabel.Name = "AllMeterMinFLabel";
            this.AllMeterMinFLabel.Size = new System.Drawing.Size(91, 16);
            this.AllMeterMinFLabel.TabIndex = 19;
            this.AllMeterMinFLabel.Text = "Min frequency";
            // 
            // AllMeterMinFDropBox
            // 
            this.AllMeterMinFDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMinFDropBox.FormattingEnabled = true;
            this.AllMeterMinFDropBox.Location = new System.Drawing.Point(100, 3);
            this.AllMeterMinFDropBox.Name = "AllMeterMinFDropBox";
            this.AllMeterMinFDropBox.Size = new System.Drawing.Size(115, 24);
            this.AllMeterMinFDropBox.TabIndex = 18;
            this.AllMeterMinFDropBox.SelectionChangeCommitted += new System.EventHandler(this.AllMeterMinFDropBox_SelectedIndexChanged);
            // 
            // MaxFPanel
            // 
            this.MaxFPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.MaxFPanel.Controls.Add(this.AllMeterMaxFLabel);
            this.MaxFPanel.Controls.Add(this.AllMeterMaxFDropBox);
            this.MaxFPanel.Location = new System.Drawing.Point(15, 30);
            this.MaxFPanel.Name = "MaxFPanel";
            this.MaxFPanel.Size = new System.Drawing.Size(220, 30);
            this.MaxFPanel.TabIndex = 19;
            // 
            // AllMeterMaxFLabel
            // 
            this.AllMeterMaxFLabel.AutoSize = true;
            this.AllMeterMaxFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMaxFLabel.Location = new System.Drawing.Point(5, 7);
            this.AllMeterMaxFLabel.Name = "AllMeterMaxFLabel";
            this.AllMeterMaxFLabel.Size = new System.Drawing.Size(95, 16);
            this.AllMeterMaxFLabel.TabIndex = 19;
            this.AllMeterMaxFLabel.Text = "Max frequency";
            // 
            // AllMeterMaxFDropBox
            // 
            this.AllMeterMaxFDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterMaxFDropBox.FormattingEnabled = true;
            this.AllMeterMaxFDropBox.Location = new System.Drawing.Point(100, 3);
            this.AllMeterMaxFDropBox.Name = "AllMeterMaxFDropBox";
            this.AllMeterMaxFDropBox.Size = new System.Drawing.Size(115, 24);
            this.AllMeterMaxFDropBox.TabIndex = 18;
            this.AllMeterMaxFDropBox.SelectionChangeCommitted += new System.EventHandler(this.AllMeterMaxFDropBox_SelectedIndexChanged);
            // 
            // AllMeterSettingsLabel
            // 
            this.AllMeterSettingsLabel.AutoSize = true;
            this.AllMeterSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterSettingsLabel.Location = new System.Drawing.Point(75, 5);
            this.AllMeterSettingsLabel.Name = "AllMeterSettingsLabel";
            this.AllMeterSettingsLabel.Size = new System.Drawing.Size(87, 16);
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
            this.AllMeterModes.Location = new System.Drawing.Point(300, 25);
            this.AllMeterModes.Name = "AllMeterModes";
            this.AllMeterModes.Size = new System.Drawing.Size(150, 150);
            this.AllMeterModes.TabIndex = 0;
            // 
            // AllMeterModesLabel
            // 
            this.AllMeterModesLabel.AutoSize = true;
            this.AllMeterModesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterModesLabel.Location = new System.Drawing.Point(5, 5);
            this.AllMeterModesLabel.Name = "AllMeterModesLabel";
            this.AllMeterModesLabel.Size = new System.Drawing.Size(143, 16);
            this.AllMeterModesLabel.TabIndex = 16;
            this.AllMeterModesLabel.Text = "Measuring parameters";
            this.AllMeterModesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllMeterFi
            // 
            this.AllMeterFi.AutoSize = true;
            this.AllMeterFi.Enabled = false;
            this.AllMeterFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterFi.Location = new System.Drawing.Point(75, 120);
            this.AllMeterFi.Name = "AllMeterFi";
            this.AllMeterFi.Size = new System.Drawing.Size(33, 20);
            this.AllMeterFi.TabIndex = 15;
            this.AllMeterFi.Text = "fi";
            this.AllMeterFi.UseVisualStyleBackColor = true;
            // 
            // AllMeterQr
            // 
            this.AllMeterQr.AutoSize = true;
            this.AllMeterQr.Enabled = false;
            this.AllMeterQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQr.Location = new System.Drawing.Point(75, 90);
            this.AllMeterQr.Name = "AllMeterQr";
            this.AllMeterQr.Size = new System.Drawing.Size(37, 20);
            this.AllMeterQr.TabIndex = 14;
            this.AllMeterQr.Text = "Q";
            this.AllMeterQr.UseVisualStyleBackColor = true;
            // 
            // AllMeterQl
            // 
            this.AllMeterQl.AutoSize = true;
            this.AllMeterQl.Enabled = false;
            this.AllMeterQl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterQl.Location = new System.Drawing.Point(75, 60);
            this.AllMeterQl.Name = "AllMeterQl";
            this.AllMeterQl.Size = new System.Drawing.Size(37, 20);
            this.AllMeterQl.TabIndex = 13;
            this.AllMeterQl.Text = "Q";
            this.AllMeterQl.UseVisualStyleBackColor = true;
            // 
            // AllMeterD
            // 
            this.AllMeterD.AutoSize = true;
            this.AllMeterD.Enabled = false;
            this.AllMeterD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterD.Location = new System.Drawing.Point(75, 30);
            this.AllMeterD.Name = "AllMeterD";
            this.AllMeterD.Size = new System.Drawing.Size(37, 20);
            this.AllMeterD.TabIndex = 12;
            this.AllMeterD.Text = "D";
            this.AllMeterD.UseVisualStyleBackColor = true;
            // 
            // AllMeterZ
            // 
            this.AllMeterZ.AutoSize = true;
            this.AllMeterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterZ.Location = new System.Drawing.Point(25, 120);
            this.AllMeterZ.Name = "AllMeterZ";
            this.AllMeterZ.Size = new System.Drawing.Size(35, 20);
            this.AllMeterZ.TabIndex = 11;
            this.AllMeterZ.Text = "Z";
            this.AllMeterZ.UseVisualStyleBackColor = true;
            this.AllMeterZ.CheckedChanged += new System.EventHandler(this.AllMeterZ_CheckedChanged);
            // 
            // AllMeterR
            // 
            this.AllMeterR.AutoSize = true;
            this.AllMeterR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterR.Location = new System.Drawing.Point(25, 90);
            this.AllMeterR.Name = "AllMeterR";
            this.AllMeterR.Size = new System.Drawing.Size(37, 20);
            this.AllMeterR.TabIndex = 10;
            this.AllMeterR.Text = "R";
            this.AllMeterR.UseVisualStyleBackColor = true;
            this.AllMeterR.CheckedChanged += new System.EventHandler(this.AllMeterR_CheckedChanged);
            // 
            // AllMeterL
            // 
            this.AllMeterL.AutoSize = true;
            this.AllMeterL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterL.Location = new System.Drawing.Point(25, 60);
            this.AllMeterL.Name = "AllMeterL";
            this.AllMeterL.Size = new System.Drawing.Size(34, 20);
            this.AllMeterL.TabIndex = 9;
            this.AllMeterL.Text = "L";
            this.AllMeterL.UseVisualStyleBackColor = true;
            this.AllMeterL.CheckedChanged += new System.EventHandler(this.AllMeterL_CheckedChanged);
            // 
            // AllMeterC
            // 
            this.AllMeterC.AutoSize = true;
            this.AllMeterC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMeterC.Location = new System.Drawing.Point(25, 30);
            this.AllMeterC.Name = "AllMeterC";
            this.AllMeterC.Size = new System.Drawing.Size(36, 20);
            this.AllMeterC.TabIndex = 8;
            this.AllMeterC.Text = "C";
            this.AllMeterC.UseVisualStyleBackColor = true;
            this.AllMeterC.CheckedChanged += new System.EventHandler(this.AllMeterC_CheckedChanged);
            // 
            // TemperatureMeterPanel
            // 
            this.TemperatureMeterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TemperatureMeterPanel.Location = new System.Drawing.Point(50, 331);
            this.TemperatureMeterPanel.Name = "TemperatureMeterPanel";
            this.TemperatureMeterPanel.Size = new System.Drawing.Size(700, 100);
            this.TemperatureMeterPanel.TabIndex = 4;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TemperatureMeterPanel);
            this.Controls.Add(this.AllMeterPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.TemperatureMeterButton);
            this.Controls.Add(this.AllMeterButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "App";
            this.Text = "E7-20";
            this.Load += new System.EventHandler(this.App_Load);
            this.SizeChanged += new System.EventHandler(this.App_Resize);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.AllMeterPanel.ResumeLayout(false);
            this.AllMeterSavingPanel.ResumeLayout(false);
            this.AllMeterSavingPanel.PerformLayout();
            this.AllMeterSettings.ResumeLayout(false);
            this.AllMeterSettings.PerformLayout();
            this.AllMeterMeasurementsPanel.ResumeLayout(false);
            this.AllMeterMeasurementsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllMeterMeasurementsBar)).EndInit();
            this.MinFPanel.ResumeLayout(false);
            this.MinFPanel.PerformLayout();
            this.MaxFPanel.ResumeLayout(false);
            this.MaxFPanel.PerformLayout();
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
        private System.Windows.Forms.Panel AllMeterMeasurementsPanel;
        private System.Windows.Forms.TrackBar AllMeterMeasurementsBar;
        private System.Windows.Forms.Label AllMeterMeasurementsLabel;
        private System.Windows.Forms.Panel MinFPanel;
        private System.Windows.Forms.Label AllMeterMinFLabel;
        private System.Windows.Forms.ComboBox AllMeterMinFDropBox;
        private System.Windows.Forms.Panel MaxFPanel;
        private System.Windows.Forms.Label AllMeterMaxFLabel;
        private System.Windows.Forms.ComboBox AllMeterMaxFDropBox;
        private System.Windows.Forms.Label AllMeterSettingsLabel;
        private System.Windows.Forms.Label AllMeterModesLabel;
        private System.Windows.Forms.CheckBox AllMeterFi;
        private System.Windows.Forms.CheckBox AllMeterQr;
        private System.Windows.Forms.CheckBox AllMeterQl;
        private System.Windows.Forms.CheckBox AllMeterD;
        private System.Windows.Forms.Panel AllMeterSavingPanel;
        private System.Windows.Forms.Label AllMeterSavingLabel;
        private System.Windows.Forms.CheckBox AllMeterStandardDeviation;
        private System.Windows.Forms.CheckBox AllMeterMaxValue;
        private System.Windows.Forms.CheckBox AllMeterMinValue;
        private System.Windows.Forms.CheckBox AllMeterAverageValue;
        private System.Windows.Forms.TextBox AllMeterMeasurements;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button AllMeterFast;
        private System.Windows.Forms.Button AllMeterSlow;
    }
}

