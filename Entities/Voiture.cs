using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Voiture : Vehicule
	{
		//accesseur
		public double Puissance { get; set; }

		//constructeur
		public Voiture(int num, string marque, string modele, double puissance):base(num, marque, modele) 
		{
			Puissance = puissance;
		}

		//méthodes

		public override string Afficher()
		{
			return string.Format("Numéro: {0}, Marque: {1}, Modèle: {2}, Puissance: {3}", Numero, Marque, Modele, Puissance);
		}

		public override string ToString()
		{
			return $"Numéro: {Numero}, Marque: {Marque}, Modèle: {Modele}, Puissance: {Puissance}";
		}
	}
}
