using SIS.App.Screens;
using SIS.App.Screens.GMP.Calendar;
using SIS.App.Screens.GMP.Customer;
using SIS.App.Screens.GMP.Definitions;
using SIS.App.Screens.GMP.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.App
{
    public class Screns
    {
        public void Help(Form _MdiForm)
        {
            Helps Help = new Helps();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }


        #region GMP
        public void CalendarForm(Form _MdiForm)
        {
            CalendarForm Help = new CalendarForm();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }


        #region Definitions
        public void CompanyList(Form _MdiForm)
        {
            CompanyList companyList = new CompanyList();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void BirimTanimlari(Form _MdiForm)
        {
            BirimTanimlari companyList = new BirimTanimlari();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }
        public void GelirTanimlari(Form _MdiForm)
        {
            GelirTanimlari companyList = new GelirTanimlari();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void GiderTanimlari(Form _MdiForm)
        {
            GiderTanimlari companyList = new GiderTanimlari();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void KasaHesabiTanimEdit(Form _MdiForm)
        {
            KasaHesabiTanimEdit companyList = new KasaHesabiTanimEdit();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void KDVTanimlari(Form _MdiForm)
        {
            KDVTanimlari companyList = new KDVTanimlari();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void PersonelList(Form _MdiForm)
        {
            PersonelList companyList = new PersonelList();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void PersonelTaskDefinEdit(Form _MdiForm)
        {
            PersonelTaskDefinEdit companyList = new PersonelTaskDefinEdit();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void SalonTanimEdit(Form _MdiForm)
        {
            SalonTanimEdit companyList = new SalonTanimEdit();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }
        #endregion

        #region Settings
        public void Parametreler(Form _MdiForm)
        {
            Parametreler companyList = new Parametreler();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }

        public void UsersList(Form _MdiForm)
        {
            UsersList companyList = new UsersList();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }


        #endregion

        #region Customer
        public void CustomerList(Form _MdiForm)
        {
            CustomerList Help = new CustomerList();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }
        public void ReservationList(Form _MdiForm)
        {
            ReservationList Help = new ReservationList();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }

        public void CustomerAccountList(Form _MdiForm)
        {
            CustomerAccountList Help = new CustomerAccountList();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }

        public void TaksitlerList(Form _MdiForm)
        {
            TaksitlerList Help = new TaksitlerList();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }

        #endregion

        #endregion





    }
}
