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
using SIS.Client.GMP.Utils;

namespace SIS.App.Screens.GMP.Operation
{
    public partial class OperationAndProducList : DevExpress.XtraEditors.XtraForm
    {
        public OperationAndProducList()
        {
            InitializeComponent();
        }




        #region Record


        public void do_refresh()
        {

        }

        private void do_New()
        {

            if (xtraOperation.SelectedTabPage == xtpUrunListesi || xtraOperation.SelectedTabPage == xtpIslemListesi)
            {
                bl.GMP.OperationAndProducEdit(Data.FormOpenType.New, 0, (xtraOperation.SelectedTabPage == xtpUrunListesi ? Data.OperationProductType.Product : Data.OperationProductType.Operation));
            }
            else
            {
                bl.GMP.SeansEdit(Data.FormOpenType.New, 0, Data.OperationProductType.SeansPacket);
            }
        }

        private void do_Edit()
        {

        }

        private void do_Delete()
        {

        }
        private void do_Print()
        {

        }

        #endregion


        #region bbi_bar
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_New();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Edit();
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Delete();
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
        private void bbi_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Print();
        }
        #endregion

        private void OperationAndProducList_Load(object sender, EventArgs e)
        {

        }


    }
}