using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using TestRequest.db;

namespace TestGate
{
    public sealed partial class CHeader_Result
    {

        private frmMain fMain;

        public CHeader_Result(ref frmMain fMain)
        {

            this.fMain = fMain;

        }




        public void Add()
        {

            frmHeaderTemplate fHeader_Template = new frmHeaderTemplate();


            tHeaderTemplate otHeaderResult = new tHeaderTemplate();


             

            CServers oServers = new CServers();


            CHeaderTemplate oHeaderTemplate =new CHeaderTemplate(ref fHeader_Template);


            oServers.Update_CMB(fHeader_Template.tspHeader_Result_cmbServers);




            fHeader_Template.tspHeader_Result_bntServers.Click += oServers.tspHeader_Result_bntServers_Click;

            if (fHeader_Template.ShowDialog() == DialogResult.OK)
            {
               

                otHeaderResult.ServerLine = fHeader_Template.tspHeader_Result_cmbServers.Text;


                otHeaderResult.FileForExtension =
                    oServers.getFile(fHeader_Template.tspHeader_Result_cmbServers.SelectedIndex);

                otHeaderResult.ServerPassword =
                    oServers.getPassword(fHeader_Template.tspHeader_Result_cmbServers.SelectedIndex);



                otHeaderResult.HeaderLine = SaveToDB(oHeaderTemplate.HeaderData);

                
                




                otHeaderResult.SaveAndFlush();

                Update_LV(fMain.lsvHeader_Result);

                fMain.lsvHeader_Result.Items[fMain.lsvHeader_Result.Items.Count - 1].Selected = true;

                fMain.lsvHeader_Result.Items[fMain.lsvHeader_Result.Items.Count - 1].Focused = true;
            }

           

            fHeader_Template.tspHeader_Result_bntServers.Click += oServers.tspHeader_Result_bntServers_Click;


        }

        public void Edit(int Index_Header_Result)
        {



            frmHeaderTemplate fHeader_Template = new frmHeaderTemplate();


            

            tHeaderTemplate otHeaderResult = tHeaderTemplate.byINDEX(Index_Header_Result);

            CServers oServers = new CServers();

            
            
            CHeaderData oHeaderData = _Read_DB(otHeaderResult.HeaderLine);

            
            
            CHeaderTemplate oHeaderTemplate = new CHeaderTemplate(ref fHeader_Template, ref oHeaderData);

            
            

            fHeader_Template.tspHeader_Result_cmbServers.Text = otHeaderResult.ServerLine;

            
            fHeader_Template.tspHeader_Result_bntServers.Click += oServers.tspHeader_Result_bntServers_Click;

            oServers.Update_CMB(fHeader_Template.tspHeader_Result_cmbServers);



            fHeader_Template.tspHeader_Result_cmbServers.Text = otHeaderResult.ServerLine;



            if (fHeader_Template.ShowDialog() == DialogResult.OK)
            {

                otHeaderResult.ServerLine = fHeader_Template.tspHeader_Result_cmbServers.Text;

                
                otHeaderResult.FileForExtension =
                   oServers.getFile(fHeader_Template.tspHeader_Result_cmbServers.SelectedIndex);


                otHeaderResult.ServerPassword =
                    oServers.getPassword(fHeader_Template.tspHeader_Result_cmbServers.SelectedIndex);


                otHeaderResult.HeaderLine = SaveToDB(oHeaderTemplate.HeaderData);

                
                otHeaderResult.SaveAndFlush();

                Update_LV(fMain.lsvHeader_Result);
            }
        }




        public void Del(int Index_Header_Result)
        {
            tHeaderTemplate.byINDEX(Index_Header_Result).DeleteAndFlush();
        }





        public void Update_LV(ListView lsv)
        {

            lsv.Items.Clear();

            StringBuilder tmpSTR;


            foreach (var VARIABLE in tHeaderTemplate.FindAll())
            {

                tmpSTR = new StringBuilder();

                CHeaderData tmpHeaderData = _Read_DB(VARIABLE.HeaderLine);




                tmpSTR.Append(VARIABLE.ServerLine);

                foreach (var VAR in tmpHeaderData.lst_Parametrs)
                {
                    if (string.IsNullOrEmpty(VAR.NameParametr))
                    {
                        tmpSTR.Append("/" + VAR.ValueParametr);
                    }
                    else
                    {
                        tmpSTR.Append("/" + VAR.NameParametr + "=" + VAR.ValueParametr);
                    }

                    
                }

                ListViewItem item = new ListViewItem(tmpSTR.ToString());

                item.Tag = VARIABLE.ID_Header_Template;


                lsv.Items.Add(item);
            }


        }





        
        private string SaveToDB(CHeaderData oHeaderData)
        {
            if (oHeaderData==null)
            {
                return string.Empty;
            }

            StreamReader aReader = null;

            MemoryStream aMemoryStream = new MemoryStream();

            XmlWriter xmlWriter = null;






            xmlWriter = new XmlTextWriter(aMemoryStream, Encoding.UTF8);

            xmlWriter.WriteStartDocument();

            //xmlWriter.WriteStartElement("TemplateData");




            XmlSerializer xs = new XmlSerializer(typeof(CHeaderData));

            XmlSerializerNamespaces xsNameSpace = new XmlSerializerNamespaces();

            xsNameSpace.Add("", "");

            xs.Serialize(xmlWriter, oHeaderData, xsNameSpace);


            //xmlWriter.WriteEndElement();



            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();

            aMemoryStream.Position = 0;

            aReader = new StreamReader(aMemoryStream);

            return aReader.ReadToEnd();

        }


        private CHeaderData _Read_DB(string xmlSting)
        {

            return Read_DB(xmlSting);
        }


        public static CHeaderData Read_DB(string xmlSting)
        {
            CHeaderData oHeaderData = null;

            var xs = new XmlSerializer(typeof(CHeaderData));


            using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlSting)))
            {

                while (xmlReader.Read())
                {

                    oHeaderData = (CHeaderData)xs.Deserialize(xmlReader);


                }

            }

            return oHeaderData;
        }


    }
}
