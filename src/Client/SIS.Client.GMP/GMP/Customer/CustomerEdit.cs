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
using SIS.Model.Models.GMP.Customer;
using SIS.App.Tool;
using SIS.Data;
using SIS.Client.GMP.Utils;
using SIS.Model.Models.Utilities;
using SIS.App.Tools;

namespace SIS.App.Screens.GMP.Customer
{
    public partial class CustomerEdit : FormBase
    {
        public CustomerEdit()
        {
            InitializeComponent();
        }
        AppTools appTools = new AppTools();

        public SIS.Data.FormOpenType _FormOpenType;
        public CustomersDTO __dl_Customers = new CustomersDTO();

        private void CustomerEdit_Load(object sender, EventArgs e)
        {

            if (_FormOpenType  == Data.FormOpenType.New)
            {
                __dl_Customers.RecordDate = DateTime.Now;
                //__dl_Customers.RecordUser = AppMain.UserCode;
            }
            if (_FormOpenType == Data.FormOpenType.Edit)
            {

            }
            if (_FormOpenType == Data.FormOpenType.View)
            {
                bbi_Save.Enabled = false;
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

            //if (bl.message.get_RecordSave())
            //{
            //    try
            //    {
            //        //var response = bl._repository.Run<CustomersService, ActionResponse<CustomersDTO>>(x => x.Save_Customers(__dl_Customers));
            //        //if (response.ResponseType != ResponseType.Ok)
            //        //{
            //        //    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        //}
            //        //else
            //        //{
            //        //    do_Refresh_List_Form();
            //        //    this.Close();
            //        //}
            //    }
            //    catch (Exception ex)
            //    {
            //        bl.message.get_RecordSave_Error(ex.Message);
            //    }
            //}
        }

        private void do_Refresh_List_Form()
        {
            Form _Form = FormTool.get_OpenForm("CustomerList");
            if (_Form != null)
            {
                ((CustomerList)_Form).do_refresh();
            }
            _Form = null;

        }



        #endregion

        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}