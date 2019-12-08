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
using System.Xml.Serialization;

namespace ApoInfo
{
    public partial class frm_main : Form
    {
        private TimeSpan timeoutToHideCursor;
        private DateTime lastMouseMove;
        private Boolean isCursorHidden;

        private String dateOfToday;
        private String[] lastResults = { "-\n-\n-\n-\n-", "-\n-\n-\n-\n-", "-\n-\n-\n-\n-", "-\n-\n-\n-\n-" };
        private Tag aktuellerTagessatz;

        string[] delimiters1 = new string[] { "(", ")" };
        string[] delimiters2 = new string[] { " - ", " – " };

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

            lbl_result1.Text = lastResults[0];
            lbl_result2.Text = lastResults[1];
            lbl_result3.Text = lastResults[2];
            lbl_result4.Text = lastResults[3];

            setSkaling();

            getDataFromLocalFile();
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

            lbl_result1.Font = new Font(lbl_result1.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result1.Top = (pnl_result1.Height - lbl_result1.Height) / 2;
            lbl_result1.Left = pnl_first1.Width / 100 * 6;

            lbl_result2.Font = new Font(lbl_result2.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result2.Top = (pnl_result2.Height - lbl_result2.Height) / 2;
            lbl_result2.Left = pnl_first1.Width / 100 * 6;

            label2.Font = new Font(label2.Font.Name, 50, FontStyle.Bold, GraphicsUnit.Point);
            label2.Top = (pnl_second1.Height - label2.Height) / 2;
            label2.Left = pnl_second1.Width / 100 * 3;

            lbl_result3.Font = new Font(lbl_result3.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result3.Top = (pnl_result1.Height - lbl_result1.Height) / 2;
            lbl_result3.Left = pnl_second1.Width / 100 * 6;

            lbl_result4.Font = new Font(lbl_result2.Font.Name, 31, FontStyle.Regular, GraphicsUnit.Point);
            lbl_result4.Top = (pnl_result4.Height - lbl_result4.Height) / 2;
            lbl_result4.Left = pnl_second1.Width / 100 * 6;

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

            int shrinkResultPanel = this.Width / 100 * 1;

            pnl_result1.Top = this.Height / 100 * 37;
            pnl_result1.Height = this.Height / 100 * 31;
            pnl_result1.Left = this.Width / 100 * 4;
            pnl_result1.Width = this.Width / 100 * 46;

            pnl_result2.Top = this.Height / 100 * 37;
            pnl_result2.Height = this.Height / 100 * 31;
            pnl_result2.Left = this.Width / 100 * 51;
            pnl_result2.Width = this.Width / 100 * 46;
            
            //skallingPanelCenter(pnl_second1, 65, 3, 10);

            pnl_result3.Top = this.Height / 100 * 70;
            pnl_result3.Height = this.Height / 100 * 31;
            pnl_result3.Left = this.Width / 100 * 4;
            pnl_result3.Width = this.Width / 100 * 46;

            pnl_result4.Top = this.Height / 100 * 70;
            pnl_result4.Height = this.Height / 100 * 31;
            pnl_result4.Left = this.Width / 100 * 51;
            pnl_result4.Width = this.Width / 100 * 46;

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

        private void getDataFromLocalFile()
        {
            // Frisch aus Excel exportierte XML mit einfacher Hirachie (kompatitibilitaet) erweitern
            try
            {
                var fileName = AppDomain.CurrentDomain.BaseDirectory + "\\Notdienstdatenbank.xml";
                var txtLines = File.ReadAllLines(fileName).ToList();

                if (!txtLines.Contains("<Tage>"))
                {
                    var upperTag = "\t<Tag>";
                    var upperTagToAdd = "<Tage>";

                    var lowerTag = "\t</Tag>";
                    var lowerTagToAdd = "</Tage>";


                    txtLines.Insert(txtLines.IndexOf(upperTag), upperTagToAdd);
                    txtLines.Insert(txtLines.LastIndexOf(lowerTag) + 1, lowerTagToAdd);
                    File.WriteAllLines(fileName, txtLines);
                }

                // Deserialize
                // Abbilden der XML in neue Instanz der Klasse Notdienstliste
                Notdienstliste notdienstListe = new Notdienstliste();
                XmlSerializer xmlS = new XmlSerializer(typeof(Notdienstliste));

                using (MemoryStream stream = new MemoryStream())
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Notdienstdatenbank.xml"));
                        writer.Flush();
                        stream.Position = 0;
                        notdienstListe = xmlS.Deserialize(stream) as Notdienstliste;
                    }
                }

                // Durchsuchen der Datensaetze nach tagesaktuellen Informationen zur Weiterverarbeitung
                if (DateTime.Now.Hour >= noRefreshTimeStart && DateTime.Now.Hour < noRefreshTimeEnd)
                {
                    // Datum vom Vortag waehlen
                    // d.h. 12 Stunden zurueck
                    TimeSpan refreshDelay = TimeSpan.FromHours(12);
                    DateTime previousDate = DateTime.Now - refreshDelay;
                    dateOfToday = previousDate.ToString("yyyy") + "-" + previousDate.ToString("MM") + "-" + previousDate.ToString("dd");
                    //nowTime.Replace(".", "-");
                }
                else
                {
                    dateOfToday = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd");
                    //nowTime.Replace(".", "-");
                }

                Boolean resultDayFound = false;
                foreach (Tag tag in notdienstListe.Tage)
                {
                    if (tag.Datum.Equals(dateOfToday))
                    {
                        aktuellerTagessatz = tag;
                        resultDayFound = true;
                    }
                }

                if (!resultDayFound)
                {
                    lbl_result1.Text = "Fehler. Kein Notdienst registriert.";
                    lbl_result2.Text = "";
                    lbl_result3.Text = "Fehler. Kein Notdienst registriert.";
                    lbl_result4.Text = "";
                }
                else
                {
                    string dataOfFirst = string.Empty;
                    string dataOfSecond = string.Empty;
                    string dataOfThird = string.Empty;
                    string dataOfFourth = string.Empty;

                    if (aktuellerTagessatz.InhaltApotheke_eins != null)
                    {
                        // --------------------------------------------------------------------------------------------------------
                        // Erste Apotheke
                        // Schicht 9 - 9 Uhr (24 Stunden)
                        dataOfFirst = aktuellerTagessatz.InhaltApotheke_eins;

                        lbl_result1.Text = convertResultSplittedToLines(dataOfFirst);
                    }
                    else
                    {
                        lbl_result1.Text = "";
                    }

                    if (aktuellerTagessatz.InhaltApotheke_zwei != null)
                    {
                        // --------------------------------------------------------------------------------------------------------
                        // Zweite Apotheke
                        // Schicht 9 - 9 Uhr (24 Stunden)
                        dataOfSecond = aktuellerTagessatz.InhaltApotheke_zwei;

                        lbl_result2.Text = convertResultSplittedToLines(dataOfSecond);
                    }
                    else
                    {
                        lbl_result2.Text = "";
                    }

                    if (aktuellerTagessatz.InhaltApotheke_drei != null)
                    {
                        // --------------------------------------------------------------------------------------------------------
                        // Dritte Apotheke
                        // Schicht 9 - 9 Uhr (24 Stunden)
                        dataOfThird = aktuellerTagessatz.InhaltApotheke_drei;

                        lbl_result3.Text = convertResultSplittedToLines(dataOfThird);
                    }
                    else
                    {
                        lbl_result3.Text = "";
                    }

                    if (aktuellerTagessatz.InhaltApotheke_vier != null)
                    {
                        // --------------------------------------------------------------------------------------------------------
                        // Vierte Apotheke
                        // Schicht 9 - 9 Uhr (24 Stunden)
                        dataOfFourth = aktuellerTagessatz.InhaltApotheke_vier;

                        lbl_result4.Text = convertResultSplittedToLines(dataOfFourth);
                    }
                    else
                    {
                        lbl_result4.Text = "";
                    }

                }
            } catch (FileNotFoundException)
            {
                Cursor.Show();
                isCursorHidden = false;

                MessageBox.Show("Fehler beim Zugriff auf die Datenbank. Befindet sich diese im vorgebenen Pfad?", "FileNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private string convertResultSplittedToLines(string dataOfDay)
        {
            // Name der Apotheke von den Zusatzinformationen trennen und fuer spaetere Darstellung aufbereiten
            string formedValue = "";
            string[] dataSet1 = dataOfDay.Split(delimiters1, StringSplitOptions.RemoveEmptyEntries);
            string[] dataSet2 = dataSet1[1].Split(delimiters2, StringSplitOptions.RemoveEmptyEntries);

            formedValue = dataSet1[0] + "\n";

            foreach (string s in dataSet2)
            {
                formedValue += "\n" + s.Trim();
            }

            return formedValue;
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
            getDataFromLocalFile();
        }

        private void tmr_updateOnce_Tick(object sender, EventArgs e)
        {
            // Ausloesen einer Aktuallisierung um 9 Uhr
            if (DateTime.Now.Hour == 9 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
            {
                getDataFromLocalFile();
            }
        }

        private void tmr_updateDateTime_Tick(object sender, EventArgs e)
        {
            // Zeit in der Kopfzeile aktualisieren
            lbl_date.Text = "Oldenburg, den " + DateTime.Now.ToString("dd.MM.yyyy, H:mm") + " Uhr";
        }
    }
}
