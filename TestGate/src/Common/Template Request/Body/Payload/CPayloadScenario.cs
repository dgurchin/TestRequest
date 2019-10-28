using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRequest.db;

namespace TestGate
{
    public sealed partial class CPayloadScenario
    {

        private frmMain fMain;

        public CPayloadScenario(ref frmMain fMain)
        {
            this.fMain = fMain;
        }





        public void Update_LV(ListView lsv)
        {

            lsv.Items.Clear();



            foreach (var VARIABLE in tPayLoad_Scenario.FindAll())
            {


                string[] s = new string[2];

                s[0] = VARIABLE.tPayLoadData.PayLoad_Name;

                s[1] = VARIABLE.tPayLoadData.PayLoad_Content;


                lsv.Items.Add(new ListViewItem(s));
            }
        }

        public void Update_CMD(ComboBox cmb)
        {
            fMain.cmbPAYLOAD.Items.Clear();

            fMain.cmbPAYLOAD.Text = string.Empty;


            fMain.cmbPAYLOAD.Items.AddRange(tScenarioData.getName(tPayLoad_Scenario.FindAll()).ToArray());

        }
    }
}
