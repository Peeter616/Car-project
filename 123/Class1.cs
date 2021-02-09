using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms; //na potrzeby obiektów aplikacji deskopowych
namespace _123
{
    //deklaracja typu wyliczeniowego
    enum TypSamochodu
    {
        ciezarowy,
        dostawczy,
        osobowy,
        sportowy,
        wyscigowy
    }
    class Samochod : vehicle
    {
        public string kolor;
        double mocSilnika;//[KM] - możliwa modyfikacja +-5%
        double ZnamionowaMocSilnika;
        int przebieg;//[km]
        TypSamochodu typ;
        //deklaracje obiektu innej klasy
        DowódRejestracyjnny dowód;
             
        //pole statyczne
        static int liczbaSamochodow = 0;

        public static int LiczbaSamochodow
        {
            get
            {
                return liczbaSamochodow;
            }
        }

        public int pokazPrzebieg
        {
            get
            {
                return przebieg;
            }
        }

        //wlasciwosc dla pola moc silnika 
        public double ustawMocSilnika
        {
            set //sekcja umozliwiajaca przypisanie wartosci do pola moc silnika
            {
                //kontrola warotsci parametru - if() else... - wywolanie metod sluzacych do sprawdzenia wartosci mocy
                if (value < 0)
                    MessageBox.Show("Moc silnika nie może być ujemna!");
                else
                mocSilnika = value;
                ZnamionowaMocSilnika = value;
            }
            get //sekcja umozliwiajaca zwrocenie wartosci
            {
                return mocSilnika;
            }
        }
        override public void Przyspiesz(int dV)
        {
            //zwiększenie aktualnej prędkości
            aktualnaPrędkość += dV;
            //zwiększenie rozmiaru tablicy o 1
            Array.Resize(ref tablicaZmianPrędkości, tablicaZmianPrędkości.Length + 1);
            //zapisanie wartości na ostatnie miesce w tablicy
            tablicaZmianPrędkości[tablicaZmianPrędkości.Length - 1] = aktualnaPrędkość;

        }

        override public void Zwolnij(int dV)
        {
            //if(dV > aktualnaPrędkość) //Nie mozna o tyle zwolnic itp...
            //zwiększenie aktualnej prędkości
            aktualnaPrędkość -= dV;
            //zwiększenie rozmiaru tablicy o 1
            Array.Resize(ref tablicaZmianPrędkości, tablicaZmianPrędkości.Length + 1);
            //zapisanie wartości na ostatnie miesce w tablicy
            tablicaZmianPrędkości[tablicaZmianPrędkości.Length - 1] = aktualnaPrędkość;
        }

        //konstruktor domyslny
        //przypisuje wartosci poczatkowe do pol w klasie
        public Samochod()
        {
            kolor = "Czarny";
            mocSilnika = 700;
            ZnamionowaMocSilnika = 700;
            przebieg = 1000;
            typ = TypSamochodu.wyscigowy;

            dowód = new DowódRejestracyjnny();

            liczbaSamochodow += 1;
        }

        //konstruktor przeciazony
        public Samochod(string kolor, double mocSilnika)
        {
            //this odwoluje sie do elementu klasy w ktorym obecnie sie znajdujemy
            this.kolor = kolor;
            this.mocSilnika = mocSilnika;
            liczbaSamochodow += 1;

            dowód = new DowódRejestracyjnny();
        }

        //destruktor - umozliwia wykonanie kodu w momencie usuwania obiektu z pamieci
        ~Samochod()
        {
            MessageBox.Show("Samochod zostal zezlomowany");
        }

        //technika przeciazania operatora + dla 2 obiektow typu Samochod

        public static int DodajPrzebiegi(params int[] ListaSamochodow)
        {
           
            int suma = 0;
            foreach (int i in ListaSamochodow)
            {
                suma += i;
            }
            return suma;
        }
        public static int operator +(Samochod samochod1, Samochod samochod2)
        {
            //sumowanie przebiegow
            int suma = samochod1.przebieg + samochod2.przebieg;

            //tu mozna wykonywac inne operacje

            return suma;
        }

        public void info()
        {
            MessageBox.Show("Parametry samochodu: " + "\r\n" +
                            "Kolor: " + kolor + Environment.NewLine +
                            "Moc silnika: " + mocSilnika.ToString() + "\r\n" +
                            "Przebieg: " + przebieg.ToString() + Environment.NewLine +
                            "Typ samochodu: " + typ.ToString() + "\r\n" +
                            "Numer rejestracji: " + dowód.nrRejestracji);
        }
    }
}
