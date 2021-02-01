using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mini_Projet_Gestion_Visite.model;


namespace Mini_Projet_Gestion_Visite
{
	public partial class Form1 : Form
	{
		// last point that our mouse clicked and moved towards it
		Point lastPoint;

		// DataBase DB()
		DB dataBase = new DB();
		// Notre Commercial
		Personne commercial;
		// Liste des Clients déja visités
		List<int> dejavisite;
		// Liste des ID des personne en ordre pour avoir le plus cours chemin
		List<Personne> ordre;


		public Form1()
		{
			InitializeComponent();
			// SET the id to the last Incremented ID
			idField.Text = (dataBase.clients.Count+1).ToString();

			// SHOW LIST OF CLIENTS
			ClientsDataGrid.DataSource = dataBase.clients.Select(c => new { c.id, c.nom, c.position.x, c.position.y }).ToList();
			ClientsDataGrid.Columns[0].HeaderText = "ID";
			ClientsDataGrid.Columns[1].HeaderText = "Nom";
			ClientsDataGrid.Columns[2].HeaderText = "X";
			ClientsDataGrid.Columns[3].HeaderText = "Y";
		}

		private void close_Btn_Panel_MouseEnter(object sender, EventArgs e)
		{
			close_Btn_Panel.BackgroundImage = Properties.Resources.close_18px_hover;
		}

		private void close_Btn_Panel_MouseLeave(object sender, EventArgs e)
		{
			close_Btn_Panel.BackgroundImage = Properties.Resources.close_18px;
		}

		private void minimize_Btn_Panel_MouseEnter(object sender, EventArgs e)
		{
			minimize_Btn_Panel.BackgroundImage = Properties.Resources.minimize_18px_hover;
		}

		private void minimize_Btn_Panel_MouseLeave(object sender, EventArgs e)
		{
			minimize_Btn_Panel.BackgroundImage = Properties.Resources.minimize_18px;
		}

		// Exit Application [ CLOSE X]
		private void close_Btn_Panel_MouseClick(object sender, MouseEventArgs e)
		{
			Application.Exit();
		}

		// Minimize Window [ MINIMIZE --- ]
		private void minimize_Btn_Panel_MouseClick(object sender, MouseEventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		// Drag and move window By Title_Bar [ DRAG & MOVE ]
		private void Title_Bar_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		// Store LastPoint (Mouse Position in Click by Left Button event )
		private void Title_Bar_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void calculerBtn_Panel_MouseEnter(object sender, EventArgs e)
		{
			calculerBtn_Panel.BackColor = System.Drawing.Color.FromArgb(247, 156, 54);
		}

		private void calculerBtn_Panel_MouseLeave(object sender, EventArgs e)
		{
			calculerBtn_Panel.BackColor = System.Drawing.Color.FromArgb(229, 226, 238);
		}


		// CALCULER BUTTON Clicked [ Call Methods That *Calculate Distance and Short Path* to Take ]
		private void calculerBtn_Panel_MouseClick(object sender, MouseEventArgs e)
		{
			// Store Inputs and Instatiat person that is our Commercial
			string idTxt = idField.Text;
			string nomTxt = nomField.Text;
			string xTxt = xField.Text;
			string yTxt = yField.Text;
			commercial = new Personne(idTxt,nomTxt,xTxt,yTxt);
			// Reset alreadyVisited to NULL by instanciating a new object and store it
			dejavisite = new List<int>();
			// Reset Ordred List for the short path
			ordre = new List<Personne>();
			// Visite all the clients by order
			VisiteClients(commercial,dataBase.clients);
			// SET COLUMNS HEADERS TEXT
			pathDataGrid.ColumnCount = 5;
			pathDataGrid.Columns[0].Name = "ID";
			pathDataGrid.Columns[1].Name = "Nom";
			pathDataGrid.Columns[2].Name = "X";
			pathDataGrid.Columns[3].Name = "Y";
			pathDataGrid.Columns[4].Name = "Distance cumulée";
			// SHOW path Clients Order
			double distanceCumule=0;
			for (int i = 0; i < ordre.Count; i++)
			{
				double distance;
				Personne c = ordre[i];
				if (i == 0)
				{
					distance = Helper.Distance(commercial, ordre[i]);
				}
				else
				{
					distance = Helper.Distance(ordre[i-1], ordre[i]);
				}
				distanceCumule += distance;
				pathDataGrid.Rows.Add(c.id, c.nom, c.position.x, c.position.y, distanceCumule);
			}
			// Total Distance
			TotaleDistanceLabel.Text = distanceCumule.ToString();
		}

		private void VisiteClients(Personne commercial, List<Personne> clients)
		{
			Personne plusProche = CalculerPlusProcheClient(commercial,clients,dejavisite);
			if (plusProche != null)
			{
				ordre.Add(plusProche);
				dejavisite.Add(plusProche.id);
				VisiteClients(plusProche, clients);
			}
		}

		private Personne CalculerPlusProcheClient(Personne commercial, List<Personne> clients, List<int> dejavisite)
		{
			Personne plusProche = null;
			double minDistance = double.MaxValue;

			foreach (Personne c in clients)
			{
				if (!dejavisite.Contains(c.id))
				{
					double distance = Helper.Distance(commercial, c);
					if (distance < minDistance)
					{
						minDistance = distance;
						plusProche = c;
					}
				}
			}
			return plusProche;
		}

		private void calculerBtn_Panel_Paint(object sender, PaintEventArgs e)
		{
			var myGraphics = e.Graphics;
			// Paint Calculer in our panel (BUTTON)
			Font font = new Font("Verdana", 12);
			Brush brush = new SolidBrush(System.Drawing.Color.FromArgb(22, 26, 46));
			myGraphics.DrawString("Calculer", font, brush, 24, 6);
		}
	}
}
