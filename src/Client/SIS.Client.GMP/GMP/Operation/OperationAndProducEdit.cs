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
using SIS.Data;
using SIS.Entity.Entities.GMP;

namespace SIS.App.Screens.GMP.Operation
{
    public partial class OperationAndProducEdit : DevExpress.XtraEditors.XtraForm
    {
        public OperationAndProducEdit()
        {
            InitializeComponent();
            set_form();
        }


        public ProductOperation _dll_ProductOperation;


        public FormOpenType _FormOpenType;
        public OperationProductType _operationType;

        private void set_form()
        {

        }



        #region Record

        private void empty_control()
        {

        }

        private void do_save()
        {

        }
        private void do_Refresh_List_Form()
        {
            //Form _Form = FormTool.get_OpenForm("CustomerList");
            //if (_Form != null)
            //{
            //    ((CustomerList)_Form).do_refresh();
            //}
            //_Form = null;

        }

        #endregion

        private void OperationAndProducEdit_Load(object sender, EventArgs e)
        {

            switch (_operationType)
            {
                case OperationProductType.Product:
                    lcName.Text = "Ürün Adı";
                    lcBarcode.Text = "Ürün Barkodu";
                    lcSinifi.Text = "Ürün Sınıfı";
                    lcBirim.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lckritikStok.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcAlisFiyati.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcislemSuresi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case OperationProductType.Operation:
                    lcName.Text = "İşlem/Hizmet Adı";
                    lcBarcode.Text = "İşlem/Hizmet Barkodu";
                    lcSinifi.Text = "İşlem/Hizmet Sınıfı";
                    lcBirim.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lckritikStok.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcAlisFiyati.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcislemSuresi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                default:
                    break;
            }


        }




    }
}