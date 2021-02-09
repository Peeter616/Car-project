using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class ElCar : Samochod
    {
        public override void AktualnaPrędkośćPojazdu() //nadpisanie metody
        {
            System.Windows.Forms.MessageBox.Show("Aktualna prędkość samochodu elektrycznego = "
                                                    + aktualnaPrędkość.ToString());
        }
    }
}


