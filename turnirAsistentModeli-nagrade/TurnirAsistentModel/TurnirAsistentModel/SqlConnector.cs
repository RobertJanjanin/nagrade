using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class SqlConnector : IDataConnection
    {
        public Nagrada NapraviNagradu(Nagrada model)
        {
            model.Id = 1;
            return model;
        }
    }
}

