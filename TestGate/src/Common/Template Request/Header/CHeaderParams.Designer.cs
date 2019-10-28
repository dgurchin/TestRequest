using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRequest.Properties;

namespace TestGate
{
    partial class CHeaderParams
    {

        private void tspParametrs_Add_Click(object sender, EventArgs e)
        {


            frmHeaderParametrs frm =(sender as ToolStripButton).Owner.FindForm() as frmHeaderParametrs;

            Add();

            CParametrData oParametrData = oHeaderData.lst_Parametrs[oHeaderData.lst_Parametrs.Count - 1];

            Paint(ref oParametrData);

            if (frm.pnlParametrs.Controls.Count>0)
            {
                frm.tspHeaderTemplate_Save.Enabled = true;
            }
            
        }
        

        private void txtNameParametr_TextChanged(object sender, EventArgs e)
        {
            
            TextBox txtParametr = sender as TextBox;


            foreach (var VARIABLE in oHeaderData.lst_Parametrs)
            {
                if (VARIABLE.ID==txtParametr.Tag.ToInt())
                {

                    VARIABLE.NameParametr= txtParametr.Text;

                }

            }

        }


        private void btnDel_Parametr_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            frmHeaderParametrs frm = btn.FindForm() as frmHeaderParametrs;

            Del(btn.Tag.ToInt());

            Erase(btn.Tag.ToInt());

            if (frm.pnlParametrs.Controls.Count==0)
            {
                frm.tspHeaderTemplate_Save.Enabled = false;
            }
            


    
        }


        private void pcbColorParametr_Click(object sender, EventArgs e)
        {

            if (fHeaderParametrs.dlgColor.ShowDialog() == DialogResult.OK)
            {
                (sender as PictureBox).BackColor = fHeaderParametrs.dlgColor.Color;
            }

        }

       

    }
}
