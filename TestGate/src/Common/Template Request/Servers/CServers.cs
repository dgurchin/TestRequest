
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestRequest.db;

namespace TestGate
{
    public sealed partial class CServers
    {

        private frmServerInfo fServerInfo;

        private frmSelect fSelect;


        
        public CServers()
        {
            fSelect = new frmSelect();

            fSelect.Text = "Servers";

            fSelect.lsvSelect.Columns.Add("Full Name", 734);

            fSelect.tspSelect_Add.Click += tspServers_Add_Click;

            fSelect.tspSelect_Del.Click += tspServers_Del_Click;

            fSelect.tspSelect_Edit.Click += tspServers_Edit_Click;

           
            




        }



     
        
        public void Add()
        {
            fServerInfo = new frmServerInfo();

            fServerInfo.Text += " SERVERS";

            fServerInfo.cmbProtocol.SelectedIndexChanged += cmbProtocol_SelectedIndexChanged;

            fServerInfo.btnSelectFile.Click += btnSelectFile_Click;

            fServerInfo.btnClearFile.Click += btnClearFile_Click;

            fServerInfo.txtSelectFile.TextChanged += txtSelectFile_TextChanged;
                    
            fServerInfo.cmbProtocol.SelectedItem = fServerInfo.cmbProtocol.Items[1];

            


            if (fServerInfo.ShowDialog() == DialogResult.OK)
            {
                tServers otServers = new tServers();

                otServers.Protocol = fServerInfo.cmbProtocol.Text;

                otServers.ServerIP = fServerInfo.txt_IP_Server.Text;

               

                otServers.Method = fServerInfo.cmdMethod.Text;


                if (fServerInfo.chbPort.Checked)
                {
                    otServers.Port = fServerInfo.numPort.Value.ToInt16();
                }
                else
                {
                    otServers.Port = 0;
                }
               


                if (string.IsNullOrEmpty(fServerInfo.txtSelectFile.Text) || fServerInfo.cmbProtocol.SelectedItem == fServerInfo.cmbProtocol.Items[0])
                {

                    otServers.FileName = string.Empty;

                    otServers.FileForExtension = null;

                    otServers.Password = string.Empty;


                }
                else
                {

                    otServers.FileName = fServerInfo.txtSelectFile.Text;

                    otServers.FileForExtension = File.ReadAllBytes(fServerInfo.dlgOpen.FileName).ToArray();

                    otServers.Password = fServerInfo.txtPassword.Text;
                }
                

                otServers.SaveAndFlush();

                Update_LV(fSelect.lsvSelect);


                fSelect.lsvSelect.Items[fSelect.lsvSelect.Items.Count-1].Focused = true;

                fSelect.lsvSelect.Items[fSelect.lsvSelect.Items.Count - 1].Selected = true;

            }

            


            fServerInfo.cmbProtocol.SelectedIndexChanged -= cmbProtocol_SelectedIndexChanged;

            fServerInfo.btnSelectFile.Click -= btnSelectFile_Click;

            fServerInfo.txtSelectFile.TextChanged -= txtSelectFile_TextChanged;

            fServerInfo.btnClearFile.Click -= btnClearFile_Click;

        }

