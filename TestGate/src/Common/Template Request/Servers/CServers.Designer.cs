using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGate
{
    partial class CServers
    {


       

        private void tspServers_Add_Click(object sender, EventArgs e)
        {
            Add();
        }


       

        private void tspServers_Del_Click(object sender, EventArgs e)
        {
            Del(fSelect.lsvSelect.SelectedItems[0].Tag.ToInt());

            Update_LV(fSelect.lsvSelect);

           


        }


        private void tspServers_Edit_Click(object sender, EventArgs e)
        {
            Edit(fSelect.lsvSelect.SelectedItems[0].Tag.ToInt());
        }

        
        



        public void tspHeader_Result_bntServers_Click(object sender, EventArgs e)
        {



            fSelect.tspSelect_Select.Enabled = false;

            fSelect.tspSelect_Del.Enabled = false;

            fSelect.tspSelect_Edit.Enabled = false;


            Update_LV(fSelect.lsvSelect);
            
            var fReques = (sender as ToolStripButton).Owner.FindForm() as frmHeaderTemplate;

            if (fSelect.ShowDialog() == DialogResult.OK)
            {
                Update_CMB(fReques.tspHeader_Result_cmbServers);

                if (fReques.tspHeader_Result_cmbServers.Items.Count>0)
                {
                    fReques.tspHeader_Result_cmbServers.SelectedItem =
                        fReques.tspHeader_Result_cmbServers.Items[fSelect.lsvSelect.SelectedIndices[0]];
                }

                


            }
            else
            {
                Update_CMB(fReques.tspHeader_Result_cmbServers);

                
            }

           






        }

        private void btnClearFile_Click(object sender, System.EventArgs e)
        {

            fServerInfo.txtSelectFile.Text = string.Empty;
            
            fServerInfo.txtPassword.Text = string.Empty;

            fServerInfo.txtSelectFile.Tag = null;


        }


        private void txtSelectFile_TextChanged(object sender, System.EventArgs e)
        {

            fServerInfo.btnClearFile.Enabled = string.IsNullOrEmpty(fServerInfo.txtSelectFile.Text) ? false : true;

            fServerInfo.txtPassword.Text = string.Empty;


        }


        private void btnSelectFile_Click(object sender, System.EventArgs e)
        {


           
            if (fServerInfo.dlgOpen.ShowDialog()==DialogResult.OK)
            {
                fServerInfo.txtSelectFile.Text = fServerInfo.dlgOpen.SafeFileName;

                fServerInfo.txtSelectFile.Tag = File.ReadAllBytes(fServerInfo.dlgOpen.FileName).ToArray();


            }


            


        }

       

        private void cmbProtocol_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (fServerInfo.cmbProtocol.SelectedItem == fServerInfo.cmbProtocol.Items[0])
            {
                fServerInfo.btnSelectFile.Visible = false;

                fServerInfo.txtSelectFile.Visible = false;

                fServerInfo.txtSelectFile.Visible = false;

                fServerInfo.txtSelectFile.Text = string.Empty;

                fServerInfo.btnClearFile.Visible = false;
                
                fServerInfo.lblPassword.Visible = false;
                
                fServerInfo.txtPassword.Visible = false;

                fServerInfo.txtPassword.Text = string.Empty;




            }
            else
            {
                fServerInfo.btnSelectFile.Visible = true;

                fServerInfo.txtSelectFile.Visible = true;
                
                fServerInfo.txtSelectFile.Visible = true;

                fServerInfo.btnClearFile.Visible = true;

                fServerInfo.lblPassword.Visible = true;

                fServerInfo.txtPassword.Visible = true;


            }
        }
    }
}
