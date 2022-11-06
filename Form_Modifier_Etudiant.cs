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
    public partial class Form_Modifier_Etudiant : Form
    {
        public Form_Modifier_Etudiant()
        {
            InitializeComponent();
            openFileDialog1.ShowDialog();
            var ligne = File.OpenRead(openFileDialog1.FileName);
            string Dataread;
            using (StreamReader sr = new StreamReader(ligne))
            {
                Dataread = sr.ReadToEnd();
            }
            Class_Etudiant etudiant = JsonConvert.DeserializeObject<Class_Etudiant>(Dataread);
            textBoxId.Text = etudiant.Id;
            textBoxNOM.Text = etudiant.Name;
            textBoxpRENOM.Text = etudiant.LastName;
            textBoxREF.Text = etudiant.Referentiel;
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            var etudiant = new Class_Etudiant
           (textBoxId.Text,
               textBoxNOM.Text,
               textBoxpRENOM.Text,
               textBoxREF.Text
           );
            string ligne = etudiant.Id;
            string fichier = "E_" + ligne + ".json";
            if (File.Exists(fichier))
            {
                string json = JsonConvert.SerializeObject(etudiant, Newtonsoft.Json.Formatting.Indented);
                string chemin = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data", fichier);
                File.WriteAllText(chemin, json);
                MessageBox.Show(
                 "L'etudiant n'a pas pue etre Modifier"
                );
            }
            else
            {
                string json = JsonConvert.SerializeObject(etudiant, Newtonsoft.Json.Formatting.Indented);
                string chemin = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data", fichier);
                File.WriteAllText(chemin, json);
                MessageBox.Show(
                 "L'etudiant a bien ete Modifier"
                );
            }
              this.Close();
        }
    }
}
