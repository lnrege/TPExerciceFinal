using Entities;
using static Entities.SampleDatas;
using TPExerciceFinal;
using static TPExerciceFinal.CRUD;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TPExerciceFinal
{
	class Program : Common
	{
		static void Main(string[] args)
		{

			//Création de la liste de véhicules;
			List<Vehicule> vehicules = new List<Vehicule>();

			//Création fichier json de sauvegarde
			string fichierListeVehicules = "ListeVehicules.json";

			//Affichage du menu
			Menu();
			//Récupération du choix saisi par l'utilisateur
			var choix = GetIntFromConsole();

			while (choix != 0)
			{
				switch (choix)
				{
					case 1: CreateVehicule(vehicules); break;
					case 2: LoadSampleDatas(vehicules); break;
					case 3: DisplayAllVehicules(vehicules); break;
					case 4: DisplayVehicule(vehicules); break;
					case 5: UpdateVehicule(vehicules); break;
					case 6: DeleteVehicule(vehicules); break;
					case 7: SortVehicule(vehicules); break;
					case 8: FilterVehicule(vehicules); break;
					case 9: SaveVehicules(vehicules, fichierListeVehicules);break;
					case 10: LoadVehicules(fichierListeVehicules);break;
				}

				//Affichage du menu
				Menu();
				//récupération du choix saisi par l'utilisateur
				choix = GetIntFromConsole();
			}
			ExitConsoleApp();
		}
	}
}