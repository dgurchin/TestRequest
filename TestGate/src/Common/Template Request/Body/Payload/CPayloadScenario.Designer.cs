using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRequest.db;

namespace TestGate
{
    partial class CPayloadScenario
    {



        public void llblPAYLOAD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {





            frmSelect fPayloadSelect = new frmSelect();

            fPayloadSelect.Text += "PAYLOAD SCENARIO";

            fPayloadSelect.lsvSelect.Columns.Add("Name PAYLOAD", 175);

            fPayloadSelect.lsvSelect.Columns.Add("Content PAYLOAD", 545);

            Update_LV(fPayloadSelect.lsvSelect);



            fPayloadSelect.tspSelect_Add.Click += tspSelectPayload_Add_Click;

            fPayloadSelect.tspSelect_Del.Click += tspSelectPayload_Del_Click;

            fPayloadSelect.tspSelect_Edit.Click += tspSelectPayload_Edit_Click;


            if (fPayloadSelect.ShowDialog() == DialogResult.OK)
            {

                int i = fPayloadSelect.lsvSelect.SelectedIndices[0];

                Update_CMD(fMain.cmbPAYLOAD);

                fMain.cmbPAYLOAD.SelectedItem = fMain.cmbPAYLOAD.Items[i];

            }
            else
            {
                fMain.cmbPAYLOAD.Text = string.Empty;

                Update_CMD(fMain.cmbPAYLOAD);

                if (fMain.cmbPAYLOAD.Items.Count == 0)
                {
                    fMain.cmbPAYLOAD.Items.Clear();
                }


            }



            fPayloadSelect.tspSelect_Add.Click -= tspSelectPayload_Add_Click;

            fPayloadSelect.tspSelect_Del.Click -= tspSelectPayload_Del_Click;

            fPayloadSelect.tspSelect_Edit.Click -= tspSelectPayload_Edit_Click;

        }














