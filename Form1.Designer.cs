
namespace Mini_Projet_Gestion_Visite
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Title_Bar = new System.Windows.Forms.Panel();
			this.minimize_Btn_Panel = new System.Windows.Forms.Panel();
			this.Titre_Label = new System.Windows.Forms.Label();
			this.close_Btn_Panel = new System.Windows.Forms.Panel();
			this.InputsPanel = new System.Windows.Forms.Panel();
			this.calculerBtn_Panel = new System.Windows.Forms.Panel();
			this.yField = new System.Windows.Forms.TextBox();
			this.xField = new System.Windows.Forms.TextBox();
			this.nomField = new System.Windows.Forms.TextBox();
			this.idField = new System.Windows.Forms.TextBox();
			this.position_shape_label = new System.Windows.Forms.Label();
			this.Position_label = new System.Windows.Forms.Label();
			this.Nom_label = new System.Windows.Forms.Label();
			this.ID_label = new System.Windows.Forms.Label();
			this.inputs_Heading = new System.Windows.Forms.Panel();
			this.heading = new System.Windows.Forms.Label();
			this.Clients_Info_Panel = new System.Windows.Forms.Panel();
			this.ClientsDataGrid = new System.Windows.Forms.DataGridView();
			this.Clients_heading_Panel = new System.Windows.Forms.Panel();
			this.clients_heading_label = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TotaleDistanceLabel = new System.Windows.Forms.Label();
			this.distance_Label = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.info_Label = new System.Windows.Forms.Label();
			this.pathDataGrid = new System.Windows.Forms.DataGridView();
			this.Title_Bar.SuspendLayout();
			this.InputsPanel.SuspendLayout();
			this.inputs_Heading.SuspendLayout();
			this.Clients_Info_Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
			this.Clients_heading_Panel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pathDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Title_Bar
			// 
			this.Title_Bar.AllowDrop = true;
			this.Title_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.Title_Bar.Controls.Add(this.minimize_Btn_Panel);
			this.Title_Bar.Controls.Add(this.Titre_Label);
			this.Title_Bar.Controls.Add(this.close_Btn_Panel);
			this.Title_Bar.Location = new System.Drawing.Point(0, 0);
			this.Title_Bar.Margin = new System.Windows.Forms.Padding(0);
			this.Title_Bar.Name = "Title_Bar";
			this.Title_Bar.Size = new System.Drawing.Size(700, 25);
			this.Title_Bar.TabIndex = 0;
			this.Title_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_Bar_MouseDown);
			this.Title_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_Bar_MouseMove);
			// 
			// minimize_Btn_Panel
			// 
			this.minimize_Btn_Panel.BackColor = System.Drawing.Color.Transparent;
			this.minimize_Btn_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_Btn_Panel.BackgroundImage")));
			this.minimize_Btn_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.minimize_Btn_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.minimize_Btn_Panel.ForeColor = System.Drawing.Color.Transparent;
			this.minimize_Btn_Panel.Location = new System.Drawing.Point(645, 0);
			this.minimize_Btn_Panel.Margin = new System.Windows.Forms.Padding(0);
			this.minimize_Btn_Panel.Name = "minimize_Btn_Panel";
			this.minimize_Btn_Panel.Size = new System.Drawing.Size(25, 25);
			this.minimize_Btn_Panel.TabIndex = 1;
			this.minimize_Btn_Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimize_Btn_Panel_MouseClick);
			this.minimize_Btn_Panel.MouseEnter += new System.EventHandler(this.minimize_Btn_Panel_MouseEnter);
			this.minimize_Btn_Panel.MouseLeave += new System.EventHandler(this.minimize_Btn_Panel_MouseLeave);
			// 
			// Titre_Label
			// 
			this.Titre_Label.AutoSize = true;
			this.Titre_Label.BackColor = System.Drawing.Color.Transparent;
			this.Titre_Label.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Titre_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(54)))));
			this.Titre_Label.Location = new System.Drawing.Point(10, 7);
			this.Titre_Label.Margin = new System.Windows.Forms.Padding(0);
			this.Titre_Label.Name = "Titre_Label";
			this.Titre_Label.Size = new System.Drawing.Size(152, 13);
			this.Titre_Label.TabIndex = 1;
			this.Titre_Label.Text = "Application-Gestion Visite";
			this.Titre_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// close_Btn_Panel
			// 
			this.close_Btn_Panel.BackColor = System.Drawing.Color.Transparent;
			this.close_Btn_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_Btn_Panel.BackgroundImage")));
			this.close_Btn_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.close_Btn_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close_Btn_Panel.ForeColor = System.Drawing.Color.Transparent;
			this.close_Btn_Panel.Location = new System.Drawing.Point(672, 0);
			this.close_Btn_Panel.Margin = new System.Windows.Forms.Padding(0);
			this.close_Btn_Panel.Name = "close_Btn_Panel";
			this.close_Btn_Panel.Size = new System.Drawing.Size(25, 25);
			this.close_Btn_Panel.TabIndex = 0;
			this.close_Btn_Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_Btn_Panel_MouseClick);
			this.close_Btn_Panel.MouseEnter += new System.EventHandler(this.close_Btn_Panel_MouseEnter);
			this.close_Btn_Panel.MouseLeave += new System.EventHandler(this.close_Btn_Panel_MouseLeave);
			// 
			// InputsPanel
			// 
			this.InputsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.InputsPanel.Controls.Add(this.calculerBtn_Panel);
			this.InputsPanel.Controls.Add(this.yField);
			this.InputsPanel.Controls.Add(this.xField);
			this.InputsPanel.Controls.Add(this.nomField);
			this.InputsPanel.Controls.Add(this.idField);
			this.InputsPanel.Controls.Add(this.position_shape_label);
			this.InputsPanel.Controls.Add(this.Position_label);
			this.InputsPanel.Controls.Add(this.Nom_label);
			this.InputsPanel.Controls.Add(this.ID_label);
			this.InputsPanel.Controls.Add(this.inputs_Heading);
			this.InputsPanel.Location = new System.Drawing.Point(20, 45);
			this.InputsPanel.Margin = new System.Windows.Forms.Padding(0);
			this.InputsPanel.Name = "InputsPanel";
			this.InputsPanel.Size = new System.Drawing.Size(290, 180);
			this.InputsPanel.TabIndex = 1;
			// 
			// calculerBtn_Panel
			// 
			this.calculerBtn_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.calculerBtn_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.calculerBtn_Panel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.calculerBtn_Panel.Location = new System.Drawing.Point(84, 140);
			this.calculerBtn_Panel.Margin = new System.Windows.Forms.Padding(0);
			this.calculerBtn_Panel.Name = "calculerBtn_Panel";
			this.calculerBtn_Panel.Size = new System.Drawing.Size(120, 30);
			this.calculerBtn_Panel.TabIndex = 9;
			this.calculerBtn_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.calculerBtn_Panel_Paint);
			this.calculerBtn_Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calculerBtn_Panel_MouseClick);
			this.calculerBtn_Panel.MouseEnter += new System.EventHandler(this.calculerBtn_Panel_MouseEnter);
			this.calculerBtn_Panel.MouseLeave += new System.EventHandler(this.calculerBtn_Panel_MouseLeave);
			// 
			// yField
			// 
			this.yField.BackColor = System.Drawing.Color.White;
			this.yField.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.yField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(159)))), ((int)(((byte)(178)))));
			this.yField.Location = new System.Drawing.Point(201, 107);
			this.yField.Margin = new System.Windows.Forms.Padding(0);
			this.yField.Name = "yField";
			this.yField.Size = new System.Drawing.Size(58, 20);
			this.yField.TabIndex = 8;
			this.yField.Text = "Y";
			this.yField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// xField
			// 
			this.xField.BackColor = System.Drawing.Color.White;
			this.xField.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.xField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(159)))), ((int)(((byte)(178)))));
			this.xField.Location = new System.Drawing.Point(119, 107);
			this.xField.Margin = new System.Windows.Forms.Padding(0);
			this.xField.Name = "xField";
			this.xField.Size = new System.Drawing.Size(58, 20);
			this.xField.TabIndex = 7;
			this.xField.Text = "X";
			this.xField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nomField
			// 
			this.nomField.BackColor = System.Drawing.Color.White;
			this.nomField.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nomField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(159)))), ((int)(((byte)(178)))));
			this.nomField.Location = new System.Drawing.Point(119, 77);
			this.nomField.Margin = new System.Windows.Forms.Padding(0);
			this.nomField.Name = "nomField";
			this.nomField.Size = new System.Drawing.Size(140, 20);
			this.nomField.TabIndex = 6;
			this.nomField.Text = "nom..";
			// 
			// idField
			// 
			this.idField.BackColor = System.Drawing.Color.White;
			this.idField.Enabled = false;
			this.idField.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.idField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(159)))), ((int)(((byte)(178)))));
			this.idField.Location = new System.Drawing.Point(119, 47);
			this.idField.Margin = new System.Windows.Forms.Padding(0);
			this.idField.Name = "idField";
			this.idField.Size = new System.Drawing.Size(58, 20);
			this.idField.TabIndex = 5;
			this.idField.Text = "id..";
			// 
			// position_shape_label
			// 
			this.position_shape_label.AutoSize = true;
			this.position_shape_label.BackColor = System.Drawing.Color.Transparent;
			this.position_shape_label.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.position_shape_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.position_shape_label.Location = new System.Drawing.Point(97, 102);
			this.position_shape_label.Margin = new System.Windows.Forms.Padding(0);
			this.position_shape_label.Name = "position_shape_label";
			this.position_shape_label.Size = new System.Drawing.Size(184, 23);
			this.position_shape_label.TabIndex = 4;
			this.position_shape_label.Text = "(           ,          )";
			this.position_shape_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Position_label
			// 
			this.Position_label.AutoSize = true;
			this.Position_label.BackColor = System.Drawing.Color.Transparent;
			this.Position_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Position_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.Position_label.Location = new System.Drawing.Point(15, 109);
			this.Position_label.Margin = new System.Windows.Forms.Padding(0);
			this.Position_label.Name = "Position_label";
			this.Position_label.Size = new System.Drawing.Size(57, 14);
			this.Position_label.TabIndex = 3;
			this.Position_label.Text = "Position";
			this.Position_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Nom_label
			// 
			this.Nom_label.AutoSize = true;
			this.Nom_label.BackColor = System.Drawing.Color.Transparent;
			this.Nom_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Nom_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.Nom_label.Location = new System.Drawing.Point(15, 79);
			this.Nom_label.Margin = new System.Windows.Forms.Padding(0);
			this.Nom_label.Name = "Nom_label";
			this.Nom_label.Size = new System.Drawing.Size(35, 14);
			this.Nom_label.TabIndex = 2;
			this.Nom_label.Text = "Nom";
			this.Nom_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ID_label
			// 
			this.ID_label.AutoSize = true;
			this.ID_label.BackColor = System.Drawing.Color.Transparent;
			this.ID_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ID_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.ID_label.Location = new System.Drawing.Point(15, 49);
			this.ID_label.Margin = new System.Windows.Forms.Padding(0);
			this.ID_label.Name = "ID_label";
			this.ID_label.Size = new System.Drawing.Size(21, 14);
			this.ID_label.TabIndex = 1;
			this.ID_label.Text = "ID";
			this.ID_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputs_Heading
			// 
			this.inputs_Heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(54)))));
			this.inputs_Heading.Controls.Add(this.heading);
			this.inputs_Heading.Location = new System.Drawing.Point(0, 0);
			this.inputs_Heading.Margin = new System.Windows.Forms.Padding(0);
			this.inputs_Heading.Name = "inputs_Heading";
			this.inputs_Heading.Size = new System.Drawing.Size(350, 30);
			this.inputs_Heading.TabIndex = 0;
			// 
			// heading
			// 
			this.heading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.heading.AutoSize = true;
			this.heading.BackColor = System.Drawing.Color.Transparent;
			this.heading.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.heading.Location = new System.Drawing.Point(72, 2);
			this.heading.Margin = new System.Windows.Forms.Padding(0);
			this.heading.Name = "heading";
			this.heading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.heading.Size = new System.Drawing.Size(144, 25);
			this.heading.TabIndex = 0;
			this.heading.Text = "Commercial";
			this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Clients_Info_Panel
			// 
			this.Clients_Info_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.Clients_Info_Panel.Controls.Add(this.ClientsDataGrid);
			this.Clients_Info_Panel.Controls.Add(this.Clients_heading_Panel);
			this.Clients_Info_Panel.Location = new System.Drawing.Point(330, 45);
			this.Clients_Info_Panel.Margin = new System.Windows.Forms.Padding(0);
			this.Clients_Info_Panel.Name = "Clients_Info_Panel";
			this.Clients_Info_Panel.Size = new System.Drawing.Size(350, 180);
			this.Clients_Info_Panel.TabIndex = 10;
			// 
			// ClientsDataGrid
			// 
			this.ClientsDataGrid.AllowUserToResizeRows = false;
			this.ClientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ClientsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.ClientsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ClientsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.ClientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(195)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ClientsDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
			this.ClientsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
			this.ClientsDataGrid.Location = new System.Drawing.Point(10, 37);
			this.ClientsDataGrid.Margin = new System.Windows.Forms.Padding(0);
			this.ClientsDataGrid.Name = "ClientsDataGrid";
			this.ClientsDataGrid.ReadOnly = true;
			this.ClientsDataGrid.RowHeadersVisible = false;
			this.ClientsDataGrid.RowHeadersWidth = 15;
			this.ClientsDataGrid.RowTemplate.ReadOnly = true;
			this.ClientsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ClientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ClientsDataGrid.Size = new System.Drawing.Size(330, 135);
			this.ClientsDataGrid.TabIndex = 1;
			// 
			// Clients_heading_Panel
			// 
			this.Clients_heading_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(54)))));
			this.Clients_heading_Panel.Controls.Add(this.clients_heading_label);
			this.Clients_heading_Panel.Location = new System.Drawing.Point(0, 0);
			this.Clients_heading_Panel.Margin = new System.Windows.Forms.Padding(0);
			this.Clients_heading_Panel.Name = "Clients_heading_Panel";
			this.Clients_heading_Panel.Size = new System.Drawing.Size(350, 30);
			this.Clients_heading_Panel.TabIndex = 0;
			// 
			// clients_heading_label
			// 
			this.clients_heading_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clients_heading_label.AutoSize = true;
			this.clients_heading_label.BackColor = System.Drawing.Color.Transparent;
			this.clients_heading_label.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.clients_heading_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.clients_heading_label.Location = new System.Drawing.Point(78, 2);
			this.clients_heading_label.Margin = new System.Windows.Forms.Padding(0);
			this.clients_heading_label.Name = "clients_heading_label";
			this.clients_heading_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clients_heading_label.Size = new System.Drawing.Size(195, 25);
			this.clients_heading_label.TabIndex = 0;
			this.clients_heading_label.Text = "Liste des Clients";
			this.clients_heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.panel1.Controls.Add(this.TotaleDistanceLabel);
			this.panel1.Controls.Add(this.distance_Label);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.info_Label);
			this.panel1.Controls.Add(this.pathDataGrid);
			this.panel1.Location = new System.Drawing.Point(20, 234);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(660, 180);
			this.panel1.TabIndex = 11;
			// 
			// TotaleDistanceLabel
			// 
			this.TotaleDistanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(54)))));
			this.TotaleDistanceLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TotaleDistanceLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TotaleDistanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.TotaleDistanceLabel.Location = new System.Drawing.Point(449, 66);
			this.TotaleDistanceLabel.Margin = new System.Windows.Forms.Padding(0);
			this.TotaleDistanceLabel.Name = "TotaleDistanceLabel";
			this.TotaleDistanceLabel.Size = new System.Drawing.Size(210, 72);
			this.TotaleDistanceLabel.TabIndex = 5;
			this.TotaleDistanceLabel.Text = "0.00";
			this.TotaleDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// distance_Label
			// 
			this.distance_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(54)))));
			this.distance_Label.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.distance_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			this.distance_Label.Location = new System.Drawing.Point(458, 14);
			this.distance_Label.Margin = new System.Windows.Forms.Padding(0);
			this.distance_Label.Name = "distance_Label";
			this.distance_Label.Size = new System.Drawing.Size(192, 52);
			this.distance_Label.TabIndex = 4;
			this.distance_Label.Text = "Path Distance";
			this.distance_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(54)))));
			this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(449, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(211, 180);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// info_Label
			// 
			this.info_Label.AutoSize = true;
			this.info_Label.BackColor = System.Drawing.Color.Transparent;
			this.info_Label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.info_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.info_Label.Location = new System.Drawing.Point(8, 14);
			this.info_Label.Margin = new System.Windows.Forms.Padding(0);
			this.info_Label.Name = "info_Label";
			this.info_Label.Size = new System.Drawing.Size(295, 14);
			this.info_Label.TabIndex = 2;
			this.info_Label.Text = "Voici les clients à ordre du plus cours chemin :";
			// 
			// pathDataGrid
			// 
			this.pathDataGrid.AllowUserToResizeRows = false;
			this.pathDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.pathDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.pathDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.pathDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.pathDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(195)))), ((int)(((byte)(133)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.pathDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
			this.pathDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
			this.pathDataGrid.Location = new System.Drawing.Point(10, 35);
			this.pathDataGrid.Margin = new System.Windows.Forms.Padding(0);
			this.pathDataGrid.Name = "pathDataGrid";
			this.pathDataGrid.ReadOnly = true;
			this.pathDataGrid.RowHeadersVisible = false;
			this.pathDataGrid.RowHeadersWidth = 15;
			this.pathDataGrid.RowTemplate.ReadOnly = true;
			this.pathDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.pathDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.pathDataGrid.Size = new System.Drawing.Size(430, 135);
			this.pathDataGrid.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
			this.ClientSize = new System.Drawing.Size(700, 440);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Clients_Info_Panel);
			this.Controls.Add(this.InputsPanel);
			this.Controls.Add(this.Title_Bar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Title_Bar.ResumeLayout(false);
			this.Title_Bar.PerformLayout();
			this.InputsPanel.ResumeLayout(false);
			this.InputsPanel.PerformLayout();
			this.inputs_Heading.ResumeLayout(false);
			this.inputs_Heading.PerformLayout();
			this.Clients_Info_Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
			this.Clients_heading_Panel.ResumeLayout(false);
			this.Clients_heading_Panel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pathDataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Title_Bar;
		private System.Windows.Forms.Label Titre_Label;
		private System.Windows.Forms.Panel close_Btn_Panel;
		private System.Windows.Forms.Panel minimize_Btn_Panel;
		private System.Windows.Forms.Panel InputsPanel;
		private System.Windows.Forms.Panel inputs_Heading;
		private System.Windows.Forms.Label heading;
		private System.Windows.Forms.Label position_shape_label;
		private System.Windows.Forms.Label Position_label;
		private System.Windows.Forms.Label Nom_label;
		private System.Windows.Forms.Label ID_label;
		private System.Windows.Forms.TextBox idField;
		private System.Windows.Forms.TextBox yField;
		private System.Windows.Forms.TextBox xField;
		private System.Windows.Forms.TextBox nomField;
		private System.Windows.Forms.Panel calculerBtn_Panel;
		private System.Windows.Forms.Panel Clients_Info_Panel;
		private System.Windows.Forms.DataGridView ClientsDataGrid;
		private System.Windows.Forms.Panel Clients_heading_Panel;
		private System.Windows.Forms.Label clients_heading_label;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView pathDataGrid;
		private System.Windows.Forms.Label distance_Label;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Label info_Label;
		private System.Windows.Forms.Label TotaleDistanceLabel;
	}
}

