using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class Form1 : Form
    {
        string connexion;
        SqlConnection con;
        DataClassesDataContext db;
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            connexion = "Data Source =DESKTOP-3HPS76H\\SQLEXPRESS; Initial Catalog =GestionEtudiants ;Integrated Security = true";
            con = new SqlConnection(connexion);
            ListFiliere();
            db = new DataClassesDataContext();
            var studenDB = from student in db.etudiants select student;
            foreach (var s in studenDB)
            {
                listeCne.Items.Add(s.cne);
            }
            CrystalReport1 crystal = new CrystalReport1();
            DataSet ds = new DataSet();
            var stu = from c in db.etudiants select c;
            DataTable dt = new DataTable();
            dt.TableName = "etudiants";
            SqlDataAdapter dap = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select * from etudiant", con);
            dap.SelectCommand = cmd;
            dap.Fill(dt);
            ds.Tables.Add(dt);

        }
        public void ListFiliere()
        {
            dataGridView1.Rows.Clear();
            SqlCommand filieresCmd = new SqlCommand("Select * from Filiere", con);
            con.Open();
            SqlDataReader drFiliere = filieresCmd.ExecuteReader();
            while (drFiliere.Read())
            {
                dataGridView1.Rows.Add(drFiliere[0], drFiliere[1]);
                comboBox1.Items.Add(drFiliere[1]);
            }
            con.Close();
        }
        public Etudiant selectedEtudiant()
        {
            int cneSelected = Convert.ToInt32(listeCne.SelectedItem.ToString());
            var etdSelected = (from etd in db.etudiants
                               where etd.cne == cneSelected
                               select etd).SingleOrDefault();
            etudiant e1 = etdSelected as etudiant;
            Etudiant student = new Etudiant(e1.nom, e1.prenom, e1.date_naiss, e1.adresse, e1.telephone, e1.cne, Convert.ToInt32(e1.id_fil), Convert.ToChar(e1.sexe));
            return student;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand updateCmd = new SqlCommand("Update Filiere set nom_Filiere = @newName where id_Filiere = @oldFiliere", con);
            SqlParameter param1 = new SqlParameter("@newName", nouveauNom.Text);
            SqlParameter param2 = new SqlParameter("@oldFiliere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            updateCmd.Parameters.Add(param1);
            updateCmd.Parameters.Add(param2);
            con.Open();
            updateCmd.ExecuteNonQuery();
            con.Close();
            nouveauNom.Text = "";
            panel2.Visible = false;
            ListFiliere();
        }
        

        private void ajouterFiliere_Click_1(object sender, EventArgs e)
        {
            SqlCommand insertFiliereCmd = new SqlCommand("Insert into Filiere Values(@nom_Filiere)", con);
            SqlParameter nomFil = new SqlParameter("@nom_Filiere", nomFiliere.Text);

            insertFiliereCmd.Parameters.Add(nomFil);

            con.Open();
            insertFiliereCmd.ExecuteNonQuery();
            con.Close();
            ListFiliere(); 
        }

        private void ModifierFiliere_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }
        }

        private void deleteFiliere_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string msg = "Vous voulez supprimer la filiere " + dataGridView1.SelectedRows[0].Cells[1].Value;
                var confirm = MessageBox.Show(msg, "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    SqlCommand deleteCmd = new SqlCommand("Delete from Filiere where  id_Filiere = @Filiere", con);
                    SqlParameter param = new SqlParameter("@Filiere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    deleteCmd.Parameters.Add(param);
                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();
                    ListFiliere();
                }
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }
        }

        private void validerNom_Click(object sender, EventArgs e)
        {
            SqlCommand updateCmd = new SqlCommand("Update Filiere set nom_Filiere = @newName where id_Filiere = @oldFiliere", con);
            SqlParameter param1 = new SqlParameter("@newName", nouveauNom.Text);
            SqlParameter param2 = new SqlParameter("@oldFiliere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            updateCmd.Parameters.Add(param1);
            updateCmd.Parameters.Add(param2);
            con.Open();
            updateCmd.ExecuteNonQuery();
            con.Close();
            nouveauNom.Text = "";
            panel2.Visible = false;
            ListFiliere();
        }

        private void ajouter_Click_1(object sender, EventArgs e)
        {
            var x = (from etd in db.etudiants
                     where etd.cne == Convert.ToInt32(cne.Text)
                     select etd).SingleOrDefault();
            etudiant etdd = x as etudiant;
            if (etdd == null)
            {
                char sex = ' ';
                if (male.Checked)
                    sex = 'M';
                else
                    sex = 'F';
                etudiant etd = new etudiant();
                etd.cne = Int32.Parse(cne.Text);
                etd.date_naiss = dateN.Text;
                etd.adresse = adresse.Text;
                etd.sexe = sex;
                etd.nom = Nom.Text;
                etd.prenom = prenom.Text;
                
                var id = from f in db.Filieres
                         where f.nom_Filiere.Equals(comboBox1.SelectedItem.ToString())
                         select f.id_Filiere;
                foreach (int y in id)
                {
                    etd.id_fil = y;
                    break;
                }
                
                etd.telephone = telephone.Text;
                db.etudiants.InsertOnSubmit(etd);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Etudiant existe dèja");
            }
        }

        private void triCroissant_Click_1(object sender, EventArgs e)
        {
           
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Ascending);

        }

        private void triDecroissant_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);
        }

        private void chargerDonnees_Click_1(object sender, EventArgs e)
        {
            var x = from etd in db.etudiants
                    select etd;
            etudiant e1 = x as etudiant;
            dataGridView2.DataSource = x;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                string msg = "Vous voulez supprimer la filiere " + dataGridView2.SelectedRows[0].Cells[1].Value;
                var confirm = MessageBox.Show(msg, "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    SqlCommand deleteCmd = new SqlCommand("Delete from etudiant where cne = @Cne", con);
                    SqlParameter param = new SqlParameter("@Cne", Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                    deleteCmd.Parameters.Add(param);
                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView2.Rows.Clear();

                }
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            var x = (from etd in db.etudiants
                     where etd.cne == Convert.ToInt32(listeCne.SelectedItem.ToString())
                     select etd).SingleOrDefault();
            etudiant etdd = x as etudiant;
            x.date_naiss = dateN.Text;
            x.adresse = adresse.Text;
            char sex = ' ';
            if (male.Checked)
                sex = 'M';
            else
                sex = 'F';
            x.sexe = sex;
            x.nom = Nom.Text;
            x.prenom = prenom.Text;
            x.telephone = telephone.Text;
            var id = from f in db.Filieres
                     where f.nom_Filiere.Equals(comboBox1.SelectedItem.ToString())
                     select f.id_Filiere;
            foreach (int y in id)
            {
                x.id_fil = y;
                break;
            }
            db.SubmitChanges();
        }

        private void listeCne_SelectedIndexChanged(object sender, EventArgs e)
        {
            Etudiant a = selectedEtudiant();

            cne.Text = a.Cne.ToString();
            Nom.Text = a.Nom;
            prenom.Text = a.Prenom;
            if (a.Sexe == 'F')
                female.Checked = true;
            else
                male.Checked = true;
            dateN.Text = a.DateNaissance;
            adresse.Text = a.Adresse;
            telephone.Text = a.Telephone;
            var fil = (from etd in db.etudiants
                       join f in db.Filieres on
                       etd.id_fil equals f.id_Filiere
                       where etd.id_fil == a.Filiere
                       select f);
            foreach (Filiere f in fil)
            {
                comboBox1.SelectedItem = f.nom_Filiere;
                break;
            }
        }
    }
}
