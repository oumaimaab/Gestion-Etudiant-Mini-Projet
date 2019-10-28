namespace GestionEtudiant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.triDecroissant = new System.Windows.Forms.Button();
            this.triCroissant = new System.Windows.Forms.Button();
            this.chargerDonnees = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.importer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cne = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.male = new System.Windows.Forms.RadioButton();
            this.ajouter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteFiliere = new System.Windows.Forms.Button();
            this.ModifierFiliere = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.validerNom = new System.Windows.Forms.Button();
            this.nouveauNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajouterFiliere = new System.Windows.Forms.Button();
            this.nomFiliere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateN = new System.Windows.Forms.TextBox();
            this.listeCne = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new GestionEtudiant.CrystalReport1();
            this.cachedCrystalReport11 = new GestionEtudiant.CachedCrystalReport1();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.charger = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(676, 128);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(634, 497);
            this.dataGridView2.TabIndex = 11;
            // 
            // triDecroissant
            // 
            this.triDecroissant.Location = new System.Drawing.Point(1118, 66);
            this.triDecroissant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.triDecroissant.Name = "triDecroissant";
            this.triDecroissant.Size = new System.Drawing.Size(171, 35);
            this.triDecroissant.TabIndex = 10;
            this.triDecroissant.Text = "Tri Décroissant";
            this.triDecroissant.UseVisualStyleBackColor = true;
            this.triDecroissant.Click += new System.EventHandler(this.triDecroissant_Click_1);
            // 
            // triCroissant
            // 
            this.triCroissant.Location = new System.Drawing.Point(909, 66);
            this.triCroissant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.triCroissant.Name = "triCroissant";
            this.triCroissant.Size = new System.Drawing.Size(171, 35);
            this.triCroissant.TabIndex = 9;
            this.triCroissant.Text = "Tri Croissant";
            this.triCroissant.UseVisualStyleBackColor = true;
            this.triCroissant.Click += new System.EventHandler(this.triCroissant_Click_1);
            // 
            // chargerDonnees
            // 
            this.chargerDonnees.Location = new System.Drawing.Point(698, 66);
            this.chargerDonnees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chargerDonnees.Name = "chargerDonnees";
            this.chargerDonnees.Size = new System.Drawing.Size(171, 35);
            this.chargerDonnees.TabIndex = 8;
            this.chargerDonnees.Text = "Charger données";
            this.chargerDonnees.UseVisualStyleBackColor = true;
            this.chargerDonnees.Click += new System.EventHandler(this.chargerDonnees_Click_1);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(394, 658);
            this.modifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 35);
            this.modifier.TabIndex = 6;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(556, 658);
            this.supprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 35);
            this.supprimer.TabIndex = 5;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // importer
            // 
            this.importer.Location = new System.Drawing.Point(756, 658);
            this.importer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importer.Name = "importer";
            this.importer.Size = new System.Drawing.Size(112, 35);
            this.importer.TabIndex = 4;
            this.importer.Text = "Importer";
            this.importer.UseVisualStyleBackColor = true;
            this.importer.Click += new System.EventHandler(this.importer_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 411);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Filière:";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(201, 360);
            this.telephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(298, 26);
            this.telephone.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 360);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Téléphone:";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(201, 303);
            this.adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(298, 26);
            this.adresse.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Adresse:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Date de naissance:";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(232, 206);
            this.female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(44, 24);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "F";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 209);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sex:";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(201, 157);
            this.prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(298, 26);
            this.prenom.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prénom:";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(201, 103);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(298, 26);
            this.Nom.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nom:";
            // 
            // cne
            // 
            this.cne.Location = new System.Drawing.Point(201, 52);
            this.cne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cne.Name = "cne";
            this.cne.Size = new System.Drawing.Size(298, 26);
            this.cne.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "CNE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Informations Etudiant";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1800, 865);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistique";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(426, 203);
            this.male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(47, 24);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "M";
            this.male.UseVisualStyleBackColor = true;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(225, 658);
            this.ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 35);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1808, 898);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteFiliere);
            this.tabPage1.Controls.Add(this.ModifierFiliere);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1358, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filière";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteFiliere
            // 
            this.deleteFiliere.Location = new System.Drawing.Point(954, 312);
            this.deleteFiliere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteFiliere.Name = "deleteFiliere";
            this.deleteFiliere.Size = new System.Drawing.Size(112, 35);
            this.deleteFiliere.TabIndex = 6;
            this.deleteFiliere.Text = "Supprimer";
            this.deleteFiliere.UseVisualStyleBackColor = true;
            this.deleteFiliere.Click += new System.EventHandler(this.deleteFiliere_Click_1);
            // 
            // ModifierFiliere
            // 
            this.ModifierFiliere.Location = new System.Drawing.Point(714, 312);
            this.ModifierFiliere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifierFiliere.Name = "ModifierFiliere";
            this.ModifierFiliere.Size = new System.Drawing.Size(112, 35);
            this.ModifierFiliere.TabIndex = 5;
            this.ModifierFiliere.Text = "Modifier";
            this.ModifierFiliere.UseVisualStyleBackColor = true;
            this.ModifierFiliere.Click += new System.EventHandler(this.ModifierFiliere_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.validerNom);
            this.panel2.Controls.Add(this.nouveauNom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(73, 312);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 160);
            this.panel2.TabIndex = 4;
            // 
            // validerNom
            // 
            this.validerNom.Location = new System.Drawing.Point(136, 111);
            this.validerNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.validerNom.Name = "validerNom";
            this.validerNom.Size = new System.Drawing.Size(171, 35);
            this.validerNom.TabIndex = 2;
            this.validerNom.Text = "Valider";
            this.validerNom.UseVisualStyleBackColor = true;
            this.validerNom.Click += new System.EventHandler(this.validerNom_Click);
            // 
            // nouveauNom
            // 
            this.nouveauNom.Location = new System.Drawing.Point(220, 46);
            this.nouveauNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nouveauNom.Name = "nouveauNom";
            this.nouveauNom.Size = new System.Drawing.Size(223, 26);
            this.nouveauNom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nouveau nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName});
            this.dataGridView1.Location = new System.Drawing.Point(636, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 231);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id_Filière";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 150;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nom_Filière";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ajouterFiliere);
            this.panel1.Controls.Add(this.nomFiliere);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 200);
            this.panel1.TabIndex = 2;
            // 
            // ajouterFiliere
            // 
            this.ajouterFiliere.Location = new System.Drawing.Point(159, 143);
            this.ajouterFiliere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ajouterFiliere.Name = "ajouterFiliere";
            this.ajouterFiliere.Size = new System.Drawing.Size(150, 35);
            this.ajouterFiliere.TabIndex = 3;
            this.ajouterFiliere.Text = "Ajouter";
            this.ajouterFiliere.UseVisualStyleBackColor = true;
            this.ajouterFiliere.Click += new System.EventHandler(this.ajouterFiliere_Click_1);
            // 
            // nomFiliere
            // 
            this.nomFiliere.Location = new System.Drawing.Point(255, 58);
            this.nomFiliere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomFiliere.Name = "nomFiliere";
            this.nomFiliere.Size = new System.Drawing.Size(211, 26);
            this.nomFiliere.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Filière";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une filière";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.triDecroissant);
            this.tabPage2.Controls.Add(this.triCroissant);
            this.tabPage2.Controls.Add(this.chargerDonnees);
            this.tabPage2.Controls.Add(this.modifier);
            this.tabPage2.Controls.Add(this.supprimer);
            this.tabPage2.Controls.Add(this.importer);
            this.tabPage2.Controls.Add(this.ajouter);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.listeCne);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1800, 865);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etudiant";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.dateN);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.telephone);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.adresse);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.male);
            this.panel3.Controls.Add(this.female);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.prenom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Nom);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cne);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(34, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 481);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 423);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // dateN
            // 
            this.dateN.Location = new System.Drawing.Point(201, 254);
            this.dateN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateN.Name = "dateN";
            this.dateN.Size = new System.Drawing.Size(298, 26);
            this.dateN.TabIndex = 18;
            // 
            // listeCne
            // 
            this.listeCne.FormattingEnabled = true;
            this.listeCne.Location = new System.Drawing.Point(270, 74);
            this.listeCne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listeCne.Name = "listeCne";
            this.listeCne.Size = new System.Drawing.Size(272, 28);
            this.listeCne.TabIndex = 1;
            this.listeCne.SelectedIndexChanged += new System.EventHandler(this.listeCne_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Checher un étudiant";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.crystalReportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1800, 865);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporting";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1792, 855);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(124, 21);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Nombre etudiants";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1550, 662);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.charger);
            this.panel4.Controls.Add(this.Browse);
            this.panel4.Location = new System.Drawing.Point(563, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 234);
            this.panel4.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 26);
            this.textBox1.TabIndex = 2;
            // 
            // charger
            // 
            this.charger.Location = new System.Drawing.Point(258, 150);
            this.charger.Name = "charger";
            this.charger.Size = new System.Drawing.Size(189, 33);
            this.charger.TabIndex = 1;
            this.charger.Text = "Charger dans la base de donnée";
            this.charger.UseVisualStyleBackColor = true;
            this.charger.Click += new System.EventHandler(this.charger_Click_1);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(478, 83);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(175, 38);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 880);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button triDecroissant;
        private System.Windows.Forms.Button triCroissant;
        private System.Windows.Forms.Button chargerDonnees;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button importer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button deleteFiliere;
        private System.Windows.Forms.Button ModifierFiliere;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button validerNom;
        private System.Windows.Forms.TextBox nouveauNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouterFiliere;
        private System.Windows.Forms.TextBox nomFiliere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox dateN;
        private System.Windows.Forms.ComboBox listeCne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.ComboBox comboBox1;
        private CachedCrystalReport1 cachedCrystalReport11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button charger;
        private System.Windows.Forms.Button Browse;
    }
}