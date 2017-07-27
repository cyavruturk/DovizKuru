using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurGoster
{
    public partial class FormKurGoster : Form
    {
        public FormKurGoster()
        {
            InitializeComponent();
        }

        private void ListViewDoldur(List<Kur> kurlarim, ListView listView)
        {
            foreach (Kur item in kurlarim)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.Kurr;
                lvi.Tag = item; //diğer özelliklerine ulaşmak istersek diye attık.
                listView.Items.Add(lvi);  //listview'a eklediğimiz bölüm.

            }

        }

        private void btnKurYukle_Click(object sender, EventArgs e)
        {
            try
            {

                string link = @"http://www.tcmb.gov.tr/kurlar/today.xml";
                RssReader rss = new RssReader();
                List<Kur> kurlarim = rss.XmlParcala(link);
                ListViewDoldur(kurlarim, lsvParaBirimi);
            }
            catch (Exception)
            {

                MessageBox.Show("Linke ulaşılamadı...");
            }
        }

   
        private void lsvParaBirimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvParaBirimi.SelectedItems.Count > 0)
            {
                lblAlisFiyat.Text = ((lsvParaBirimi.SelectedItems[0].Tag) as Kur).Alis;
                lblSatisFiyat.Text = ((lsvParaBirimi.SelectedItems[0].Tag) as Kur).Satis;


            }
        }

    }
}
