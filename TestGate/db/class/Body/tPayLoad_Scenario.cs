using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRequest.db
{
    partial class tPayLoad_Scenario
    {
        public static tPayLoad_Scenario byID(int ID_PayLoad)
        {
            foreach (var VARIABLE in FindAllByProperty("ID_PayLoad_Scenario", ID_PayLoad))
            {
                if (VARIABLE.ID_PayLoad_Scenario == ID_PayLoad)
                {
                    return VARIABLE;
                }
            }

            return null;
        }


        public static tPayLoad_Scenario byINDEX(int INDEX_Payload)
        {


            return FindAll()[INDEX_Payload];
        }
    }
}
