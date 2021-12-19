using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace LedenLijstForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string APIKey = "f5f5622710976d593af7220bb231d439";
        private void btnZoeken_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid{1}", txtCity.Text, APIKey);
                var json = web.DownloadString(url);
                Weerbericht.root Info = JsonConvert.DeserializeObject<Weerbericht.root>(json);

                pbIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                ToestandResult.Text = Info.weather[0].main;
                DetailsResult.Text = Info.weather[0].description;
                //ZonsopgangResult.Text = Info.sys.sunset.ToString();
                //ZonsondergangResult.Text = Info.sys.sunset.ToString();
                WindsnelheidResult.Text = Info.wind.speed.ToString();
                LuchtdrukResult.Text = Info.main.pressure.ToString();

            }
        }
    }
}
