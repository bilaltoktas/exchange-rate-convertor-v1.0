using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeRateConvertor_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double kaynak=0, hedef=0, sonuc=0, kaynakMiktar = 1;

        private void hedefCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bugun = "http://tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string selectedItem = hedefCmb.SelectedItem.ToString();
            string kod = selectedItem.Substring(0, 3);
            if (hedefCmb.SelectedIndex == 0)
            {
                hedef = 1;
                hedefKurTxt.Text = hedef.ToString();
            }
            else
            {
                string para = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod = '"+kod+"']/BanknoteSelling").InnerXml;
                hedef = Convert.ToDouble(para);
                hedef = hedef / 10000;        //xml sayfasında sayıyı nokta ile alıyor virgül ile değil bu sebeple virgüllü göstermemiz için 10000e böldük
                hedefKurTxt.Text = hedef.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kynkTutarTxt.Text == string.Empty)
            {
                MessageBox.Show("KAYNAK MİKTARI BOŞ GEÇİLEMEZ", "BİLGİ FORMU", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                kaynakMiktar = Convert.ToDouble(kynkTutarTxt.Text);
            }
            if(kaynakMiktar <= 0)
            {
                MessageBox.Show("GİRİLEN DEĞER 0 VE YA NEGATİF OLMAMALIDIR", "BİLGİ FORMU", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                sonuc = (kaynak * kaynakMiktar) / hedef;
            }
            hedefTutarTxt.Text = sonuc.ToString();
        }

        private void kaynakCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            string bugun = "http://tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string selectedItem = kaynakCmb.SelectedItem.ToString();
            string kod = selectedItem.Substring(0, 3);
            if (kaynakCmb.SelectedIndex == 0)
            {
                kaynak = 1;
                kaynakKurTxt.Text = kaynak.ToString();
            }
            else
            {
                string para = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod = '" + kod + "']/BanknoteSelling").InnerXml;
                kaynak = Convert.ToDouble(para);
                kaynak = kaynak / 10000;        //xml sayfasında sayıyı nokta ile alıyor virgül ile değil bu sebeple virgüllü göstermemiz için 10000e böldük
                kaynakKurTxt.Text = kaynak.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "http://tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            tarihlbl.Text = string.Format("Tarih : " + tarih.ToShortDateString());
        
        
        }
    }
}
