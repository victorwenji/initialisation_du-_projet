namespace ValidationCompetence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick; 
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           timer1.Enabled=false;
            Form_Home form_Home = new Form_Home();
            form_Home.Show();
            this.Close();
        }
    }
}