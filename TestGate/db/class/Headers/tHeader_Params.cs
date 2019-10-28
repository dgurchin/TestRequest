using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRequest.db
{
    partial class tHeader_Params
    {
        public static tHeader_Params byID(int ID_Header)
        {
            foreach (var VARIABLE in FindAllByProperty("ID_Header_Params", ID_Header))
            {
                if (VARIABLE.ID_Header_Params == ID_Header)
                {
                    return VARIABLE;
                }
            }

            return null;
        }

        public static tHeader_Params byINDEX(int INDEX_Header)
        {


            return FindAll()[INDEX_Header];
        }
    }
}
