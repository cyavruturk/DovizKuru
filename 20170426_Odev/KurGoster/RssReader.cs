using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KurGoster
{
    class RssReader
    {
        private XmlDocument XmlCek(string url)
        {
            WebClient webClient = new WebClient(); //istemci tanımladık.

            webClient.Encoding = Encoding.UTF8; //xml bu tipte diye yazıyoruz UTF8= Türkçe demek (okuyucuya bilgi veriyoruz dili anlaması için)

            string rssData = webClient.DownloadString(url); //webClient a verdiğimi bana string olarak dön 
            //DownloadData deseydik datanın tamamını indirirdi
            XmlDocument xmlDosyasi = new XmlDocument();
            xmlDosyasi.LoadXml(rssData); //string bir veriyi alıp içerisindeki xml tipini okuyor=loadxml

            return xmlDosyasi;
        }

        public List<Kur> XmlParcala(string url)
        {
            List<Kur> kurlarim = new List<Kur>();
            XmlDocument xmlDocument = XmlCek(url);
            // sitedeki nodları yakalıyoruz  tüm item'ları seçiyoruz ve nod halinde nodlist te tutuyoruz
            XmlNodeList nodeList = xmlDocument.SelectNodes("Tarih_Date/Currency");
            foreach (XmlNode item in nodeList)
            {
                Kur kur = new Kur();
                kur.Kurr = item.SelectSingleNode("Isim").InnerText;
                kur.Alis = item.SelectSingleNode("ForexBuying").InnerText;
                kur.Satis = item.SelectSingleNode("ForexSelling").InnerText;
        
                kurlarim.Add(kur);

            }
            return kurlarim;

        }
    }
}
