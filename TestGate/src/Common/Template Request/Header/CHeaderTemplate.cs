using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using TestRequest.db;
using TestRequest.Properties;


namespace TestGate
{


    public sealed partial class CHeaderTemplate
    {











        private frmHeaderTemplate fHeader_Template;

        private CHeaderData fromDB = null;

        private CHeaderData _HeaderData = null;


        private List<CHeaderData> lst_HeaderTemplates;


        public CHeaderData HeaderData
        {
            get
            {
                if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex >= 0)
                {
                    _HeaderData = lst_HeaderTemplates[fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex];
                }
                else
                {
                    if (fromDB != null)
                    {
                        _HeaderData = fromDB;
                    }
                }
                return _HeaderData;
            }


        }





        public CHeaderTemplate(ref frmHeaderTemplate fHeader_Template)
        {

            this.fHeader_Template = fHeader_Template;



            lst_HeaderTemplates = new List<CHeaderData>();


            foreach (var VARIABLE in tHeader_Params.FindAll())
            {
                CHeaderData tmpHeaderData = new CHeaderData();

                tmpHeaderData.NameTemplate = VARIABLE.NameTemplate;



                _Read_DB(VARIABLE.TemplateParametrs, ref tmpHeaderData);

                lst_HeaderTemplates.Add(tmpHeaderData);

            }


            Update_CMB(fHeader_Template.tspHeaderParams_cmbHedearsNames);




            fHeader_Template.tspHeader_Result_Save.Click += tspHeader_Result_Save_Click;


            fHeader_Template.tspHeaderParams_btnHedears.Click += tspHeaderParams_btnHedears_Click;

            fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndexChanged +=
                tspHeaderParams_cmbHedearsNames_SelectedIndexChanged;



            fHeader_Template.tspHeaderParams_Save.Click += tspHeaderParams_Save_Click;


            fHeader_Template.tspHeaderParams_Add.Click += tspHeaderParams_AddParam_Click;




        }




        public CHeaderTemplate(ref frmHeaderTemplate fHeader_Template, ref CHeaderData _HeaderData)
            : this(ref fHeader_Template)
        {

            this._HeaderData = _HeaderData;



            fromDB = new CHeaderData();

            fromDB.NameTemplate = _HeaderData.NameTemplate;

            fromDB.lst_Parametrs.AddRange(_HeaderData.lst_Parametrs);







            for (int i = 0; i < fHeader_Template.tspHeaderParams_cmbHedearsNames.Items.Count; i++)
            {
                if (_HeaderData.NameTemplate == fHeader_Template.tspHeaderParams_cmbHedearsNames.Items[i].ToString())
                {
                    fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex = i;


                    fromDB = null;



                    break;
                }
            }


            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex == -1)
            {
                fHeader_Template.tspHeaderParams_cmbHedearsNames.Text = _HeaderData.NameTemplate;

                fHeader_Template.tspHeader_LoadOriginal.Visible = true;

                fHeader_Template.toolStripSeparator1.Visible = true;

                fHeader_Template.tspHeader_LoadOriginal.Click += tspHeader_LoadOriginal_Click;

            }


            fHeader_Template.panelHeader.Controls.Clear();

            Paint(_HeaderData);

            foreach (var VAR in fHeader_Template.panelHeader.Controls)
            {
                if (VAR is TextBox)
                {

                    foreach (var VARIABLE in _HeaderData.lst_Parametrs)
                    {
                        if (((TextBox) VAR).Tag.ToInt() == VARIABLE.ID)
                        {

                            ((TextBox) VAR).Text = VARIABLE.ValueParametr;
                        }
                    }


                }
            }


