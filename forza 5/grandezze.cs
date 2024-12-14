using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forza_5
{
    internal class grandezze
    {
        private int larghezzaForm=1000;
        private int altezzaForm = 1000;
        private int larghezzaScacchiera = 600;
        private int altezzaScacchiera = 600;
        private int griglia = 40;
        private int diametro = 30;

        public  int LarghezzaForm { get {return larghezzaForm; } }
        public int AltezzaForm { get { return altezzaForm; } }

        public int LarghezzaScacchiera { get { return larghezzaScacchiera; } }
        public int AltezzaScacchiera { get { return altezzaScacchiera; } }
        public int Griglia { get { return griglia; } }
        public int Diametro { get { return diametro; } }

    }
}
