using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace EntSHCodeGenerator
{
    class EntHttpControl
    {

        private Form1 form;
        private string currentVersion = "1.0.0";

        public EntHttpControl(Form1 form)
        {
            this.form = form;
        }

        public void sendRequest(string url)
        {
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            request.BeginGetResponse(new AsyncCallback(getReponse), request);
        }

        public void getReponse(IAsyncResult ar)
        {
            string result = null;

            try
            {
                HttpWebRequest request = ar.AsyncState as HttpWebRequest;
                HttpWebResponse response = request.EndGetResponse(ar) as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                //String read = reader.ReadLine();

                while (true)
                {
                    string read = reader.ReadLine();

                    if (read.Contains("<title>"))
                    {
                        //System.Console.WriteLine(read);

                        XElement xml = XElement.Parse(read);
                        string value = xml.Value;
                        result = value.Substring(value.LastIndexOf(" ") + 1);

                        break;
                    }

                }

                reader.Close();
                stream.Close();
                response.Close();
            }

            catch (System.Net.WebException ex)
            {
                return;
            }

            

            //System.Console.WriteLine(result.Equals(currentVersion));

            if (!result.Equals(currentVersion))
            {
                this.form.showMessage();
            }
            
        }

    }
}
