using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class Sudionik
    {
        /// <summary>
        /// ekipa koja sudjeluje u utakmici
        /// </summary>
        public EkipaModel NatjecateljskaEkipa { get; set; } = new EkipaModel();
        /// <summary>
        /// Rezultat ove ekipe u utakmici
        /// </summary>
        public double Rezultat { get; set; }
        /// <summary>
        /// Prethodna utakmica u kojoj je ova ekipa bila pobjednik
        /// </summary>
        public Utakmica PrethodnaUtakmica { get; set; } = new Utakmica();
        
    }
}
