using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace _123
{
    abstract class vehicle
    {
        //protected = private + możliwość dziedziczenia
        //deklaracja cech wspólnych pojazdów
        protected string opisPojazdu;
        protected double aktualnaPrędkość;
        protected double[] tablicaZmianPrędkości;

        //konstruktor domyślny
        public vehicle()
        {
            //tworzenie tablicy
            tablicaZmianPrędkości = new double[0];
        }

        //konstruktor przeciążony
        public vehicle(double prędkośćPoczątkowa, string opis) : this() //:this() - wymusza wywołanie konstruktora domyślnego z tej klasy
        {
            this.aktualnaPrędkość = prędkośćPoczątkowa;
            this.opisPojazdu = opis;
        }

        abstract public void Przyspiesz(int dV);

        abstract public void Zwolnij(int dV);

        /// <summary>
        /// metoda wirtualna będzie mogła być nadpisywana w klasach dziedziczących (uruchomienie polimorfizmu)
        /// </summary>
        public virtual void AktualnaPrędkośćPojazdu()
        {
            MessageBox.Show("Aktualna prędkość pojazdu = " + aktualnaPrędkość.ToString());
        }

        public void RysujPrzebiegPrędkości(System.Windows.Forms.DataVisualization.Charting.Chart wykres)
        {
            //zmiana typu wykresu na liniowy
            wykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            //czyszczenie punktow wykresu przed ponownym narysowaniem
            wykres.Series[0].Points.Clear();
            //rysowanie przebiegu
            for (int i = 0; i < tablicaZmianPrędkości.Length; i++)
                wykres.Series[0].Points.AddY(tablicaZmianPrędkości[i]); //addY - rysuje wykres od 0 
        }

    }
}

