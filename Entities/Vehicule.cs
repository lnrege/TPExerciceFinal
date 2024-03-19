using System.ComponentModel.DataAnnotations;
using System.Linq;
using Entities.Exceptions;
using System;

namespace Entities
{
	public class Vehicule
	{
		//Attributs
		private int _numero;
		private string _marque;

		//constructeur
		public Vehicule(int num, string marque, string modele)
		{
			Numero = num;
			Marque = marque;
			Modele = modele;
		}


		//Propriétés
		public string Marque
		{
			get { return _marque; }
			set
			{
				List<string> digits = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
				bool isDigit=false;
				foreach (var d in digits)
				{
					isDigit = value.Contains(d);
					if (isDigit) 
						throw new InvalidMarqueException("Marque invalide ! La marque ne doit pas contenir de chiffre !");
					else _marque = value;
				}
			}
		}
		public string Modele { get; set; }
		public int Numero
		{
			get { return _numero; }
			set
			{
				if ((value.ToString().Length>3) && (value.ToString().Length<7))
					_numero = value;
				else throw new InvalidNumeroException("Numéro invalide ! La longueur du numéro doit être entre 4 à 6");
			}
		}

		public virtual string Afficher()
		{
			return string.Format("Numéro: {0}, Marque: {1}, Modèle: {2}", Numero, Marque, Modele);
		}

		public override string ToString()
		{
			return $"Numéro: {Numero}, Marque: {Marque}, Modèle: {Modele}";
		}

	}
}
