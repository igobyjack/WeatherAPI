using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherAPI.Processes;
using WeatherAPI.Services;

namespace WeatherAPI
{
    public partial class WeatherAPIForm : Form
    {
        public WeatherAPIForm()
        {
            InitializeComponent();
        }

        private void WeatherAPIForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            int enteredValue = int.Parse(txtZip.Text.Trim());
            List<Models.Weather> result = null;
            try
            {
                result = WeatherService.GetWeather(enteredValue, true);
                txtCity.Text = result[0].City;
                txtHigh.Text = result[0].HighTemp;
                txtFeels.Text = result[0].FeelsLike;
                txtClouds.Text = result[0].Clouds;
                txtTemp.Text = result[0].CurrentTemp;
                txtHigh.Text = result[0].HighTemp;
                txtLow.Text = result[0].LowTemp;
                txtLatitude.Text = result[0].Latitude;
                txtLongitude.Text = result[0].Longitude;
                txtWind.Text = result[0].Wind;
            } catch (ArgumentException ex) {
                txtZip.Text = ex.Message;
            }
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
