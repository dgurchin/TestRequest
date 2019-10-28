using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGate
{
    public sealed partial class CPayloadTemplate
    {

        private frmMain fMain;
        
        
       

        private CPayloadScenario oPayloadScenario;
        
       

        public CPayloadTemplate(ref frmMain fMain)
        {
            this.fMain = fMain;


            fMain.cmbPAYLOAD.Items.Clear();

            fMain.cmbPAYLOAD.Text = string.Empty;

            fMain.rtxtPAYLOAD.Text = string.Empty;



            

            oPayloadScenario = new CPayloadScenario(ref this.fMain);


           
                fMain.llblPAYLOAD.LinkClicked += oPayloadScenario.llblPAYLOAD_LinkClicked;

                fMain.cmbPAYLOAD.SelectedIndexChanged += oPayloadScenario.cmbPAYLOAD_SelectedIndexChanged;

                fMain.btnSave_PAYLOAD.Click += oPayloadScenario.btnSave_PAYLOAD_Click;

                fMain.btnDel_PAYLOAD.Click += oPayloadScenario.btnDel_PAYLOAD_Click;

                oPayloadScenario.Update_CMD(fMain.cmbPAYLOAD);

                if (fMain.cmbPAYLOAD.Items.Count > 0)
                {
                    fMain.cmbPAYLOAD.SelectedItem = fMain.cmbPAYLOAD.Items[0];
                }
            


          




        }



        
        private void Update_CMB_Scenario(ComboBox cmb)
        {
            oPayloadScenario.Update_CMD(cmb);
        }





    }
}
