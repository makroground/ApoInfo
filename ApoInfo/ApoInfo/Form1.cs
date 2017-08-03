using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoInfo
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_get_Click(object sender, EventArgs e)
        {

            lbl_result1_1.Text = "";
            lbl_result2_1.Text = "";

            string result = string.Empty;
            string url = @"http://oldenburger-apotheken.de/notdienst";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }



            // Datensatz fuer den heutigen Tag extrahieren



            string[] delimiters1 = new string[] { "<TR>", "</TR>" };
            string[] dataSet1;
            string dataOfDay = string.Empty;

            dataSet1 = result.Split(delimiters1, StringSplitOptions.RemoveEmptyEntries);

            int row = 1;
            Boolean resultDayFound = false;
            foreach (string s in dataSet1)
            {
                if (s.Contains("03.08.17"))
                {
                    dataOfDay = s;
                    //lbl_result.Text = "Ergebnis " + row + ":   " + s;
                    resultDayFound = true;
                }

                //lbl_result.Text += row.ToString() + ":   " + s + '\n';
                row++;
            }




            if (!resultDayFound)
            {
                lbl_result1_1.Text = "Kein Notdienst registriert.";
            }
            else
            {



                // Datensatz der dritten und vierten Spalte extrahieren



                string[] delimiters2 = new string[] { "<TD ALIGN=LEFT VALIGN=TOP><FONT SIZE=1 COLOR=\"#00CC00\">", "<TD ALIGN=LEFT VALIGN=TOP><FONT SIZE=1 COLOR=\"#FF0000\">", "</FONT></TD>" };

                string dataOfFirst = string.Empty;
                string dataOfFirst2 = string.Empty;
                string dataOfSecond = string.Empty;
                string dataOfSecond2 = string.Empty;

                string[] dataSet2 = dataOfDay.Split(delimiters2, StringSplitOptions.RemoveEmptyEntries);

                int dayRow = 1;
                foreach (string s in dataSet2)
                {
                    if (dayRow == 4)
                    {

                        if (s.Contains("<BR>"))
                        {
                            string[] delimiters3 = new string[] { "und<BR>", "<BR>und" };

                            string[] dataSet3 = s.Split(delimiters3, StringSplitOptions.RemoveEmptyEntries);

                            dataOfFirst = dataSet3[0];

                            dataOfFirst2 = dataSet3[1];
                        }
                        else
                        {
                            dataOfFirst = s;
                        }

                    }
                    else if (dayRow == 6)
                    {
                        if (s.Contains("<BR>"))
                        {
                            string[] delimiters4 = new string[] { "und<BR>", "<BR>und" };

                            string[] dataSet4 = s.Split(delimiters4, StringSplitOptions.RemoveEmptyEntries);

                            dataOfSecond = dataSet4[0];

                            dataOfSecond2 = dataSet4[1];
                        }
                        else
                        {
                            dataOfSecond = s;
                        }
                    }
                    
                    dayRow++;
                }

                lbl_result1_1.Text = dataOfFirst;
                if (dataOfFirst2 == String.Empty)
                {
                    lbl_result1_2.Text = "";
                }
                else
                {
                    lbl_result1_2.Text = dataOfFirst2;
                }

                lbl_result2_1.Text = dataOfSecond;
                if (dataOfSecond2 == String.Empty)
                {
                    lbl_result2_2.Text = "";
                }
                else
                {
                    lbl_result2_2.Text = dataOfSecond2;
                }
            }

            



            //lbl_result.Text = result;

        }
    }
}
