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
        private TimeSpan timeoutToHideCursor;
        private DateTime lastMouseMove;
        private Boolean isCursorHidden;

        private String dateOfToday;
        private String[] lastResults = { "-\n-\n-\n-\n-", "-\n-\n-\n-\n-", "-\n-\n-\n-\n-", "-\n-\n-\n-\n-" };

        // Ergebnis von 0 bis 9 Uhr weiterhin gültig
        private static int noRefreshTimeStart = 0;
        private static int noRefreshTimeEnd = 9;

        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timeoutToHideCursor = TimeSpan.FromSeconds(5);

            lbl_date.Text = "Oldenburg, den " + DateTime.Now.ToString("dd.MM.yyyy, H:mm") + " Uhr";
            //lbl_time.Text = DateTime.Now.ToString("H:mm") + " Uhr";

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            lbl_result1_1.Text = lastResults[0];
            lbl_result1_2.Text = lastResults[1];
            lbl_result2_1.Text = lastResults[2];
            lbl_result2_2.Text = lastResults[3];

            setSkaling();

            getDataFromWebsite();
        }

        private void setSkaling()
        {
            setPanels();

            int shrink4to3_1 = 0;
            int shrink4to3_2 = 0;

            if (is4to3Display())
            {
                shrink4to3_1 = 30;
                shrink4to3_2 = 15;
            }

            lbl_date.Font = new Font(lbl_date.Font.Name, 15, FontStyle.Bold, GraphicsUnit.Point);
            lbl_date.Top = this.Height / 100 * 3;
            lbl_date.Left = this.Width - lbl_date.Width - (this.Width / 100 * 5);

            lbl_info.Font = new Font(lbl_info.Font.Name, 15, FontStyle.Bold, GraphicsUnit.Point);
            lbl_info.Top = this.Height - lbl_info.Height - (this.Height / 100 * 2);
            lbl_info.Left = (this.Width - lbl_info.Width) / 2;

            /*lbl_time.Font = new Font(lbl_time.Font.Name, 20, FontStyle.Bold, GraphicsUnit.Point);
            lbl_time.Top = this.Height / 100 * 2 + lbl_date.Height;
            lbl_time.Left = this.Width - lbl_time.Width - (this.Width / 100 * 3);*/

            pbx_apota.Size = new Size(this.Height / 100 * 23, this.Height / 100 * 23);
            pbx_apota.Top = this.Height / 100 * 1;
            pbx_apota.Left = this.Height / 100 * 2;

            lbl_neterror.Font = new Font(lbl_neterror.Font.Name, 15, FontStyle.Bold, GraphicsUnit.Point);
            lbl_neterror.Top = this.Height / 100 * 20;
            lbl_neterror.Left = (pbx_apota.Left * 2) + pbx_apota.Width;

            pbx_appqr.Size = new Size(this.Height / 100 * 40, this.Height / 100 * 18);
            pbx_appqr.Top = this.Height / 100 * 6;
            pbx_appqr.Left = this.Width - pbx_appqr.Width - (this.Width / 100 * 5);

            lbl_title.Font = new Font(lbl_title.Font.Name, 130, GraphicsUnit.Point);
            lbl_title.Top = this.Height / 100 * 1;
            lbl_title.Left = (pbx_apota.Left * 2) + pbx_apota.Width;

            label1.Font = new Font(label1.Font.Name, 50, FontStyle.Bold, GraphicsUnit.Point);
            label1.Top = (pnl_first1.Height - label1.Height) / 2;
            label1.Left = pnl_first1.Width / 100 * 3;

            lbl_result1_1.Font = new Font(lbl_result1_1.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result1_1.Top = (pnl_result1_1.Height - lbl_result1_1.Height) / 2;
            lbl_result1_1.Left = pnl_first1.Width / 100 * 6;

            lbl_result1_2.Font = new Font(lbl_result1_2.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result1_2.Top = (pnl_result1_2.Height - lbl_result1_2.Height) / 2;
            lbl_result1_2.Left = pnl_first1.Width / 100 * 6;

            label2.Font = new Font(label2.Font.Name, 50, FontStyle.Bold, GraphicsUnit.Point);
            label2.Top = (pnl_second1.Height - label2.Height) / 2;
            label2.Left = pnl_second1.Width / 100 * 3;

            lbl_result2_1.Font = new Font(lbl_result2_1.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result2_1.Top = (pnl_result1_1.Height - lbl_result1_1.Height) / 2;
            lbl_result2_1.Left = pnl_second1.Width / 100 * 6;

            lbl_result2_2.Font = new Font(lbl_result1_2.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result2_2.Top = (pnl_result2_2.Height - lbl_result2_2.Height) / 2;
            lbl_result2_2.Left = pnl_second1.Width / 100 * 6;

            //skalingLabelLeft(label1, pnl_first1, 0, 70, 3, FontStyle.Bold);
            //skalingLabelLeft(lbl_result1_1, pnl_result1_1, 15, 15, 15, FontStyle.Regular);
            //skalingLabelLeft(lbl_result1_2, pnl_result1_2, 15, 15, 15, FontStyle.Regular);
            //skalingLabelLeft(label2, pnl_second1, 0, 70, 3, FontStyle.Bold);
            //skalingLabelLeft(lbl_result2_1, pnl_result2_1, 15, 15, 15, FontStyle.Regular);
            //skalingLabelLeft(lbl_result2_2, pnl_result2_2, 15, 15, 15, FontStyle.Regular);

        }

        private void skalingLabelCenter(Label lbl, int percentTop, float percentFont, int percentPaddingLeft)
        {

            lbl.Font = new Font(lbl.Font.Name, this.Height / 100 * (percentFont), FontStyle.Bold);
            lbl.Top = this.Height / 100 * percentTop;
            lbl.Left = ((this.Width - lbl.Width) / 2) + (this.Width / 100 * percentPaddingLeft);

        }

        private void skalingLabelLeft(Label lbl, Panel innerPanel, int percentTop, int percentFont, int percentPaddingLeft, FontStyle fontStyle)
        {

            lbl.Font = new Font(lbl.Font.Name, innerPanel.Height / 100 * (percentFont), fontStyle, GraphicsUnit.Point);
            lbl.Top = innerPanel.Height / 100 * percentTop;
            lbl.Left = innerPanel.Width / 100 * percentPaddingLeft;
        }

        private bool is4to3Display()
        {

            Double faktor = (double)this.Width / this.Height;
            if (faktor < 1.77)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void setPanels()
        {
            skallingPanelCenter(pnl_first1, 25, 3, 10);

            pnl_result1_1.Top = this.Height / 100 * 35;
            pnl_result1_1.Height = this.Height / 100 * 27;
            pnl_result1_1.Left = this.Width / 100 * 3;
            pnl_result1_1.Width = pnl_first1.Width / 2;

            pnl_result1_2.Top = this.Height / 100 * 35;
            pnl_result1_2.Height = this.Height / 100 * 27;
            pnl_result1_2.Left = this.Width / 100 * 3 + pnl_result1_1.Width;
            pnl_result1_2.Width = pnl_first1.Width / 2;
            
            skallingPanelCenter(pnl_second1, 65, 3, 10);

            pnl_result2_1.Top = this.Height / 100 * 75;
            pnl_result2_1.Height = this.Height / 100 * 27;
            pnl_result2_1.Left = this.Width / 100 * 3;
            pnl_result2_1.Width = pnl_second1.Width / 2;

            pnl_result2_2.Top = this.Height / 100 * 75;
            pnl_result2_2.Height = this.Height / 100 * 27;
            pnl_result2_2.Left = this.Width / 100 * 3 + pnl_result2_1.Width;
            pnl_result2_2.Width = pnl_second1.Width / 2;

        }

        private void skallingPanelCenter(Panel pnl, int percentTop, int percentPaddingLeft, int percentHeight)
        {
            pnl.Top = this.Height / 100 * percentTop;
            pnl.Height = this.Height / 100 * percentHeight;
            int paddingLeft = this.Width / 100 * percentPaddingLeft;
            pnl.Width = this.Width - (paddingLeft * 2);
            pnl.Left = paddingLeft;
        }

        private void skallingPanel(Panel pnl, int percentTop, int percentPaddingLeft, int percentHeight)
        {
            pnl.Top = this.Height / 100 * percentTop;
            pnl.Height = this.Height / 100 * percentHeight;
            pnl.Left = this.Width / 100 * percentPaddingLeft;
        }

        private void getDataFromWebsite()
        {
            try
            {
                if (DateTime.Now.Hour >= noRefreshTimeStart && DateTime.Now.Hour < noRefreshTimeEnd)
                {
                    // Datum vom Vortag waehlen
                    // d.h. 12 Stunden zurueck
                    TimeSpan refreshDelay = TimeSpan.FromHours(12);
                    DateTime previousDate = DateTime.Now - refreshDelay;
                    dateOfToday = previousDate.ToString("dd.MM.yy");
                }
                else
                {
                    dateOfToday = DateTime.Now.ToString("dd.MM.yy");
                }

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

                Boolean resultDayFound = false;
                foreach (string s in dataSet1)
                {
                    if (s.Contains(dateOfToday))
                    {
                        dataOfDay = s;

                        resultDayFound = true;
                    }
                }




                if (!resultDayFound)
                {
                    lbl_result1_1.Text = "Fehler. Kein Notdienst registriert.";
                    lbl_result1_2.Text = "";
                    lbl_result2_1.Text = "Fehler. Kein Notdienst registriert.";
                    lbl_result2_2.Text = "";
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

                                dataOfFirst = dataSet3[0].Trim();

                                dataOfFirst2 = dataSet3[1].Trim();
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

                                dataOfSecond = dataSet4[0].Trim();

                                dataOfSecond2 = dataSet4[1].Trim();
                            }
                            else
                            {
                                dataOfSecond = s;
                            }
                        }

                        dayRow++;
                    }

                    string[] delimiters5 = new string[] { "(", ")" };
                    string[] dataSet5 = dataOfFirst.Split(delimiters5, StringSplitOptions.RemoveEmptyEntries);

                    string[] delimiters6 = new string[] { " - ", " – " };
                    string[] dataSet6 = dataSet5[1].Split(delimiters6, StringSplitOptions.RemoveEmptyEntries);

                    dataOfFirst = dataSet5[0] + "\n";

                    foreach (string s in dataSet6)
                    {
                        dataOfFirst += "\n" + s.Trim();
                    }

                    lbl_result1_1.Text = decodeHtml(dataOfFirst);
                    if (dataOfFirst2 == String.Empty)
                    {
                        lbl_result1_2.Text = "";
                    }
                    else
                    {
                        string[] delimiters7 = new string[] { "(", ")" };
                        string[] dataSet7 = dataOfFirst2.Split(delimiters7, StringSplitOptions.RemoveEmptyEntries);

                        string[] delimiters8 = new string[] { " - ", " – " };
                        string[] dataSet8 = dataSet7[1].Split(delimiters8, StringSplitOptions.RemoveEmptyEntries);

                        dataOfFirst2 = dataSet7[0] + "\n";

                        foreach (string s in dataSet8)
                        {
                            dataOfFirst2 += "\n" + s.Trim();
                        }

                        lbl_result1_2.Text = decodeHtml(dataOfFirst2);
                    }

                    string[] delimiters9 = new string[] { "(", ")" };
                    string[] dataSet9 = dataOfSecond.Split(delimiters9, StringSplitOptions.RemoveEmptyEntries);

                    string[] delimiters10 = new string[] { " - ", " – " };
                    string[] dataSet10 = dataSet9[1].Split(delimiters10, StringSplitOptions.RemoveEmptyEntries);

                    dataOfSecond = dataSet9[0] + "\n";

                    foreach (string s in dataSet10)
                    {
                        dataOfSecond += "\n" + s.Trim();
                    }

                    lbl_result2_1.Text = decodeHtml(dataOfSecond);
                    if (dataOfSecond2 == String.Empty)
                    {
                        lbl_result2_2.Text = "";
                    }
                    else
                    {
                        string[] delimiters11 = new string[] { "(", ")" };
                        string[] dataSet11 = dataOfSecond2.Split(delimiters11, StringSplitOptions.RemoveEmptyEntries);

                        string[] delimiters12 = new string[] { " - ", " – " };
                        string[] dataSet12 = dataSet11[1].Split(delimiters12, StringSplitOptions.RemoveEmptyEntries);

                        dataOfSecond2 = dataSet11[0] + "\n";

                        foreach (string s in dataSet10)
                        {
                            dataOfSecond2 += "\n" + s.Trim();
                        }

                        lbl_result2_2.Text = decodeHtml(dataOfSecond2);
                    }

                    // Letzte Ergebnisse speichern, falls z.B. Netzwerkprobleme auftreten.
                    lastResults[0] = lbl_result1_1.Text;
                    lastResults[1] = lbl_result1_2.Text;
                    lastResults[2] = lbl_result2_1.Text;
                    lastResults[3] = lbl_result2_2.Text;
                }

                // Kein Netzwerkfehler aufgetreten
                lbl_neterror.Visible = false;
            } catch (WebException)
            {
                // Netzwerkfehler beim Abrufen der Daten. Information anzeigen.
                lbl_neterror.Visible = true;

                // Ergebnisse der letzten erfolgreichen Datensammlung anzeigen
                lbl_result1_1.Text = lastResults[0];
                lbl_result1_2.Text = lastResults[1];
                lbl_result2_1.Text = lastResults[2];
                lbl_result2_2.Text = lastResults[3];
            }
            
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            getDataFromWebsite();
        }

        private string decodeHtml (String s)
        {
            return WebUtility.HtmlDecode(s);
        }

        private void frm_main_MouseMove(object sender, MouseEventArgs e)
        {
            lastMouseMove = DateTime.Now;

            if (isCursorHidden)
            {
                Cursor.Show();
                isCursorHidden = false;
            }
        }

        private void tmr_hideCursor_Tick(object sender, EventArgs e)
        {
            TimeSpan timeHidden = DateTime.Now - lastMouseMove;
            if (timeHidden >= timeoutToHideCursor && !isCursorHidden)
            {
                Cursor.Hide();
                isCursorHidden = true;
            }
        }

        private void lbl_date_Click(object sender, EventArgs e) 
        {
            tmr_hideCursor.Stop();
            Cursor.Show();

            DialogResult result;

            result = MessageBox.Show(this, "Wollen Sie das Programm wirklich beenden?", "Schließen?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                tmr_hideCursor.Start();
            }
            
        }

        private void trm_updateData_Tick(object sender, EventArgs e)
        {
            getDataFromWebsite();
        }

        private void tmr_updateOnce_Tick(object sender, EventArgs e)
        {
            // Ausloesen einer Aktuallisierung um 9 Uhr
            if (DateTime.Now.Hour == 9 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
            {
                getDataFromWebsite();
            }
        }

        private void tmr_updateDateTime_Tick(object sender, EventArgs e)
        {
            // Zeit in der Kopfzeile aktualisieren
            lbl_date.Text = "Oldenburg, den " + DateTime.Now.ToString("dd.MM.yyyy, H:mm") + " Uhr";
        }
    }
}
