using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
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
        private VirtualDevice _virtualMachine = null;
        private RealDevice _workMachine = null;
        private MenuMode _currentPage = MenuMode.StartMenu;

        private bool _IsDebug = false;

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
                PortsList.Items.Add(ports[i]);
            }
            if (ports.Length == 0)
                PortsList.Items.Add("VirtualCOM");
        }
        private void AutoName_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoName.Checked)
                FileName.Text = "Experiment";
            FileName.Enabled = !AutoName.Checked;
            
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
            AllMeterSettings.Visible = (mode == MenuMode.AllMeterMenu);
            AllMeterButton.Visible = (mode == MenuMode.StartMenu);
            AllMeterModes.Visible = (mode == MenuMode.AllMeterMenu);
            CurieSettings.Visible = (mode == MenuMode.CurieMenu);
            CurieMeterButton.Visible = (mode == MenuMode.StartMenu);
            CurieCoefficientsPanel.Visible = (mode == MenuMode.CurieMenu);
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
                    AllMeterInit();
                    break;
                case MenuMode.CurieMenu:
                    CurieInit();
                    break;
            }
        }
        #region GeneralPanel
        public void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            _folderPath = FolderBrowserDialog.SelectedPath;
            DirectoryPath.Text = _folderPath;
        }
        public void AllMeterButton_Click(object sender, EventArgs e)
        {
            if (CheckGeneralInput() == false)
                return;
            ChangeMenuInterface(MenuMode.AllMeterMenu);
        }
        public void TemperatureMeterButton_Click(object sender, EventArgs e)
        {
            if (CheckGeneralInput() == false)
                return;
            ChangeMenuInterface(MenuMode.CurieMenu);
        }
        public void ReturnButton_Click(object sender, EventArgs e)
        {
            ChangeMenuInterface(MenuMode.StartMenu);
        }
        public bool CheckGeneralInput()
        {
            if (PortsList.Text == default(string) || PortsList.Text.Contains("COM") == false)
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
            AllMeterModes.Enabled = state;
            CurieCoefficientsPanel.Enabled = state;
            if (_currentPage == MenuMode.AllMeterMenu)
            {
                AllMeterFast.Enabled = state;
                AllMeterSlow.Enabled = state;
            }
            else
            {
                CurieStart.Enabled = state;
            }
            ReturnButton.Enabled = state;
            AllMeterStop.Enabled = !state;
            ProgressPanel.Visible = !state;
        }
        private List<ModeCommands> GetModes()
        {
            List<ModeCommands> modes = new List<ModeCommands>();
            if (AllMeterC.Checked)
                modes.Add(ModeCommands.C);
            if (AllMeterD.Checked)
                modes.Add(ModeCommands.D);
            if (AllMeterL.Checked)
                modes.Add(ModeCommands.L);
            if (AllMeterQl.Checked)
                modes.Add(ModeCommands.Ql);
            if (AllMeterR.Checked)
                modes.Add(ModeCommands.R);
            if (AllMeterQr.Checked)
                modes.Add(ModeCommands.Qr);
            if (AllMeterZ.Checked)
                modes.Add(ModeCommands.Z);
            if (AllMeterFi.Checked)
                modes.Add(ModeCommands.Fi);
            return modes;
        }
        private void ResetProgressBar()
        {
            ProgressBar.Maximum = 0;
            ProgressBar.Step = 0;
            ProgressBar.Value = 0;
            EstimatedTime.Text = "prepearing for start...";
        }
        #endregion

        #region AllMeterPanel
        public void AllMeterInit()
        {
            UpdateLists();
            StartEnabling();
        }
        public void UpdateLists()
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
        }
        public void AllMeterC_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterD.Enabled = AllMeterC.Checked;
            if (AllMeterC.Checked == false)
                AllMeterD.Checked = false;
            StartEnabling();
        }

        public void AllMeterL_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterQl.Enabled = AllMeterL.Checked;
            if (AllMeterL.Checked == false)
                AllMeterQl.Checked = false;
            StartEnabling();
        }

        public void AllMeterR_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterQr.Enabled = AllMeterR.Checked;
            if (AllMeterR.Checked == false)
                AllMeterQr.Checked = false;
            StartEnabling();
        }

        public void AllMeterZ_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterFi.Enabled = AllMeterZ.Checked;
            if (AllMeterZ.Checked == false)
                AllMeterFi.Checked = false;
            StartEnabling();
        }
        private void StartEnabling()
        {
            AllMeterFast.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
            AllMeterSlow.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
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
                MessageBox.Show("Start and end frequences have to be different!");
                return;
            }
            List<ModeCommands> modes = GetModes();
            MeasurementProcess(false);
            ResetProgressBar();
            int startF = Constants.MAIN_FREQUENCES[AllMeterStartFDropBox.SelectedIndex];
            int endF = Constants.MAIN_FREQUENCES[AllMeterEndFDropBox.SelectedIndex];
            if (_IsDebug)
                _virtualMachine = new VirtualDevice(DirectoryPath.Text, FileName.Text, startF, endF, speed, modes.ToArray());
            else
                _workMachine = new RealDevice(PortsList.Text, DirectoryPath.Text, FileName.Text, startF, endF, speed, modes.ToArray());
            MeasuresTimer.Start();
        }

        private void AllMeterStop_Click(object sender, EventArgs e)
        {
            MeasuresTimer.Stop();
            if (_IsDebug)
            {
                if (_virtualMachine != null)
                    _virtualMachine.Break();
            }
            else if (_workMachine != null)
                _workMachine.IsWorking = false;
            MeasurementProcess(true);
        }
        #endregion

        private void MeasuresTimer_Tick(object sender, EventArgs e)
        {
            if (_IsDebug)
            {
                if (_virtualMachine != null && _virtualMachine.MakeMeasurement() == false)
                    AllMeterStop_Click(sender, e);
            }
            else if (_workMachine != null)
            {
                if (_workMachine.IsWorking == false)
                    AllMeterStop_Click(sender, e);
                else if (_workMachine.IsDataChanged)
                {
                    _workMachine.IsDataChanged = false;
                    double time = _workMachine.GetProgress;
                    if (ProgressBar.Maximum <= time)
                    {
                        ProgressBar.Maximum = (int)time;
                    }
                    else
                    {
                        if (ProgressBar.Step == 0)
                        {
                            ProgressBar.Step = ProgressBar.Maximum - (int)time - 1;
                            ProgressBar.Value += ProgressBar.Step;
                        }
                        ProgressBar.Value += ProgressBar.Step;
                    }
                    if (time > 60)
                        EstimatedTime.Text = Math.Round(time / 60, 2).ToString() + " min";
                    else
                        EstimatedTime.Text = Math.Round(time, 2).ToString() + " sec";
                }
            }
        }

        #region TemperatureMeterPanel
        private void CurieInit()
        {
          //  throw new NotImplementedException();
        }
        private void CurieStart_Click(object sender, EventArgs e)
        {
            List<ModeCommands> modes = GetModes();
            MeasurementProcess(false);
            ResetProgressBar();
        }
        #endregion

    }
}
