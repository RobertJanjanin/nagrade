using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            
            if (database)
            {
                //TODO-create a sql connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }
            if (textFiles) {
                //TODO - create the Text connection
                TextConnection Text = new TextConnection();
                Connections.Add(text);
            }

        }
    }
}
