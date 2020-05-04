using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// U toj listi se nalaze clanovi ekipe
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Tako se zove ime ekipe.
        /// </summary>
        public string ImeEkipe { get; set; }
    }
}
