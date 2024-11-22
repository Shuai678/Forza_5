namespace forza_5
{
    internal static class Vittoria
    {
        public static bool Controlla(int[,] scacchiera, int giocatore)
        {
            int dimensione = scacchiera.GetLength(0);

            for (int x = 0; x < dimensione; x++)
            {
                for (int y = 0; y < dimensione; y++)
                {
                    if (scacchiera[x, y] == giocatore)
                    {
                        if (VerificaDirezione(scacchiera, x, y, 1, 0, giocatore) || // Orizzontale
                            VerificaDirezione(scacchiera, x, y, 0, 1, giocatore) || // Verticale
                            VerificaDirezione(scacchiera, x, y, 1, 1, giocatore) || // Diagonale 
                            VerificaDirezione(scacchiera, x, y, -1, 1, giocatore))  // Diagonale 
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static bool VerificaDirezione(int[,] scacchiera, int x, int y, int dx, int dy, int giocatore)
        {
            int dimensione = scacchiera.GetLength(0);

            for (int i = 1; i < 5; i++)
            {
                int nx = x + i * dx, ny = y + i * dy;

                if (nx < 0 || ny < 0 || nx >= dimensione || ny >= dimensione || scacchiera[nx, ny] != giocatore)
                    return false;
            }

            return true;
        }
    }
}
