using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRequest.db
{
    public partial class tServers
    {

        public static tServers byID(int ID_Server)
        {
            foreach (var VARIABLE in FindAllByProperty("ID_Servers", ID_Server))
            {
                if (VARIABLE.ID_Servers == ID_Server)
                {
                    return VARIABLE;
                }
            }

            return null;
        }


        public static tServers byINDEX(int INDEX_Server)
        {
            return FindAll()[INDEX_Server];
        }
    }
}
