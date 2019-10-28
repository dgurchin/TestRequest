using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGate
{
    public sealed class CDDos_Attack_Data
    {

        private int _iCount_Request=5;

        [DisplayName("Count Request"),
        Category("DDos_Parametr"),
        Description("TODO"),
        DefaultValue(5)]
        public int Count_Request 
        {
            get { return _iCount_Request; }
            set { _iCount_Request = value; }
        }

    }
}
