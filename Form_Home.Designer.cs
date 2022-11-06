namespace ValidationCompetence
{
    partial class Form_Home
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
            this.buttonCompetence = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNCREATE = new System.Windows.Forms.Button();
            this.textBoxRECHERCHE = new System.Windows.Forms.TextBox();
            this.label_Validation_Des_Competence = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelRef = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonCompetence
            // 
            this.buttonCompetence.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCompetence.Location = new System.Drawing.Point(628, 480);
            this.buttonCompetence.Name = "buttonCompetence";
            this.buttonCompetence.Size = new System.Drawing.Size(289, 55);
            this.buttonCompetence.TabIndex = 24;
            this.buttonCompetence.Text = "COMPETENCE";
            this.buttonCompetence.UseVisualStyleBackColor = true;
            this.buttonCompetence.Click += new System.EventHandler(this.buttonCompetence_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "RECHERCHE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxinfo.Location = new System.Drawing.Point(134, 204);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.Size = new System.Drawing.Size(644, 52);
            this.textBoxinfo.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(731, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "MODIFIER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTNCREATE
            // 
            this.BTNCREATE.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNCREATE.Location = new System.Drawing.Point(21, 480);
            this.BTNCREATE.Name = "BTNCREATE";
            this.BTNCREATE.Size = new System.Drawing.Size(289, 55);
            this.BTNCREATE.TabIndex = 20;
            this.BTNCREATE.Text = "CREE UN ETUDIANT";
            this.BTNCREATE.UseVisualStyleBackColor = true;
            this.BTNCREATE.Click += new System.EventHandler(this.BTNCREATE_Click_1);
            // 
            // textBoxRECHERCHE
            // 
            this.textBoxRECHERCHE.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRECHERCHE.Location = new System.Drawing.Point(203, 138);
            this.textBoxRECHERCHE.Name = "textBoxRECHERCHE";
            this.textBoxRECHERCHE.Size = new System.Drawing.Size(509, 43);
            this.textBoxRECHERCHE.TabIndex = 19;
            // 
            // label_Validation_Des_Competence
            // 
            this.label_Validation_Des_Competence.AutoSize = true;
            this.label_Validation_Des_Competence.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Validation_Des_Competence.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Validation_Des_Competence.Location = new System.Drawing.Point(123, 49);
            this.label_Validation_Des_Competence.Name = "label_Validation_Des_Competence";
            this.label_Validation_Des_Competence.Size = new System.Drawing.Size(677, 38);
            this.label_Validation_Des_Competence.TabIndex = 18;
            this.label_Validation_Des_Competence.Text = "VALIDATION DES COMPETENCE POUR ERIS/MS2D";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNom.Location = new System.Drawing.Point(134, 286);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(39, 38);
            this.labelNom.TabIndex = 27;
            this.labelNom.Text = "--";
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRef.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRef.Location = new System.Drawing.Point(713, 286);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(39, 38);
            this.labelRef.TabIndex = 26;
            this.labelRef.Text = "--";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrenom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrenom.Location = new System.Drawing.Point(375, 286);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(39, 38);
            this.labelPrenom.TabIndex = 25;
            this.labelPrenom.Text = "--";
            // 
            // OFD1
            // 
            this.OFD1.FileName = "openFileDialog1";
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 585);
            this.Controls.Add(this.buttonCompetence);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNCREATE);
            this.Controls.Add(this.textBoxRECHERCHE);
            this.Controls.Add(this.label_Validation_Des_Competence);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelRef);
            this.Controls.Add(this.labelPrenom);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCompetence;
        private Button button2;
        private TextBox textBoxinfo;
        private Button button1;
        private Button BTNCREATE;
        private TextBox textBoxRECHERCHE;
        private Label label_Validation_Des_Competence;
        private Label labelNom;
        private Label labelRef;
        private Label labelPrenom;
        private OpenFileDialog OFD1;
    }
}