using System;
using System.Windows.Forms;

namespace TestGate
{
    public partial class frmHeaderTemplate : Form
    {
        public frmHeaderTemplate()
        {
            InitializeComponent();

        }

       
       
      

        private void tspHeader_NameParam_TextChanged(object sender, EventArgs e)
        {
            tspHeaderParams_Add.Enabled = !string.IsNullOrEmpty(tspHeaderParams_NameParam.Text);
        }

       

        private void tspHeaderParams_cmbHedearsNames_TextChanged(object sender, EventArgs e)
        {
           
            tspHeaderParams_Save.Enabled = !string.IsNullOrEmpty(tspHeaderParams_cmbHedearsNames.Text);
        }

      

      

      
       
        

        

        

     

       

       

        
       

        

      
      
       

       

        
       

        
       
        

       



    }
}
