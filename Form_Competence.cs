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
    public partial class Form_Competence : Form
    {
        public Form_Competence()
        {
            InitializeComponent();
            cutomizeDesing();
            openFileDialog1 = new OpenFileDialog();
            string file = openFileDialog1.FileName;
            string Dataread;
            using (StreamReader sr = new StreamReader(file))
            {
                Dataread = sr.ReadToEnd();
            }
            Class_Etudiant etudiant = JsonConvert.DeserializeObject<Class_Etudiant>(Dataread);
            label4.Text = etudiant.Id;
            label1.Text = etudiant.Name;
            label2.Text = etudiant.LastName;
            label3.Text = etudiant.Referentiel;
        }

        private void cutomizeDesing()
        {
            panelsousA.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelsousA.Visible == true)
            {
                panelsousA.Visible = false;
            }
        }

        private void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private void BTNsave_Click(object sender, EventArgs e)
        {

            string filename = label4.Text;
            var etudiantMs2d = new Class1_EtudiantMs2d
           (
                checkBoxA.Checked,
                checkBoxA1.Checked,
                checkBoxA2.Checked,
                checkBoxA3.Checked,
                checkBoxA4.Checked,
                checkBoxA5.Checked,
                checkBoxA6.Checked,
                checkBoxA7.Checked,
                checkBoxA8.Checked
            );
            string fichier = "E_" + filename + ".json";
            if (File.Exists(fichier))
            {
                string json = JsonConvert.SerializeObject(etudiantMs2d, Newtonsoft.Json.Formatting.Indented);
                string chemin = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data", fichier);
                File.WriteAllText(chemin, json);
                MessageBox.Show(
                 "L'etudiant n'a pas pue etre Modifier"
                );
            }
            else
            {
                string json = JsonConvert.SerializeObject(etudiantMs2d, Newtonsoft.Json.Formatting.Indented);
                //string chemin = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data", "E_" + ligne + ".json");
                string chemin = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data", fichier);
                File.WriteAllText(chemin, json);
                MessageBox.Show(
                 "L'etudiant a bien ete Modifier"
                );
            }
        }

        private void BTNCLose_Click(object sender, EventArgs e)
        {
            Form_Home form_home = new Form_Home();
            form_home.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsousA);
        }
    }
}
