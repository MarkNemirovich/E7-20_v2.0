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
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private readonly int[] _fArray = new int[17] { 25, 50, 60, 100, 120, 200, 500, 1000, 2000, 5000, 10000, 20000, 50000, 100000, 200000, 500000, 1000000 };
        private int _maxFIndex = 1;
        private int _minFIndex = 0;
        private int _currentWidth = 800;
        private int _currentHeight = 500;

        private enum MenuMode
        {
            StartMenu,
            AllMeterMenu,
            TemperatureMeterMenu
        }
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
                    InitAllMeter();
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
        private void InitAllMeter()
        {
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
            NewList(AllMeterMaxFDropBox, _maxFIndex, _fArray.Length - 1);
            NewList(AllMeterMinFDropBox, 0, _maxFIndex-1);
            AllMeterMaxFDropBox.Text = _fArray[_maxFIndex].ToString();
            AllMeterMinFDropBox.Text = _fArray[_minFIndex].ToString();
        }
        private void NewList(ComboBox box, int from, int to)
        {
            box.Items.Clear();
            for (int i = from; i <= to; i++)
            {
                box.Items.Add(_fArray[i].ToString());
            }
        }
        private void MeasurementsBar_Scroll(object sender, EventArgs e)
        {
            AllMeterMeasurements.Text = AllMeterMeasurementsBar.Value.ToString();
        }
        private void MaxFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _maxFIndex = _minFIndex + 1 + AllMeterMaxFDropBox.SelectedIndex;
            NewList(AllMeterMaxFDropBox, _minFIndex + 1, _fArray.Length - 1);
            NewList(AllMeterMinFDropBox, 0, _maxFIndex - 1);
            AllMeterMaxFDropBox.Text = _fArray[_maxFIndex].ToString();
        }

        private void MinFDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _minFIndex = AllMeterMinFDropBox.SelectedIndex;
            NewList(AllMeterMaxFDropBox, _minFIndex + 1, _fArray.Length - 1);
            NewList(AllMeterMinFDropBox, 0, _maxFIndex - 1);
            AllMeterMinFDropBox.Text = _fArray[_minFIndex].ToString();
        }

        #endregion

        #region TemperatureMeterPanel
        #endregion

    }
}
