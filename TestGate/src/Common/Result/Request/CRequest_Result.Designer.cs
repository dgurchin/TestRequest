using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRequest.db;
using System.Net.Http;
using System.Threading;


namespace TestGate
{
    partial class CRequest_Result
    {


        private void txtResult()
        {

            fMain.rtxtResult.Text = string.Empty;


            if (_Request==null)
            {

                fMain.rtxtResult.Text = string.Empty;
                return;
            }


            if (_Request==Request.GET)
            {

                fMain.rtxtResult.Text = _Request + " " + URL + "\r\n\r\n";
            }
            else
            {
                fMain.rtxtResult.AppendText(_Request + " " + URL + "\r\n\r\n" + "PARAMETRS:", Color.Red);

                fMain.rtxtResult.AppendText(Environment.NewLine + Header + _Body_, Color.Black);
            }




        }


        private void lsvTemplateRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fMain.lsvHeader_Result.SelectedItems.Count>0)
            {


                tHeaderTemplate otHeaderTemplate = tHeaderTemplate.byINDEX(fMain.lsvHeader_Result.SelectedIndices[0]);

                if (string.IsNullOrEmpty(otHeaderTemplate.ServerLine))
                {
                    MessageBox.Show("Incorect Server string");

                    _Request = null;

                    return;
                }
                
                else if (otHeaderTemplate.ServerLine.Substring(0, otHeaderTemplate.ServerLine.IndexOf(' ')) ==
                         Request.GET.ToString())
                {
                    _Request = Request.GET;
                }
                else if (otHeaderTemplate.ServerLine.Substring(0, otHeaderTemplate.ServerLine.IndexOf(' ')) ==
                         Request.POST.ToString())
                {
                    _Request = Request.POST;
                }
                else
                {
                    MessageBox.Show("Incorect Server string");

                    _Request = null;

                    return;
                }



                if (_Request==Request.GET)
                {
                    CHeaderData oHeaderData = CHeader_Result.Read_DB(otHeaderTemplate.HeaderLine);

                    StringBuilder str = new StringBuilder();

                    foreach (var VARIABLE in oHeaderData.lst_Parametrs)
                    {
                        str.Append("/" + VARIABLE.ValueParametr);
                    }

                    URL = otHeaderTemplate.ServerLine.Substring(otHeaderTemplate.ServerLine.IndexOf("HT")) + str;


                    Header = string.Empty;


                }
                else
                {
                    CHeaderData oHeaderData = CHeader_Result.Read_DB(otHeaderTemplate.HeaderLine);

                    StringBuilder str = new StringBuilder();

                    URL = otHeaderTemplate.ServerLine.Substring(otHeaderTemplate.ServerLine.IndexOf("HT"));

                    foreach (var VARIABLE in oHeaderData.lst_Parametrs)
                    {

                        str.Append("/" + VARIABLE.NameParametr + "=" + VARIABLE.ValueParametr);


                    }


                    Header = str.ToString();

                }

               

            }

            else
            {

                _Request = null;
                
                
            }

