using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Camion : Vehicule
	{
		//accesseur
		public double Poids { get; set; }

		//constructeur
		public Camion(int num, string marque, string modele, double poids) : base(num, marque, modele)
		{
			Poids = poids;
		}

		//méthodes

		public override string Afficher()
		{
			return string.Format("Numéro: {0}, Marque: {1}, Modèle: {2}, Poids: {3}", Numero, Marque, Modele, Poids);
		}

		public override string ToString()
		{
			return $"Numéro: {Numero}, Marque: {Marque}, Modèle: {Modele}, Poids: {Poids}";
		}
	}
}
