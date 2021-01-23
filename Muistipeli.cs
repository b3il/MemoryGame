using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Muisti
{
    public partial class frmMuistipeli : Form
    {
        bool muuttunut = false;                                         //luodaan bool-muuttuja jonka avulla tarkastellaan onko lomakkeella jokin kenttä muuttunut

        Random random = new Random();                                   //luodaan random-muuttuja jonka avulla arvotaan labelit ruutuihin

        List<string> kuvat = new List<string>()                         //luodaan lista johon listataan merkit jotka halutaan ruutuihin
        {
            "e", "e", "Y", "Y", "€", "€", ",", ",",
            "l", "l", "v", "v", "p", "p", "h", "h"
        };

        Label ensinKlikattu, toinenKlikattu;                            //luodaan label-muuttujat joiden avulla katsotaan onko molemmat samat eli pari

        public struct Pelaaja                                           //luodaan struct-muuttuja johon otetaan ylös pelaajien nimet, voitot ja häviöt
        {                                                               //tämän olisi pystynyt todennäköisesti luomaan pelkällä yhdellä nimi, voitot ja häviöt muuttujalla
            public string nimi1;
            public string nimi2;
            public int voitot1;
            public int voitot2;
            public int häviöt1;
            public int häviöt2;
            public string Nimi1 { get { return nimi1; } }
            public string Nimi2 { get { return nimi2; } }
            public int Voitot1 { get { return voitot1; } }
            public int Voitot2 { get { return voitot2; } }
            public int Häviöt1 { get { return häviöt1; } }
            public int Häviöt2 { get { return häviöt2; } }
        }

        public List<Pelaaja> pelaajat = new List<Pelaaja>();            //luodaan list-muuttuja johon lisätään structista pelaajat
        public ArrayList ruudut = new ArrayList();

        public frmMuistipeli()
        {
            InitializeComponent();
            KuvatRuutuihin();                                           //kutsutaan funktiota alusta, jotta labelit saadaan lisättyä oikein tauluun
            

            if (tbPelaaja1.Text.Length >= 1 && tbPelaaja2.Text.Length >= 1)
            {
                btnPelaa.Enabled = true;
            }
        }

        private void KuvatRuutuihin()                                       //sijoitetaan listasta merkit ruutuihin            
        {
            Label label;
            int satunNumero;

            for (int i = 0; i < tlpPeli.Controls.Count; i++)                //käydään läpi kaikki taulun merkit
            {
                if (tlpPeli.Controls[i] is Label)
                {
                    label = (Label)tlpPeli.Controls[i];
                    ruudut.Add(label);
                }
                else
                    continue;

                satunNumero = random.Next(0, kuvat.Count);                  //haetaan merkit listasta
                label.Text = kuvat[satunNumero];                            //laitetaan labelin tekstiksi valittu merkki

                kuvat.RemoveAt(satunNumero);                                //poistetaan merkki listasta
            }
        }

        private void label_Click(object sender, EventArgs e)            //funktiossa määritellään mitä tapahtuu kun taulun labeleita klikataan
        {
            if (ensinKlikattu != null && toinenKlikattu != null)
                return;

            Label klikattuLabel = sender as Label;                      //otetaan klikkaustapahtuma haltuun senderin avulla

            if (klikattuLabel == null)
                return;

            if (klikattuLabel.ForeColor == Color.Green ||               //jos käyttäjä klikkaa labelia jota on jo klikattu, tämä rivi jättää huomioimatta sen klikkauksen
                klikattuLabel.ForeColor == Color.Black) 
                return;

            if (ensinKlikattu == null)                                  //
            {
                ensinKlikattu = klikattuLabel;                          //laitetaan säilöön mitä on painettu ensimmäiseksi
                ensinKlikattu.ForeColor = Color.Black;                  //nähdään mitä on painettu ensimmäiseksi
                return;
            }

            toinenKlikattu = klikattuLabel;                             //laitetaan säilöön mitä on painettu toiseksi
            toinenKlikattu.ForeColor = Color.Black;                     //nähdään mitä on painettu toiseksi

            if (ensinKlikattu.Text != toinenKlikattu.Text)              //kun ensimmäinen ja toinen label eivät ole samoja
            {
                if (rbPelaaja1Vuoro.Checked == true)                    //vaihdetaan pelaajan vuoroa jos pari on väärä
                    rbPelaaja2Vuoro.Checked = true;
                else if (rbPelaaja2Vuoro.Checked == true)
                    rbPelaaja1Vuoro.Checked = true;
            }

            TarkistaVoittaja();                                         //kutsutaan funktiota jos kaikki parit on löydetty

            if (ensinKlikattu.Text == toinenKlikattu.Text)              //kun pari löytyy
            {
                ensinKlikattu.ForeColor = Color.Green;
                toinenKlikattu.ForeColor = Color.Green;

                if (rbPelaaja1Vuoro.Checked == true)                   //lisätään piste pelaaja 1
                {
                    int i = int.Parse(lblPelaaja1Pisteet.Text);
                    i++;
                    lblPelaaja1Pisteet.Text = i.ToString();
                }

                if (rbPelaaja2Vuoro.Checked == true)                    //lisätään piste pelaaja 2
                {
                    int i = int.Parse(lblPelaaja2Pisteet.Text);
                    i++;
                    lblPelaaja2Pisteet.Text = i.ToString();
                }

                ensinKlikattu = null;
                toinenKlikattu = null;
            }
            else
                timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)            //jos parit eivät ole samat, 1 sec ennen kuin ne piilotetaan
        {
            timer1.Stop();

            foreach (Label l in ruudut)                                //käydään läpi ruudut
            {
                if (l.ForeColor == Color.Black)                        //tarkastetaan onko läpikäytävän ruudun väri musta 
                {
                    l.ForeColor = Color.CornflowerBlue;                //jos on, niin asetetaan takaisin näkymättömäksi
                }
            }
            
            ensinKlikattu = null;
            toinenKlikattu = null;
        }


        private void btnPelaa_Click(object sender, EventArgs e)             //peli käynnistetään
        {
            tlpPeli.Visible = true;
            btnPelaa.Visible = false;

            Pelaaja p;                                                      //määritetään structin muuttujille arvot
            p.nimi1 = tbPelaaja1.Text;
            p.voitot1 = (int)numPelaaja1V.Value;
            p.häviöt1 = (int)numPelaaja1H.Value;

            p.nimi2 = tbPelaaja2.Text;
            p.voitot2 = (int)numPelaaja2V.Value;
            p.häviöt2 = (int)numPelaaja2H.Value;
            pelaajat.Add(p);                                                //lisätään listaan pelaajat

            if (tbPelaaja1.Text.Length <= 1000 && tbPelaaja2.Text.Length <= 1000)
            {
                tbPelaaja1.Enabled = false;                                 //laitetaan kentät käyttämättömiksi, jotta käyttäjä ei voi muokata niitä kesken pelin
                tbPelaaja2.Enabled = false;
                numPelaaja1V.Enabled = false;
                numPelaaja1H.Enabled = false;
                numPelaaja2V.Enabled = false;
                numPelaaja2H.Enabled = false;
                btnPelaaja1Tuo.Enabled = false;
                btnPelaaja2Tuo.Enabled = false;
            }
        }

        private void TarkistaVoittaja()                                     //tarkistetaan voittaja funktiossa
        {
            Label label;
            for (int i = 0; i < tlpPeli.Controls.Count; i++)                //käydään läpi taulun kontrollit
            {
                label = tlpPeli.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)    //tarkastellaan onko kaikki parit löydetty
                    return;
            }

            if (Convert.ToInt32(lblPelaaja1Pisteet.Text) > Convert.ToInt32(lblPelaaja2Pisteet.Text))               //pelaaja 1 voittaa
            {
                lblPelaaja1VT.Visible = true;
                lblPelaaja1VT.Text = "Voittaja!";

                numPelaaja1V.Value++;
                numPelaaja2H.Value++;
                btnPelaaja1Tal.Visible = true;                              //laitetaan tallennus-buttonit näkyviin jotta käyttäjä voi tallentaa tulokset
                btnPelaaja2Tal.Visible = true;
                lblUudestaan.Visible = true;
            }
            else if (Convert.ToInt32(lblPelaaja2Pisteet.Text) > Convert.ToInt32(lblPelaaja1Pisteet.Text))          //pelaaja 2 voittaa
            {
                lblPelaaja2VT.Visible = true;
                lblPelaaja2VT.Text = "Voittaja!";

                numPelaaja1H.Value++;
                numPelaaja2V.Value++;
                btnPelaaja1Tal.Visible = true;
                btnPelaaja2Tal.Visible = true;
                lblUudestaan.Visible = true;
            }
            else if (Convert.ToInt32(lblPelaaja2Pisteet.Text) == Convert.ToInt32(lblPelaaja1Pisteet.Text))          //tasapeli
            {
                lblPelaaja1VT.Visible = true;
                lblPelaaja2VT.Visible = true;
                lblPelaaja1VT.Text = "Tasapeli!";
                lblPelaaja2VT.Text = "Tasapeli!";
                btnPelaaja1Tal.Visible = true;
                btnPelaaja2Tal.Visible = true;
                lblUudestaan.Visible = true;
            }
        }

        private void btnPelaaja1Tal_Click(object sender, EventArgs e)       //pelaaja 1 nimi, voitot ja häviöt tallennus tiedostoon
        {
            SaveFileDialog tal = new SaveFileDialog();
            tal.Title = "Tallenna pelaaja";
            tal.Filter = "Teksti tiedostot (*.txt)| *txt";

            if (tal.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(File.Create(tal.FileName + ".txt")))      //tallennetaan tekstitiedostona
                {
                    sw.Write(tbPelaaja1.Text + "\r\n" + numPelaaja1V.Value + "\r\n" + numPelaaja1H.Value);    //tallennetaan muodossa, josta voidaan tuoda pelaaja helposti tiedostosta
                    sw.Dispose();
                }
            }
        }

        private void btnPelaaja1Tuo_Click(object sender, EventArgs e)       //pelaaja 1 nimi, voitot ja häviöt tiedostosta tuonti sovellukseen
        {
            OpenFileDialog tuo = new OpenFileDialog();
            tuo.Title = "Tuo pelaaja";
            tuo.Filter = "Teksti tiedostot (*.txt)| *txt";

            if (tuo.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(tuo.FileName));

                tbPelaaja1.Text = sr.ReadLine();                            //luetaan tekstitiedostosta pelaajan tiedot rivi kerrallaan
                numPelaaja1V.Value = Convert.ToInt32(sr.ReadLine());
                numPelaaja1H.Value = Convert.ToInt32(sr.ReadLine());
                tuo.Dispose();
            }
        }

        private void btnPelaaja2Tal_Click(object sender, EventArgs e)   //pelaaja 2 nimi, voitot ja häviöt tallennus tiedostoon
        {
            SaveFileDialog tal = new SaveFileDialog();
            tal.Title = "Tallenna pelaaja";
            tal.Filter = "Teksti tiedostot (*.txt)| *txt";

            if (tal.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(File.Create(tal.FileName + ".txt")))
                {
                    sw.Write(tbPelaaja2.Text + "\r\n" + numPelaaja2V.Value + "\r\n" + numPelaaja2H.Value);
                    sw.Dispose();
                }
            }
            muuttunut = false;
        }

        private void btnPelaaja2Tuo_Click(object sender, EventArgs e)   //pelaaja 1 nimi, voitot ja häviöt tiedostosta tuonti sovellukseen
        {
            OpenFileDialog tuo = new OpenFileDialog();
            tuo.Title = "Tuo pelaaja";
            tuo.Filter = "Teksti tiedostot (*.txt)| *txt";

            if (tuo.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(tuo.FileName));

                tbPelaaja2.Text = sr.ReadLine();
                numPelaaja2V.Value = Convert.ToInt32(sr.ReadLine());
                numPelaaja2H.Value = Convert.ToInt32(sr.ReadLine());
                tuo.Dispose();
            }
        }

        private void tbPelaaja1_Validated(object sender, EventArgs e)       //tehdään poikkeuskäsittely/validointi "nimi" tekstiboxeille
        {
            TextBox tb = (TextBox)sender;

            epPeli.SetError(tb, "");
        }

        private void tbPelaaja1_Validating(object sender, CancelEventArgs e)    //pelaaja 1 tekstibox
        {
            TextBox tb = (TextBox)sender;
            if (tbPelaaja1.Text.Length <= 0)                                    //ei sallita nimetöntä
            {
                epPeli.SetError(tb, "Syötä pidempi nimi");
                e.Cancel = true;
            }
        }

        private void tbPelaaja2_Validating(object sender, CancelEventArgs e)    //pelaaja 2 tekstibox
        {
            TextBox tb = (TextBox)sender;
            if (tbPelaaja2.Text.Length <= 0)                                    //ei sallita nimetöntä
            {
                epPeli.SetError(tb, "Syötä pidempi nimi");
                e.Cancel = true;
            }
        }

        private void tbPelaaja1_TextChanged(object sender, EventArgs e)         //jos tekstiboxia muutettu, muutetaan "muuttunut" arvo "true"
        {
            TextBox tb = (TextBox)sender;
            muuttunut = true;
        }

        private void numPelaaja1V_ValueChanged(object sender, EventArgs e)      //jos NumericUpDown muutettu,  muutetaan "muuttunut" arvo "true" 
        {
            NumericUpDown num = (NumericUpDown)sender;
            muuttunut = true;
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)  //määritetään poistumisnappula
        {
            if (muuttunut)                                                      //jos muuttunut= true, kysytään käyttäjältä haluaako poistua
            {
                DialogResult dr;
                dr = MessageBox.Show("Tiedot muuttuneet, haluatko poistua?", "Poistu", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    Application.Exit();
            }
            else
                Application.Exit();
        }
    }
}