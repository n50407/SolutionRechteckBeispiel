using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektRechteckBeispiel.Models
{
    internal class Bankueberweisung : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseChangeEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private double _Ueberweisungbetrag;

        public double Ueberweisungbetrag
        {
            get { return _Ueberweisungbetrag; }
            set
            {
                _Ueberweisungbetrag = value;
                RaiseChangeEvent("Ueberweisungbetrag");
                RaiseChangeEvent("SpesenAusgabe");
            }
        }

        private bool _IstExpressAktiviert;

        public bool IstExpressAktiviert
        {
            get { return _IstExpressAktiviert; }
            set
            {
                _IstExpressAktiviert = value;
                RaiseChangeEvent("IstExpressAktiviert");
                RaiseChangeEvent("SpesenAusgabe");
                RaiseChangeEvent("SignalFarbe");
            }
        }

        public string SpesenAusgabe
        {


            get
            {
                var spesen =
                    IstExpressAktiviert ? Ueberweisungbetrag * 0.15
                    : Ueberweisungbetrag * 0.1;

                return $" Express aktiviert? {IstExpressAktiviert} Spesen: {spesen} Euro";
            }


        }

        public string SignalFarbe
        {
            get
            {
                var farbe =
                    IstExpressAktiviert ? "Red" : "Green";

                return farbe;
            }
        }
    }

}
