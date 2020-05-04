using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    
    public class TurnirModel
    {
        /// <summary>
        /// Kako se zove turnir.
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Koliko se naplacuje ulaz u turnir.
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Koji timovi su prijavljeni u turnir
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Koje nagrade postoje.
        /// </summary>
        public List<Nagrada> Nagrade { get; set; } = new List<Nagrada>();
        /// <summary>
        /// Naziv rundi
        /// druga je za broj utakmica u rundi a prva je za broj rundi
        /// </summary>
        public List<Utakmica> Runde { get; set; } = new List<Utakmica>();
    }
}
