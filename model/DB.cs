using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mini_Projet_Gestion_Visite.model
{
	public class DB
	{

		public List<Personne> clients { get; set; }

		public DB()
		{
			clients = new List<Personne>();
			clients.Add(new Personne(1, "Ali", 5, 8));
			clients.Add(new Personne(2, "Fatima", 10, 3));
			clients.Add(new Personne(3, "Driss", 7, 7));
			clients.Add(new Personne(4, "Allal", 0, 12));
			clients.Add(new Personne(5, "Rachida", -15, 0));
		}

		public Personne FindById(int id)
		{
			foreach (Personne client in clients)
			{
				if(client.id == id)
				{
					return client;
				}
			}
			return null;
			//return clients.Where(c => c.id == id).FirstOrDefault();
		}

	}
}
