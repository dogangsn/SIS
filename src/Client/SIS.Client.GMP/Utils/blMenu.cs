using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.GMP.Utils
{
    public class blMenu
    {
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
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-İşlem ve Ürün Listesi", "OperationAndProducList", "", "OperationAndProducList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Alış ve Satış", "SaleBuyingList", "", "SaleBuyingList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Cari Hesaplar", "CustomerAccountList", "", "CustomerAccountList", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Kasa/POS", "KasaPOSList", "", "KasaPOSList", "", new int[] { 2 }));

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
