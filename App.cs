using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace E7_20_v2._0
{
    public partial class App : Form
    {
        private enum MenuMode
        {
            StartMenu,
            AllMeterMenu,
            CurieMenu
        }
        private string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private BaseMachine workMachine = null;
        private MenuMode currentPage = MenuMode.StartMenu;
        private double estimatedTime = 0;
        private double lastTime = 0;
        public App()
        {
            InitializeComponent();
        }
        public void App_Load(object sender, EventArgs e)
        {
            DirectoryPath.Text = folderPath;
            ChangeMenuInterface(MenuMode.StartMenu);
            ReadCoefficients();
            FillThePorts(sender, e);
        }
        private void FillThePorts(object sender, EventArgs e)
        {
            PortsList.Items.Clear();
            string[] ports = IOProvider.GetPorts;
            foreach (string port in ports)
            {
                if (Regex.IsMatch(port, @"COM\d+$"))
                {
                    PortsList.Items.Add(port);
                }
            }
            if (PortsList.Items.Count == 0)
            {
                PortsList.Items.Add("VirtualCOM");
            }
        }
        private void ChangeMenuInterface(MenuMode mode)
        {
            StartPanel.Enabled = (mode == MenuMode.StartMenu);
            Settings.Visible = (mode == MenuMode.AllMeterMenu || mode == MenuMode.CurieMenu);
            SettingsModes.Visible = (mode == MenuMode.AllMeterMenu || mode == MenuMode.CurieMenu);
            AllMeterSettings.Visible = (mode == MenuMode.AllMeterMenu);
            AllMeterButton.Visible = (mode == MenuMode.StartMenu);
            CurieSettings.Visible = (mode == MenuMode.CurieMenu);
            CurieMeterButton.Visible = (mode == MenuMode.StartMenu);
            ControlButtonPanel.Visible = (mode != MenuMode.StartMenu);
            AllMeterFast.Visible = (mode == MenuMode.AllMeterMenu);
            AllMeterSlow.Visible = (mode == MenuMode.AllMeterMenu);
            CurieStart.Visible = (mode == MenuMode.CurieMenu);
            currentPage = mode;
            switch (mode)
            {
                case MenuMode.StartMenu:
                    break;
                case MenuMode.AllMeterMenu:
                    ParameterC.Checked = false;
                    ParameterL.Checked = false;
                    ParameterR.Checked = false;
                    ParameterZ.Checked = false;
                    MainParameters.Enabled = true;
                    AllMeterInit();
                    break;
                case MenuMode.CurieMenu:
                    ParameterC.Checked = false;
                    ParameterL.Checked = true;
                    ParameterR.Checked = true;
                    ParameterZ.Checked = false;
                    ParameterQl.Checked = false;
                    ParameterQr.Checked = false;
                    MainParameters.Enabled = false;
                    break;
            }
        }
        #region GeneralPanel
        private void AutoName_CheckedChanged(object sender, EventArgs e)
        {
            FileName.Text = AutoName.Checked ? "Experiment" : "";
            FileName.Enabled = !AutoName.Checked;
        }
        public void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                folderPath = FolderBrowserDialog.SelectedPath;
                DirectoryPath.Text = folderPath;
            }
        }
        public void AllMeterButton_Click(object sender, EventArgs e)
        {
            if (CheckGeneralInput())
                ChangeMenuInterface(MenuMode.AllMeterMenu);
        }
        public void TemperatureMeterButton_Click(object sender, EventArgs e)
        {
            if (CheckGeneralInput())
                ChangeMenuInterface(MenuMode.CurieMenu);
        }
        public void ReturnButton_Click(object sender, EventArgs e)
        {
            ChangeMenuInterface(MenuMode.StartMenu);
        }
        private bool CheckGeneralInput()
        {
            if (String.IsNullOrEmpty(PortsList.Text) || PortsList.Text.Contains("COM") == false)
            {
                MessageBox.Show("Choose the port please");
                return false;
            }
            if (FileName.Text == "" || FileName.Text.Contains(" "))
            {
                MessageBox.Show("Write the file name please without spaces");
                return false;
            }
            return true;
        }
        private void MeasurementProcess(bool state)
        {
            AllMeterSettings.Enabled = state;
            CurieSettings.Enabled = state;
            SettingsModes.Enabled = state;
            AllMeterFast.Enabled = state && currentPage == MenuMode.AllMeterMenu;
            AllMeterSlow.Enabled = state && currentPage == MenuMode.AllMeterMenu;
            CurieStart.Enabled = state && currentPage == MenuMode.CurieMenu;
            ReturnButton.Enabled = state;
            AllMeterStop.Enabled = !state;
            ProgressPanel.Visible = !state;
        }
        private ModeCommands[] GetModes()
        {
            List<ModeCommands> modes = new List<ModeCommands>();
            if (ParameterC.Checked) modes.Add(ModeCommands.C);
            if (ParameterD.Checked) modes.Add(ModeCommands.D);
            if (ParameterL.Checked) modes.Add(ModeCommands.L);
            if (ParameterQl.Checked) modes.Add(ModeCommands.Ql);
            if (ParameterR.Checked) modes.Add(ModeCommands.R);
            if (ParameterQr.Checked) modes.Add(ModeCommands.Qr);
            if (ParameterZ.Checked) modes.Add(ModeCommands.Z);
            if (ParameterFi.Checked) modes.Add(ModeCommands.Fi);
            return modes.ToArray();
        }
        private void ResetProgressBar(int maxValue)
        {
            ProgressBar.Maximum = maxValue;
            ProgressBar.Step = 1;
            ProgressBar.Value = 0;
            EstimatedTime.Text = "preparing for start...";
        }
        #endregion

        #region AllMeterPanel
        private void AllMeterInit()
        {
            AllMeterStartFDropBox.Items.Clear();
            AllMeterEndFDropBox.Items.Clear();
            for (int i = 0; i < Constants.MAIN_FREQUENCES.Length; i++)
            {
                AllMeterStartFDropBox.Items.Add(Constants.MAIN_FREQUENCES[i].ToString());
                AllMeterEndFDropBox.Items.Add(Constants.MAIN_FREQUENCES[i].ToString());
            }
            AllMeterStartFDropBox.SelectedIndex = 0;
            AllMeterEndFDropBox.SelectedIndex = 1;
            UpdateStartEnabling();
        }

        private void UpdateCheckBox(CheckBox targetCheckbox, CheckBox linkedCheckbox)
        {
            linkedCheckbox.Enabled = targetCheckbox.Checked;
            linkedCheckbox.Checked = targetCheckbox.Checked;
            UpdateStartEnabling();
        }
        public void AllMeterC_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox(ParameterC, ParameterD);
        }

        public void AllMeterL_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox(ParameterL, ParameterQl);
        }

        private void AllMeterR_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox(ParameterR, ParameterQr);
        }

        private void AllMeterZ_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox(ParameterZ, ParameterFi);
        }

        private void UpdateStartEnabling()
        {
            bool anyChecked = ParameterC.Checked | ParameterL.Checked | ParameterR.Checked | ParameterZ.Checked;
            AllMeterFast.Enabled = anyChecked;
            AllMeterSlow.Enabled = anyChecked;
            CurieStart.Enabled = anyChecked;
        }
        public void AllMeterFast_Click(object sender, EventArgs e)
        {
            AllMeterStart(SpeedMode.Fast);
        }

        public void AllMeterSlow_Click(object sender, EventArgs e)
        {
            AllMeterStart(SpeedMode.Slow);
        }
        private void AllMeterStart(SpeedMode speed)
        {
            if (AllMeterStartFDropBox.SelectedIndex == AllMeterEndFDropBox.SelectedIndex)
            {
                MessageBox.Show("Start and end frequencies have to be different!");
                return;
            }
            int startF;
            int endF;
            try
            {
                startF = Constants.MAIN_FREQUENCES[AllMeterStartFDropBox.SelectedIndex];
                endF = Constants.MAIN_FREQUENCES[AllMeterEndFDropBox.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("Choose the frequency from the list. Do not write it by yourself.");
                return;
            }
            ModeCommands[] modes = GetModes();
            MeasurementProcess(false);
            ResetProgressBar(EvaluateProgress(speed));
            workMachine = new AllMeterMachine(PortsList.Text, DirectoryPath.Text, FileName.Text, startF, endF, speed, modes);
            workMachine.TimeUpdated += UpdateTimeBar;
            BarUpdateTimer.Start();
        }
        private int EvaluateProgress(SpeedMode mode)
        {
            if (mode == SpeedMode.Fast)
            {
                return Math.Abs(AllMeterStartFDropBox.SelectedIndex - AllMeterEndFDropBox.SelectedIndex);
            }
            else
            {
                var startF = Constants.MAIN_FREQUENCES[AllMeterStartFDropBox.SelectedIndex];
                var endF = Constants.MAIN_FREQUENCES[AllMeterEndFDropBox.SelectedIndex];
                var steps = Math.Abs(endF - startF) / Constants.THOUSAND;
                if (startF < Constants.THOUSAND && endF >= Constants.THOUSAND || startF >= Constants.THOUSAND && endF < Constants.THOUSAND)
                {
                    steps += Constants.THOUSAND - Math.Min(startF, endF) % Constants.THOUSAND;
                }
                return steps;
            }
        }
        #endregion
        #region TemperatureMeterPanel
        private double[] ReadCoefficients()
        {
            string coefficientsFile = string.Concat(Directory.GetCurrentDirectory(), "coefficients.txt");
            double[] coefficients;
            if (File.Exists(coefficientsFile))
            {
                coefficients = File.ReadAllLines(coefficientsFile)
                        .Select(x => double.TryParse(StyleFormatter.ChangeDoubleSeparator(x), out double value)
                                ? value : throw new ArgumentException("Invalid double value in coefficients.txt"))
                        .ToArray();
            }
            else
            {
                SetInitialCoefficients(out coefficients);
                SaveCoefficients(coefficients);
            }
            return coefficients;
        }
        private void SaveCoefficients(double[] coefficients)
        {
            string coefficientsFile = Path.Combine(Directory.GetCurrentDirectory(), "coefficients.txt");
            File.WriteAllLines(coefficientsFile, coefficients.Select(x => x.ToString()).ToArray());
        }
        private bool CheckCoefficients(out double[] coefficients)
        {
            bool isCorrect = true;
            isCorrect &= double.TryParse(StyleFormatter.ChangeDoubleSeparator(CurieA.Text), out double a);
            isCorrect &= double.TryParse(StyleFormatter.ChangeDoubleSeparator(CurieB.Text), out double b);
            isCorrect &= double.TryParse(StyleFormatter.ChangeDoubleSeparator(CurieC.Text), out double c);
            isCorrect &= double.TryParse(StyleFormatter.ChangeDoubleSeparator(CurieD.Text), out double d);
            coefficients = new double[] { a, b, c, d };
            if (isCorrect)
            {
                SaveCoefficients(coefficients);
            }
            return isCorrect;
        }
        private void SetInitialCoefficients(out double[] coefficients)
        {
            CurieA.Text = StyleFormatter.ChangeDoubleSeparator(1.0.ToString());
            CurieB.Text = StyleFormatter.ChangeDoubleSeparator(1.0.ToString());
            CurieC.Text = StyleFormatter.ChangeDoubleSeparator(1.0.ToString());
            CurieD.Text = StyleFormatter.ChangeDoubleSeparator(1.0.ToString());
            coefficients = new double[] { 1,1,1,1 };
        }
        private void CurieStart_Click(object sender, EventArgs e)
        {
            Interval.Text = StyleFormatter.ChangeDoubleSeparator(Interval.Text);
            if (!CurieValidate()) return;
            double[] coefficients = ReadCoefficients();
            if (!CheckCoefficients(out coefficients)) return;
            ModeCommands[] modes = GetModes();
            MeasurementProcess(false);
            ResetProgressBar(Int32.Parse(Amount.Text));
            workMachine = new CurieMachine(PortsList.Text, DirectoryPath.Text, FileName.Text, 
                modes, Int32.Parse(Amount.Text), Double.Parse(Interval.Text), coefficients);
            workMachine.TimeUpdated += UpdateTimeBar;
            BarUpdateTimer.Start();
        }
        private bool CurieValidate()
        {
            Int32.TryParse(Amount.Text, out int amount);
            if (amount < 1 || amount > Constants.THOUSAND)
            {
                MessageBox.Show("Amount of measurements have to be in the range from 1 to 1000");
                return false;
            }
            Double.TryParse(Interval.Text, out double interval);
            Math.Round(interval, 2);
            if (interval < 1 || interval > Constants.THOUSAND)
            {
                MessageBox.Show("Interval between measurements have to be in the range from 1 to 1000.0 seconds with precision to 0.1 second");
                return false;
            }
            return true;
        }
        #endregion
        #region MeasurementControllers
        private void Stop_Click(object sender, EventArgs e)
        {
            EndExperiment();
        }
        private void EndExperiment()
        {
            BarUpdateTimer.Stop();
            workMachine.TimeUpdated -= UpdateTimeBar;
            workMachine?.Stop();
            MeasurementProcess(true);
        }
        private void BarUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (estimatedTime != lastTime)
            {
                ProgressBar.Value += ProgressBar.Step;
                EstimatedTime.Text = estimatedTime > 60
                    ? $"{Math.Round(estimatedTime / 60, 2)} min"
                    : $"{Math.Round(estimatedTime, 2)} sec";
                lastTime = estimatedTime;
            }
            if (estimatedTime == -1 || ProgressBar.Value >= ProgressBar.Maximum)
            {
                EndExperiment();
            }
        }
        private void UpdateTimeBar(double time)
        {
            estimatedTime = time;
        }
        #endregion
    }
}