            txtResult();
        }

        

       

       



        private void rtxtPAYLOAD_TextChanged(object sender, EventArgs e)
        {

            _Body_ = "/&WGBODY=" + fMain.rtxtPAYLOAD.Text;

               

                txtResult();
            
        }


        private string GET()
        {



            HttpClient client = new HttpClient();

            
            return Regex.Unescape(client.GetStringAsync(URL).Result);

        }

        private string POST()
        {


            tHeaderTemplate otHeaderTemplate = tHeaderTemplate.byINDEX(fMain.lsvHeader_Result.SelectedIndices[0]);





            X509Certificate2 clientCertificate = new X509Certificate2(otHeaderTemplate.FileForExtension,
                otHeaderTemplate.ServerPassword);



            WebRequestHandler handler = new WebRequestHandler();



            handler.ClientCertificates.Add(clientCertificate);

            handler.ClientCertificateOptions = ClientCertificateOption.Manual;


            HttpClient client = new HttpClient(handler);


            client.DefaultRequestHeaders.Accept.Clear();



            HttpResponseMessage response = client.PostAsync(URL, new StringContent(Header + _Body_)).Result;

            response.EnsureSuccessStatusCode();



            return response.Content.ReadAsStringAsync().Result;




        }

        private void btnTest_Click(object sender, EventArgs e)
        {





            txtResult();


            if (fMain.rdbRequest.Checked)
            {

                if (_Request == Request.GET)
                {
                    try
                    {
                        fMain.rtxtResult.AppendText("RESULT REQUEST:\r\n\r\n" + GET(), Color.Gray);
                    }

                    catch (Exception e1)
                    {

                        fMain.rtxtResult.AppendText("\r\n\r\nError:\r\n\r\n" + e1.ToString(), Color.Red);
                    }
                }
                else if (_Request == Request.POST)
                {

                    StringBuilder tmpSTR = new StringBuilder();


                    if (string.IsNullOrEmpty(URL))
                    {
                        tmpSTR.AppendLine("Unknown Server");


                    }
                   
                    else if (string.IsNullOrEmpty(fMain.rtxtPAYLOAD.Text))
                    {
                        tmpSTR.AppendLine("Input _Body_ Data");


                    }


                    if (!string.IsNullOrEmpty(tmpSTR.ToString()))
                    {
                        MessageBox.Show(tmpSTR.ToString());

                        return;

                    }



                    try
                    {
                        fMain.rtxtResult.AppendText("\r\n\r\nRESULT REQUEST:\r\n\r\n" + POST(), Color.Gray);
                    }

                    catch (Exception e1)
                    {

                        fMain.rtxtResult.AppendText("\r\n\r\nError:\r\n\r\n" + e1.ToString(), Color.Red);
                    }
                }


            }
            else
            {
                if (_Request == Request.GET)
                {
                    CDDos_Attack_Data o = fMain.prgDDos_Parametr.SelectedObject as CDDos_Attack_Data;

                   

                        for (int i = 0; i < o.Count_Request; i++)
                        {
                            
                                fMain.BeginInvoke(
                                   new Action(
                                       delegate
                                       {
                                           fMain.rtxtResult.AppendText("\r\nRequest " +
                                                                       (fMain.rtxtResult.Lines.Length - 2).ToString() +
                                                                       " " +
                                                                       Load_Result().Result);
                                       }));
                            
                        }

                    
                }
                else if (_Request == Request.POST)
                {

                    tHeaderTemplate otHeaderTemplate = tHeaderTemplate.byINDEX(fMain.lsvHeader_Result.SelectedIndices[0]);





                    X509Certificate2 clientCertificate = new X509Certificate2(otHeaderTemplate.FileForExtension,
                        otHeaderTemplate.ServerPassword);


                    CDDos_Attack_Data o = fMain.prgDDos_Parametr.SelectedObject as CDDos_Attack_Data;

                    StringBuilder a = new StringBuilder();

                    Task.Factory.StartNew(delegate
                    {

                        for (int i = 0; i < o.Count_Request; i++)
                        {


                            Task.Factory.StartNew(delegate
                            {
                                WebRequestHandler handler = new WebRequestHandler();



                                handler.ClientCertificates.Add(clientCertificate);

                                handler.ClientCertificateOptions = ClientCertificateOption.Manual;


                                HttpClient client = new HttpClient(handler);


                                client.DefaultRequestHeaders.Accept.Clear();


                               



                                fMain.BeginInvoke(
                                    new Action(
                                        delegate
                                        {
                                            fMain.rtxtResult.AppendText("\r\nRequest " +
                                                                        (fMain.rtxtResult.Lines.Length - 5).ToString() +
                                                                        " " +
                                                                        Load_Result(client).Result);
                                        }));










                            });





                        }


                    }).Wait();
                }
            }





        }

        private async Task<bool> Load_Result(HttpClient httpClient)
        {

           HttpResponseMessage response = httpClient.PostAsync(URL, new StringContent(Header + _Body_)).Result;

           response.EnsureSuccessStatusCode();








           return response.Content.ReadAsStringAsync().IsCompleted; ;
        }


        private async Task<bool> Load_Result()
        {


            HttpClient client = new HttpClient();

            HttpResponseMessage res = await client.GetAsync(URL).ConfigureAwait(false);

            return  res.Content.ReadAsStringAsync().IsCompleted;
        }




    }
}
