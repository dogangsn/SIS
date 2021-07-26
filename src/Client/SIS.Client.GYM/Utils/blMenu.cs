using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.GYM.Utils
{
    public class blMenu
    {
        public List<Data.Menus> get_List_Menus_GYM()
        {
            List<Data.Menus> _List_Menus = new List<Data.Menus>();

            #region GYM
            _List_Menus.Add(new Data.Menus(10, "GYM", "Üyeler", "", "-Üye Listesi", "Üye Listesi", "", "CalendarForm", "", new int[] { 2 }));
            _List_Menus.Add(new Data.Menus(10, "GYM", "Personel", "", "-Personel Listesi", "Personel Listesi", "", "CustomerList", "", new int[] { 2 }));
            #endregion


            return _List_Menus;
        }
    }
}
