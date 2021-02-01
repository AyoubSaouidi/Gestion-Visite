using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Projet_Gestion_Visite.model
{
	public class Geometry
	{
		public double x { get; set; }
		public double y { get; set; }

		public Geometry()
		{

		}

		public Geometry(double x,double y)
		{
			this.x = x;
			this.y = y;
		}

		public Geometry(string textX, string textY)
		{
			this.x = Double.Parse(textX);
			this.y = Double.Parse(textY);
		}

	}
}
