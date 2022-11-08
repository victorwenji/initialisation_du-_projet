using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ValidationCompetence
{
    public partial class Form_Competence : Form
    {
        public Form_Competence()
        {
            InitializeComponent();
            oPD1.ShowDialog();
            var file = File.OpenRead(oPD1.FileName);
            string Dataread;
            using (StreamReader sr = new StreamReader(file))
            {
                Dataread = sr.ReadToEnd();
            }
            Class_Etudiant etudiant = JsonConvert.DeserializeObject<Class_Etudiant>(Dataread);
            label5.Text = etudiant.Date.ToString();
            label4.Text = etudiant.Id;
            label1.Text = etudiant.Name;
            label2.Text = etudiant.LastName;
            label3.Text = etudiant.Referentiel;
            checkBoxA.Checked = etudiant.A_RNCP34408BC01;
            checkBoxA1.Checked = etudiant.A1;
            checkBoxA2.Checked = etudiant.A2;
            checkBoxA3.Checked= etudiant.A3;
            checkBoxA4.Checked = etudiant.A4;
            checkBoxA5.Checked = etudiant.A5;
            checkBoxA6.Checked = etudiant.A6;
            checkBoxA7.Checked = etudiant.A7;
            checkBoxA8.Checked = etudiant.A8;   
            cutomizeDesing();
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

      

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsousA);
        }

        private void BTNsave_Click_1(object sender, EventArgs e)
        {
           
            var etudiant = new Class_Etudiant
            (
                checkBoxA.Checked ,
                checkBoxA1.Checked ,
                checkBoxA2.Checked ,
                checkBoxA3.Checked ,
                checkBoxA4.Checked ,
                checkBoxA5.Checked ,
                checkBoxA6.Checked ,
                checkBoxA7.Checked ,
                checkBoxA8.Checked
             );

            //string filename = etudiant.Id;
            string fichier = "loic.json";
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

        }

        private void BTNCLose_Click_1(object sender, EventArgs e)
        {
            Form_Home form_home = new Form_Home();
            form_home.Show();
            this.Close();
        }

        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
