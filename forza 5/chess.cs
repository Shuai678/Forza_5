using System;
using System.Drawing;
using System.Windows.Forms;

namespace forza_5
{
    internal static class Chess
    {
        private static grandezze grandezze = new grandezze();

        public static void DisegnaPedina(Panel pannello, bool turnoNero, int x, int y)
        {
            // ottieni il contesto grafico del pannello
            using (Graphics g = pannello.CreateGraphics())
            {
                // Calcola la posizione della pedina
                int posX = x * grandezze.Griglia + 3; // Offset per centrare
                int posY = y * grandezze.Griglia + 3;

                // colore della pedina
                Color colore = turnoNero ? Color.Black : Color.White;

                // dsegna la pedina come un cerchio pieno
                using (Brush pennello = new SolidBrush(colore))
                {
                    g.FillEllipse(pennello, posX, posY, grandezze.Diametro, grandezze.Diametro);
                }

                // disegna il bordo nero della pedina
                using (Pen bordo = new Pen(Color.Black, 1))
                {
                    g.DrawEllipse(bordo, posX, posY, grandezze.Diametro, grandezze.Diametro);
                }
            }
        }

        // metodo per aggiornare la scacchiera
        public static void Aggiorna(Panel pannello, int[,] scacchiera)
        {
            // iottieni il contesto grafico del pannello
            using (Graphics g = pannello.CreateGraphics())
            {
                // per ogni cella nella matrice della scacchiera
                for (int i = 0; i < scacchiera.GetLength(0); i++)
                {
                    for (int j = 0; j < scacchiera.GetLength(1); j++)
                    {
                        // controlla se c'è una pedina
                        if (scacchiera[i, j] != 0)
                        {
                            // colore in base al valore nella matrice
                            bool turnoNero = scacchiera[i, j] == 1;

                            // calcola la posizione della pedina
                            int posX = i * grandezze.Griglia + 3; // Offset per centrare
                            int posY = j * grandezze.Griglia + 3;

                            // colore della pedina
                            Color colore = turnoNero ? Color.Black : Color.White;

                            // disegna la pedina come un cerchio pieno
                            using (Brush pennello = new SolidBrush(colore))
                            {
                                g.FillEllipse(pennello, posX, posY, grandezze.Diametro, grandezze.Diametro);
                            }

                            // disegna il bordo della pedina
                            using (Pen bordo = new Pen(Color.Black, 1))
                            {
                                g.DrawEllipse(bordo, posX, posY, grandezze.Diametro, grandezze.Diametro);
                            }
                        }
                    }
                }
            }
        }
    }
}
