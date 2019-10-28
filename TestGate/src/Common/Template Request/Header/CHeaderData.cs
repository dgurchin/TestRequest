using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestGate
{

    [Serializable]
    public sealed class CHeaderData
    {

        
        public string NameTemplate { get; set; }

        
        public List<CParametrData> lst_Parametrs;

        public CHeaderData()
        {
            lst_Parametrs = new List<CParametrData>();
        }


    }

    public sealed class CParametrData
    {
        public int ID { get; set; }

        public string NameParametr { get; set; }

        public string ValueParametr { get; set; }

        public string Color { get; set; }
    }
}
