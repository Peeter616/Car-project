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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie obiektu klasy samochód
            Samochod samochod = new Samochod();
            //wywolanie metody z wyswietlajacej wartosci parametrow samochodu
            samochod.info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Samochod samochod = new Samochod("Czerwony", 444.22);
            samochod.info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Samochod samochod = new Samochod();
            samochod.info();

            //zmiana warotsci pola
            samochod.kolor = "Szary";
            samochod.info();

            samochod.ustawMocSilnika = 111.22;
            samochod.info();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Samochod s1 = new Samochod();
            Samochod s2 = new Samochod();

            //PD - napisac metode ktora umozliwi sumowanie dowolnej ilosci obiektow typu Samochod (params)

            //sumowanie przebiegow dwoch obiektow
            int x = s1 + s2;

            MessageBox.Show(x.ToString());//zsumowana wartosc przebiegow

            //wyświetlenie wartości pola statycznego (iloscSamochodow)
            MessageBox.Show(Samochod.LiczbaSamochodow.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Samochod s10 = new Samochod();

            s10.ustawMocSilnika = Convert.ToDouble(zadanaMoc.Value);
            s10.info();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Samochod s11 = new Samochod();

            s11.ustawMocSilnika = Convert.ToDouble(zadanaMoc.Value)*(1+Convert.ToDouble(ProcentMocyZn.Value)*0.01);
            s11.info();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Samochod s13 = new Samochod();
            Samochod s14 = new Samochod();
            Samochod s15 = new Samochod();
            int x = Samochod.DodajPrzebiegi(s13.pokazPrzebieg, s14.pokazPrzebieg, s15.pokazPrzebieg);

            MessageBox.Show(x.ToString());//zsumowana wartosc przebiegow

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Samochod s16 = new Samochod();
            Samochod s17 = new Samochod();
            Samochod s18 = new Samochod();
            Samochod s19 = new Samochod();
            int x = Samochod.DodajPrzebiegi(s16.pokazPrzebieg, s17.pokazPrzebieg, s18.pokazPrzebieg, s19.pokazPrzebieg);

            MessageBox.Show(x.ToString());//zsumowana wartosc przebiegow
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //utworzenie obiektu formularza dziedziczenie
            Form form = new Inheritance();
            //wywołanie okna dialogowego
            form.ShowDialog();

        }
    }
}
