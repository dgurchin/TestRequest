using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGate
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void tspSelect_Select_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }

        private void lsvSelect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void lsvSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSelect.SelectedItems.Count > 0)
            {


                tspSelect_Select.Enabled = true;

                tspSelect_Del.Enabled = true;

                tspSelect_Dublicate.Enabled = true;

                tspSelect_Edit.Enabled = true;

               
            }
            else
            {



                tspSelect_Select.Enabled = false;

                tspSelect_Del.Enabled = false;

                tspSelect_Dublicate.Enabled = false;

                tspSelect_Edit.Enabled = false;


            }
        }

        private void tspSelect_Del_Click(object sender, EventArgs e)
        {

            tspSelect_Select.Enabled = false;

            tspSelect_Dublicate.Enabled = false;

            tspSelect_Del.Enabled = false;

            tspSelect_Edit.Enabled = false;
            
        }

        

       

       

      

        
        
        
        
       
        


       
    }
}
