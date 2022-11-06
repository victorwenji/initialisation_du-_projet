using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationCompetence
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
      
        private void button2_Click_1(object sender, EventArgs e)
        {
            string Dataread;
            string chemin = textBoxRECHERCHE.Text;
            string path = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data");
            if (File.Exists(@"D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data\" + chemin + ".json"))
            {
                textBoxinfo.Text = "L'etudiant avec l'id : " + chemin + " existe";
            }
            else
            {
                textBoxinfo.Text = "L'etudiant avec l'id : " + chemin + " n'existe pas";
            }

            using (StreamReader sr = new StreamReader(@"D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data\" + chemin + ".json"))
            {
                Dataread = sr.ReadToEnd();
            }
            Class_Etudiant etudiant = JsonConvert.DeserializeObject<Class_Etudiant>(Dataread);
            labelNom.Text = etudiant.Name;
            labelPrenom.Text = etudiant.LastName;
            labelRef.Text = etudiant.Referentiel;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Modifier_Etudiant form_Modifier_Etudiant = new Form_Modifier_Etudiant();
            form_Modifier_Etudiant.Show();
        }

        private void BTNCREATE_Click_1(object sender, EventArgs e)
        {
            Form_Cree_Etudiant form_Cree_Etudiant = new Form_Cree_Etudiant();
            form_Cree_Etudiant.Show();
        }

        private void buttonCompetence_Click(object sender, EventArgs e)
        {
            Form_Competence form_Competence = new Form_Competence();
            form_Competence.Show();
        }
    }
}
