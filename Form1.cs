using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            TemperatureMeterMenu
        }
        public string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private int _currentWidth = 800;
        private int _currentHeight = 500;
        private int _maxIndex = 1;
        private int _minIndex = 0;
  //      private SerialPortHandler _port = new SerialPortHandler();

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
            //string[] ports = _port.GetPorts;
            //for (int i = 0; i < ports.Length; i++)
            //{
            //    PortsList.Items.Add(ports[i]);
            //}
        }
        private void AutoName_CheckedChanged(object sender, EventArgs e)
        {
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
        public void PortsList_SelectedIndexChanged(object sender, EventArgs e)
        {
     //       _port = new SerialPortHandler(PortsList.SelectedItem.ToString());
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
            if (PortsList.Text == default(string))
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
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
            UpdateLists();
            StartEnabling();
        }
        public void AllMeterMeasurementsBar_Scroll(object sender, EventArgs e)
        {
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
            AllMeterMaxValue.Enabled = AllMeterMeasurementsBar.Value > 1;
            AllMeterMinValue.Enabled = AllMeterMeasurementsBar.Value > 1;
            AllMeterStandardDeviation.Enabled = AllMeterMeasurementsBar.Value > 1;
            if (AllMeterMeasurementsBar.Value == 1)
            {
                AllMeterAverageValue.Checked = true;
                AllMeterAverageValue.Enabled = false;
                AllMeterMinValue.Checked = false;
                AllMeterMaxValue.Checked = false;
                AllMeterStandardDeviation.Checked = false;
            }
        }
        public void AllMeterMaxFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _maxIndex = _minIndex + AllMeterMaxFDropBox.SelectedIndex+1;
            UpdateLists();
        }

        public void AllMeterMinFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _minIndex = AllMeterMinFDropBox.SelectedIndex;
            UpdateLists();
        }
        public void UpdateLists()
        {
            AllMeterMinFDropBox.Items.Clear();
            AllMeterMaxFDropBox.Items.Clear();
            for (int i = 0; i < _maxIndex; i++)
            {
                AllMeterMinFDropBox.Items.Add(Constants.MAIN_FREQUENCES[i].ToString());
            }
            for (int i = _minIndex+1; i < Constants.MAIN_FREQUENCES.Length; i++)
            {
                AllMeterMaxFDropBox.Items.Add(Constants.MAIN_FREQUENCES[i].ToString());
            }
            AllMeterMinFDropBox.SelectedIndex = _minIndex;
            AllMeterMaxFDropBox.SelectedIndex = _maxIndex-_minIndex-1;
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
        public void AllMeterMinValue_CheckedChanged(object sender, EventArgs e)
        {
            if ((AllMeterMinValue.Checked | AllMeterMaxValue.Checked | AllMeterStandardDeviation.Checked) == false)
            {
                AllMeterAverageValue.Checked = true;
                AllMeterAverageValue.Enabled = false;
            }
            else
            {
                AllMeterAverageValue.Enabled = true;
            }

        }

        public void AllMeterMaxValue_CheckedChanged(object sender, EventArgs e)
        {
            if ((AllMeterMinValue.Checked | AllMeterMaxValue.Checked | AllMeterStandardDeviation.Checked) == false)
            {
                AllMeterAverageValue.Checked = true;
                AllMeterAverageValue.Enabled = false;
            }
            else
            {
                AllMeterAverageValue.Enabled = true;
            }
        }
        private void AllMeterStandardDeviation_CheckedChanged(object sender, EventArgs e)
        {
            if ((AllMeterMinValue.Checked | AllMeterMaxValue.Checked | AllMeterStandardDeviation.Checked) == false)
            {
                AllMeterAverageValue.Checked = true;
                AllMeterAverageValue.Enabled = false;
            }
            else
            {
                AllMeterAverageValue.Enabled = true;
            }
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
            Modes m = new Modes(AllMeterC.Checked, AllMeterL.Checked, AllMeterR.Checked, AllMeterZ.Checked, AllMeterD.Checked, AllMeterQl.Checked, AllMeterQr.Checked, AllMeterFi.Checked);
            Params p = new Params(AllMeterAverageValue.Checked, AllMeterMaxValue.Checked, AllMeterMinValue.Checked, AllMeterStandardDeviation.Checked);
          //  _workMachine = new AllMeterGrasper(_port, AllMeterMeasurementsBar.Value, m, p, speed, $"{DirectoryPath.Text}\\{FileName.Text}.txt");
            MeasurementProcess(false);
            MeasuresTimer.Start();
        }

        private void AllMeterStop_Click(object sender, EventArgs e)
        {
            MeasuresTimer.Stop();
        //    _workMachine.Finish();
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
        //    if (_workMachine != null)
        //        _workMachine.WriteData();
        }
    }
}
