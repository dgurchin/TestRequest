namespace TestGate
{
    public sealed partial class CMain
    {
       

        private frmMain fMain;

        private CDataBase oDataBase;


        private CRequest_Result oRequestResult;

       
        


        private bool OpenFile = false;

        

        public CMain()
        {

           
            
            
            oDataBase = new CDataBase();
            
            fMain = new frmMain();

            oRequestResult= new CRequest_Result(ref fMain);
            
            fMain.mnuMainFile_Create.Click += mnuMainFile_Create_Click;

            fMain.mnuMainFile_Open.Click += mnuMainFile_Open_Click;

            
            
            
            fMain.tspTemplateRequest_Add.Click += tspTemplateRequest_Add_Click;

            fMain.tspTemplateRequest_Del.Click += tspTemplateRequest_Del_Click;

            fMain.tspTemplateRequest_Edit.Click += tspTemplateRequest_Edit_Click;

            fMain.lsvHeader_Result.MouseDoubleClick += tspTemplateRequest_Edit_Click;






        }



        private void Initialization()
        {
            CHeader_Result oHeaderResult = new CHeader_Result(ref fMain);

            oHeaderResult.Update_LV(fMain.lsvHeader_Result);


            

            
            CPayloadTemplate oPayloadTemplate = new CPayloadTemplate(ref fMain);

            


            fMain.rtxtResult.Enabled = true;

            fMain.grbBody.Enabled = true;

            fMain.grbResult.Enabled = true;




           
            

            OpenFile = true;
        }


    }
}
