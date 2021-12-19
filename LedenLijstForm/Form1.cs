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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.modelDataSet.Table);

        }

        private void geslachtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (geslachtCheckBox.CheckState == CheckState.Checked)
                geslachtCheckBox.Text = "Man";
            else if (geslachtCheckBox.CheckState == CheckState.Unchecked)
                geslachtCheckBox.Text = "Vrouw";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        string APIKey = "75b27bc9bff754a08fef1fc466d2483f";
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
                

                WindsnelheidResult.Text = Info.wind.speed.ToString();
                LuchtdrukResult.Text = Info.main.pressure.ToString();

            }
        }
    }
}
