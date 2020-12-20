using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SIS.Service.Repository;
using SIS.Model.Models.GMP.Customer;

namespace SIS.App.Screens.GMP.Customer
{
    public partial class CustomerEdit : FormBase
    {
        Repository _repository;
        public CustomerEdit()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public SIS.Data.FormOpenType _FormOpenType;
        public CustomersDTO __dl_Customers = new CustomersDTO();

        private void CustomerEdit_Load(object sender, EventArgs e)
        {

            if (_FormOpenType  == Data.FormOpenType.New)
            {

            }
            if (_FormOpenType == Data.FormOpenType.Edit)
            {

            }
            if (_FormOpenType == Data.FormOpenType.View)
            {

            }

            bs_CustomerEdit.DataSource = __dl_Customers;

        }


        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #region Record

        private bool do_Validation()
        {
            bool _return = false;
            return _return;
        }

        private void do_save()
        {
            if (do_Validation()) return;




        }





        #endregion

        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}