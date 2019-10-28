
namespace TestGate
{

    public enum Request
    {
        GET,
        POST
    }


    public sealed partial class CRequest_Result
    {

        private frmMain fMain;

        private Request? _Request;

        private string URL;



        private string Header;


        

        
        //-
        private string _Body_;





        public CRequest_Result(ref frmMain fMain)
        {

            this.fMain = fMain;

            


            fMain.btnTest.Click += btnTest_Click;





            fMain.lsvHeader_Result.SelectedIndexChanged += lsvTemplateRequest_SelectedIndexChanged;


            

            fMain.rtxtPAYLOAD.TextChanged += rtxtPAYLOAD_TextChanged;



        }





    }
}
