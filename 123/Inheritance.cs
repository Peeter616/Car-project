using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123

{
    public partial class Inheritance : Form
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        //deklaracja obiektu
        vehicle pojazd;

        private void button1_Click_1(object sender, EventArgs e)
        {
            //tworzenie obiektu
            // pojazd = new Pojazd(0, "jakiś pojazd"); 

            //wykorzystanie dziedziczenia
            pojazd = new Samochod();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pojazd.Przyspiesz(25);
            //aktualizacja przebiegu
            pojazd.RysujPrzebiegPrędkości(chart1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pojazd.Zwolnij(20);
            //aktualizacja przebiegu
            pojazd.RysujPrzebiegPrędkości(chart1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //wyswietlenie aktualnej prędkości pojazdu
            pojazd.AktualnaPrędkośćPojazdu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //vehicle pojazd = new vehicle();
            //vehicle.AktualnaPrędkośćPojazdu();

            vehicle samochód = new Samochod();
            samochód.AktualnaPrędkośćPojazdu();

            vehicle samochodElektryczny = new ElCar();
            samochodElektryczny.AktualnaPrędkośćPojazdu();
        }
    }
}
