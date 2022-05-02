using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _220502_MVOP
{
    public partial class PlanetPage : ContentPage
    {
        public ObservableCollection<Planet> ListOfPlanets = new ObservableCollection<Planet>();

        public PlanetPage()
        {
            InitializeComponent();
            Planet p = new Planet() { ID = 0, title = "Merkur", average = 4878, temperature = "-193 až +420", numberofmoons = 0, description = "Jedna polovina kamenné planety je vystavena zničujícímu žáru blízkého Slunce, druhá absolutnímu chladu kosmického prostoru" };
            Planet p1 = new Planet() { ID = 1, title = "Venuše", average = 12104, temperature = "+460", numberofmoons = 0, description = "Planeta s poetickým jménem, ale ve skutečnosti skleníkové peklo v husté atmosféře z oxidu uhličitého. Království vulkánů a síry" };
            Planet p2 = new Planet() { ID = 2, title = "Země", average = 12756, temperature = "-89 až +58", numberofmoons = 1, description = "Naše planeta, obdařená vodou a pro nás dýchatelným vzduchem. Jediný domov pro živé organismy, které doposud známe" };
            ListOfPlanets.Add(p); ListOfPlanets.Add(p1); ListOfPlanets.Add(p2);
            lv_planets.ItemsSource = ListOfPlanets;
        }

        private void lv_planets_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPlanet = lv_planets.SelectedItem as Planet;
            lb_planet_title.Text = selectedPlanet.title;
            lb_planet_average.Text = "Průměr: " + selectedPlanet.average.ToString() + " km";
            lb_planet_temperature.Text = "Teplota: " + selectedPlanet.temperature.ToString() + " °C";
            lb_planet_numberofmoons.Text = "Počet měsíců: " + selectedPlanet.numberofmoons.ToString();
            lb_planet_description.Text = "Popis: " + selectedPlanet.description;
        }
    }
}