        public void cmbPAYLOAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fMain.cmbPAYLOAD.SelectedIndex >= 0)
            {
                fMain.rtxtPAYLOAD.Text =
                    tPayLoad_Scenario.byINDEX(fMain.cmbPAYLOAD.SelectedIndex).tPayLoadData.PayLoad_Content;
                
                
            }
           
        }



        public void btnSave_PAYLOAD_Click(object sender, EventArgs e)
        {
            if (fMain.cmbPAYLOAD.SelectedIndex < 0)
            {

                if (string.IsNullOrEmpty(fMain.cmbPAYLOAD.Text))
                {
                    tPayLoad_Scenario otPayLoadScenario = new tPayLoad_Scenario();

                    otPayLoadScenario.tPayLoadData = new tPayLoadData();

                    otPayLoadScenario.tPayLoadData.PayLoad_Name = tScenarioData.OriginalName(tPayLoad_Scenario.FindAll());

                    otPayLoadScenario.tPayLoadData.PayLoad_Content = fMain.rtxtPAYLOAD.Text;

                    otPayLoadScenario.SaveAndFlush();

                    Update_CMD(fMain.cmbPAYLOAD);


                    for (int i = 0; i < fMain.cmbPAYLOAD.Items.Count; i++)
                    {
                        if (otPayLoadScenario.tPayLoadData.PayLoad_Name == fMain.cmbPAYLOAD.Items[i].ToString())
                        {
                            fMain.cmbPAYLOAD.SelectedIndex = i;


                        }
                    }

                }
                else if (!string.IsNullOrEmpty(fMain.cmbPAYLOAD.Text)) 
                {
                    if (tScenarioData.DuplicateName(tPayLoad_Scenario.FindAll(), fMain.cmbPAYLOAD.Text))
                    {
                        for (int i = 0; i < fMain.cmbPAYLOAD.Items.Count; i++)
                        {
                            if (fMain.cmbPAYLOAD.Text == fMain.cmbPAYLOAD.Items[i].ToString())
                            {
                                fMain.cmbPAYLOAD.SelectedIndex = i;

                                tPayLoad_Scenario otPayLoadScenario = tPayLoad_Scenario.byINDEX(i);

                                otPayLoadScenario.tPayLoadData.PayLoad_Content = fMain.rtxtPAYLOAD.Text;

                                otPayLoadScenario.SaveAndFlush();
                            }
                        }
                    }
                    else
                    {
                        tPayLoad_Scenario otPayLoadScenario =new tPayLoad_Scenario();

                        otPayLoadScenario.tPayLoadData = new tPayLoadData();

                        otPayLoadScenario.tPayLoadData.PayLoad_Name = fMain.cmbPAYLOAD.Text;

                        otPayLoadScenario.tPayLoadData.PayLoad_Content = fMain.rtxtPAYLOAD.Text;

                        otPayLoadScenario.SaveAndFlush();

                        Update_CMD(fMain.cmbPAYLOAD);

                        for (int i = 0; i < fMain.cmbPAYLOAD.Items.Count; i++)
                        {
                            if (otPayLoadScenario.tPayLoadData.PayLoad_Name == fMain.cmbPAYLOAD.Items[i].ToString())
                            {

                                fMain.cmbPAYLOAD.SelectedIndex = i;

                            }
                        }
                    }
                }


                
            }
            else
            {
                tPayLoad_Scenario otPayLoadScenario = tPayLoad_Scenario.byINDEX(fMain.cmbPAYLOAD.SelectedIndex);
                
                otPayLoadScenario.tPayLoadData.PayLoad_Content = fMain.rtxtPAYLOAD.Text;

                otPayLoadScenario.SaveAndFlush();


                Update_CMD(fMain.cmbPAYLOAD);

                for (int i = 0; i < fMain.cmbPAYLOAD.Items.Count; i++)
                {
                    if (otPayLoadScenario.tPayLoadData.PayLoad_Name == fMain.cmbPAYLOAD.Items[i].ToString())
                    {
                        fMain.cmbPAYLOAD.SelectedIndex = i;
                    }
                }
                
            }
            
        }

        public void btnDel_PAYLOAD_Click(object sender, EventArgs e)
        {
            if (fMain.cmbPAYLOAD.SelectedIndex >= 0)
            {
                tPayLoad_Scenario.byINDEX(fMain.cmbPAYLOAD.SelectedIndex).DeleteAndFlush();

                fMain.cmbPAYLOAD.Text = string.Empty;

                fMain.cmbPAYLOAD.SelectedIndex = -1;


                Update_CMD(fMain.cmbPAYLOAD);

                if (fMain.cmbPAYLOAD.Items.Count>0)
                {
                    fMain.cmbPAYLOAD.SelectedItem = fMain.cmbPAYLOAD.Items[0];
                    
                }
                


            }
        }
























        private void tspSelectPayload_Add_Click(object sender, EventArgs e)
        {
            frmSelect fSelect = (sender as ToolStripButton).Owner.FindForm() as frmSelect;

            frmPAYLOAD fPayloadSelect = new frmPAYLOAD();


            if (fPayloadSelect.ShowDialog() == DialogResult.OK)
            {

                tPayLoad_Scenario otPayLoadScenario = new tPayLoad_Scenario();

                otPayLoadScenario.tPayLoadData = new tPayLoadData();

                otPayLoadScenario.tPayLoadData.PayLoad_Name = fPayloadSelect.tspPayload_NamePayload.Text;

                otPayLoadScenario.tPayLoadData.PayLoad_Content = fPayloadSelect.rtxtContent.Text;

                otPayLoadScenario.SaveAndFlush();

                Update_LV(fSelect.lsvSelect);

                fSelect.lsvSelect.Items[fSelect.lsvSelect.Items.Count - 1].Focused = true;

                fSelect.lsvSelect.Items[fSelect.lsvSelect.Items.Count - 1].Selected = true;


            }
        }


        private void tspSelectPayload_Del_Click(object sender, EventArgs e)
        {

            frmSelect fSelect = (sender as ToolStripButton).Owner.FindForm() as frmSelect;

            int i = fSelect.lsvSelect.SelectedIndices[0];

            tPayLoad_Scenario.byINDEX(i).DeleteAndFlush();

            Update_LV(fSelect.lsvSelect);

        }

        private void tspSelectPayload_Edit_Click(object sender, EventArgs e)
        {


            frmSelect fSelect = (sender as ToolStripButton).Owner.FindForm() as frmSelect;

            int INDEX = fSelect.lsvSelect.SelectedIndices[0];


            frmPAYLOAD fPayloadSelect = new frmPAYLOAD();

            tPayLoad_Scenario otPayLoadScenario = tPayLoad_Scenario.byINDEX(INDEX);

            fPayloadSelect.tspPayload_NamePayload.Text = otPayLoadScenario.tPayLoadData.PayLoad_Name;

            fPayloadSelect.rtxtContent.Text = otPayLoadScenario.tPayLoadData.PayLoad_Content;


            if (fPayloadSelect.ShowDialog() == DialogResult.OK)
            {


                otPayLoadScenario.tPayLoadData.PayLoad_Name = fPayloadSelect.tspPayload_NamePayload.Text;

                otPayLoadScenario.tPayLoadData.PayLoad_Content = fPayloadSelect.rtxtContent.Text;

                otPayLoadScenario.SaveAndFlush();


                Update_LV(fSelect.lsvSelect);


                fSelect.lsvSelect.Items[INDEX].Focused = true;

                fSelect.lsvSelect.Items[INDEX].Selected = true;
            }
        }
    }
}
