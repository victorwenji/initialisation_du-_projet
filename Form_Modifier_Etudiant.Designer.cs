namespace ValidationCompetence
{
    partial class Form_Modifier_Etudiant
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.BTNCLEAR = new System.Windows.Forms.Button();
            this.BTN = new System.Windows.Forms.Button();
            this.textBoxpRENOM = new System.Windows.Forms.TextBox();
            this.textBoxNOM = new System.Windows.Forms.TextBox();
            this.labelREF = new System.Windows.Forms.Label();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.labelNOM = new System.Windows.Forms.Label();
            this.label_Validation_Des_Competence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpF1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(292, 104);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(368, 43);
            this.textBoxId.TabIndex = 33;
            // 
            // BTNCLEAR
            // 
            this.BTNCLEAR.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNCLEAR.Location = new System.Drawing.Point(66, 495);
            this.BTNCLEAR.Name = "BTNCLEAR";
            this.BTNCLEAR.Size = new System.Drawing.Size(189, 55);
            this.BTNCLEAR.TabIndex = 31;
            this.BTNCLEAR.Text = "CLOSE";
            this.BTNCLEAR.UseVisualStyleBackColor = true;
            this.BTNCLEAR.Click += new System.EventHandler(this.BTNCLEAR_Click);
            // 
            // BTN
            // 
            this.BTN.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN.Location = new System.Drawing.Point(694, 495);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(189, 55);
            this.BTN.TabIndex = 30;
            this.BTN.Text = "ENREGISTRER";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click_1);
            // 
            // textBoxpRENOM
            // 
            this.textBoxpRENOM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxpRENOM.Location = new System.Drawing.Point(292, 249);
            this.textBoxpRENOM.Name = "textBoxpRENOM";
            this.textBoxpRENOM.Size = new System.Drawing.Size(368, 43);
            this.textBoxpRENOM.TabIndex = 28;
            // 
            // textBoxNOM
            // 
            this.textBoxNOM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNOM.Location = new System.Drawing.Point(292, 163);
            this.textBoxNOM.Name = "textBoxNOM";
            this.textBoxNOM.Size = new System.Drawing.Size(368, 43);
            this.textBoxNOM.TabIndex = 27;
            // 
            // labelREF
            // 
            this.labelREF.AutoSize = true;
            this.labelREF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelREF.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelREF.Location = new System.Drawing.Point(23, 337);
            this.labelREF.Name = "labelREF";
            this.labelREF.Size = new System.Drawing.Size(220, 38);
            this.labelREF.TabIndex = 26;
            this.labelREF.Text = "REFERENTIELE :";
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPRENOM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPRENOM.Location = new System.Drawing.Point(23, 254);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(153, 38);
            this.labelPRENOM.TabIndex = 25;
            this.labelPRENOM.Text = "PRENOM :";
            // 
            // labelNOM
            // 
            this.labelNOM.AutoSize = true;
            this.labelNOM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNOM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNOM.Location = new System.Drawing.Point(23, 166);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(111, 38);
            this.labelNOM.TabIndex = 24;
            this.labelNOM.Text = "NOM : ";
            // 
            // label_Validation_Des_Competence
            // 
            this.label_Validation_Des_Competence.AutoSize = true;
            this.label_Validation_Des_Competence.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Validation_Des_Competence.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Validation_Des_Competence.Location = new System.Drawing.Point(292, 44);
            this.label_Validation_Des_Competence.Name = "label_Validation_Des_Competence";
            this.label_Validation_Des_Competence.Size = new System.Drawing.Size(349, 38);
            this.label_Validation_Des_Competence.TabIndex = 23;
            this.label_Validation_Des_Competence.Text = "MODIFIER UN ETUDIANT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id : ";
            // 
            // OpF1
            // 
            this.OpF1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MS2D-2022",
            "ERIS-2022"});
            this.comboBox1.Location = new System.Drawing.Point(292, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 45);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.Text = " CHOISIR LE REFERENTIEL";
            // 
            // Form_Modifier_Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 585);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.BTNCLEAR);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.textBoxpRENOM);
            this.Controls.Add(this.textBoxNOM);
            this.Controls.Add(this.labelREF);
            this.Controls.Add(this.labelPRENOM);
            this.Controls.Add(this.labelNOM);
            this.Controls.Add(this.label_Validation_Des_Competence);
            this.Controls.Add(this.label1);
            this.Name = "Form_Modifier_Etudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Modifier_Etudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxId;
        private Button BTNCLEAR;
        private Button BTN;
        private TextBox textBoxpRENOM;
        private TextBox textBoxNOM;
        private Label labelREF;
        private Label labelPRENOM;
        private Label labelNOM;
        private Label label_Validation_Des_Competence;
        private Label label1;
        private OpenFileDialog OpF1;
        private ComboBox comboBox1;
    }
}