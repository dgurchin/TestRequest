using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRequest.db;

namespace TestGate
{
    partial class CHeaderTemplate
    {


        private void tspHeader_Result_Save_Click(object sender, EventArgs e)
        {
            fHeader_Template.DialogResult = DialogResult.OK;

            tspHeaderParams_Save_Click(fHeader_Template.tspHeaderParams_Save, e);

        }
       



        
        private void tspHeader_LoadOriginal_Click(object sender, EventArgs e)
        {



            _HeaderData = new CHeaderData();

            _HeaderData.NameTemplate = fromDB.NameTemplate;

            _HeaderData.lst_Parametrs.AddRange(fromDB.lst_Parametrs);
           
            
            fHeader_Template.tspHeaderParams_cmbHedearsNames.Text = _HeaderData.NameTemplate;
            
            fHeader_Template.panelHeader.Controls.Clear();

            Paint(_HeaderData);
        }





        
        public void tspHeaderParams_btnHedears_Click(object sender, EventArgs e)
        {




            frmSelect fHeaders = new frmSelect();

            fHeaders.tspSelect_Dublicate.Visible = true;

            fHeaders.lsvSelect.Columns.Add("Name Header Template", 273);

            fHeaders.lsvSelect.Columns.Add("Parametrs", 462);
            
            Update_LV(fHeaders.lsvSelect);




          
            fHeaders.tspSelect_Add.Click += tspSelectHeader_Add_Click;

            fHeaders.tspSelect_Dublicate.Click += tspSelectHeader_Dublicate_Click;

            fHeaders.tspSelect_Del.Click += tspSelectHeader_Del_Click;

            fHeaders.tspSelect_Edit.Click += tspSelectHeader_Edit_Click;

          

            
            

            if (fHeaders.ShowDialog() == DialogResult.OK)
            {
                int i = fHeaders.lsvSelect.SelectedIndices[0];

                Update_CMB(fHeader_Template.tspHeaderParams_cmbHedearsNames);

                fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedItem =
                    fHeader_Template.tspHeaderParams_cmbHedearsNames.Items[i];
            }
            else
            {
                fHeader_Template.tspHeaderParams_cmbHedearsNames.Text = string.Empty;

                Update_CMB(fHeader_Template.tspHeaderParams_cmbHedearsNames);

                if (fHeader_Template.tspHeaderParams_cmbHedearsNames.Items.Count == 0)
                {
                    fHeader_Template.tspHeaderParams_cmbHedearsNames.Items.Clear();
                }
            }


          




            
            fHeaders.tspSelect_Add.Click -= tspSelectHeader_Add_Click;

            fHeaders.tspSelect_Dublicate.Click -= tspSelectHeader_Dublicate_Click;

            fHeaders.tspSelect_Del.Click -= tspSelectHeader_Del_Click;

            fHeaders.tspSelect_Edit.Click -= tspSelectHeader_Edit_Click;

            
        }


        private void tspHeaderParams_Save_Click(object sender, EventArgs e)
        {


            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex >= 0)
            {
                int Index_HeaderData = fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex;


                _HeaderData = lst_HeaderTemplates[Index_HeaderData];

                tHeader_Params otHeaderParams = tHeader_Params.byINDEX(Index_HeaderData);

                otHeaderParams.NameTemplate = _HeaderData.NameTemplate;

                otHeaderParams.TemplateParametrs = SaveToDB(_HeaderData);

                otHeaderParams.SaveAndFlush();
            }
            else
            {

                if (fromDB != null)
                {
                    if (fHeader_Template.tspHeaderParams_cmbHedearsNames.Text == fromDB.NameTemplate)
                    {
                        fromDB = new CHeaderData();

                        fromDB.NameTemplate = _HeaderData.NameTemplate;

                        fromDB.lst_Parametrs.AddRange(_HeaderData.lst_Parametrs);

                        return;
                    }

                }

                if (string.IsNullOrEmpty(fHeader_Template.tspHeaderParams_NameParam.Text))
                {
                    fHeader_Template.tspHeaderParams_NameParam.Text = "New_Parametr";
                }

                tspHeaderParams_AddParam_Click(fHeader_Template.tspHeaderParams_Add, e);




            }


        }




