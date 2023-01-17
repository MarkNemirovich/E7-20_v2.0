using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E7_20_v2._0
{
    public partial class App : Form
    {
        private enum MenuMode
        {
            StartMenu,
            AllMeterMenu,
            TemperatureMeterMenu
        }
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private int _currentWidth = 800;
        private int _currentHeight = 500;
        private int _endIndex = 1;
        private int _startIndex = 0;
        private VirtualDevice _virtualMachine = null;
        private RealDevice _workMachine = null;

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
            AllMeterButton.Visible = (mode == MenuMode.StartMenu);
            TemperatureMeterButton.Visible = (mode == MenuMode.StartMenu);
            AllMeterPanel.Visible = (mode == MenuMode.AllMeterMenu);
            TemperatureMeterPanel.Visible = (mode == MenuMode.TemperatureMeterMenu);
            switch (mode)
            {
                case MenuMode.StartMenu:
                    break;
                case MenuMode.AllMeterMenu:
                    AllMeterInit();
                    break;
                case MenuMode.TemperatureMeterMenu:
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
            ChangeMenuInterface(MenuMode.TemperatureMeterMenu);
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
        #endregion

        #region AllMeterPanel
        public void AllMeterInit()
        {
            UpdateLists();
            StartEnabling();
        }
        public void AllMeterEndFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _endIndex = AllMeterEndFDropBox.SelectedIndex;
            UpdateLists();
        }

        public void AllMeterStartFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _startIndex = AllMeterStartFDropBox.SelectedIndex;
            UpdateLists();
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
            AllMeterStartFDropBox.SelectedIndex = _startIndex;
            AllMeterEndFDropBox.SelectedIndex = _endIndex;
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
            Start(SpeedMode.Fast);
        }

        public void AllMeterSlow_Click(object sender, EventArgs e)
        {
            Start(SpeedMode.Slow);
        }
        private void Start(SpeedMode speed)
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
            if (AllMeterL.Checked)
                modes.Add(ModeCommands.R);
            if (AllMeterR.Checked)
                modes.Add(ModeCommands.Qr);
            if (AllMeterZ.Checked)
                modes.Add(ModeCommands.Z);
            if (AllMeterFi.Checked)
                modes.Add(ModeCommands.Fi);
            MeasurementProcess(false);
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
            else
                if (_workMachine != null)
                    _workMachine.Break();
            MeasurementProcess(true);
        }

        private void MeasurementProcess(bool state)
        {
            AllMeterFast.Enabled = state;
            AllMeterSlow.Enabled = state;
            ReturnButton.Enabled = state;
            AllMeterStop.Enabled = !state;
        }
        #endregion

        #region TemperatureMeterPanel

        #endregion

        private void MeasuresTimer_Tick(object sender, EventArgs e)
        {
            if (_IsDebug)
            {
                if (_virtualMachine != null && _virtualMachine.MakeMeasurement() == false)
                    AllMeterStop_Click(sender, e);
            }
            else if (_workMachine != null && _workMachine.IsWorking == false)
                AllMeterStop_Click(sender, e);
        }
        [Conditional("DEBUG")]
        private void IsDebug(ref bool isDebug)
        {
            isDebug = true;
        }
    }
}
