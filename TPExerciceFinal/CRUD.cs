﻿using Entities;
using static TPExerciceFinal.Common;
using static Entities.SampleDatas;
using System.Collections.Generic;
using System.Text.Json;

namespace TPExerciceFinal
{
	public class CRUD
	{
		public static void CreateVehicule(List<Vehicule> vehicules)
		{
			int numero = GetIntFromConsole("Numéro (Entre 4 et 6 chiffres)  ?");
			string marque = GetStringFromConsole("Marque (Sans chiffre) ?");
			string modele = GetStringFromConsole("Modèle ?");
			string type = GetStringFromConsole("Quel type ? v pour voiture, c pour camion");

			double valeurSpecifique = 0;

			if (type == "v")
				valeurSpecifique = GetIntFromConsole("Puissance ?");
			else
				valeurSpecifique = GetIntFromConsole("Poids ?");

			if (type == "v")
				vehicules.Add(new Voiture(numero, marque, modele, valeurSpecifique));
			else
				vehicules.Add(new Camion(numero, marque, modele, valeurSpecifique));

			Console.WriteLine("Véhicule créé");
		}

		public static void DisplayAllVehicules(List<Vehicule> vehicules)
		{
			foreach (var v in vehicules)
				Console.WriteLine(v.ToString());
		}
		public static void LoadSampleDatas(List<Vehicule> vehicules)
		{
			GetSampleVehicules(vehicules);
			foreach (var v in vehicules)
				Console.WriteLine(v.ToString());
		}

		//ne marche pas
		public static void UpdateVehicule(List<Vehicule> vehicules)
		{
			DisplayAllVehicules(vehicules);

			int numeroToUpdate = GetIntFromConsole("Nouveau numéro ?");

			var vehiculeToUpade = vehicules.FirstOrDefault(v => v.Numero == numeroToUpdate);

			string newMarque = GetStringFromConsole("Nouvelle marque ?");
			vehiculeToUpade.Marque = newMarque;
			string newModele = GetStringFromConsole("Nouveau modèle ?");
			vehiculeToUpade.Modele = newModele;

			if (vehiculeToUpade is Voiture voitureToUpdate)
				voitureToUpdate.Puissance = GetIntFromConsole("Nouvelle puissance ?");
			else if (vehiculeToUpade is Camion camionToUpdate)
				camionToUpdate.Poids = GetIntFromConsole("Nouveau poids ?");

			Console.WriteLine("Véhicule modifié");
		}

		public static void DeleteVehicule(List<Vehicule> vehicules)
		{
			DisplayAllVehicules(vehicules);
			var numeroToUpdate = GetIntFromConsole("Numéro à supprimer ?");
			vehicules.Remove(vehicules.FirstOrDefault(v => v.Numero == numeroToUpdate));
			Console.WriteLine("Véhicule suprimé");
		}

		public static void DisplayVehicule(List<Vehicule> vehicules)
		{
			DisplayAllVehicules(vehicules);
			int num = GetIntFromConsole("Numéro ?");
			Console.WriteLine(vehicules.FirstOrDefault(v => v.Numero == num));
		}

		public static void SortVehicule(List<Vehicule> vehicules)
		{
			var sort = GetStringFromConsole("Quel tri ? n: numéro, m: marque, o: modèle, pu => puissance (voiture seulement), po => poids (camion seulement)");

			switch (sort)
			{
				case "n":
					DisplayAllVehicules(vehicules.OrderBy(v => v.Numero).ToList());
					break;
				case "m":
					DisplayAllVehicules(vehicules.OrderBy(v => v.Marque).ToList());
					break;
				case "o":
					DisplayAllVehicules(vehicules.OrderBy(v => v.Modele).ToList());
					break;
				case "pu":
					//DisplayAllVehicules(vehicules.OrderBy(v => v.Puissance).ToList());
					break;
				case "po":
					//DisplayAllVehicules(vehicules.OrderBy(v => v.Poids).ToList());
					break;
				default:
					break;
			}
		}

		public static void FilterVehicule(List<Vehicule> vehicules)
		{
			var sort = GetStringFromConsole().ToLower();

			Console.WriteLine(string.Join("\n", vehicules.Where(v => v.Marque.ToLower().Contains(sort) || v.Modele.ToLower().Contains(sort) || v.Numero.ToString().ToLower().Contains(sort)
			 || (v is Voiture && ((Voiture)v).Puissance.ToString().ToLower().Contains(sort))
			 || (v is Camion && ((Camion)v).Poids.ToString().ToLower().Contains(sort)))));

		}

		public static string SaveVehicules(List<Vehicule> vehicules, string fichierListeVehicules)
		{
			//serialize dans un fichier
			string jsonString = JsonSerializer.Serialize(vehicules);
			File.WriteAllText(fichierListeVehicules, jsonString);
			return fichierListeVehicules;
		}

		public static void LoadVehicules(List<Vehicule> vehicules, string fichierListeVehicules)
		{
			//désérialize dans un fichier
			var contenuFichier = File.ReadAllText(fichierListeVehicules);
			var listeVehicules = JsonSerializer.Deserialize<List<Vehicule>>(contenuFichier);
			foreach (var item in listeVehicules)
			{
				Console.WriteLine(item);
			}
		}
	}
}