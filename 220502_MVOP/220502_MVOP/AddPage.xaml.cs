using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _220502_MVOP
{
    public partial class AddPage : ContentPage
    {
        PlanetPage pp = new PlanetPage();
        public AddPage()
        {
            InitializeComponent();        
        }

        private void btn_add_Clicked(object sender, EventArgs e)
        {
            if (ent_planet_name.Text==null||ent_planet_average.Text == null ||ent_planet_temperature.Text == null ||ent_planet_numberofmoons.Text == null ||ent_planet_description.Text == null)
            {
                DisplayAlert("Chyba", "Musíte zadat všechny parametry!", "OK");
            }
            else
            {
                bool b = false;
                try
                {
                    double ave = Convert.ToDouble(ent_planet_average.Text);
                    int nof = Convert.ToInt32(ent_planet_numberofmoons.Text);
                }
                catch (Exception)
                {
                    b = true;
                }

                if (b == false)
                {
                    int id = pp.ListOfPlanets.Count + 1;
                    double average = Convert.ToDouble(ent_planet_average.Text);
                    int numberofmoons = Convert.ToInt32(ent_planet_numberofmoons.Text);

                    Planet planet = new Planet()
                    {
                        ID = id,
                        title = ent_planet_name.Text,
                        average = average,
                        temperature = ent_planet_temperature.Text,
                        numberofmoons = numberofmoons,
                        description = ent_planet_description.Text
                    };

                    pp.ListOfPlanets.Add(planet);
                    ent_planet_name.Text = string.Empty; ent_planet_average.Text = string.Empty; ent_planet_temperature.Text = string.Empty; ent_planet_numberofmoons.Text = string.Empty; ent_planet_description.Text = string.Empty;
                    DisplayAlert("Úspěch", "Planeta byla úspěšně vložena!", "OK");
                }
                else
                {
                    DisplayAlert("Chyba", "Parametry Průměr nebo Počet měsíců nejsou ve správném formátu!", "OK");
                }
            }
        }
    }
}
