namespace forza_5
{
    public partial class Form1 : Form
    {
        private bool giocoIniziato;
        private bool turnoNero = true; // Turno: true = Nero, false = Bianco
        private const int dimensione = 15;
        private int[,] matriceScacchiera = new int[dimensione, dimensione];

        private grandezze grandezze = new grandezze();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InizializzaGioco();
            this.Width = grandezze.LarghezzaForm;
            this.Height = grandezze.AltezzaForm;
        }

        private void InizializzaGioco()
        {
            for (int i = 0; i < dimensione; i++)
                for (int j = 0; j < dimensione; j++)
                    matriceScacchiera[i, j] = 0;

            giocoIniziato = false;
            label1.Text = "Gioco non iniziato";
            button1.Visible = true;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giocoIniziato = true;
            turnoNero = true;
            label1.Text = "Turno del Nero";
            button1.Visible = false;
            button2.Visible = true;
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi ricominciare il gioco?", "Conferma", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                InizializzaGioco();
                button1_Click(sender, e);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Ottieni l'oggetto Graphics dall'evento Paint
            Scacchiera.DisegnaScacchiera(g); // Chiama il metodo per disegnare la scacchiera
            Chess.Aggiorna(panel2, matriceScacchiera); // Aggiorna le pedine sulla scacchiera
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        /*
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Clic rilevato sul pannello!");
        }*/
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (!giocoIniziato)
            {

                MessageBox.Show("Inizia prima il gioco!", "Avviso");
                return;
            }

            // Calcola la posizione della griglia in base al clic
            int x = e.X / grandezze.Griglia;
            int y = e.Y / grandezze.Griglia;

            Console.WriteLine($"Coordinate calcolate: X={x}, Y={y}");

            if (x >= dimensione || y >= dimensione || x < 0 || y < 0)
            {

                MessageBox.Show("Clic fuori dalla scacchiera!", "Errore");
                return;
            }

            if (matriceScacchiera[x, y] != 0)
            {

                MessageBox.Show("Posizione gi¨¤ occupata!", "Errore");
                return;
            }

            // Aggiorna la matrice per tenere traccia dello stato
            matriceScacchiera[x, y] = turnoNero ? 1 : 2;

            Console.WriteLine("Pedina aggiunta correttamente!");

            // Disegna la pedina su panel2
            Chess.DisegnaPedina(panel2, turnoNero, x, y);

            // Controlla la vittoria
            if (Vittoria.Controlla(matriceScacchiera, turnoNero ? 1 : 2))
            {
                string vincitore = turnoNero ? "Nero" : "Bianco";
                Console.WriteLine($"Vince il {vincitore}!");
                MessageBox.Show($"Vince il {vincitore}!", "Partita finita");
                InizializzaGioco();
                return;
            }

            // Cambia turno
            turnoNero = !turnoNero;
            label1.Text = turnoNero ? "Turno del Nero" : "Turno del Bianco";

            Console.WriteLine($"Turno cambiato: turnoNero={turnoNero}");
            panel2.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("sicuro di voler ricomincare?", "avviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK);
            {
                InizializzaGioco();                      
                button1_Click(sender, e);              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
