using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Authentication;
using System.Text;
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
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private int _currentWidth = 800;
        private int _currentHeight = 500;
        private BaseMachine _workMachine = null;
        private MenuMode _currentPage = MenuMode.StartMenu;
        public App()
        {
            InitializeComponent();
        }
        public void App_Load(object sender, EventArgs e)
        {
            DirectoryPath.Text = _folderPath;
            ChangeMenuInterface(MenuMode.StartMenu);
        }
        private void FillThePorts(object sender, EventArgs e)
        {
            PortsList.Items.Clear();
            string[] ports = IOprovider.GetPorts;
            for (int i = 0; i < ports.Length; i++)
            {
                if (Regex.IsMatch(ports[i], @"COM\d?$"))
                    PortsList.Items.Add(ports[i]);
            }
            if (PortsList.Items.Count == 0)
                PortsList.Items.Add("VirtualCOM");
        }
        public void App_Resize(object sender, EventArgs e)
        {
            int width = App.ActiveForm.Size.Width;
            int height = App.ActiveForm.Size.Height;
            App.ActiveForm.Scale(new SizeF(width / _currentWidth, height / _currentHeight));
            _currentWidth = width;
            _currentHeight = height;
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
            _currentPage = mode;
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
            if (AutoName.Checked)
                FileName.Text = "Experiment";
            FileName.Enabled = !AutoName.Checked;
        }
        public void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            _folderPath = FolderBrowserDialog.SelectedPath;
            DirectoryPath.Text = _folderPath;
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
            if (String.IsNullOrEmpty(PortsList.Text))
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
            if (_currentPage == MenuMode.AllMeterMenu)
            {
                AllMeterFast.Enabled = state;
                AllMeterSlow.Enabled = state;
            }
            else
                CurieStart.Enabled = state;
            ReturnButton.Enabled = state;
            AllMeterStop.Enabled = !state;
            ProgressPanel.Visible = !state;
        }
        private List<ModeCommands> GetModes()
        {
            List<ModeCommands> modes = new List<ModeCommands>();
            if (ParameterC.Checked)
                modes.Add(ModeCommands.C);
            if (ParameterD.Checked)
                modes.Add(ModeCommands.D);
            if (ParameterL.Checked)
                modes.Add(ModeCommands.L);
            if (ParameterQl.Checked)
                modes.Add(ModeCommands.Ql);
            if (ParameterR.Checked)
                modes.Add(ModeCommands.R);
            if (ParameterQr.Checked)
                modes.Add(ModeCommands.Qr);
            if (ParameterZ.Checked)
                modes.Add(ModeCommands.Z);
            if (ParameterFi.Checked)
                modes.Add(ModeCommands.Fi);
            return modes;
        }
        private void ResetProgressBar()
        {
            ProgressBar.Maximum = 0;
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
            StartEnabling();
        }
        public void AllMeterC_CheckedChanged(object sender, EventArgs e)
        {
            ParameterD.Enabled = ParameterC.Checked;
            ParameterD.Checked = ParameterC.Checked;
            StartEnabling();
        }

        public void AllMeterL_CheckedChanged(object sender, EventArgs e)
        {
            ParameterQl.Enabled = ParameterL.Checked;
            ParameterQl.Checked = ParameterL.Checked;
            StartEnabling();
        }

        public void AllMeterR_CheckedChanged(object sender, EventArgs e)
        {
            ParameterQr.Enabled = ParameterR.Checked;
            ParameterQr.Checked = ParameterR.Checked;
            StartEnabling();
        }

        public void AllMeterZ_CheckedChanged(object sender, EventArgs e)
        {
            ParameterFi.Enabled = ParameterZ.Checked;
            ParameterFi.Checked = ParameterZ.Checked;
            StartEnabling();
        }
        private void StartEnabling()
        {
            AllMeterFast.Enabled = ParameterC.Checked | ParameterL.Checked | ParameterR.Checked | ParameterZ.Checked;
            AllMeterSlow.Enabled = ParameterC.Checked | ParameterL.Checked | ParameterR.Checked | ParameterZ.Checked;
            CurieStart.Enabled = ParameterC.Checked | ParameterL.Checked | ParameterR.Checked | ParameterZ.Checked;
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
            List<ModeCommands> modes = GetModes();
            MeasurementProcess(false);
            ResetProgressBar();
            int startF = Constants.MAIN_FREQUENCES[AllMeterStartFDropBox.SelectedIndex];
            int endF = Constants.MAIN_FREQUENCES[AllMeterEndFDropBox.SelectedIndex];
            _workMachine = new AllMeterMachine(PortsList.Text, DirectoryPath.Text, FileName.Text, startF, endF, speed, modes.ToArray());
            MeasuresTimer.Start();
        }
        #endregion
        #region TemperatureMeterPanel
        private void CurieStart_Click(object sender, EventArgs e)
        {
            Interval.Text = StyleFormatter.ChangeDoubleSeparator(Interval.Text);
            if (CurieValidate())
            {
                List<ModeCommands> modes = GetModes();
                MeasurementProcess(false);
                ResetProgressBar();
                _workMachine = new CurieMachine(PortsList.Text, DirectoryPath.Text, FileName.Text, modes.ToArray(), Int32.Parse(Amount.Text), Double.Parse(Interval.Text), 
                    new double[] {
                        double.Parse(StyleFormatter.ChangeDoubleSeparator(CurieA.Text)),
                        double.Parse(StyleFormatter.ChangeDoubleSeparator(CurieB.Text)),
                        double.Parse(StyleFormatter.ChangeDoubleSeparator(CurieC.Text)),
                        double.Parse(StyleFormatter.ChangeDoubleSeparator(CurieD.Text)),
                    });
                MeasuresTimer.Start();
            }
        }
        private bool CurieValidate()
        {
            Int32.TryParse(Amount.Text, out int amount);
            if (amount < 1|| amount > 1000)
            {
                MessageBox.Show("Amount of measurements have to be in the range from 1 to 1000");
                return false;
            }
            Double.TryParse(Interval.Text, out double interval);
            Math.Round(interval, 2);
            if (interval < 1 || interval > 1000)
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
            MeasuresTimer.Stop();
            if (_workMachine != null)
                _workMachine.IsWorking = false;
            MeasurementProcess(true);
        }
        private void MeasuresTimer_Tick(object sender, EventArgs e)
        {
            if (_workMachine != null)
            {
                if (_workMachine.IsWorking == false)
                {
                    Stop_Click(sender, e);
                    return;
                }
                if (_workMachine.IsDataChanged)
                {
                    _workMachine.IsDataChanged = false;
                    double time = _workMachine.GetProgress;
                    if (ProgressBar.Maximum <= time)                    
                        ProgressBar.Maximum = (int)time;
                    else
                        ProgressBar.Value = ProgressBar.Maximum - (int)time;
                    if (time > 60)
                        EstimatedTime.Text = Math.Round(time / 60, 2).ToString() + " min";
                    else
                        EstimatedTime.Text = Math.Round(time, 2).ToString() + " sec";
                }
            }
        }
        #endregion
    }
}
