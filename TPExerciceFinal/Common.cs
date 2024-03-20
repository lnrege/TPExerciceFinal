using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TPExerciceFinal
{
	class Common
	{
		/// <summary>
		/// Récupère l'entrée utilisateur
		/// </summary>
		/// <returns>la valeur saisie en chaîne de caractères</returns>
		public static string GetStringFromConsole(string Label = "Entrez la valeur")
		{
			WriteLine(Label);
			var input = ReadLine();

			while (string.IsNullOrWhiteSpace(input))
			{
				WriteLine("Entrée incorrecte, veuilllez réessayer");
				input = ReadLine();
			}

			return input;
		}

		/// <summary>
		/// Récupère l'entrée utilisateur
		/// </summary>
		/// <returns>la valeur saisie en entier</returns>
		public static int GetIntFromConsole(string Label = "Entrez la valeur")
		{
			int inputNumber;
			var input = GetStringFromConsole(Label);

			while (!int.TryParse(input, out inputNumber))
			{
				WriteLine("Entrée incorrecte, veuilllez réessayer");
				input = ReadLine();
			}

			return inputNumber;
		}

		// Méthode pour terminer le programme
		public static void ExitConsoleApp()
		{
			WriteLine("----- Programe terminé, appuyez sur Entrée pour quitter -----");
			ReadLine();
		}

		//Menu de sélection
		public static void Menu()
		{
			Console.WriteLine("Quelle action ?");
			Console.WriteLine("0 - Sortir du programme");
			Console.WriteLine("1 - Créer un véhicule");
			Console.WriteLine("2 - Charger un jeu de données existant et l'afficher");
			Console.WriteLine("3 - Afficher tous les véhicules");
			Console.WriteLine("4 - Voir un véhicule");
			Console.WriteLine("5 - Mettre à jour un véhicule");
			Console.WriteLine("6 - Supprimer un véhicule");
			Console.WriteLine("7 - Trier les véhicules");
			Console.WriteLine("8 - Filtrer les véhicules");
			Console.WriteLine("9 - Sauvegarder les véhicules");
			Console.WriteLine("10 - Charger les véhicules à partir d'un fichier");
		}
	}
}
