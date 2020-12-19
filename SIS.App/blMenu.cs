using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.App
{
    public class blMenu
    {
        public List<SIS.Data.Menus> get_List_Menus()
        {
            List<SIS.Data.Menus> _List_Menus = new List<SIS.Data.Menus>();


            #region Hastane
            //_List_Menus.Add(new Data.Menus(10, "Hastane", "Seans", "", "-Seans Yönet", "Help", "", "Help", "", new int[] { 1 }));
            //_List_Menus.Add(new Data.Menus(10, "Hastane", "Seans", "", "-Randevu Yönet", "Help", "", "Help", "", new int[] { 1 }));
            //_List_Menus.Add(new Data.Menus(10, "Hastane", "Hasta", "", "-Hasta Bilgileri", "Help", "", "Help", "", new int[] { 1 }));
            //_List_Menus.Add(new Data.Menus(10, "Hastane", "Ayarlar", "", "-Sekreter Kaydet", "Help", "", "Help", "", new int[] { 1 }));
            //_List_Menus.Add(new Data.Menus(10, "Hastane", "Ayarlar", "", "-Uzman Kaydet", "Help", "", "Help", "", new int[] { 1 }));
            //_List_Menus.Add(new Data.Menus(10, "Hastane", "Ayarlar", "", "-Parola Sıfırla", "Help", "", "Help", "", new int[] { 1 }));

            _List_Menus.Add(new Data.Menus(10, "Hastane", "Takvim", "", "-Takvim / Randevu", "Takvim / Randevu", "", "Help", "", new int[] { 1 }));

            _List_Menus.Add(new Data.Menus(10, "Hastane", "Hasta", "", "-Hasta Listesi", "Hasta Listesi", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Hasta", "", "-Randevu Listesi", "Randevu Listesi", "", "Help", "", new int[] { 1 }));

            _List_Menus.Add(new Data.Menus(10, "Hastane", "Muayene", "", "-Muayene", "Randevu Listesi", "", "Help", "", new int[] { 1 }));

            _List_Menus.Add(new Data.Menus(10, "Hastane", "Vezne", "", "-Kasa", "Kasa", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Vezne", "", "-Hesap Hareketleri", "Hesap Hareketleri", "", "Help", "", new int[] { 1 }));


            _List_Menus.Add(new Data.Menus(10, "Hastane", "Muhasebe", "", "-Kurumlar", "Kurumlar", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Muhasebe", "", "-Hesap Hareketleri", "Hesap Hareketleri", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Muhasebe", "", "-Kasa Hareketleri", "Kasa Hareketleri", "", "Help", "", new int[] { 1 }));

            _List_Menus.Add(new Data.Menus(10, "Hastane", "Tanımlar", "", "-Kurumlar", "Kurumlar", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Tanımlar", "", "-Doktor Ve Diğer Personel Tanımları", "Doktor Ve Diğer Personel Tanımları", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Tanımlar", "", "-Poliklinik Tanımları", "Poliklinik Tanımları", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Tanımlar", "", "-Tetkik ve İşlem Kalemleri Tanımları", "Tetkik ve İşlem Kalemleri Tanımları", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Tanımlar", "", "-Banka Tanımları", "Banka Tanımları", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Tanımlar", "", "-Branş Tanımları", "Branş Tanımları", "", "Help", "", new int[] { 1 }));


            _List_Menus.Add(new Data.Menus(10, "Hastane", "AYarlar", "", "-Parametreler", "Parametreler", "", "Help", "", new int[] { 1 }));


            _List_Menus.Add(new Data.Menus(10, "Hastane", "Help", "", "-Help", "Help", "", "Help", "", new int[] { 1 }));
            #endregion

            #region Labarotuvar

            #endregion

            return _List_Menus;
        }

        public List<Data.Menus> get_List_Menus_GMP()
        {
            List<Data.Menus> _List_Menus = new List<Data.Menus>();

            #region GMP
            _List_Menus.Add(new Data.Menus(10, "GMP", "Takvim", "", "-Takvim", "Takvim", "", "CalendarForm", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Müşteriler", "Müşteriler", "", "CustomerList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Randevu Listesi", "Randevu Listesi", "", "ReservationList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Müşteri Hesapları", "Müşteri Hesapları", "", "CustomerAccountList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Taksitler", "Taksitler", "", "TaksitlerList", "", new int[] { 2 }));


            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Tedarikçiler", "Tedarikçiler", "", "TedarikList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-İşlem ve Ürün Listesi", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Alış ve Satış", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Cari Hesaplar", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Kasa/POS", "Help", "", "Help", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Yardımcı İşlemler", "", "-Mail Gönder", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Yardımcı İşlemler", "", "-SMS Gönder", "Help", "", "Help", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-İşyeri", "İşyeri", "", "CompanyList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-Personel Tanımları", "Personel Tanımları", "", "PersonelList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-Personel Görev Tanımları", "Personel Görev Tanımları", "", "PersonelTaskDefinEdit", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-İşlem Salonu Tanımları", "İşlem Salonu Tanımları", "", "SalonTanimEdit", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-Birim Tanımları", "Birim Tanımları", "", "BirimTanimlari", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-Gelir Tanımları", "Gelir Tanımları", "", "GelirTanimlari", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-Gider Tanımları", "Gider Tanımları", "", "GiderTanimlari", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-Kasa Hesabı Tanımları", "Kasa Hesabı Tanımları", "", "KasaHesabiTanimEdit", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-KDV Tanımları", "KDV Tanımları", "", "KDVTanimlari", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Ayarlar", "", "-Parametreler", "Parametreler", "", "Parametreler", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Ayarlar", "", "-Kullanıcı İşlemleri", "Kullanıcı İşlemleri", "", "UsersList", "", new int[] { 2 }));



            _List_Menus.Add(new Data.Menus(10, "GMP", "Yardım", "", "-Yardım", "Help", "", "Help", "", new int[] { 2 }));





            #endregion

            return _List_Menus;
        }

    }
}