        public void Edit(int ID_Server)
        {


            int Index_Select = fSelect.lsvSelect.SelectedIndices[0];


            tServers otServers = tServers.byID(ID_Server);

            fServerInfo = new frmServerInfo();

            //fServerInfo.Text += " SERVERS";

            fServerInfo.cmbProtocol.SelectedIndexChanged += cmbProtocol_SelectedIndexChanged;

            fServerInfo.btnSelectFile.Click += btnSelectFile_Click;

            fServerInfo.btnClearFile.Click += btnClearFile_Click;

            fServerInfo.txtSelectFile.TextChanged += txtSelectFile_TextChanged;

            
            //Данная строчка вызывает событие cmbProtocol_SelectedIndexChanged
            //для корректного отображения элементов на форме
            fServerInfo.cmbProtocol.SelectedItem = otServers.Protocol == "HTTPS"
                ? fServerInfo.cmbProtocol.Items[1]
                : fServerInfo.cmbProtocol.Items[0];

            

            fServerInfo.txt_IP_Server.Text = otServers.ServerIP;

            if (otServers.Port==0)
            {
                fServerInfo.chbPort.Checked = false;

                fServerInfo.numPort.Value = 0;
            }
            else
            {
                fServerInfo.chbPort.Checked = true;

                fServerInfo.numPort.Value = otServers.Port;
            }


            fServerInfo.numPort.Value = otServers.Port;

            fServerInfo.cmdMethod.Text= otServers.Method;

            fServerInfo.txtSelectFile.Text= otServers.FileName;

            fServerInfo.txtSelectFile.Tag = otServers.FileForExtension;

            fServerInfo.txtPassword.Text = otServers.Password;

            

            if (fServerInfo.ShowDialog()==DialogResult.OK)
            {

                otServers.Protocol = fServerInfo.cmbProtocol.Text;
                
                otServers.ServerIP = fServerInfo.txt_IP_Server.Text;

                otServers.Port = fServerInfo.numPort.Value.ToInt16();

                otServers.Method = fServerInfo.cmdMethod.Text;



                if (string.IsNullOrEmpty(fServerInfo.txtSelectFile.Text) || fServerInfo.cmbProtocol.SelectedItem == fServerInfo.cmbProtocol.Items[0])
                {

                    otServers.FileName = string.Empty;

                    otServers.FileForExtension = null;

                    otServers.Password = string.Empty;


                }
                else
                {

                    otServers.FileName = fServerInfo.txtSelectFile.Text;

                    otServers.FileForExtension = (byte[]) fServerInfo.txtSelectFile.Tag;

                    otServers.Password = fServerInfo.txtPassword.Text;
                }
                
                

                


                otServers.SaveAndFlush();

                Update_LV(fSelect.lsvSelect);


                fSelect.lsvSelect.Items[Index_Select].Focused = true;

                fSelect.lsvSelect.Items[Index_Select].Selected = true;

            }

            fServerInfo.cmbProtocol.SelectedIndexChanged -= cmbProtocol_SelectedIndexChanged;

            fServerInfo.btnSelectFile.Click -= btnSelectFile_Click;

            fServerInfo.btnClearFile.Click -= btnClearFile_Click;

            fServerInfo.txtSelectFile.TextChanged -= txtSelectFile_TextChanged;
        }

        public void Del(int ID_Server)
        {
            tServers otServer=tServers.byID(ID_Server);

            otServer.DeleteAndFlush();
        }



        public void Update_CMB(ToolStripComboBox cmb)
        {

            cmb.Items.Clear();

            StringBuilder str = new StringBuilder();

            foreach (var VARIABLE in tServers.FindAll())
            {
                str = new StringBuilder();


                if (VARIABLE.Port == 0)
                {
                    str.Append(VARIABLE.Method + "  " + VARIABLE.Protocol + "://" + VARIABLE.ServerIP);
                }
                else
                {
                    str.Append(VARIABLE.Method + "  " + VARIABLE.Protocol + "://" + VARIABLE.ServerIP + ":" + VARIABLE.Port);
                }


                

                cmb.Items.Add(str.ToString());


            }
        }

        public void Update_LV(ListView lsv)
        {

            lsv.Items.Clear();

            ListViewItem item =new ListViewItem();

            StringBuilder str = new StringBuilder();

            foreach (var VARIABLE in tServers.FindAll())
            {
                str = new StringBuilder();

                if (VARIABLE.Port==0)
                {
                    str.Append(VARIABLE.Method + "  " + VARIABLE.Protocol + "://" + VARIABLE.ServerIP);
                }
                else
                {
                    str.Append(VARIABLE.Method + "  " + VARIABLE.Protocol + "://" + VARIABLE.ServerIP + ":" + VARIABLE.Port);
                }

                

                item = new ListViewItem();

                item.Text = str.ToString();


                item.Tag = VARIABLE.ID_Servers;

                lsv.Items.Add(item);


            }




        }




        public byte[] getFile(int INDEX_Server)
        {
            if (INDEX_Server < 0)
            {
                return null;
            }
            else
            {
                return tServers.byINDEX(INDEX_Server).FileForExtension;
            }
            
        }

        public string getPassword(int INDEX_Server)
        {
            if (INDEX_Server < 0)
            {
                return null;
            }
            else
            {
                return tServers.byINDEX(INDEX_Server).Password;
            }

        }


    }
}
