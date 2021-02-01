using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Projet_Gestion_Visite.model
{
	public class Personne
	{

		public int id { get; set; }
		public string nom { get; set; }
		public Geometry position { get; set; }

		public Personne()
		{

		}

		public Personne(int id,string nom,double x, double y)
		{
			this.id = id;
			this.nom = nom;
			this.position = new Geometry(x, y);
		}

		public Personne(string textId, string nom, string textX, string textY)
		{
			this.id = int.Parse(textId);
			this.nom = nom;
			this.position = new Geometry(textX, textY);
		}

	}
}
