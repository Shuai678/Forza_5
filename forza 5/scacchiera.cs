using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace forza_5
{
    internal static class Scacchiera
    {
        private static grandezze grandezze = new grandezze();

        public static void DisegnaScacchiera(Graphics g)
        {
            int larghezzaGriglia = grandezze.Griglia;
            int numeroLinee = grandezze.LarghezzaScacchiera / larghezzaGriglia;

            g.Clear(Color.Bisque); // colore di sfondo della scacchiera
            Pen penna = new Pen(Color.FromArgb(192, 166, 107), 2); // penna con spessore visibile

            // disegna le linee orizzontali e verticali
            for (int i = 0; i <= numeroLinee; i++)
            {
                int offset = i * larghezzaGriglia + 20; // Calcola l'offset per ogni riga/colonna
                g.DrawLine(penna, 20, offset, grandezze.LarghezzaScacchiera + 20, offset); // Orizzontale
                g.DrawLine(penna, offset, 20, offset, grandezze.LarghezzaScacchiera + 20); // Verticale
            }
        }

    }
}
