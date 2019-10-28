using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TestRequest.Properties;

namespace TestGate
{
    partial class CHeaderParams
    {


        private CHeaderData oHeaderData;

        private frmHeaderParametrs fHeaderParametrs;



        public CHeaderParams(ref CHeaderData oHeaderData)
        {
            fHeaderParametrs = new frmHeaderParametrs();

            this.oHeaderData = oHeaderData;

            fHeaderParametrs.tspParametrs_Add.Click += tspParametrs_Add_Click;
        }

        

        public CHeaderParams(ref frmHeaderParametrs fHeaderParametrs, ref CHeaderData oHeaderData)
        {
            this.fHeaderParametrs = fHeaderParametrs;
            
            this.oHeaderData = oHeaderData;
            
            

            fHeaderParametrs.tspParametrs_Add.Click += tspParametrs_Add_Click;
            
            
        }


      



        public void Add(string NameParametr = null)
        {

            CParametrData oParametrData = new CParametrData();


            if (oHeaderData.lst_Parametrs.Count > 0)
            {
                oParametrData.ID = oHeaderData.lst_Parametrs[oHeaderData.lst_Parametrs.Count - 1].ID + 1;
            }
            else
            {
                oParametrData.ID = oHeaderData.lst_Parametrs.Count;
            }


            if (string.IsNullOrEmpty(NameParametr))
            {
                
                oParametrData.NameParametr = "New_Parametr_" + oParametrData.ID;


                
            }
            else
            {
                oParametrData.NameParametr = NameParametr;
            }
            

            oHeaderData.lst_Parametrs.Add(oParametrData);


            
            


        }



        private void Del(int ID)
        {

            for (int i = 0; i < oHeaderData.lst_Parametrs.Count; i++)
            {
                if (oHeaderData.lst_Parametrs[i].ID==ID)
                {
                    oHeaderData.lst_Parametrs.RemoveAt(i);
                }
            }

           

            
          
        }


        public DialogResult Edit()
        {




            fHeaderParametrs.tspHeaderTemplate_txtNameTemplate.Text = oHeaderData.NameTemplate;


            Paint(ref oHeaderData);

            return fHeaderParametrs.ShowDialog();
        }


       


        private void Paint(ref CParametrData oParametrData)
        {

            int Coordinate=0;

            int z=0;

            foreach (var VARIABLE in fHeaderParametrs.pnlParametrs.Controls)
            {
                if (VARIABLE is TextBox)
                {
                    if ((VARIABLE as TextBox).Location.Y>Coordinate)
                    {
                        Coordinate = (VARIABLE as TextBox).Location.Y;

                       
                    }
                }
            }

            if (Coordinate > 0) z = 5;


            Label lblParametr_ID = new Label();

            lblParametr_ID.AutoSize = true;
            lblParametr_ID.Size = new Size(23, 13);

            lblParametr_ID.Location = new Point(9, 25 + Coordinate + z);
            lblParametr_ID.Name = "lblParametr_ID_" + oParametrData.ID;
            lblParametr_ID.Text = "ID–" + oParametrData.ID;
            lblParametr_ID.Tag = oParametrData.ID;

            fHeaderParametrs.pnlParametrs.Controls.Add(lblParametr_ID);



            TextBox txtNameParametr = new TextBox();

            txtNameParametr.Anchor =
                AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            txtNameParametr.Location = new Point(62, 22 + Coordinate + z);
            txtNameParametr.Name = "txtNameParametr_" + oParametrData.ID;
            txtNameParametr.Size = new Size(305, 20);

            txtNameParametr.Tag = oParametrData.ID;

            txtNameParametr.Text = oParametrData.NameParametr;
            txtNameParametr.TextChanged += txtNameParametr_TextChanged;

            


            fHeaderParametrs.pnlParametrs.Controls.Add(txtNameParametr);


            Label lblColor = new Label();

            lblColor.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;

            lblColor.AutoSize = true;
            lblColor.Location = new Point(376, 25 + Coordinate + z);
            lblColor.Name = "lblColor" + oParametrData.ID;
            lblColor.Size = new Size(31, 13);
            lblColor.Text = "Color";
            lblColor.Tag = oParametrData.ID;



            fHeaderParametrs.pnlParametrs.Controls.Add(lblColor);


            PictureBox pcbColorParametr = new PictureBox();

            ((ISupportInitialize)(pcbColorParametr)).BeginInit();

            pcbColorParametr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbColorParametr.BackColor = SystemColors.ActiveCaptionText;
            pcbColorParametr.BorderStyle = BorderStyle.Fixed3D;
            pcbColorParametr.Cursor = Cursors.Hand;
            pcbColorParametr.Location = new Point(413, 22 + Coordinate + z);
            pcbColorParametr.Name = "pcbColorParametr" + oParametrData.ID; ;
            pcbColorParametr.Size = new Size(37, 20);
            pcbColorParametr.TabStop = false;

            pcbColorParametr.Tag = oParametrData.ID;

            pcbColorParametr.Click += pcbColorParametr_Click;


            ((ISupportInitialize)(pcbColorParametr)).EndInit();


            fHeaderParametrs.pnlParametrs.Controls.Add(pcbColorParametr);

            Button btnDel_Parametr = new Button();
            btnDel_Parametr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel_Parametr.Location = new Point(465, 21 + Coordinate + z);
            btnDel_Parametr.Name = "btnDelParametr" + oParametrData.ID; ;
            btnDel_Parametr.Size = new Size(21, 21);
            btnDel_Parametr.UseVisualStyleBackColor = true;
            btnDel_Parametr.Image = Resources.Del_Parametr;

            btnDel_Parametr.Tag = oParametrData.ID;

            btnDel_Parametr.Click+=btnDel_Parametr_Click;

            fHeaderParametrs.pnlParametrs.Controls.Add(btnDel_Parametr);
        }

        private void Paint(ref CHeaderData oHeaderData)
        {


            for (int i = 0; i < oHeaderData.lst_Parametrs.Count; i++)
            {
                var oParametrData = oHeaderData.lst_Parametrs[i];
                
                Paint(ref oParametrData);
            }

           




        }


        private void Erase(int ID)
        {





            List <Label> lbl = new List<Label>();

            TextBox txt = null;

            PictureBox pic = null;

            Button btn = null;


            foreach (Control VARIABLE in fHeaderParametrs.pnlParametrs.Controls)
            {
                
                if (VARIABLE is Label)
                {
                    if (VARIABLE.Tag.ToInt() == ID)
                    {
                        lbl.Add(VARIABLE as Label);
                    }
                }
                    
                else if (VARIABLE is TextBox)
                {
                    if (VARIABLE.Tag.ToInt() == ID)
                    {
                        txt = VARIABLE as TextBox;

                        continue;


                    }
                }

                else if (VARIABLE is PictureBox)
                {
                    if (VARIABLE.Tag.ToInt()==ID)
                    {
                        pic = VARIABLE as PictureBox;
                        
                    }
                }
                else if (VARIABLE is Button)
                {
                    if (VARIABLE.Tag.ToInt()==ID)
                    {
                        btn = VARIABLE as Button;
                    }
                }



            }

            foreach (var VARIABLE in lbl)
            {
                fHeaderParametrs.pnlParametrs.Controls.Remove(VARIABLE);
            }

          

            fHeaderParametrs.pnlParametrs.Controls.Remove(txt);

            fHeaderParametrs.pnlParametrs.Controls.Remove(pic);

            fHeaderParametrs.pnlParametrs.Controls.Remove(btn);


        }
        
        private void Clear()
        {
            fHeaderParametrs.pnlParametrs.Controls.Clear();
        }









       

    }
}
