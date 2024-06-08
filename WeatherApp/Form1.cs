using System;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using RestSharp;
using WeatherApp.Models;

namespace WeatherApp
{
    public partial class Form1 : Form
    {

        string WeatherName;
        string TemperatureC;
        string TemperatureF;
        string TemperatureFeelsLikeC;
        string TemperatureFeelsLikeF;
        string Humidity;
        string UVindex;
        string Wind;
        string Pressure;
        string CloudCover;
        string ObsTime;
        string LocalObsDateTime;

        public Form1()
        {
            InitializeComponent();
        }

        private async Task GetWeatherData(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=j1");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = await client.ExecuteGetAsync<WeatherModel>(request);

            if (response.IsSuccessful)
            {
                var model = response.Data.CurrentCondition[0];
                WeatherName = model.WeatherDesc[0].Value;
                TemperatureC = model.TempC;
                TemperatureF = model.TempF;
                TemperatureFeelsLikeC = model.FeelsLikeC;
                TemperatureFeelsLikeF = model.FeelsLikeF;
                Humidity = model.Humidity;
                UVindex = model.UvIndex;
                Wind = model.WindspeedKmph;
                Pressure = model.Pressure;
                CloudCover = model.Cloudcover;
                ObsTime = model.ObservationTime;
                LocalObsDateTime = model.LocalObsDateTime;

                Location.Text = $"{"Location:"} {location}";

                DisplayData();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DisplayData()
        {
            Data1.Text = $"Weather: {WeatherName}";
            Data2.Text = $"Temperature (Actual): {TemperatureC}°C ({TemperatureF}°F)";
            Data3.Text = $"Temperature (Feels Like): {TemperatureFeelsLikeC}°C ({TemperatureFeelsLikeF}°F)";
            Data4.Text = $"Humidity: {Humidity}%";
            Data5.Text = $"UV Index (1-12): {UVindex}";
            Data6.Text = $"Wind: {Wind} km/h";
            Data7.Text = $"Pressure (hPa): {Pressure} hPa";
            Data8.Text = $"Cloud Cover: {CloudCover}%";
            Data9.Text = $"Observation Time: {ObsTime}";
            Data10.Text = $"Local Observation Date-Time: {LocalObsDateTime}";      
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (LocationTextBox.Text != "")
            {
                try
                {
                    await GetWeatherData(LocationTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: github.com/ilkeozs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("https://github.com/ilkeozs");
        }

        private void LocationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MoveCursorToEndOfLastWord()
        {
            if (LocationTextBox.Text.Length > 0)
            {
                // Set the cursor position to the end of the last word
                LocationTextBox.SelectionStart = LocationTextBox.Text.Length + 1;
                LocationTextBox.SelectionLength = 0;
            }
        }

        private string ConvertToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        private void UpdateTitleCase()
        {
            string inputText = LocationTextBox.Text;
            string titleCaseText = ConvertToTitleCase(inputText);
            LocationTextBox.Text = titleCaseText;

            MoveCursorToEndOfLastWord();
        }

        private void LocationTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTitleCase();
        }

    }
}