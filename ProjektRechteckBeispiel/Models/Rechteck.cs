using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektRechteckBeispiel.Models
{

	//POCO - PLAIN OLD C# OBJECT vs POJO
	internal class Rechteck:  INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        private int _Laenge;

        public string SpruchDesTages { get; set; }

        public int Laenge
		{
			get { return _Laenge; }
			set { 
				_Laenge = value; 

			if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Laenge"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Umfang"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Flaeche"));
                }


            }
		}


		private void RaiseChagneEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int _Breite;

		public int Breite
		{
			get { return _Breite; }
			set { _Breite = value;
                RaiseChagneEvent("Breite");
                RaiseChagneEvent("Umfang");
                RaiseChagneEvent("Flaeche");
            }
		}

		//snippet propfull

		private string _Farbe;

     

        public string Farbe
		{
			get { return _Farbe; }
			set
			{
				_Farbe = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Farbe"));
				}
			}
		}

		public string Umfang
		{
			get { return "Umfang " + (2 * (Laenge + Breite)); }

		}
		public int Flaeche
		{
			get { return Laenge * Breite; }
		}
	}
    }
