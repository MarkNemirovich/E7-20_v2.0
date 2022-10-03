using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E7_20_v2._0
{
    public enum SpeedMode
    {
        Fast,
        Slow
    }
    public struct Modes
    {
        public bool C;
        public bool L;
        public bool R;
        public bool Z;
        public bool D;
        public bool Ql;
        public bool Qr;
        public bool Fi;
    }
    public struct Params
    {
        public bool Avg;
        public bool Min;
        public bool Max;
        public bool Div;
    }
    public partial class App : Form
    {
        public const int PACK_LENGTH = 22;
        public readonly int[] _fArray = new int[17] { 25, 50, 60, 100, 120, 200, 500, 1000, 2000, 5000, 10000, 20000, 50000, 100000, 200000, 500000, 1000000 };
        public delegate void GetByte(byte bit);
        public event GetByte ProvideByte;

        public enum MenuMode
        {
            StartMenu,
            AllMeterMenu,
            TemperatureMeterMenu
        }
        public string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public int _currentWidth = 800;
        public int _currentHeight = 500;
        private int _maxIndex = 1;
        private int _minIndex = 0;


        public App()
        {
            InitializeComponent();
        }
        public void App_Load(object sender, EventArgs e)
        {
            DirectoryPath.Text = _folderPath;
            ChangeMenuInterface(MenuMode.StartMenu);
        }
        public void App_Resize(object sender, EventArgs e)
        {
            int width = App.ActiveForm.Size.Width;
            int height = App.ActiveForm.Size.Height;
            App.ActiveForm.Scale(new SizeF(width / _currentWidth, height / _currentHeight));
            _currentWidth = width;
            _currentHeight = height;
        }
        public void ChangeMenuInterface(MenuMode mode)
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
            if (PortsList.SelectedItem.ToString() == null)
                return;
            if (Port.IsOpen)
                Port.Close();
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

            return true; // temporary


            if (Port.IsOpen == false)
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
                AllMeterMinFDropBox.Items.Add(_fArray[i].ToString());
            }
            for (int i = _minIndex+1; i < _fArray.Length; i++)
            {
                AllMeterMaxFDropBox.Items.Add(_fArray[i].ToString());
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
     //       _allMeter.Start(PACK_LENGTH, AllMeterMeasurementsBar.Value);
        }

        public void AllMeterSlow_Click(object sender, EventArgs e)
        {
     //       _allMeter.Start(PACK_LENGTH, AllMeterMeasurementsBar.Value, SpeedMode.Slow);
        }
        #endregion

        #region TemperatureMeterPanel

        #endregion

        public void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }

    }
}
