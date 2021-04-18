using SIS.App.Screens;
using SIS.App.Screens.GMP;
using SIS.App.Screens.GMP.Calendar;
using SIS.App.Screens.GMP.Customer;
using SIS.App.Screens.GMP.Definitions;
using SIS.App.Screens.GMP.KasaPOS;
using SIS.App.Screens.GMP.Operation;
using SIS.App.Screens.GMP.SaleBuying;
using SIS.App.Screens.GMP.Settings;
using SIS.App.Screens.GMP.Tedarik;
using SIS.Client.GMP.Utils;
using SIS.Data.App;
using SIS.Model.Models.GMP.Customer;
using SIS.Model.Models.GMP.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.Client.GMP
{
    public class Screen
    {


        GetValue _getValue = new GetValue();

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

        public void TedarikList(Form _MdiForm)
        {
            TedarikList frm = new TedarikList();
            frm.MdiParent = _MdiForm;
            frm.Show();
        }

        #region Definitions
        public void CompanyList(Form _MdiForm)
        {
            CompanyList companyList = new CompanyList();
            companyList.MdiParent = _MdiForm;
            companyList.Show();
        }
        public void CompanyEdit(SIS.Data.FormOpenType _FormOpenType, int _id)
        {
            CompanyEdit _CustomerEdit = new CompanyEdit();
            _CustomerEdit._FormOpenType = _FormOpenType;
            if (_FormOpenType == Data.FormOpenType.New)
            {
                _CustomerEdit.__company = new Model.Models.GMP.Definitions.CompanyDTO();
            }
            else
            {
                _getValue.Id = _id;
                //_CustomerEdit.__company = bl._repository.Run<DefinitionsService, CompanyDTO>(x => x.Get_Company(_getValue));

            }
            _CustomerEdit.ShowDialog();
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
        public void PersonelEdit(SIS.Data.FormOpenType _FormOpenType, int _id)
        {
            PersonelEdit _PersonelEdit = new PersonelEdit();
            _PersonelEdit._FormOpenType = _FormOpenType;
            if (_FormOpenType == Data.FormOpenType.New)
            {
                _PersonelEdit._personels = new Model.Models.GMP.Definitions.PersonelsDTO();
            }
            else
            {
                _getValue.Id = _id;
                //_PersonelEdit._personels = bl._repository.Run<DefinitionsService, PersonelsDTO>(x => x.Get_Personels(_getValue));
            }
            _PersonelEdit.ShowDialog();
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

        public void CustomerEdit(SIS.Data.FormOpenType _FormOpenType, int _id)
        {
            CustomerEdit _CustomerEdit = new CustomerEdit();
            _CustomerEdit._FormOpenType = _FormOpenType;
            if (_FormOpenType == Data.FormOpenType.New)
            {
                _CustomerEdit.__dl_Customers = new Model.Models.GMP.Customer.CustomersDTO();
            }
            else
            {
                _getValue.Id = _id;
                //_CustomerEdit.__dl_Customers = bl._repository.Run<CustomersService, CustomersDTO>(x => x.Get_Customers(_getValue));

            }
            _CustomerEdit.ShowDialog();
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

        public void KasaPOSList(Form _MdiForm)
        {
            KasaPOSList frm = new KasaPOSList();
            frm.MdiParent = _MdiForm;
            frm.Show();
        }

        public void SaleBuyingList(Form _MdiForm)
        {
            SaleBuyingList frm = new SaleBuyingList();
            frm.MdiParent = _MdiForm;
            frm.Show();
        }

        public void OperationAndProducList(Form _MdiForm)
        {
            OperationAndProducList frm = new OperationAndProducList();
            frm.MdiParent = _MdiForm;
            frm.Show();
        }


        #endregion

        #endregion





    }
}

