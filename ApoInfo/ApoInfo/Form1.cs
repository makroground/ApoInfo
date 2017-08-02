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

            lbl_result.Text = "";

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
            string[] dataSets;
            string dataOfDay = string.Empty;

            dataSets = result.Split(delimiters1, StringSplitOptions.RemoveEmptyEntries);

            int row = 1;
            Boolean resultDayFound = false;
            foreach (string s in dataSets)
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
                lbl_result.Text = "Kein Notdienst registriert.";
            } else
            {



                // Datensatz der dritten und vierten Spalte extrahieren



                string[] delimiters2 = new string[] { "<TD ALIGN=LEFT VALIGN=TOP><FONT SIZE=1 COLOR=\"#00CC00\">", "<TD ALIGN=LEFT VALIGN=TOP><FONT SIZE=1 COLOR=\"#FF0000\">", "</FONT></TD>" };

                string dataOfFirst = string.Empty;
                string dataOfSecond = string.Empty;

                dataSets = dataOfDay.Split(delimiters2, StringSplitOptions.RemoveEmptyEntries);

                int dayRow = 1;
                foreach (string s in dataSets)
                {
                    if (dayRow == 4)
                    {
                        dataOfFirst = s;
                    } else if (dayRow == 6)
                    {
                        dataOfSecond = s;
                    }
                    
                    dayRow++;
                }

                lbl_result.Text = "9 - 9 Uhr:    " + dataOfFirst + '\n';
                lbl_result.Text += "9 - 22 Uhr:  " + dataOfSecond;
            }

            



            //lbl_result.Text = result;

        }
    }
}