            fromDB = _HeaderData;






        }







        public void Add()
        {

            frmHeaderParametrs fHeaderParametrs = new frmHeaderParametrs();



            CHeaderData tmpHeaderData = new CHeaderData();

            tmpHeaderData.NameTemplate = OriginalName();



            fHeaderParametrs.tspHeaderTemplate_txtNameTemplate.Text = tmpHeaderData.NameTemplate;


            CHeaderParams oHeaderParams = new CHeaderParams(ref fHeaderParametrs, ref tmpHeaderData);





            if (fHeaderParametrs.ShowDialog() == DialogResult.OK)
            {

                if (string.IsNullOrEmpty(fHeaderParametrs.tspHeaderTemplate_txtNameTemplate.Text))
                {
                    tmpHeaderData.NameTemplate = OriginalName();
                }
                else
                {

                    tmpHeaderData.NameTemplate = fHeaderParametrs.tspHeaderTemplate_txtNameTemplate.Text;
                    
                }
            
                
               


                tHeader_Params otHeaderParams = new tHeader_Params();

                otHeaderParams.NameTemplate = tmpHeaderData.NameTemplate;

                otHeaderParams.TemplateParametrs = SaveToDB(tmpHeaderData);

                otHeaderParams.SaveAndFlush();

                lst_HeaderTemplates.Add(tmpHeaderData);


            }
        }

        public void Edit(int Index)
        {
            CHeaderData tmpHeaderData = lst_HeaderTemplates[Index];

            frmHeaderParametrs fHeaderParametrs = new frmHeaderParametrs();

            fHeaderParametrs.tspHeaderTemplate_txtNameTemplate.Text = tmpHeaderData.NameTemplate;

            CHeaderParams oHeaderParams = new CHeaderParams(ref fHeaderParametrs, ref tmpHeaderData);



            if (oHeaderParams.Edit() == DialogResult.OK)
            {

                tmpHeaderData.NameTemplate = fHeaderParametrs.tspHeaderTemplate_txtNameTemplate.Text;

                tHeader_Params ot = tHeader_Params.byINDEX(Index);

                ot.NameTemplate = tmpHeaderData.NameTemplate;

                ot.TemplateParametrs = SaveToDB(tmpHeaderData);

                ot.SaveAndFlush();


            }



        }

        public void Del(int Index)
        {


            tHeader_Params ot = tHeader_Params.byINDEX(Index);

            ot.DeleteAndFlush();


            lst_HeaderTemplates.RemoveAt(Index);




        }



        public void Duplicate(int Index)
        {



            CHeaderData tmpHeaderData = new CHeaderData();


            tmpHeaderData.NameTemplate = OriginalName();


            tmpHeaderData.lst_Parametrs.AddRange(lst_HeaderTemplates[Index].lst_Parametrs);

            lst_HeaderTemplates.Add(tmpHeaderData);


            tHeader_Params otHeaderParams = new tHeader_Params();

            otHeaderParams.NameTemplate = tmpHeaderData.NameTemplate;

            otHeaderParams.TemplateParametrs = SaveToDB(tmpHeaderData);

            otHeaderParams.SaveAndFlush();




        }

        public void Update_LV(ListView lsv)
        {

            lsv.Items.Clear();

            foreach (var VARIABLE in lst_HeaderTemplates)
            {

                StringBuilder tmpSTR = new StringBuilder();

                foreach (var VAR in VARIABLE.lst_Parametrs)
                {
                    tmpSTR.Append(VAR.NameParametr + " ");
                }

                string[] s = new string[2];

                s[0] = VARIABLE.NameTemplate;

                s[1] = tmpSTR.ToString();

                lsv.Items.Add(new ListViewItem(s));
            }

        }

        public void Update_CMB(ToolStripComboBox cmd)
        {

            cmd.Items.Clear();

            foreach (var VARIABLE in lst_HeaderTemplates)
            {
                cmd.Items.Add(VARIABLE.NameTemplate);
            }
        }










        private void Paint(CParametrData oParametrData)
        {

            int Coordinate = 0;

            int z = 0;

            foreach (var VARIABLE in fHeader_Template.panelHeader.Controls)
            {
                if (VARIABLE is TextBox)
                {
                    if ((VARIABLE as TextBox).Location.Y > Coordinate)
                    {
                        Coordinate = (VARIABLE as TextBox).Location.Y;


                    }
                }
            }

            if (Coordinate > 0) z = 15;



            //Динамическое добавление Наименование пареметра
            Label lblParametr = new Label();
            lblParametr.Size = new System.Drawing.Size(116, 18);
            lblParametr.Location = new System.Drawing.Point(14, 18 + Coordinate + z);

            lblParametr.Name = "lblParametr" + oParametrData.ID;
            lblParametr.Tag = oParametrData.ID;
            lblParametr.Text = oParametrData.NameParametr;



            fHeader_Template.panelHeader.Controls.Add(lblParametr);




            //Динамическое добавление Тектстового поля для редактирования пареметра
            TextBox txtParametr = new TextBox();
            txtParametr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtParametr.Size = new System.Drawing.Size(480, 20);
            txtParametr.Location = new System.Drawing.Point(136, 15 + Coordinate + z);




            txtParametr.Name = "txtParametr" + oParametrData.ID;
            txtParametr.Tag = oParametrData.ID;
            txtParametr.Text = oParametrData.ValueParametr;

            txtParametr.TextChanged += txtParametr_TextChanged;







            fHeader_Template.panelHeader.Controls.Add(txtParametr);





            //Динамическое добавление Кнопки для удаления параметра
            Button btnDel_Parametr = new Button();
            btnDel_Parametr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel_Parametr.Image = Resources.Del_Parametr;
            btnDel_Parametr.Size = new System.Drawing.Size(21, 21);
            btnDel_Parametr.UseVisualStyleBackColor = true;
            btnDel_Parametr.Location = new System.Drawing.Point(630, 15 + Coordinate + z);





            btnDel_Parametr.Name = "btnDel_Parametr" + oParametrData.ID;
            btnDel_Parametr.Tag = oParametrData.ID;
            btnDel_Parametr.Click += btnDel_Parametr_Click;






            fHeader_Template.panelHeader.Controls.Add(btnDel_Parametr);





        }

        private void Paint(CHeaderData oHeaderData)
        {
            foreach (var VARIABLE in oHeaderData.lst_Parametrs)
            {

                var o = VARIABLE;

                Paint(o);
            }
        }







        private string SaveToDB(CHeaderData oHeaderData)
        {



            StreamReader aReader = null;

            MemoryStream aMemoryStream = new MemoryStream();

            XmlWriter xmlWriter = null;






            xmlWriter = new XmlTextWriter(aMemoryStream, Encoding.UTF8);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("TemplateParametrs");




            XmlSerializer xs = new XmlSerializer(typeof (CParametrData[]));

            XmlSerializerNamespaces xsNameSpace = new XmlSerializerNamespaces();

            xsNameSpace.Add("", "");

            xs.Serialize(xmlWriter, oHeaderData.lst_Parametrs.ToArray(), xsNameSpace);


            xmlWriter.WriteEndElement();



            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();

            aMemoryStream.Position = 0;

            aReader = new StreamReader(aMemoryStream);

            return aReader.ReadToEnd();

        }

        private void _Read_DB(string xmlSting, ref CHeaderData oHeaderData)
        {

            var xs = new XmlSerializer(typeof(CParametrData[]));


            using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlSting)))
            {

                while (xmlReader.Read())
                {
                    if (xmlReader.Name == "ArrayOfCParametrData")
                    {
                        oHeaderData.lst_Parametrs.AddRange((CParametrData[])xs.Deserialize(xmlReader));

                    }
                }
            }

        }



       




    }




}
