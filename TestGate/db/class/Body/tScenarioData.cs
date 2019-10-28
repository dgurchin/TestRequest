using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRequest.db
{
    public class tScenarioData
    {

        public static IList<string> getName<T>(IList<T> oT) where T : class
        {


            IList<string> tmp_LST = null;

           if (typeof (T) == typeof (tPayLoad_Scenario))
            {
                tmp_LST = new List<string>();

                foreach (tPayLoad_Scenario VARIABLE in oT as IList<tPayLoad_Scenario>)
                {
                    tmp_LST.Add(VARIABLE.tPayLoadData.PayLoad_Name);
                }
            }

            else
            {
                throw new ArgumentException();

            }


            return tmp_LST;

        }

        public static string OriginalName<T>(IList<T> oT) where T : class
        {
           
            if (typeof(T) == typeof(tPayLoad_Scenario))
            {
                for (int i = 0; ; i++)
                {

                    string s = "New_PayLoad_Scenario_" + i;

                    if (DuplicateName(oT, s))
                    {
                        continue;
                    }
                    else
                    {
                        return s;

                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }


        }

        public static bool DuplicateName<T>(IList<T> oT, string NameScenario) where T : class
        {
            foreach (var VARIABLE in getName(oT))
            {

                if (VARIABLE == NameScenario)
                {
                    return true;
                }

            }

            return false;
        }

       

    }
}
