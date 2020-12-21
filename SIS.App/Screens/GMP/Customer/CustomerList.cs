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
using DevExpress.XtraGrid.Views.Grid;
using SIS.Service.Services.GMP.Customers;
using SIS.Data.App;
using SIS.Data;

namespace SIS.App.Screens.GMP.Customer
{
    public partial class CustomerList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public CustomerList()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        GetValue _GetValue = new GetValue();

        List<CustomersDTO> _List_CustomerList = new List<CustomersDTO>();

        #region Record

        public void do_refresh()
        {
            _GetValue.CompanyId = AppMain.CompanyRecId;
            _List_CustomerList = _repository.Run<CustomersService, List<CustomersDTO>>(x => x.Get_List_Customers(_GetValue));
            bs_CustomerList.DataSource = _List_CustomerList;
        }


        private void do_edit()
        {
            var oRow = (CustomersDTO)gcv_CustomerList.GetFocusedRow();
            if (oRow == null) return;
            bl.GMP.CustomerEdit(Data.FormOpenType.Edit, oRow.RecId);
        }


        #endregion




        private void CustomerList_Load(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void CustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bbi_NewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bl.GMP.CustomerEdit(Data.FormOpenType.New, 0);
        }

        private void bbi_EditCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_edit();
        }

        private void gcv_CustomerList_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) { return; }
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (((e.Button & MouseButtons.Right) != 0))
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                this.popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void gcv_CustomerList_DoubleClick(object sender, EventArgs e)
        {
            do_edit();
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        #region Arsiv
        private void bbi_Arsiv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_InsertArsiv();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
        public void do_InsertArsiv()
        {
            try
            {
                if (bl.message.get_Question("Seçilen Kayıt Arşive Kaldırılcaktır. Onaylıyor musunuz?"))
                {


                }
            }
            catch (Exception)
            {

            }


        } 
        #endregion


    }
}