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
        private class AllMeter
        {
            public readonly int[] _fArray = new int[17] { 25, 50, 60, 100, 120, 200, 500, 1000, 2000, 5000, 10000, 20000, 50000, 100000, 200000, 500000, 1000000 };
            public bool[] Modes { get; private set; }
            public bool[] Params { get; private set; }

            public int MaxFIndex = 1;
            public int MinFIndex = 0;
            public int GetF(int index) => _fArray[index];

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
        }
        private enum MenuMode
        {
            StartMenu,
            AllMeterMenu,
            TemperatureMeterMenu
        }
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private int _currentWidth = 800;
        private int _currentHeight = 500;

        private AllMeter _allMeter;

        public App()
        {
            InitializeComponent();
        }
        private void App_Load(object sender, EventArgs e)
        {
            DirectoryPath.Text = _folderPath;
            ChangeMenuInterface(MenuMode.StartMenu);
        }
        private void App_Resize(object sender, EventArgs e)
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
            StartButton.Visible = (mode != MenuMode.StartMenu);
            ReturnButton.Visible = (mode != MenuMode.StartMenu);
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
        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            _folderPath = FolderBrowserDialog.SelectedPath;
            DirectoryPath.Text = _folderPath;
        }
        private void PortsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortsList.SelectedItem.ToString() == null)
                return;
            if (Port.IsOpen)
                Port.Close();
            Port.Open();
        }
        private void AllMeterButton_Click(object sender, EventArgs e)
        {
            if (CheckGeneralInput() == false)
                return;
            ChangeMenuInterface(MenuMode.AllMeterMenu);
        }
        private void TemperatureMeterButton_Click(object sender, EventArgs e)
        {
            if (CheckGeneralInput() == false)
                return;
            ChangeMenuInterface(MenuMode.TemperatureMeterMenu);
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ChangeMenuInterface(MenuMode.StartMenu);
        }
        private bool CheckGeneralInput()
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
        private void AllMeterInit()
        {
            if (_allMeter == null)
                _allMeter = new AllMeter();
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
            UpdateLists();
        }
        private void AllMeterMeasurementsBar_Scroll(object sender, EventArgs e)
        {
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
        }
        private void AllMeterMaxFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _allMeter.MaxFIndex = _allMeter.MinFIndex + 1 + AllMeterMaxFDropBox.SelectedIndex;
            UpdateLists();
        }

        private void AllMeterMinFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _allMeter.MinFIndex = AllMeterMinFDropBox.SelectedIndex;
            UpdateLists();
        }
        private void UpdateLists()
        {
            _allMeter.UpdateList(AllMeterMaxFDropBox, _allMeter.MinFIndex + 1, _allMeter._fArray.Length);
            _allMeter.UpdateList(AllMeterMinFDropBox, 0, _allMeter.MaxFIndex);
            AllMeterMaxFDropBox.Text = _allMeter._fArray[_allMeter.MaxFIndex].ToString();
            AllMeterMinFDropBox.Text = _allMeter._fArray[_allMeter.MinFIndex].ToString();
        }
        private void AllMeterC_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterD.Enabled = AllMeterC.Checked;
            if (AllMeterC.Checked == false)
                AllMeterD.Checked = false;
        }

        private void AllMeterL_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterQl.Enabled = AllMeterL.Checked;
            if (AllMeterL.Checked == false)
                AllMeterQl.Checked = false;
        }

        private void AllMeterR_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterQr.Enabled = AllMeterR.Checked;
            if (AllMeterR.Checked == false)
                AllMeterQr.Checked = false;
        }

        private void AllMeterZ_CheckedChanged(object sender, EventArgs e)
        {
            AllMeterFi.Enabled = AllMeterZ.Checked;
            if (AllMeterZ.Checked == false)
                AllMeterFi.Checked = false;
        }

        private void AllMeterAverageValue_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AllMeterMinValue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AllMeterMaxValue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AllMeterStandardDeviation_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region TemperatureMeterPanel
        #endregion


    }
}
