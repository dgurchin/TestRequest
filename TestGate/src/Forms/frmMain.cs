using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestRequest.db;


namespace TestGate
{

   
    
    public partial class frmMain : Form
    {




        public frmMain()
        {
            InitializeComponent();

            prgDDos_Parametr.SelectedObject = new CDDos_Attack_Data();

            
           
        }

        private void mnuMainFile_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbRequest_CheckedChanged(object sender, EventArgs e)
        {
            grbDDos_Parametr.Visible = rdbDDos_Attack.Checked;

            tspDDos_Attack.Enabled = rdbDDos_Attack.Checked;


            tspDDos_Attack_NameResult.Text = string.Empty;




        }

      

        private void tspDDos_Attack_NameResult_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tspDDos_Attack_NameResult.Text))
            {
                tspDDos_Attack_Save.Enabled = false;
            }
            else
            {
                tspDDos_Attack_Save.Enabled = true;
            }
        }

        private void lsvTemplateRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHeader_Result.SelectedItems.Count > 0)
            {
                tspTemplateRequest_Del.Enabled = true;

                tspTemplateRequest_Edit.Enabled = true;

                btnTest.Enabled = true;



            }
            else
            {
                tspTemplateRequest_Del.Enabled = false;

                tspTemplateRequest_Edit.Enabled = false;
                
                btnTest.Enabled = false;


                rtxtResult.Text = string.Empty;

            }
        }

      

        private void cmbPAYLOAD_TextChanged(object sender, EventArgs e)
        {
            btnDel_PAYLOAD.Enabled = false;

            rtxtPAYLOAD.Text = string.Empty;
        }

        

        private void cmbPAYLOAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPAYLOAD.SelectedIndex >= 0)
            {
                btnDel_PAYLOAD.Enabled = true;
            }
            else
            {
                btnDel_PAYLOAD.Enabled = false;

                rtxtPAYLOAD.Text = string.Empty;
            }
        }

        private void rtxtResult_TextChanged(object sender, EventArgs e)
        {
            


            rtxtResult.SelectionStart = rtxtResult.Text.Length;
            // scroll it automatically
            rtxtResult.ScrollToCaret();

        }


       
    }
}
