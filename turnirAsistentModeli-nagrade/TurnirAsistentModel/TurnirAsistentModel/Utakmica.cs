using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    /// <summary>
    /// Klasa za utakmicu
    /// </summary>
    public class Utakmica
    {
        /// <summary>
        /// Ekipe koje sudjeluju u utakmici
        /// </summary>
        public List<Sudionik> Natjecatelji { get; set; } = new List<Sudionik>();
    /// <summary>
    /// Pobjednik odigrane utakmice.
    /// </summary>
        public EkipaModel Pobjednik { get; set; } = new EkipaModel();
        /// <summary>
        /// Broj runde u kojoj je odigrana utakmica.
        /// </summary>
        public int BrojRunde { get; set; }
               
    }
}
