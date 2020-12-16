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
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Seans", "", "-Seans Yönet", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Seans", "", "-Randevu Yönet", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Hasta", "", "-Hasta Bilgileri", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Ayarlar", "", "-Sekreter Kaydet", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Ayarlar", "", "-Uzman Kaydet", "Help", "", "Help", "", new int[] { 1 }));
            _List_Menus.Add(new Data.Menus(10, "Hastane", "Ayarlar", "", "-Parola Sıfırla", "Help", "", "Help", "", new int[] { 1 }));
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
            _List_Menus.Add(new Data.Menus(10, "GMP", "Takvim", "", "-Takvim", "Help", "", "Help", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Müşteriler", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Randevu Listesi", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Müşteri Hesapları", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Müşteri", "", "-Taksitler", "Help", "", "Help", "", new int[] { 2 }));


            //_List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Tedarikçiler", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-İşlem ve Ürün Listesi", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Alış ve Satış", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Cari Hesaplar", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "İşlemler", "", "-Kasa/POS", "Help", "", "Help", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Yardımcı İşlemler", "", "-Mail Gönder", "Help", "", "Help", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GMP", "Yardımcı İşlemler", "", "-SMS Gönder", "Help", "", "Help", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Tanımlar", "", "-İşyeri", "Help", "", "Help", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "GMP", "Yardım", "", "-Yardım", "Help", "", "Help", "", new int[] { 2 }));





            #endregion

            return _List_Menus;
        }

    }
}
