using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    /// <summary>
    /// Klasa za nagradu
    /// </summary>
    public class Nagrada
    {
        //The Unique identifier for the prize
        public int Id { get; set; }
        /// <summary>
        /// Koje je osvojeno mjesto za ekipu.
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Lokacija gdje se odrzava utakmica.
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Kolika je ukupna nagrada u turniru
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Koliki ce biti postotak ukupne nagrade za prva 3 mjesta.
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
