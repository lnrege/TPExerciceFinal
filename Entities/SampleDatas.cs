using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
	public static class SampleDatas
	{
		public static List<Vehicule> GetSampleVehicules(List<Vehicule> vehicules)
		{
			vehicules.Add(new Vehicule(1001, "SEAT", "CORDOBA"));
			vehicules.Add(new Vehicule(1002, "SEAT", "LEON"));
			vehicules.Add(new Vehicule(1003, "SEAT", "IBIZA"));
			vehicules.Add(new Voiture(1004, "RENAULT", "5008", 5));
			vehicules.Add(new Camion(1005, "RENAULT", "TRAFFIC", 345.2));
			return vehicules;
		}
	}
}
