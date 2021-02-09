using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class DowódRejestracyjnny
    {
        public readonly string nrRejestracji;//"PO 12345"

        public DowódRejestracyjnny()
        {
            //obiekt losujący liczbę
            Random random = new Random();
            //przypisywanie nr rejestracji
            nrRejestracji = "PO" + random.Next(10000, 99999).ToString();

        }
    }
}
