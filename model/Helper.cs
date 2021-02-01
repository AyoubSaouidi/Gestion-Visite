using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Projet_Gestion_Visite.model
{
	public class Helper
	{

		public static double Distance(Personne person1,Personne person2)
		{
			return Distance(person1.position, person2.position);
		}

		private static double Distance(Geometry position1, Geometry position2)
		{
			double distance = Math.Sqrt(Math.Pow(position1.x-position2.x,2)+ Math.Pow(position1.y - position2.y, 2));
			return distance;
		}
	}
}
