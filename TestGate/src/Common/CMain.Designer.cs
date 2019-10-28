using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGate
{
    partial class CMain
    {
        #region Entry Point Application ()

        private static CMain oTestGate;


        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);

            oTestGate = new CMain();


            //У Microsoft есть свои требования к сертификатам
            //И ServerCertificateValidationCallback проверят сертификат на соответсвие 
            //требованиям Microsoft. Что б отлючить эту проверку надо создать свою функцию
            //валидации сертификата. Так как нам такого не требуется – мы создаем ананонимную функцию возвращающую
            //всегда True. Тем самым возврат True отключает проверку Microsoft.
            //Так же эту настройку можно отключать в свойствах проекта, но где пока не нашел
            ServicePointManager.ServerCertificateValidationCallback =
                  delegate { return true; };

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

             Application.Run(oTestGate.fMain);
        }

        #endregion




        private void mnuMainFile_Create_Click(object sender, EventArgs e)
        {
            if (fMain.dlgSave.ShowDialog() == DialogResult.OK)
            {
                oDataBase.CreateDB(fMain.dlgSave.FileName);

                Initialization();
               
            }
        }

        private void mnuMainFile_Open_Click(object sender, EventArgs e)
        {
            if (fMain.dlgOpen.ShowDialog() == DialogResult.OK)
            {
                oDataBase.InitDB(fMain.dlgOpen.FileName);

                
                Initialization();


            }

        }


        private void tspTemplateRequest_Add_Click(object sender, EventArgs e)
        {
            if (OpenFile)
            {
                CHeader_Result oHeaderResult = new CHeader_Result(ref fMain);

                oHeaderResult.Add();
            }

            else
            {
                mnuMainFile_Open_Click(sender, e);

                
            }
        }

        private void tspTemplateRequest_Del_Click(object sender, EventArgs e)
        {

            CHeader_Result oHeaderResult = new CHeader_Result(ref fMain);

            int i = fMain.lsvHeader_Result.SelectedIndices[0];



            oHeaderResult.Del(i);

            oHeaderResult.Update_LV(fMain.lsvHeader_Result);

            fMain.tspTemplateRequest_Del.Enabled = false;

            fMain.tspTemplateRequest_Edit.Enabled = false;

        }

        

        private void tspTemplateRequest_Edit_Click(object sender, EventArgs e)
        {

            CHeader_Result oHeaderResult = new CHeader_Result(ref fMain);

            int i = fMain.lsvHeader_Result.SelectedIndices[0];

            oHeaderResult.Edit(i);

            oHeaderResult.Update_LV(fMain.lsvHeader_Result);

            fMain.lsvHeader_Result.Items[i].Selected = true;

            fMain.lsvHeader_Result.Items[i].Focused = true;
        }




        
        

    }
}
