using SIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.APT.Utils
{
    public class blMenu
    {
        public List<Menus> get_List_Menus_APT()
        {
            List<Data.Menus> _List_Menus = new List<Data.Menus>();

            #region GMP
            _List_Menus.Add(new Data.Menus(10, "APT", "Dashboard", "", "-Dashboard", "Dashboard", "", "Info", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "APT", "İşlemler", "", "-Onaylancak Kayıtlar", "Onaylancak Kayıtlar", "", "Info", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "APT", "İşlemler", "", "-Hayvan Listesi", "Hayvan Listesi", "", "Info", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "APT", "İşlemler", "", "-Sertifika İşl.", "Sertifika İşl.", "", "Info", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "APT", "İşlemler", "", "-Sahipler/Yetiştirici", "Sahipler/Yetiştirici", "", "Info", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "APT", "İşlemler", "", "-Basılan Belgeler", "Basılan Belgeler", "", "Info", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "APT", "İşlemler", "", "-Devir/Transfer", "Devir/Transfer", "", "Info", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "APT", "Başvurular", "", "-Yeni Hayvan Başv.", "Yeni Hayvan Başv.", "", "Info", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "APT", "Başvurular", "", "-Üreme İzin", "Üreme İzin", "", "Info", "", new int[] { 2 }));


            _List_Menus.Add(new Data.Menus(10, "APT", "Tanımlar", "", "-Irk/Renk/Cinsiyet", "Irk/Renk/Cinsiyet", "", "Info", "", new int[] { 2 }));

            _List_Menus.Add(new Data.Menus(10, "APT", "Ayarlar", "", "-Parameter", "Parameter", "", "Info", "", new int[] { 2 }));



            #endregion

            return _List_Menus;
        }
    }
}
