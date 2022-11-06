﻿using Newtonsoft.Json;
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
    public partial class Form_Cree_Etudiant : Form
    {
        public Form_Cree_Etudiant()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txbId.Clear();
            textBoxNOM.Clear();
            textBoxpRENOM.Clear();
            textBoxREF.Clear();
        }

        private void BTNCLEAR_Click_1(object sender, EventArgs e)
        {
            Form_Home form_Home = new Form_Home();
            form_Home.Show();
            this.Close();
        }

        private void BTN_Click_1(object sender, EventArgs e)
        {
            var etudiant = new Class_Etudiant
            (txbId.Text,
                textBoxNOM.Text,
                textBoxpRENOM.Text,
                textBoxREF.Text
            );
            string filename = txbId.Text;
            string json = JsonConvert.SerializeObject(etudiant, Newtonsoft.Json.Formatting.Indented);
            string chemin = Path.Combine("D:\\limoge\\Project\\Interface_De_Validation\\Interface_De_Validation\\data", "E_" + filename + ".json");
            File.WriteAllText(chemin, json);
            MessageBox.Show(
                   "L'etudiant  N° " + filename + " a bien ete enregistrez"
                  );
            Clear();
        }
    }
}
