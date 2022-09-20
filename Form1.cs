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
    public partial class App : Form
    {
        public enum SpeedMode
        {
            Fast,
            Slow
        }
        public const int PACK_LENGTH = 22;


        public class Grasper
        {
            public int _bufferSize;
            public Queue<byte[]> _data;
            public Queue<byte> _pack;
            public bool _RecivedStartByte;
            public SpeedMode _speed;

            public Grasper(int size, int amount, SpeedMode speed)
            {
                _bufferSize = size;
                _speed = speed;
                _data = new Queue<byte[]>(amount);
                _pack = new Queue<byte>(_bufferSize);
            }

            public void AddByte(byte newByte)
            {
                if (_RecivedStartByte == false)
                {
                    if (newByte == 0xAA)
                    {
                        _pack.Clear();
                        _pack.Enqueue(newByte);
                    }
                }
                else
                {
                    if (_pack.Count == _bufferSize)
                    {
                        _data.Enqueue(_pack.ToArray());
                        _pack.Clear();
                    }
                    _pack.Enqueue(newByte);
                }
            }
        }
        public class AllMeterGrasper : Grasper
        {
            public AllMeterGrasper(int size, int amount, SpeedMode speed) : base(size, amount, speed)
            {

            }
        }
        public class AllMeter
        {
            public readonly int[] _fArray = new int[17] { 25, 50, 60, 100, 120, 200, 500, 1000, 2000, 5000, 10000, 20000, 50000, 100000, 200000, 500000, 1000000 };

            public bool[] Modes;
            public bool[] Params;

            public int MaxFIndex = 1;
            public int MinFIndex = 0;
            public int GetF(int index) => _fArray[index];
            public AllMeterGrasper _grasper;

            public AllMeter()
            {
                Modes = new bool[8];
                Params = new bool[4] { true, false, false, false };
            }
            public void UpdateList(ComboBox box, int start, int end)
            {
                box.Items.Clear();
                for (int i = start; i < end; i++)
                {
                    box.Items.Add(_fArray[i].ToString());
                }
            }
            public void UpdateOutput(int paramIndex, bool newValue)
            {
                Params[paramIndex] = newValue;
            }
            public void Start(int portSize, int dataAmount, SpeedMode speed = SpeedMode.Fast)
            {
                _grasper = new AllMeterGrasper(portSize, dataAmount, speed);
            }
        }
        public enum MenuMode
        {
            StartMenu,
            AllMeterMenu,
            TemperatureMeterMenu
        }
        public string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public int _currentWidth = 800;
        public int _currentHeight = 500;

        public AllMeter _allMeter;

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
            Port.Open();
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
            //if (Port.IsOpen == false)
            //{
            //    MessageBox.Show("Choose the port please");
            //    return false;
            //}
            //if (FileName.Text == "" || FileName.Text == "Write the file name")
            //{
            //    MessageBox.Show("Write the file name please");
            //    return false;
            //}
            return true;
        }
        #endregion

        #region AllMeterPanel
        public void AllMeterInit()
        {
            if (_allMeter == null)
                _allMeter = new AllMeter();
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
            UpdateLists();
        }
        public void AllMeterMeasurementsBar_Scroll(object sender, EventArgs e)
        {
            if (_allMeter == null)
                _allMeter = new AllMeter();
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
            AllMeterMaxValue.Enabled = AllMeterMeasurementsBar.Value > 1;
            AllMeterMinValue.Enabled = AllMeterMeasurementsBar.Value > 1;
            AllMeterStandardDeviation.Enabled = AllMeterMeasurementsBar.Value > 1;
        }
        public void AllMeterMaxFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _allMeter.MaxFIndex = _allMeter.MinFIndex + 1 + AllMeterMaxFDropBox.SelectedIndex;
            UpdateLists();
        }

        public void AllMeterMinFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _allMeter.MinFIndex = AllMeterMinFDropBox.SelectedIndex;
            UpdateLists();
        }
        public void UpdateLists()
        {
            _allMeter.UpdateList(AllMeterMaxFDropBox, _allMeter.MinFIndex + 1, _allMeter._fArray.Length);
            _allMeter.UpdateList(AllMeterMinFDropBox, 0, _allMeter.MaxFIndex);
            AllMeterMaxFDropBox.Text = _allMeter._fArray[_allMeter.MaxFIndex].ToString();
            AllMeterMinFDropBox.Text = _allMeter._fArray[_allMeter.MinFIndex].ToString();
        }
        public void AllMeterC_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterD.Enabled = AllMeterC.Checked;
            if (AllMeterC.Checked == false)
                AllMeterD.Checked = false;
            AllMeterFast.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
            AllMeterSlow.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
        }

        public void AllMeterL_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterQl.Enabled = AllMeterL.Checked;
            if (AllMeterL.Checked == false)
                AllMeterQl.Checked = false;
            AllMeterFast.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
            AllMeterSlow.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
        }

        public void AllMeterR_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterQr.Enabled = AllMeterR.Checked;
            if (AllMeterR.Checked == false)
                AllMeterQr.Checked = false;
            AllMeterFast.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
            AllMeterSlow.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
        }

        public void AllMeterZ_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterFi.Enabled = AllMeterZ.Checked;
            if (AllMeterZ.Checked == false)
                AllMeterFi.Checked = false;
            AllMeterFast.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
            AllMeterSlow.Enabled = AllMeterC.Checked | AllMeterL.Checked | AllMeterR.Checked | AllMeterZ.Checked;
        }

        public void AllMeterMinValue_CheckedChanged(object sender, EventArgs e)
        {
            _allMeter.UpdateOutput(1, AllMeterMinValue.Checked);

        }

        public void AllMeterMaxValue_CheckedChanged(object sender, EventArgs e)
        {
            _allMeter.UpdateOutput(2, AllMeterMaxValue.Checked);
        }

        public void AllMeterStandardDeviation_CheckedChanged(object sender, EventArgs e)
        {
            _allMeter.UpdateOutput(3, AllMeterStandardDeviation.Checked);
        }
        public void AllMeterFast_Click(object sender, EventArgs e)
        {            
            _allMeter.Start(PACK_LENGTH, AllMeterMeasurementsBar.Value);
        }

        public void AllMeterSlow_Click(object sender, EventArgs e)
        {
            _allMeter.Start(PACK_LENGTH, AllMeterMeasurementsBar.Value, SpeedMode.Slow);
        }
        private void AllMeterStandardDeviation_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        #endregion

        #region TemperatureMeterPanel

        #endregion

        public void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}