        private void tspHeaderParams_cmbHedearsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            fHeader_Template.panelHeader.Controls.Clear();


            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex < 0) 
            {
                
                _HeaderData = new CHeaderData();

                _HeaderData.NameTemplate = fromDB.NameTemplate;

                _HeaderData.lst_Parametrs.AddRange(fromDB.lst_Parametrs);

               
            }
            else
            {

                
                var tmpHeaderData = lst_HeaderTemplates[fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex];

                _HeaderData = new CHeaderData();

                _HeaderData.NameTemplate = tmpHeaderData.NameTemplate;

                _HeaderData.lst_Parametrs.AddRange(tmpHeaderData.lst_Parametrs);



               
            }


            Paint(_HeaderData);
        }

        public string OriginalName()
        {

           
            for (int i = 0; ; i++)
            {
                string s = "New_Template_" + i;

                if (Dublicate_Name(s))
                {
                    continue;
                }
                else
                {
                    return s;

                }
            }

        }

        public bool Dublicate_Name(string NameTemplate)
        {
            foreach (var VARIABLE in tHeader_Params.FindAll())
            {
                if (VARIABLE.NameTemplate == NameTemplate)
                {
                  

                    return true;
                }
            }

            return false;
        }

        private void tspHeaderParams_AddParam_Click(object sender, EventArgs e)
        {
            



            //Анонимный метод потому что кроме как в этой функции нигде больше использоваться не будет
            Action<CHeaderData> Add_Header = (HeaderData) =>
            
            {


                CHeaderParams oHeaderParams = new CHeaderParams(ref HeaderData);

                oHeaderParams.Add(fHeader_Template.tspHeaderParams_NameParam.Text);

                tHeader_Params otHeaderParams = new tHeader_Params();

                otHeaderParams.NameTemplate = HeaderData.NameTemplate;

                otHeaderParams.TemplateParametrs = SaveToDB(HeaderData);

                otHeaderParams.SaveAndFlush();

                lst_HeaderTemplates.Add(HeaderData);

                Update_CMB(fHeader_Template.tspHeaderParams_cmbHedearsNames);

                for (int i = 0; i < fHeader_Template.tspHeaderParams_cmbHedearsNames.Items.Count; i++)
                {
                    if (HeaderData.NameTemplate == fHeader_Template.tspHeaderParams_cmbHedearsNames.Items[i].ToString())
                    {
                        fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex = i;
                    }
                }
            };


            Action<CHeaderData> Add_Parametr = (HeaderData) =>
            {
                CHeaderParams oHeaderParams = new CHeaderParams(ref HeaderData);

                oHeaderParams.Add(fHeader_Template.tspHeaderParams_NameParam.Text);

                Paint(HeaderData.lst_Parametrs[HeaderData.lst_Parametrs.Count - 1]);
            };





            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex < 0)
            {


                /*Редкий на первый взгляд но все же возможный сценарий

                 Запрос состоит из трех составляющих:
                         1. Серверная часть запроса tServers
                         2. Заглавие запроса tHeader_Params
                         3. Тело запроса (tScenarioTemplate и tPluginTemplate в зависимости от сценария)

                 Что б упростить комбинаторику была создана отдельная сущность которая в себе хранит данные
                 заглавия и серверной части tHeaderTemplate

                 tHeaderTemplate = tServers + tHeader_Params
			
                             tServers = tHeaderTemplate.ServerLine + FileForExtension (файл сертификата)

                             tHeader_Params = tHeaderTemplate.HeaderLine


                 tHeaderTemplate – отдельная сущность которая полностью автономна. Она никак не связана tHeader_Params и tServers


                 При очень редких условиях если запись будет удалена из tServers и/или tHeader_Params
                 это никак не отразиться tHeaderTemplate.ServerLine и/или tHeaderTemplate.HeaderLine

                 И вот он наступает редкий случай

                 Если нет шаблона в tServers БД и/или tHeader_Params в форму frmHeaderTemplate загружаются сохраненные данные из 
                 tHeaderTemplate (включая файл сертификата, который хранится в поле tHeaderTemplate.FileForExtension)


                 И этот шаблон можно редактировать и даже сохранить в tHeaderTemplate. Для этого используется закрытая переменная !fromDB!.
                 В случае если шаблон который находится в справочнике tHeader_Params актуален она равна null в других случаях
                 она содержит элемент сохраненный tHeaderTemplate.HeaderLine*/


                if (fromDB != null)
                {
                    if (fHeader_Template.tspHeaderParams_cmbHedearsNames.Text == fromDB.NameTemplate)
                    {
                        _HeaderData = new CHeaderData();

                        _HeaderData.NameTemplate = fromDB.NameTemplate;

                        _HeaderData.lst_Parametrs.AddRange(fromDB.lst_Parametrs);

                        Add_Parametr(_HeaderData);

                        return;

                    }
                }


                //Если ТЕКСТ списка "tspHeaderParams_cmbHedearsNames" пуст – будет создан новый элемент CHeaderTemplate
                //с уникальным именем и к нему будет добавлен ПАРАМЕТР имя которого будет соответсвовать tspHeaderParams_NameParam.Text.
                //Cозданный элемент CHeaderTemplate будет добавлен и сохранен в БД автоматически
                if (string.IsNullOrEmpty(fHeader_Template.tspHeaderParams_cmbHedearsNames.Text))
                {

                    

                    CHeaderData tmpHeaderData = new CHeaderData();

                    tmpHeaderData.NameTemplate = OriginalName();

                    Add_Header(tmpHeaderData);

                    

                    


                }



                //Если текст списка "tspHeaderParams_cmbHedearsNames" не пуст – будет создан новый элемент CHeaderTemplate
                //с именем введенным в поле tspHeaderParams_cmbHedearsNames и к нему будет добавлен ПАРАМЕТР имя которого будет соответсвовать tspHeaderParams_NameParam.Text.
                //Cозданный элемент CHeaderTemplate будет добавлен и сохранен в БД автоматически
                else if (!string.IsNullOrEmpty(fHeader_Template.tspHeaderParams_cmbHedearsNames.Text))
                {
                    if (Dublicate_Name(fHeader_Template.tspHeaderParams_cmbHedearsNames.Text))
                    {

                        for (int i = 0; i < fHeader_Template.tspHeaderParams_cmbHedearsNames.Items.Count; i++)
                        {
                            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.Text == fHeader_Template.tspHeaderParams_cmbHedearsNames.Items[i].ToString())
                            {
                                fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex = i;

                                Add_Parametr(_HeaderData);

                                return;

                            }
                        }

                       
                    }



                    CHeaderData tmpHeaderData = new CHeaderData();

                    tmpHeaderData.NameTemplate = fHeader_Template.tspHeaderParams_cmbHedearsNames.Text;

                    Add_Header(tmpHeaderData);

                    

                }

            }


            //Если выбран элемент из БД шаблонов списка "tspHeaderParams_cmbHedearsNames" – будет добавлен новый ПАРАМЕТР,
            //имя которого будет соответсвовать tspHeaderParams_NameParam.Text в элемент CHeaderTemplate.
            //Обновленный элемент отрисуется на форме, но внесенные изменения будут сохранены только при нажатии клавиши 
            // tspHeaderParams_Save
            else
            {
                CHeaderData tmpHeaderData =
                    lst_HeaderTemplates[fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex];


                Add_Parametr(tmpHeaderData);
            }

            fHeader_Template.tspHeaderParams_NameParam.Text = string.Empty;

        }


        private void btnDel_Parametr_Click(object sender, EventArgs e)
        {


            


            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex>=0)
            {

                _HeaderData = lst_HeaderTemplates[fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex];


            }
            else if (fromDB!=null)
            {

                if (fHeader_Template.tspHeaderParams_cmbHedearsNames.Text==fromDB.NameTemplate)
                {

                    _HeaderData = new CHeaderData();

                    _HeaderData.NameTemplate = fromDB.NameTemplate;

                    _HeaderData.lst_Parametrs.AddRange(fromDB.lst_Parametrs);
                }

            }
           




            Button btnDel_Parametr = sender as Button;

            Panel tmPanel = (btnDel_Parametr.FindForm() as frmHeaderTemplate).panelHeader;

            TextBox txt = null;

            Label lbl = null;


            foreach (Control VARIABLE in tmPanel.Controls)
            {
                if (VARIABLE is TextBox)
                {
                    if (VARIABLE.Tag.ToInt() == btnDel_Parametr.Tag.ToInt())
                    {
                        txt = VARIABLE as TextBox;

                        continue;


                    }
                }



                if (VARIABLE is Label)
                {
                    if (VARIABLE.Tag.ToInt() == btnDel_Parametr.Tag.ToInt())
                    {
                        lbl = VARIABLE as Label;
                    }
                }



            }


            for (int i = 0; i < _HeaderData.lst_Parametrs.Count; i++)
            {
                if (_HeaderData.lst_Parametrs[i].NameParametr == lbl.Text)
                {

                    _HeaderData.lst_Parametrs.RemoveAt(i);

                    break;

                }
            }


            tmPanel.Controls.Remove(lbl);

            tmPanel.Controls.Remove(txt);

            tmPanel.Controls.Remove(btnDel_Parametr);







        }

        private void txtParametr_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;


            if (fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex<0)
            {
                
                foreach (var VARIABLE in _HeaderData.lst_Parametrs)
                {
                    if (VARIABLE.ID == txt.Tag.ToInt())
                    {
                        VARIABLE.ValueParametr = txt.Text;
                    }
                }
            }
            else
            {
                foreach (var VARIABLE in lst_HeaderTemplates[fHeader_Template.tspHeaderParams_cmbHedearsNames.SelectedIndex].lst_Parametrs)
                {
                    if (VARIABLE.ID == txt.Tag.ToInt())
                    {
                        VARIABLE.ValueParametr = txt.Text;
                    }
                }
            }

           

        }






















        private void tspSelectHeader_Add_Click(object sender, EventArgs e)
        {

            frmSelect fHeaders = (sender as ToolStripButton).Owner.FindForm() as frmSelect;

            Add();

            Update_LV(fHeaders.lsvSelect);


        }

        private void tspSelectHeader_Dublicate_Click(object sender, EventArgs e)
        {
            frmSelect fHeaders = (sender as ToolStripButton).Owner.FindForm() as frmSelect;

            Duplicate(fHeaders.lsvSelect.SelectedIndices[0]);

            Update_LV(fHeaders.lsvSelect);


            fHeaders.lsvSelect.Items[fHeaders.lsvSelect.Items.Count - 1].Selected = true;

            fHeaders.lsvSelect.Items[fHeaders.lsvSelect.Items.Count - 1].Focused = true;


        }

        private void tspSelectHeader_Del_Click(object sender, EventArgs e)
        {
            frmSelect fHeaders = (sender as ToolStripButton).Owner.FindForm() as frmSelect;


            Del(fHeaders.lsvSelect.SelectedIndices[0]);







            Update_LV(fHeaders.lsvSelect);
        }

        private void tspSelectHeader_Edit_Click(object sender, EventArgs e)
        {
            frmSelect fHeaders = (sender as ToolStripButton).Owner.FindForm() as frmSelect;

            int i = fHeaders.lsvSelect.SelectedIndices[0];

            Edit(i);

            Update_LV(fHeaders.lsvSelect);


            fHeaders.lsvSelect.Items[i].Focused = true;

            fHeaders.lsvSelect.Items[i].Selected = true;


        }



       

        
    }
}
