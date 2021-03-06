﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.HTP.Utils
{
    public class blMenu
    {
        public List<Data.Menus> get_List_Menus()
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
    }
}
